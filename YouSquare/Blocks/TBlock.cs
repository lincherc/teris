using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public class TBlock: BlockOfFour //BlockOfFour的子类，T形方块
    {
        public override void SetoutterPosition(int indexX, int indexY)//子类中实现SetoutterPosition函数，用于绑定各个小方块的位置联系
        {
            switch (rotateTag)
            {
                case RotateTag.UP:
                    squares[0].PixelLeft = indexX * GameEngine.SQUARE_WIDTH;
                    squares[0].PixelTop = (indexY + 1) * GameEngine.SQUARE_WIDTH;

                    squares[1].PixelLeft = squares[0].PixelLeft + GameEngine.SQUARE_WIDTH;
                    squares[1].PixelTop = squares[0].PixelTop;

                    squares[2].PixelLeft = squares[0].PixelLeft + GameEngine.SQUARE_WIDTH * 2;
                    squares[2].PixelTop = squares[0].PixelTop;

                    squares[3].PixelLeft = squares[0].PixelLeft + GameEngine.SQUARE_WIDTH;
                    squares[3].PixelTop = squares[0].PixelTop - GameEngine.SQUARE_WIDTH;
                    break;
                case RotateTag.RIGHT:
                    squares[0].PixelLeft = indexX * GameEngine.SQUARE_WIDTH;
                    squares[0].PixelTop = indexY * GameEngine.SQUARE_WIDTH;

                    squares[1].PixelLeft = squares[0].PixelLeft;
                    squares[1].PixelTop = squares[0].PixelTop + GameEngine.SQUARE_WIDTH;

                    squares[2].PixelLeft = squares[0].PixelLeft;
                    squares[2].PixelTop = squares[0].PixelTop + GameEngine.SQUARE_WIDTH * 2;

                    squares[3].PixelLeft = squares[0].PixelLeft + GameEngine.SQUARE_WIDTH;
                    squares[3].PixelTop = squares[0].PixelTop + GameEngine.SQUARE_WIDTH;
                    break;
                case RotateTag.DOWN:
                    squares[0].PixelLeft = (indexX + 2) * GameEngine.SQUARE_WIDTH;
                    squares[0].PixelTop = indexY * GameEngine.SQUARE_WIDTH;

                    squares[1].PixelLeft = squares[0].PixelLeft - GameEngine.SQUARE_WIDTH;
                    squares[1].PixelTop = squares[0].PixelTop;

                    squares[2].PixelLeft = squares[0].PixelLeft - GameEngine.SQUARE_WIDTH * 2;
                    squares[2].PixelTop = squares[0].PixelTop;

                    squares[3].PixelLeft = squares[0].PixelLeft - GameEngine.SQUARE_WIDTH;
                    squares[3].PixelTop = squares[0].PixelTop + GameEngine.SQUARE_WIDTH;
                    break;
                case RotateTag.LEFT:
                    squares[0].PixelLeft = (indexX + 1) * GameEngine.SQUARE_WIDTH;
                    squares[0].PixelTop = (indexY + 2) * GameEngine.SQUARE_WIDTH;

                    squares[1].PixelLeft = squares[0].PixelLeft;
                    squares[1].PixelTop = squares[0].PixelTop - GameEngine.SQUARE_WIDTH;

                    squares[2].PixelLeft = squares[0].PixelLeft;
                    squares[2].PixelTop = squares[0].PixelTop - GameEngine.SQUARE_WIDTH * 2;

                    squares[3].PixelLeft = squares[0].PixelLeft - GameEngine.SQUARE_WIDTH;
                    squares[3].PixelTop = squares[0].PixelTop - GameEngine.SQUARE_WIDTH;
                    break;
            }
        }

        public override YouSquare.BaseBlock InitObjForClone()
        {
            return new TBlock();
        }

        public TBlock() : base((GameEngine.FIELD_W - 3) / 2, 0)
        {
        }
        public override int CenterIndexX //子类中实现抽象属性CenterIndexX
        {
            get
            {
                return squares[1].IndexLeft;
            }
            set
            {

            }
        }
        public override int CenterIndexY//子类中实现抽象属性CenterIndexY
        {
            get
            {
                return squares[1].IndexTop;
            }
            set
            {

            }
        }
    }
}
