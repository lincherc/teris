using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public class Square
    {
        public const int SQUARE_WIDTH = 25; //小方块边长
        public int PixelLeft { set; get; }  //小方块X坐标（像素）
        public int PixelTop { set; get; }  //小方块Y坐标（像素）
        public bool IsActive { set; get; }
        public int IndexLeft//小方块索引X坐标
        {
            get
            {
                return PixelLeft / Square.SQUARE_WIDTH;
            }
        }

        public int IndexTop//小方块索引Y坐标
        {
            get
            {
                return PixelTop / Square.SQUARE_WIDTH;
            }
        }

        public Color FillColor { set; get; } //小方块上色

        public bool CanUp()
        {
            return PixelTop - GameEngine.SQUARE_WIDTH < 0 ? false : true;
        }
        public void MoveUp(GameEngine engine)
        {
            if (CanUp())
            {
                engine.matrix[IndexTop, IndexLeft] = 0;
                PixelTop -= GameEngine.SQUARE_WIDTH;
                engine.matrix[IndexTop, IndexLeft] = 1;
                CenterIndexY--;
            }
        }
        public bool CanDown(GameEngine engine) //判断小方块能否向下移动
        {
            if (IndexTop + 1 >= GameEngine.FIELD_H)
                return false;
            if (engine.matrix[IndexTop + 1, IndexLeft] == 1)
                return false;
            return true;
        }

        public void MoveDown(GameEngine engine)//向下移动一格
        {
            if (CanDown(engine))
            {
                var same = engine[IndexLeft, IndexTop];
                if (same.Count == 1)//[IndexLeft, IndexTop]位置处只有当前方块本身时，矩阵置0；如果有两个，则说明当前位置还有别的方块，不能置0。
                   engine.matrix[IndexTop, IndexLeft] = 0;

                PixelTop += GameEngine.SQUARE_WIDTH;
                CenterIndexY++;
            }
            else
            {
               engine.matrix[IndexTop, IndexLeft] = 1;
            }
        }
       
        public void Draw(Graphics g)      //绘制小方块
        {
            g.FillRectangle(Brushes.Bisque, PixelLeft, PixelTop, SQUARE_WIDTH, SQUARE_WIDTH); //小方块颜色
            g.DrawRectangle(Pens.Gray, PixelLeft, PixelTop, SQUARE_WIDTH, SQUARE_WIDTH);  //小方块边框绘制

        }
        public int CenterIndexX { set; get; }//旋转中心X索引坐标
        public int CenterIndexY { set; get; }//旋转中心Y索引坐标
        public bool CanRoate(GameEngine engine)
        {
            if (engine.IsSelfGameOver)
                return false;
            int targetIndexLeft = CenterIndexX + CenterIndexY - IndexTop;
            int targetIndexTop = CenterIndexY + IndexLeft - CenterIndexX;
            if (targetIndexLeft < 0 || targetIndexLeft >= GameEngine.FIELD_W || targetIndexTop < 0 || targetIndexTop >= GameEngine.FIELD_H)
                return false;
            return engine.matrix[targetIndexTop, targetIndexLeft] == 0;
        }
        public void Roate(GameEngine engine)
        {
            if (CanRoate(engine))
            {

                int tempLeft = PixelLeft;
                int tempTop = PixelTop;
                PixelLeft = CenterIndexX * GameEngine.SQUARE_WIDTH + CenterIndexY * GameEngine.SQUARE_WIDTH - tempTop;
                PixelTop = CenterIndexY * GameEngine.SQUARE_WIDTH + tempLeft - CenterIndexX * GameEngine.SQUARE_WIDTH;
            }
        }
        
        public bool CanLeft(GameEngine engine)
        {
            if (engine.IsSelfGameOver)
                return false;
            if (PixelLeft <= 0)
                return false;
            if (engine.matrix[IndexTop, IndexLeft - 1] == 1)
                return false;
            return true;
        }
       
        public void MoveLeft(GameEngine engine)
        {
            if (CanLeft(engine))
            {
                PixelLeft -= GameEngine.SQUARE_WIDTH;
                CenterIndexX--;
            }
        }
       
        public bool CanRight(GameEngine engine)
        {
            if (engine.IsSelfGameOver)
                return false;
            if (PixelLeft + GameEngine.SQUARE_WIDTH >= engine.FieldIndexWidth)
                return false;
            if (engine.matrix[IndexTop, IndexLeft + 1] == 1)
                return false;
            return true;
        }
        
        public void MoveRight(GameEngine engine)
        {
            if (CanRight(engine))
            {
                PixelLeft += GameEngine.SQUARE_WIDTH;
                CenterIndexX++;
            }
        }
        
    }
}
