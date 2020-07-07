using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySquare.Utilities;
using MySquare.LanGame;
using MySquare.DataGram;

namespace MySquare.MagicTools
{
    public abstract class MagicTool
    {
        public abstract bool IsLocal { get; }
        protected abstract int Cost { get; }
        protected abstract void Bingo();
        public abstract MagicEnum MagicType { get; }
        protected void SendToRemote()
        {
            DataGram<MagicEnum> growMagicGram = new DataGram<MagicEnum>() { cmd = "MAGIC_TOOL", data = MagicType };
            byte[] buf = Serializer.Serialize(growMagicGram);
            if (GameEngine.IsServer)
            {
                LanServer.Instance.SendMsgToRemote(buf);
            }
            else
            {
                LanClient.Instance.SendMsgToRemote(buf);
            }
        }
        public bool CanAfford()
        {
            bool r = GameEngine.Instance.MagicPower >= Cost;
            return r;
        }
        public void Work()
        {
            if (GameEngine.isRPG)
                if (!IsLocal)
                    return;

            if (CanAfford())
            {
                Bingo();
                if (GameEngine.Instance.MagicPower - Cost >= 0)
                    GameEngine.Instance.MagicPower -= Cost;
            }
        }
    }
}
