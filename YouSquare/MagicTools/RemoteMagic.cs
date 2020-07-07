using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySquare.MagicTools
{
    public abstract class RemoteMagic : MagicTool
    {
        public override bool IsLocal
        {
            get { return false; }
        }
        protected override void Bingo()
        {
            SendToRemote();
        }
    }
}
