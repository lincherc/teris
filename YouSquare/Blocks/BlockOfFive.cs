using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public abstract class BlockOfFive: BaseBlock//父类BaseBlock的子抽象类
    {
        public BlockOfFive(int indexX, int indexY) : base(indexX, indexY)
        {
        }
        protected override void InitSquares()//子类实现为集合创建五个小方块
        {
            squares.Add(new Square());
            squares.Add(new Square());
            squares.Add(new Square());
            squares.Add(new Square());
            squares.Add(new Square());
        }
    }
}
