using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Drawing;
using YouSquare.DataGram;
using YouSquare;




namespace YouSquare
{
    public class GameEngine//游戏引擎类
    {
        public const int SQUARE_WIDTH = 25;//每个小方块的边长（以像素为单位）
        public const int FIELD_W = 12;//定义画布大小,游戏区域的宽度（以小方块的个数为单位）
        public const int FIELD_H = 20;//游戏区域的高度（以小方块的个数为单位）
        private const int SPEED_UP_STEP = 2;//等级每增长一级，速度加快多少
        private const int LEVEL_UP_SCORE = 5;//满多少分，升一级
        private const int INIT_SPEED = 30;//初始速度

        private int speed = INIT_SPEED;//游戏速度(数值越小,速度越快)
        private Timer timerEngine = new Timer();//定时器
        private List<Square> metaSquares = new List<Square>();//创建集合存储当前游戏区域内所有小方块
        public int[,] matrix = null;//定义二维数组matrix,1代表对应位置有小方块，0代表没有小方块
        public BaseBlock nextBlock =null;//下一组合方块
        public BaseBlock CurrentBlock { set; get; }//当前方块

        public event Action InvalidateFieldEvent;//刷新游戏区域事件
        public event Action SelfGameOverEvent;//游戏结束事件
        public event Action GameStartEvent;//游戏开始事件
        public event Action<BaseBlock> NewBlockEvent;//产生新组合块事件
        public event Action LineCompleteEvent;//某行满时的事件

        public static bool isRPG = true;
        public int TopSquareY
        {
            get
            {
                var orderdeSquare = metaSquares.FindAll(s =>
                {
                    return !s.IsActive;
                }).OrderBy<Square, int>(s =>
                {
                    return s.IndexTop;
                });
                var list = orderdeSquare.ToList<Square>();
                if (list == null || list.Count == 0)
                    return FIELD_H;
                var first = list.First<Square>();
                return first.IndexTop;
            }
        }
        public bool _IsSelfGameOver = false;//游戏是否结束
        public bool IsSelfGameOver
        {
            set
            {
                _IsSelfGameOver = value;
                timerEngine.Enabled = _IsSelfGameOver ? false : true;
                if(_IsSelfGameOver)
                {
                   // SetDisableColor();
                }
            }
            get
            {
                return _IsSelfGameOver;
            }
        }

        public void SetDisableColor()
        {
            foreach(var s in metaSquares)
            {
                s.FillColor = Color.White;
            }
        }
        public int FieldIndexWidth//游戏区域的宽度（以像素为单位）
        {
            get
            {
                return SQUARE_WIDTH * FIELD_W;
            }
        }
        public int FieldIndexHeight//游戏区域的高度（以像素为单位）
        {
            get
            {
                return SQUARE_WIDTH * FIELD_H;
            }
        }

        private void NewBlock()//下一个方块
        {
            if (nextBlock!=null)
            {
                nextBlock.ArriveBottomEvent += new Action(block_ArriveBottomEvent);
                CurrentBlock = nextBlock;
                AddSquares(nextBlock);
                if (!nextBlock.CanDown(this))
                {
                    
                    IsSelfGameOver = true;
                    SelfGameOverEvent();
                    return;
                }
            }
            var next = BlockFactory.Create();
           
            PrepareNextBlock(next);
        }
        public void PrepareNextBlock(BaseBlock next)
        {
            nextBlock = next;
            if (NewBlockEvent != null )
            {
                NewBlockEvent(nextBlock);
                return;
            }

        }
        public GameEngine()//私有化防止被其他类初始化
        {
            matrix = new int[FIELD_H, FIELD_W];//数组中对应位置为1时有小方块，为0时无小方块
            timerEngine.Interval = 10;//更新方块间隔一秒钟
            timerEngine.Elapsed += new ElapsedEventHandler(timerEngine_Elapsed);
        }

