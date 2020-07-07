using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySquare.MagicTools
{
    public class RemoveLastLineMagic : MagicTool
    {
        protected override int Cost
        {
            get { return 20; }
        }
        protected override void Bingo()
        {
            GameEngine.Instance.RemoveLastLine();
        }

        public override MagicEnum MagicType
        {
            get { return MagicEnum.REMOVE_LAST_LINE; }
        }

        public override bool IsLocal
        {
            get { return true; }
        }
    }
}
