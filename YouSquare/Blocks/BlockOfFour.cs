using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public abstract class BlockOfFour: BaseBlock//父类BaseBlock的子抽象类
    {
        public BlockOfFour(int indexX,int indexY):base(indexX,indexY)
        {
        }
        protected override void InitSquares()//子类实现为集合创建四个小方块
        {
            squares.Add(new Square());
            squares.Add(new Square());
            squares.Add(new Square());
            squares.Add(new Square());
        }
    }

}
