using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySquare.MagicTools
{
    public class RandomBlockMagic : RemoteMagic
    {
        protected override int Cost
        {
            get { return 30; }
        }

        public override MagicEnum MagicType
        {
            get { return MagicEnum.RANDOM_BLOCK; }
        }
    }
}
