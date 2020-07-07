using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouSquare.Utilities;

namespace YouSquare
{
    public partial class MainView : Form

    {
        private BaseBlock nextBlock1 = null;
        private BaseBlock nextBlock2 = null;
        private int GameStatu = 0;//1单人，2多人
        private Dictionary<MagicEnum, Label> dicMagics = new Dictionary<MagicEnum, Label>();
        private GameEngine gameEngine = new GameEngine();
        private GameEngine subgameEngine = new GameEngine();
        private SplashString scoreSplash1 = null;
        private SplashString scoreSplash2 = null;
        public int Grow_magic1 = 0;
        public int Grow_magic2 = 0;
        public int Remove_magic1 = 3;
        public int Remove_magic2 = 3;
        public int Change_magic1 = 3;
        public int Change_magic2 = 3;

        public MainView()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)//在界面需要重新绘制时发生
        {
            gameEngine.DrawAllSquares(e.Graphics);
        }
        private void subContainer_Paint(object sender, PaintEventArgs e)
        {
            subgameEngine.DrawAllSquares(e.Graphics);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            InitGameEngineEvent();
            this.Width = 500; //宽度
            GameStatu = 1;
            scoreSplash1 = new SplashString(scoreCanvas, "0", new System.Drawing.Size(40, 40));
            scoreSplash2 = new SplashString(subscoreCanvas, "0", new System.Drawing.Size(40, 40));
            GameStatu1.Visible = false;
            GameStatu2.Visible = false;
            GameStatu0.Visible = false;
            Pause1.Visible = false;
            Pause2.Visible = false;

        }

        private void InitGameEngineEvent()
        {
            gameEngine.InvalidateFieldEvent += new Action(Instance_InvalidateFieldEvent);
            gameEngine.LineCompleteEvent += new Action(gameEngine_LineCompleteEvent1);
            gameEngine.NewBlockEvent += new Action<BaseBlock>(gameEngine_NewBlockEvent1);
            gameEngine.LevelUpEvent += new Action<int>(gameEngine_LevelUpEvent);
            gameEngine.SelfGameOverEvent += new Action(SelfGameOverEvent);

            subgameEngine.InvalidateFieldEvent += new Action(Instance_InvalidateFieldEvent2);
            subgameEngine.LineCompleteEvent += new Action(gameEngine_LineCompleteEvent2);
            subgameEngine.NewBlockEvent += new Action<BaseBlock>(gameEngine_NewBlockEvent2);
            subgameEngine.LevelUpEvent += new Action<int>(subgameEngine_LevelUpEvent);
            subgameEngine.SelfGameOverEvent += new Action(SelfGameOverEvent);
        }

        void gameEngine_LevelUpEvent(int obj)
        {
            this.SafeInvoke(new Action<int>((l) =>
            {
                labelLevel.Text = l.ToString();
                if (l == 0)
                    scoreSplash1.Content = "0";
            }), obj);
            if (GameStatu == 2)
            {
                Grow_magic1++;
                GrowC1.Text = Grow_magic1.ToString();
            }    
           
        }
        void subgameEngine_LevelUpEvent(int obj)
        {
            this.SafeInvoke(new Action<int>((l) =>
            {
                sublabelLevel.Text = l.ToString();
                if (l == 0)
                    scoreSplash2.Content = "0";
            }), obj);
            if (GameStatu == 2)
            {
                Grow_magic2++;
                GrowC2.Text = Grow_magic1.ToString();
            }
        }


        void gameEngine_NewBlockEvent1(BaseBlock obj)
        {
            nextBlock1 = obj.Clone() as BaseBlock;
            nextBlock1.SetoutterPosition(1, 1);
            nextPreviewContainer.Invalidate();
        }
        void gameEngine_NewBlockEvent2(BaseBlock obj)
        {
            nextBlock2 = obj.Clone() as BaseBlock;
            nextBlock2.SetoutterPosition(1, 1);
            subnextpreview.Invalidate();
        }