        private int speedTimerTag;//计数标记
        void timerEngine_Elapsed(object sender, ElapsedEventArgs e)//定时器，实现方块自动下落
        {
            if (speedTimerTag >= int.MaxValue)
                speedTimerTag = 0;
            if (speedTimerTag % speed == 0)
            {
                if (CurrentBlock != null && CurrentBlock.IsActive == true)
                    CurrentBlock.MoveDown(this);
                
            }
            //else
            {
                if (InvalidateFieldEvent != null)
                    InvalidateFieldEvent();
            }
            speedTimerTag++;
        }
        public event Action<int> LevelUpEvent;//游戏等级增加事件   
        private int _Score;
        public int Score//得分
        {
            set
            {
                _Score = value;


                if (_Score % LEVEL_UP_SCORE == 0 )
                {
                    if (LevelUpEvent != null)
                    {
                        LevelUpEvent(_Score / LEVEL_UP_SCORE);
                        /*ChangeSpeed(true);*/
                    }
                }
                
            }
            get
            {
                return _Score;
            }
        }
        public event Action<int> MagicChangedEvent;//升级事件
        private int _MagicPower;
        //能量值
        public int MagicPower
        {
            set
            {
                _MagicPower = value;
                if (MagicChangedEvent != null)
                    MagicChangedEvent(_MagicPower);
            }
            get
            {
                return _MagicPower;
            }
        }

        void block_ArriveBottomEvent()//当某个方块组合落到底时的事件
        {
            
            if (IsSelfGameOver)
                return;
            CurrentBlock.IsActive = false;
            NewBlock();
            CheckLine();

        }

        private void AddSquares(BaseBlock block)//把某种形状的方块中所有的添加到集合中
        {
            metaSquares.AddRange(block.Squares);
            
        }
        public string PauseGame()
        {
            if (!IsSelfGameOver)
            {
                timerEngine.Enabled = !timerEngine.Enabled;
                return timerEngine.Enabled == true ? "游戏运行" : "游戏暂停";
            }
            return "游戏结束";
        }
        public string EndGame()
        {
            IsSelfGameOver = true;
            timerEngine.Enabled = false;
            return "游戏结束";
        }

        public void RestartGame()//重新开始游戏
        {

            speed = INIT_SPEED;
            Score = 0;
            //MagicPower = 0;
            IsSelfGameOver = false;
            if (metaSquares != null)
                metaSquares.Clear();
            ClearMatrix();
            nextBlock = BlockFactory.Create();
            if (NewBlockEvent!=null)
                NewBlock();
           
            //if (GameStartEvent != null)
                //GameStartEvent();

        }
        private void ClearMatrix()
        {
            for (int i = 0; i < FIELD_H; i++)
                for (int j = 0; j < FIELD_W; j++)
                    matrix[i, j] = 0;
        }


        public void DrawAllSquares(Graphics g)//绘制当前区域所有小方块
        {
            foreach (var s in metaSquares)
            {
                s.Draw(g);
            }
        }

        public void CheckLine()
        {
            int fullRowsCount = 0;
            for (int i = 0; i < FIELD_H; i++)//逐行检测是否有满行
            {
                bool tag = true;
                for (int j = 0; j < FIELD_W; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        tag = false;
                        break;
                    }
                    
                }
                if (tag)//如果满行
                {
                    Score++;
                    fullRowsCount++;
                    RemoveLine(i);
                }
               
            }
        }

        public List<Square> this[int x, int y]//(x,y)区域是否有小方块重合，实现消行后下落
        {
            get
            {
                List<Square> r = new List<Square>();
                for (int i = metaSquares.Count - 1; i >= 0; i--)
                {
                    if (metaSquares[i].IndexLeft == x && metaSquares[i].IndexTop == y)
                        r.Add(metaSquares[i]);
                }
                return r;
            }
        }


