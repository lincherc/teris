using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSquare
{
    public static class ControlExt
    {
        public static void SafeInvoke(this System.Windows.Forms.Control ctr, Delegate d)
        {
            if (ctr.IsHandleCreated)
                ctr.Invoke(d);
        }
        public static void SafeInvoke(this System.Windows.Forms.Control ctr, Delegate d, params object[] args)
        {
            if (ctr.IsHandleCreated)
                ctr.Invoke(d, args);
        }
    }
}
