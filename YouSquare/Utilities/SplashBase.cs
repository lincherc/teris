using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace YouSquare.Utilities
{
    public abstract class SplashBase<T> : IDisposable
    {
        private T _Content;
        public T Content
        {
            set
            {
                _Content = value;
                if (timer != null)
                    timer.Enabled = true;
            }
            get
            {
                return _Content;
            }
        }
        private Timer timer = new Timer();
        private Size initObjSize;
        protected Size objSize = Size.Empty;
        private int timerTag = 0;
        private PictureBox canvas = null;
        protected Point Loc
        {
            get
            {
                return new Point((canvas.Width - objSize.Width) / 2, (canvas.Height - objSize.Height) / 2);
            }
        }
        public SplashBase(PictureBox canv, T content, Size initSize)
        {
            canvas = canv;
            Content = content;
            initObjSize = initSize;
            Reset();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10;
            canvas.Paint += new PaintEventHandler(canvas_Paint);
        }
        private bool canShow = true;
        protected abstract void Draw(Graphics g);
        void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (objSize.Width <= 0 || objSize.Height <= 0)
                return;
            if (canShow)
                Draw(e.Graphics);
        }
        private void Reset()
        {
            objSize = initObjSize;
            timerTag = 0;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Go();
            canvas.Invalidate();
        }
        public event Action SplashCompletedEvent;
        private void Go()
        {
            int a = 9;
            if (timerTag > a)
            {
                Reset();
                timer.Enabled = false;
                if (SplashCompletedEvent != null)
                    SplashCompletedEvent();
                return;
            }
            switch (timerTag % a)
            {
                case 0:
                    objSize = initObjSize;
                    break;
                case 1:
                case 2:
                case 3:
                    objSize = new Size((int)(initObjSize.Width * 1.8), (int)(initObjSize.Height * 1.8));
                    break;
                case 4:
                case 5:
                case 6:
                    objSize = new Size((int)(initObjSize.Width * 1.3), (int)(initObjSize.Height * 1.3));
                    break;
                case 7:
                case 8:
                    objSize = new Size((int)(initObjSize.Width * 1.1), (int)(initObjSize.Height * 1.1));
                    break;
                default:
                    objSize = initObjSize;
                    break;
            }
            timerTag++;
        }
        public void Clear()
        {
            canShow = false;
        }
        public void Dispose()
        {
            timer.Enabled = false;
            timer.Dispose();
        }
    }
}