        public void RemoveLine(int i)//消行函数，消去第i行的方块
        {
            if (IsSelfGameOver)
                return;
            if (LineCompleteEvent != null)
                LineCompleteEvent();
            //matrix的行i全部设为0
            for(int a=0;a<FIELD_W;a++)
            {
                matrix[i, a] = 0;
            }
            //去除行i的全部元素
            metaSquares = metaSquares.FindAll(s => s.IndexTop != i);

            //行i上方的所有元素下移
            var aboveSquares = metaSquares.FindAll(s =>
             {
                 //return(s.IndexTop<i);
                 return (s.IndexTop < i && s.IsActive == false);
 
             });

            //按行号降序排序
            var oderedAbove = aboveSquares.OrderByDescending<Square, int>(s =>
              {
                  return s.IndexTop;
              });
            foreach (var sq in oderedAbove)
            {
                //if(sq.IsActive)
                //continue;
                sq.MoveDown(this);
                matrix[sq.IndexTop, sq.IndexLeft] = 1;
            }
           
        }
        //把所有方块集合排序
        public IOrderedEnumerable<Square> OrderedMetaSquares
        {
            get
            {
                var orderdSquares = metaSquares.OrderBy<Square, int>(s =>
                {
                    return s.IndexTop;
                });
                return orderdSquares;
            }
        }
        //道具
        //移除第i行方块
        public void Remove(int i)
        {
            if (IsSelfGameOver)
                return;
            //matrix的行i全部设为0
            for (int a = 0; a < FIELD_W; a++)
            {
                matrix[i, a] = 0;
            }
            //去除行i的全部元素
            metaSquares = metaSquares.FindAll(s => s.IndexTop != i);

            //行i上方的所有元素下移
            var aboveSquares = metaSquares.FindAll(s =>
            {
                //return(s.IndexTop<i);
                return (s.IndexTop < i && s.IsActive == false);

            });

            //按行号降序排序
            var oderedAbove = aboveSquares.OrderByDescending<Square, int>(s =>
            {
                return s.IndexTop;
            });
           
            foreach (var sq in oderedAbove)
             {
                    //if(sq.IsActive)
                    //continue;
                    sq.MoveDown(this);
                    matrix[sq.IndexTop, sq.IndexLeft] = 1;
              }
          
        }
        //加速
        public void ChangeSpeedup()
        {
            var t = speed + SPEED_UP_STEP;
            if (t > 0)
                speed = t;
        }
        //减速
        public void ChangeSpeeddown()
        {
            var t = speed - SPEED_UP_STEP;
            if (t > 0)
                speed = t;
        }
        //往上顶一行方块
        public void Grow()
        {
            bool tag = true;
            for (int j = 0; j < FIELD_W; j++)
            {
                var list = this[j, 2];//如果方块已经顶到第二行，则不再继续往上顶
                if (list.Count > 0)
                {
                    var activeSquare = list.Find(s =>
                    {
                        return s.IsActive;
                    });
                    if (activeSquare == null)
                    {
                        tag = false;
                        break;
                    }
                }
            }
            if (!tag)
                return;

            //当前方块集合的高度到达活动方块时，不再往上顶
            if (CurrentBlock != null)
            {
                if (TopSquareY <= CurrentBlock.OutterBottom)
                    return;
            }

            //按照纵坐标排序，往上顶时，按照纵坐标从上往下向上移动
            foreach (var s in OrderedMetaSquares)
            {
                if (s.IsActive)
                    continue;
                s.MoveUp(this);
            }

            //在最下面一行，生成随机个数、随机位置的方块，从而实现往上顶的效果
            System.Random rand = new System.Random();
            int randNum = rand.Next(1, FIELD_W);
            List<int> listP = new List<int>();
            for (int i = 0; i < randNum; i++)
            {
                int randLeft = rand.Next(FIELD_W);
                if (listP.Contains(randLeft))
                    continue;
                listP.Add(randLeft);
                Square sq = new Square();
                sq.PixelLeft = randLeft * SQUARE_WIDTH;
                sq.PixelTop = (FIELD_H - 1) * SQUARE_WIDTH;
                sq.FillColor = Color.White;
                metaSquares.Add(sq);
                matrix[sq.IndexTop, sq.IndexLeft] = 1;
            }
        }
        public void RemoveLastLine()
        {
            Remove(FIELD_H - 1);
        }
    }
}