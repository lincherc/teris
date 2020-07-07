using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{   //生成随机类型方块
    class BlockFactory
    {
        private static Random rand = new Random();//伪随机数生成器
        public static BaseBlock Create()
        {
            BaseBlock r = null;
            int type = rand.Next(6);
            switch(type)
            {
                case 0:
                    r = new TBlock();
                    break;
                case 1:
                    r = new ZBlock();
                    break;
                case 2:
                    r = new LBlock();
                    break;
                case 3:
                    r = new FieldBlock();
                    break;
                case 4:
                    r = new BigZBlock();
                    break;
                case 5:
                    r = new LongBlock();
                    break;
            }
            r.IsActive = true;
            return r;
        }
    }
}
