using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySquare.MagicTools
{
    public class SpeedUpMagic : RemoteMagic
    {
        protected override int Cost
        {
            get { return 15; }
        }
        public override MagicEnum MagicType
        {
            get { return MagicEnum.SPEED_UP; }
        }
    }
}
