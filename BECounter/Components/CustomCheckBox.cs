using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounter.Components
{
    public partial class CustomCheckBox : CheckBox
    {
        public CustomCheckBox()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleRight;
            AutoSize = false;
            ForeColor = Color.FromArgb(213, 212, 212);
            TickColor = Color.FromArgb(213, 212, 212);
            RectangleBorderColor = Color.FromArgb(5, 12, 19);
            RectangleFillColor = Color.FromArgb(10, 24, 39);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.Clear(BackColor); // Clear background and set color, important!

            using (SolidBrush brush = new SolidBrush(ForeColor)) // Draw text
                pe.Graphics.DrawString(Text, Font, brush, 17, 3);
            
            Point pt = new Point(1, 3);
            Rectangle rect = new Rectangle(pt, new Size(13, 13));

            using (SolidBrush brush = new SolidBrush(_rectFillColor))
                pe.Graphics.FillRectangle(brush, rect); // Fill CheckBox

            if (Checked) // Draw tick inside checkbox if checked
            {
                using (SolidBrush brush = new SolidBrush(_tickColor))
                using (Font wing = new Font("Wingdings", 12f))
                    pe.Graphics.DrawString("ü", wing, brush, -2, 3);
            }

            using (Pen pen = new Pen(_rectBorderColor, 2))
                pe.Graphics.DrawRectangle(pen, rect); // Draw checkbox

            
        }

        #region Additional Properties

        private Color _tickColor;
        [Category("Checked Color"), Description("Set tick color.")]
        public Color TickColor
        {
            get
            {
                return _tickColor;
            }
            set
            {
                _tickColor = value;
                Invalidate();
            }
        }

        private Color _rectBorderColor;
        [Category("Rectangle Border Color"), Description("Set rectangle border color.")]
        public Color RectangleBorderColor
        {
            get
            {
                return _rectBorderColor;
            }
            set
            {
                _rectBorderColor = value;
                Invalidate();
            }
        }

        private Color _rectFillColor;
        [Category("Rectangle Fill Color"), Description("Set rectangle fill color.")]
        public Color RectangleFillColor
        {
            get
            {
                return _rectFillColor;
            }
            set
            {
                _rectFillColor = value;
                Invalidate();
            }
        }

        #endregion

    }
}
