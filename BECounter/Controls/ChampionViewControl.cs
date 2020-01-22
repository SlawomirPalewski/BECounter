using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using BECounterNew.Components;

namespace BECounterNew.Controls
{
    public partial class ChampionViewControl : UserControl
    {
        public event EventHandler<EventArgs> CountingLabelReload;
        private string _executePath;

        public ChampionViewControl()
        {
            InitializeComponent();

            // Prevents background distorts and flickers
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                _executePath = "C:/Users/Dorokai/Source/repos/BECounter/BECounterNew/bin/Debug/";
            else
                 _executePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            DisableDefaultPanelScrolls();
            
            flowLayoutPanelChampionView.MouseWheel += FlowLayoutPanelChampionView_MouseWheel;
        }

        #region Picture Box

        private Save _save;
        private List<CustomPictureBox> _pbList = new List<CustomPictureBox>();
        private List<ChampionData> _championData;

        /// <summary>
        /// Loads template and makes pictureboxes inside champion panel.
        /// </summary>
        public void AddPictureBoxes(List<ChampionData> championData)
        {
            _championData = championData;
            string directory;
            int championCount = 0;

            foreach (ChampionData champion in championData)
            {
                directory = _executePath +"/Images/"+ champion.Image;

                _pbList.Add(new CustomPictureBox(directory, champion, championCount));

                _pbList[championCount].ChangeChampionValue += new EventHandler<ChampionValueChangeArgs>(ChangeChampionValueEvent);

                flowLayoutPanelChampionView.Controls.Add(_pbList[championCount]);

                championCount++;
            }

            LoadPanelTrueHeight();
        }

        /// <summary>
        /// Loads values from save to pictureBox.
        /// </summary>
        public void LoadChampionSave(Save save)
        {
            _save = save;

            foreach (SavedChampion sc in save.Champion)
            {
                CustomPictureBox cpb = _pbList.FirstOrDefault(x => x.championName.Equals(sc.Name));
                if (cpb.championName != null) cpb.championQuantity = sc.Quantity;
                cpb.RefreshLabel();
            }
        }

        /// <summary>
        /// Event that fires when Picture Boxes are pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeChampionValueEvent(object sender, ChampionValueChangeArgs e)
        {
            SavedChampion sc = _save.Champion[e.Id];
            sc.Quantity = e.Value;

            CountingLabelReload?.Invoke(sender, new EventArgs()); // If not null -> use
        }

        #endregion

        #region Scroll Bar

        private Point _location;
        private int
            _scrollYprevious, // Scroll position
            _mouseYprevious, _mouseX = MousePosition.X, _mouseY = MousePosition.Y, // Mouse position
            _mouseWheelValue = 0;
        private bool _mouseDownScroll; 
        private double _scrolledPercent = 0.0;

        /// <summary>
        /// Method for scrollbar. Detects position of mouse when you grab scrollbar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelScrollBarIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_mouseDownScroll)
            {
                _mouseYprevious = MousePosition.Y;
            }
            _mouseDownScroll = true;
            _scrollYprevious = panelScrollBarIn.Top;
        }

        /// <summary>
        /// Method for scrollbar. Detects move of mouse and position scroll there.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelScrollBarIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDownScroll)
            {
                // Counting percent of scrolled scrollbar by counting distance of scroll from top
                if (panelScrollBarIn.Top != 0)
                    _scrolledPercent = (Convert.ToDouble(panelScrollBarIn.Top-10) / (panelScrollBarMid.Size.Height -20- panelScrollBarIn.Height));
                else _scrolledPercent = 0;
                
                _mouseY = MousePosition.Y;
                _location = panelScrollBarIn.PointToScreen(Point.Empty);

                // 0-1 range
                if ((_mouseY - (_mouseYprevious - _scrollYprevious)) < panelScrollBarMid.Size.Height - 9 - panelScrollBarIn.Height && (_mouseY - (_mouseYprevious - _scrollYprevious)) > 9) panelScrollBarIn.Location = new Point(panelScrollBarIn.Left, _mouseY - (_mouseYprevious - _scrollYprevious));
                
                // Top (0) limit
                else if (_mouseY < (_location.Y )) panelScrollBarIn.Location = new Point(panelScrollBarIn.Left, 10);
                
                // Bot (1) limit
                else if (_mouseY > (this.Location.Y + panelScrollBarOut.Top + panelScrollBarMid.Height)) panelScrollBarIn.Location = new Point(panelScrollBarIn.Left, panelScrollBarMid.Size.Height - 10 - panelScrollBarIn.Height);

                flowLayoutPanelChampionView.AutoScrollPosition = new Point(flowLayoutPanelChampionView.Location.X, Convert.ToInt32(_panelTotalHeight * _scrolledPercent));

                _mouseWheelValue = panelScrollBarIn.Top;


            }
        }

        /// <summary>
        /// Method for scrollbar. It detects if you stop grabbing scroll.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelScrollBarIn_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDownScroll = false;
        }

        #endregion

        #region Champion Panel

        private double _panelTotalHeight;
        private PictureBox firstPictureBox, lastPictureBox;

        private void LoadPanelTrueHeight()
        {
            lastPictureBox = flowLayoutPanelChampionView.Controls.OfType<PictureBox>().LastOrDefault();
            firstPictureBox = flowLayoutPanelChampionView.Controls.OfType<PictureBox>().FirstOrDefault();
        }

        /// <summary>
        /// Casts when whole window is resizing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowLayoutPanelChampionView_Resize(object sender, EventArgs e)
        {
            // Count panel total height
            try
            {
                _panelTotalHeight = Convert.ToDouble(lastPictureBox.Top - flowLayoutPanelChampionView.Height + lastPictureBox.Height);
            }
            catch(Exception)
            {
                _panelTotalHeight = flowLayoutPanelChampionView.Height;
            }

            // Set panel location to 0
            flowLayoutPanelChampionView.AutoScrollPosition = new Point(flowLayoutPanelChampionView.Location.X, 0);

            // Set scroll location to 0
            panelScrollBarIn.Top = 10;
        }

        /// <summary>
        /// Metod that prevents drawing of default autoscroll.
        /// </summary>
        private void DisableDefaultPanelScrolls()
        {
            flowLayoutPanelChampionView.AutoScroll = false;
            flowLayoutPanelChampionView.HorizontalScroll.Maximum = 0;
            flowLayoutPanelChampionView.HorizontalScroll.Visible = false;
            flowLayoutPanelChampionView.VerticalScroll.Maximum = 0;
            flowLayoutPanelChampionView.VerticalScroll.Visible = false;
            flowLayoutPanelChampionView.AutoScroll = true;
        }

        /// <summary>
        /// Method for champion panel. It focuses panel when mouse hover over it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowLayoutPanelChampionView_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanelChampionView.Focus();
        }

        /// <summary>
        /// Method for panel. If you use mouse scroll on panel, you scroll the scrollbar too.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowLayoutPanelChampionView_MouseWheel(object sender, MouseEventArgs e)
        {
            // Counts percentage of scrolled panel
            double percentageScroll = (-firstPictureBox.Top+6)/_panelTotalHeight;

            // Changes scroll location by that percentage
            panelScrollBarIn.Location = new Point(panelScrollBarIn.Left, Convert.ToInt32(10+ (percentageScroll * (panelScrollBarMid.Height - 20 - panelScrollBarIn.Height))));
        }
        #endregion

        #region Overrides

        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();

            base.OnScroll(se);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }

        #endregion
    }
}