        private void SelfGameOverEvent()
        {
            mainContainer.Invalidate();
            subContainer.Invalidate();
            int score1 = gameEngine.Score;
            int score2 = subgameEngine.Score;
            string endmsg = "";
            if (GameStatu == 1) {
                GameStatu1.Visible = true;
                GameStatu1.ForeColor = Color.Black;
                GameStatu1.Text="GAME OVER";
                endmsg = "游戏结束，你的得分是" + score1.ToString();
                gameEngine.EndGame();
                MessageBox.Show(endmsg);
                return;
            }
            else if (GameStatu == 2)
            {
                if (score1 > score2)
                {
                    GameStatu1.Visible = true;
                    GameStatu1.ForeColor=Color.Red;
                    GameStatu1.Text = "You Win!";
                    GameStatu2.Visible = true;
                    GameStatu2.ForeColor = Color.Black;
                    GameStatu2.Text = "You Lose";
                    endmsg = "游戏结束，玩家1胜利";
                }

                else if (score1 < score2)
                {
                    GameStatu2.Visible = true;
                    GameStatu2.ForeColor = Color.Red;
                    GameStatu2.Text = "You Win!";
                    GameStatu1.Visible = true;
                    GameStatu1.ForeColor = Color.Black;
                    GameStatu1.Text = "You Lose";
                    endmsg = "游戏结束，玩家2胜利";
                }
                else
                {
                    GameStatu0.Visible = true;
                    endmsg = "游戏结束，平局";
                }
                gameEngine.EndGame();
                subgameEngine.EndGame();
                MessageBox.Show(endmsg);
                return;
            }
        }

        void Instance_InvalidateFieldEvent()
        {
            mainContainer.Invalidate();

        }
        void Instance_InvalidateFieldEvent2()
        {
            subContainer.Invalidate();

        }

