using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouSquare.Utilities
{
    public class SplashString : SplashBase<string>//泛型类SplashBase的子类，用于实现计分显示效果
    {
        public SplashString(PictureBox canv, string content, Size initSize)
            : base(canv, content, initSize)
        {

        }
        protected override void Draw(Graphics g)
        {
            if (Content == null)
                return;
            var font = new Font("宋体", objSize.Width, FontStyle.Bold, GraphicsUnit.Pixel);
            var size = g.MeasureString(Content, font);
            objSize = new Size((int)size.Width, (int)size.Height);
            g.DrawString(Content, font, Brushes.Red, Loc);
        }
    }
}
