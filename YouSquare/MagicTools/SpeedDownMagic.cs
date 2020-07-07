using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySquare.MagicTools
{
    public class SpeedDownMagic : MagicTool
    {
        public override bool IsLocal
        {
            get { return true; }
        }

        protected override int Cost
        {
            get { return 25; }
        }

        protected override void Bingo()
        {
            GameEngine.Instance.ChangeSpeed(false);
        }

        public override MagicEnum MagicType
        {
            get { return MagicEnum.SPEED_DOWN; }
        }
    }
}