        private void MainView_KeyDown(object sender, KeyEventArgs e)//定义键盘事件
        {
            switch (e.KeyCode)
            {
                case Keys.S:
                    if (gameEngine.CurrentBlock != null)
                    {
                        gameEngine.CurrentBlock.MoveDown(gameEngine);
                        if (!gameEngine.CurrentBlock.CanDown(gameEngine))
                            break;
                    }
                    break;
                case Keys.W:
                    if (gameEngine.CurrentBlock != null)
                        gameEngine.CurrentBlock.Roate(gameEngine);
                    break;
                case Keys.D:
                    if (gameEngine.CurrentBlock != null)
                        gameEngine.CurrentBlock.MoveRight(gameEngine);
                    break;
                case Keys.A:
                    if (gameEngine.CurrentBlock != null)
                        gameEngine.CurrentBlock.MoveLeft(gameEngine);
                    break;
                case Keys.Down:
                    if (subgameEngine.CurrentBlock != null)
                    {
                        subgameEngine.CurrentBlock.MoveDown(subgameEngine);
                        if (!subgameEngine.CurrentBlock.CanDown(subgameEngine))
                            break;
                    }
                    break;
                case Keys.Up:
                    if (subgameEngine.CurrentBlock != null)
                        subgameEngine.CurrentBlock.Roate(subgameEngine);
                    break;
                case Keys.Right:
                    if (subgameEngine.CurrentBlock != null)
                        subgameEngine.CurrentBlock.MoveRight(subgameEngine);
                    break;
                case Keys.Left:
                    if (subgameEngine.CurrentBlock != null)
                        subgameEngine.CurrentBlock.MoveLeft(subgameEngine);
                    break;
                case Keys.J:
                    if (subgameEngine.CurrentBlock != null)
                        for (int i = 8; i > 0; i--)
                        {
                            subgameEngine.CurrentBlock.MoveDown(subgameEngine);
                            if (!subgameEngine.CurrentBlock.CanDown(subgameEngine))
                                break;
                        }
                    break;
                case Keys.R:
                    if (Change_magic1 > 0) {
                        var next = BlockFactory.Create();
                        gameEngine.PrepareNextBlock(next);
                        Change_magic1--;
                    }
                    break;
                case Keys.E:
                    if (Remove_magic1 > 0)
                    {
                        gameEngine.RemoveLastLine();
                        Remove_magic1--;
                    }

                    break;
                case Keys.T:
                    if (GameStatu == 2 && Grow_magic1 > 0)
                    {
                        subgameEngine.Grow();
                        Grow_magic1--;
                    }
                    break;
                case Keys.N:
                    if (Change_magic2 > 0)
                    {
                        var next = BlockFactory.Create();
                        subgameEngine.PrepareNextBlock(next);
                        Change_magic2--;
                    }
                    break;
                case Keys.M:
                    if (Remove_magic2 > 0)
                    {
                        subgameEngine.RemoveLastLine();
                        Remove_magic2--;
                    }

                    break;
                case Keys.B:
                    if (GameStatu == 2 && Grow_magic2 > 0)
                    {
                        gameEngine.Grow();
                        Grow_magic2--;
                    }
                    break;
                case Keys.Space:
                    if (GameStatu == 1)
                    {
                        gameEngine.PauseGame();
                        Pause1.Visible = !Pause1.Visible;
                        
                    }
                    else if(GameStatu == 2){
                        gameEngine.PauseGame();
                        Pause1.Visible = !Pause1.Visible;
                        subgameEngine.PauseGame();
                        Pause2.Visible = !Pause2.Visible;
                    }

                    break;

                    /*case Keys.B:
                    GameEngine.Instance1.ChangeSpeedup();
                    break;
                case Keys.N:
                    GameEngine.Instance1.ChangeSpeeddown();
                    break;
                case Keys.M:
                    int num = Convert.ToInt32(Console.ReadLine());
                    GameEngine.Instance1.Remove(num);
                    break;*/
            }

            mainContainer.Invalidate();
            subContainer.Invalidate();
            RemoveC1.Text = Remove_magic1.ToString();
            ChangeC1.Text = Change_magic1.ToString();
            GrowC1.Text = Grow_magic1.ToString();
            RemoveC2.Text = Remove_magic2.ToString();
            ChangeC2.Text = Change_magic2.ToString();
            GrowC2.Text = Grow_magic2.ToString();
        }
        void gameEngine_LineCompleteEvent1()
        {
            this.SafeInvoke(new Action(() => {
                scoreSplash1.Content = gameEngine.Score.ToString();
            }));
            System.Random rand = new System.Random();
            int randNum = rand.Next(0, 10);
            if (true)
            {
                Change_magic1++;
                ChangeC1.Text = Change_magic1.ToString();
            }
            else if(randNum==7 && GameStatu==2)
            {
                Grow_magic1++;
                GrowC1.Text = Grow_magic1.ToString();
            }
        }
        void gameEngine_LineCompleteEvent2()
        {
            this.SafeInvoke(new Action(() => {
                scoreSplash2.Content = subgameEngine.Score.ToString();
            }));
            System.Random rand = new System.Random();
            int randNum = rand.Next(0, 10);
            if (randNum == 8 || randNum == 6)
            {
                Change_magic2++;
                ChangeC2.Text = Change_magic2.ToString();
            }
            else if (randNum == 7 && GameStatu == 2)
            {
                Grow_magic2++;
                GrowC2.Text = Grow_magic2.ToString();
            }
        }
        private void 单人游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameEngine.isRPG = true;
            GameStatu = 1;
            GameStatu1.Visible = false;
            GameStatu2.Visible = false;
            GameStatu0.Visible = false;
            Pause1.Visible = false;
            this.Width = 500; //宽度
            Remove_magic1 = 3;
            Change_magic1 = 3;
            RemoveC1.Text = Remove_magic1.ToString();
            ChangeC1.Text = Change_magic1.ToString();
            Grow.Visible = false;
            GrowC1.Visible = false;
            gameEngine.RestartGame();
            subgameEngine.EndGame();
        }

        private void nextPreviewContainer_Paint(object sender, PaintEventArgs e)
        {
            if (nextBlock1 != null)
                nextBlock1.Draw(e.Graphics);
        }
        private void subnextpreview_Paint(object sender, PaintEventArgs e)
        {
            if (nextBlock2 != null)
                nextBlock2.Draw(e.Graphics);
        }

       
        private void 双人游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 966; //宽度
            GameStatu = 2;
            GameStatu1.Visible = false;
            GameStatu2.Visible = false;
            GameStatu0.Visible = false;
            Pause1.Visible = false;
            Pause2.Visible = false;
            Grow.Visible = true;
            GrowC1.Visible = true;
            GameEngine.isRPG = true;
            Remove_magic1 = 3;
            Change_magic1 = 3;
            Grow_magic1 = 0;
            RemoveC1.Text = Remove_magic1.ToString();
            ChangeC1.Text = Change_magic1.ToString();
            GrowC1.Text = Grow_magic1.ToString();
            Remove_magic2 = 3;
            Change_magic2 = 3;
            Grow_magic2 = 0;
            RemoveC2.Text = Remove_magic1.ToString();
            ChangeC2.Text = Change_magic1.ToString();
            GrowC2.Text = Grow_magic1.ToString();
            gameEngine.RestartGame();
            subgameEngine.RestartGame();
        }

        private void mainContainer_Click(object sender, EventArgs e)
        {

        }

        private void GameStatu1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Change1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void labelLevel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Pause2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
