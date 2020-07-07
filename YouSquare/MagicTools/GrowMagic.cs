using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySquare.Utilities;

namespace MySquare.MagicTools
{
    public class GrowMagic : RemoteMagic
    {
        protected override int Cost
        {
            get { return 10; }
        }

        public override MagicEnum MagicType
        {
            get { return MagicEnum.GROW; }
        }
    }
}
