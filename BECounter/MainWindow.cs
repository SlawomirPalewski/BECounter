using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounterNew
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Neccesary to avoid visual artifacts
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush customBrush = new SolidBrush(Color.FromArgb(5, 12, 19));

            e.Graphics.FillRectangle(customBrush, TopP);
            e.Graphics.FillRectangle(customBrush, LeftP);
            e.Graphics.FillRectangle(customBrush, RightP);
            e.Graphics.FillRectangle(customBrush, BottomP);
        }


        const int vr = 10; // Length of "Corner grab"

        Rectangle TopP { get { return new Rectangle(0, 0, this.ClientSize.Width, vr); } }
        Rectangle LeftP { get { return new Rectangle(0, 0, vr, this.ClientSize.Height); } }
        Rectangle BottomP { get { return new Rectangle(0, this.ClientSize.Height - vr, this.ClientSize.Width, vr); } }
        Rectangle RightP { get { return new Rectangle(this.ClientSize.Width - vr, 0, vr, this.ClientSize.Height); } }

        Rectangle TopLeftP { get { return new Rectangle(0, 0, vr, vr); } }
        Rectangle TopRightP { get { return new Rectangle(this.ClientSize.Width - vr, 0, vr, vr); } }
        Rectangle BottomLeftP { get { return new Rectangle(0, this.ClientSize.Height - vr, vr, vr); } }
        Rectangle BottomRightP { get { return new Rectangle(this.ClientSize.Width - vr, this.ClientSize.Height - vr, vr, vr); } }


        private const int
          HTLEFT = 10,
          HTRIGHT = 11,
          HTTOP = 12,
          HTTOPLEFT = 13,
          HTTOPRIGHT = 14,
          HTBOTTOM = 15,
          HTBOTTOMLEFT = 16,
          HTBOTTOMRIGHT = 17;

        /// <summary>
        /// Overrided to change cursor when mouse is near application edge
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                Point curPos = this.PointToClient(Cursor.Position);

                if (TopLeftP.Contains(curPos)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRightP.Contains(curPos)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeftP.Contains(curPos)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRightP.Contains(curPos)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (TopP.Contains(curPos)) message.Result = (IntPtr)HTTOP;
                else if (LeftP.Contains(curPos)) message.Result = (IntPtr)HTLEFT;
                else if (RightP.Contains(curPos)) message.Result = (IntPtr)HTRIGHT;
                else if (BottomP.Contains(curPos)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
    }
}
