using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    class FieldBlock: BlockOfFour//BlockOfFour的子类,田字形方块
    {
        public override void SetoutterPosition(int indexX, int indexY)//子类中实现SetoutterPosition函数，用于绑定各个小方块的位置联系
        {
            squares[0].PixelLeft = indexX * Square.SQUARE_WIDTH;
            squares[0].PixelTop = indexY * Square.SQUARE_WIDTH;

            squares[1].PixelLeft = squares[0].PixelLeft+Square.SQUARE_WIDTH;
            squares[1].PixelTop = squares[0].PixelTop;

            squares[2].PixelLeft = squares[0].PixelLeft;
            squares[2].PixelTop = squares[0].PixelTop + Square.SQUARE_WIDTH;

            squares[3].PixelLeft = squares[0].PixelLeft+Square.SQUARE_WIDTH;
            squares[3].PixelTop = squares[0].PixelTop + Square.SQUARE_WIDTH;
        }

        public override YouSquare.BaseBlock InitObjForClone()
        {
            return new FieldBlock();
        }

        public FieldBlock()
             : base((GameEngine.FIELD_W - 2) / 2, 0)
        {
        }
        public override int CenterIndexX //子类中实现抽象属性CenterIndexX
        {
            get
            {
                return squares[3].IndexLeft;
            }
            set
            {

            }
        }
        public override int CenterIndexY//子类中实现抽象属性CenterIndexY
        {
            get
            {
                return squares[3].IndexTop;
            }
            set
            {

            }
        }

        public override bool CanRotate(GameEngine engine)//判断是否可以旋转
        {
            return false;
        }
       
    }
}
