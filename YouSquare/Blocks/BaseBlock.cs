using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public abstract class BaseBlock //公共父类是抽象类，用于定义各个形状方块的共同部分，节省时间
    {

        public RotateTag rotateTag;
        protected List<Square> squares = new List<Square>();//定义泛型集合，存放若干个小方块。
        protected abstract void InitSquares();//抽象方法，用于创建小方块
        public abstract BaseBlock InitObjForClone();
        public abstract void SetoutterPosition(int indexX, int indexY);//各种方块的小方块位置绑定，抽象方法需要在子类中实现
        public event Action ArriveBottomEvent;

        public BaseBlock(int indexX, int indexY)//定义基本方块类，用于其他方块的构建
        {
            InitSquares();
            SetoutterPosition(indexX, indexY);

            //设置集合内各个小方块的旋转中心点
            foreach (var s in squares)
            {
                s.CenterIndexX = CenterIndexX;
                s.CenterIndexY = CenterIndexY;
            }
        }
        public IEnumerable<Square> Squares//设置只读属性
        {
            get
            {
                return squares;
            }
        }
        public object Clone()
        {
            BaseBlock b = InitObjForClone();
            b.FillColor = this.FillColor;
            return b;
        }

        public Color FillColor
        {
            get
            {
                return squares[0].FillColor;
            }
            set
            {
                foreach (var s in squares)
                {
                    s.FillColor = value;
                }
            }
        }
        public abstract int CenterIndexX { set; get; }//各个方块中心X索引坐标
        public abstract int CenterIndexY { set; get; }//各个方块中心Y索引坐标

        public void Draw(Graphics g)//绘图
        {
            foreach (var s in squares)
            {
                s.Draw(g);
            }
        }
        public int OutterBottom
        {
            get
            {
                var orderByTop = squares.OrderBy<Square, int>(s =>
                {
                    return s.IndexTop;
                });
                var last = orderByTop.Last<Square>();
                return last.IndexTop + 1;
            }
        }
        public bool CanDown(GameEngine engine)//判断是否可以移动
        {
            bool tag = true;
            foreach (var s in squares)
            {
                if (!s.CanDown(engine))
                {
                    tag = false;
                    break;
                }
            }
            return tag;
        }
        
        public void TriggerArriveBottomEvent()
        {
            if (ArriveBottomEvent != null)
            {
                ArriveBottomEvent();
            }
        }

        public void MoveDown(GameEngine engine)//定义往下移动函数
        {
            if (CanDown(engine))
            {
                foreach (var s in squares)
                {
                    s.MoveDown(engine);
                }
            }
            else
            {
                foreach (var s in squares)
                {
                    engine.matrix[s.IndexTop, s.IndexLeft] = 1;
                }
                TriggerArriveBottomEvent();//当不能下落时触发事件
            }
        }
       

        public virtual bool CanRotate(GameEngine engine)//判断是否可以旋转
        {
            bool tag = true;
            foreach (var s in squares)
            {
                if (!s.CanRoate(engine))
                {
                    tag = false;
                    break;
                }
            }
            return tag;
        }
       

        public void Roate(GameEngine engine)//实现旋转
        {
            if (CanRotate(engine))
            {
                foreach (var s in squares)
                {
                    s.Roate(engine);
                }
                int y = 0;
                int x = (int)rotateTag + 1;
                y = x > 3 ? 0 : x;
                rotateTag = (RotateTag)y;
            }
        }
       

        public virtual bool CanLeft(GameEngine engine)
        {
            bool tag = true;
            foreach (var s in squares)
            {
                if (!s.CanLeft(engine))
                {
                    tag = false;
                    break;
                }
            }
            return tag;
        }
       
        public virtual void MoveLeft(GameEngine engine)
        {
            if (CanLeft(engine))
            {
                foreach (var s in squares)
                {
                    s.MoveLeft(engine);
                }
            }
        }
       
        public virtual bool CanRight(GameEngine engine)
        {
            bool tag = true;
            foreach (var s in squares)
            {
                if (!s.CanRight(engine))
                {
                    tag = false;
                    break;
                }
            }
            return tag;
        }
        
        public virtual void MoveRight(GameEngine engine)
        {
            if (CanRight(engine))
            {
                foreach (var s in squares)
                {
                    s.MoveRight(engine);
                }
            }
        }
        
        public bool CanUp()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public bool IsActive
        {
            get
            {
                return squares[0].IsActive;
            }
            set
            {
                foreach (var s in squares)
                {
                    s.IsActive = value;
                }
            }
        }
    }
}
