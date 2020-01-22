using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounter.Components
{
    public partial class CustomPictureBox : PictureBox
    {
        /// <summary>
        /// Event that triggers when PictureBox is pressed.
        /// </summary>
        public event EventHandler<ChampionValueChangeArgs> ChangeChampionValue;

        public Label Label { get; set; }
        private ToolTip _tt = new ToolTip();

        public string championName;
        public int championQuantity;
        private int _id;

        public CustomPictureBox(string imageDirectory, ChampionData champion, int championCount)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            SetPictureBoxProperties(imageDirectory, championCount);
            SetLabelProperties(champion.Name);

            InitToolTip();
            _tt.SetToolTip(this, PrepareTooltipText(champion));

            _id = championCount;

            this.Controls.Add(Label);
        }

        /// <summary>
        /// Force Label to refresh. Need to use when data is changing.
        /// </summary>
        public void RefreshLabel()
        {
            Label.Text = championQuantity.ToString();
            Label.Tag = championName;
        }

        /// <summary>
        /// Increase or decrease value when picture is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // If right then decrease amount of champion shard
            if (e.Button == MouseButtons.Right)
            {
                if (championQuantity > 0) Label.Text = (--championQuantity).ToString();
            }
            // If left then increase amount
            else if (e.Button == MouseButtons.Left)
                Label.Text = (++championQuantity).ToString();

            // If changeChampionValue is assigned, then fire event
            if (ChangeChampionValue != null)
            {
                ChangeChampionValue(sender, new ChampionValueChangeArgs(_id, championQuantity));
            }
        }

        #region Set Properties

        private void SetPictureBoxProperties(string imageDirectory, int championId)
        {
            this.Size = new Size(130, 130);
            this.Margin = new Padding(0);
            this.Image = Image.FromFile(imageDirectory);
            this.Tag = championId;
            this.MouseDown += PictureBox_MouseDown;
        }

        private void SetLabelProperties(string championName)
        {
            this.championName = championName;

            Label = new Label();
            Label.Text = "0";
            Label.Bounds = new Rectangle(this.Width - 45, this.Height - 35, 35, 25);
            Label.Tag = championName;
            Label.BackColor = Color.FromArgb(190, 5, 12, 19);
            Label.ForeColor = Color.White;
            Label.Font = new Font("Arial", 10, FontStyle.Bold);
            Label.AutoSize = false;
            Label.TextAlign = ContentAlignment.MiddleRight;
            Label.Anchor = AnchorStyles.Right;
            Label.MouseDown += PictureBox_MouseDown;
        }
        #endregion

        #region PictureBox ToolTip

        /// <summary>
        /// Prepares tooltip for champion
        /// </summary>
        /// <param name="champion"></param>
        /// <returns></returns>
        private string PrepareTooltipText(ChampionData champion)
        {
            int sellPrice = 0, buyPriceWithShard = 0, buyPrice = champion.Price;

            switch (buyPrice)
            {
                case 450:
                    sellPrice = 90;
                    buyPriceWithShard = 270;
                    break;
                case 1350:
                    sellPrice = 270;
                    buyPriceWithShard = 810;
                    break;
                case 3150:
                    sellPrice = 630;
                    buyPriceWithShard = 1890;
                    break;
                case 4800:
                    sellPrice = 960;
                    buyPriceWithShard = 2880;
                    break;
                case 6300:
                    sellPrice = 1260;
                    buyPriceWithShard = 3780;
                    break;
                case 7800:
                    sellPrice = 1560;
                    buyPriceWithShard = 3780;
                    break;
            }

            string tooltip = champion.Name + "\n  Sell piece: " + sellPrice + " BE\n  Buy without piece: " + buyPrice + " BE\n  Buy with piece: " + buyPriceWithShard + " BE";
            return tooltip;
        }

        /// <summary>
        /// Method for tooltip. Initialize tooltip and gives him events from other methods.
        /// </summary>
        private void InitToolTip()
        {
            _tt.OwnerDraw = true;
            _tt.Draw += new DrawToolTipEventHandler(ToolTip_Draw);
            _tt.Popup += new PopupEventHandler(ToolTip_Popup);
        }

        /// <summary>
        /// Changes color and time of tooltip spawn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            _tt.InitialDelay = 1300;
            Font font = new Font("Arial", 10.0f, FontStyle.Bold);
            _tt.BackColor = Color.FromArgb(255, 5, 12, 19);
            _tt.ForeColor = Color.FromArgb(255, 213, 212, 212);
            e.DrawBackground();
            e.DrawBorder();
            Brush myBrush = new SolidBrush(Color.FromArgb(255, 213, 212, 212));

            e.Graphics.DrawString(e.ToolTipText, font, myBrush, new PointF(2.0f, 2.0f));
        }

        /// <summary>
        /// Changes size of tooltip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolTip_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(185, 65);
        }
        #endregion

    }
}
