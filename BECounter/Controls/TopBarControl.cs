using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounter.Controls
{
    public partial class TopBarControl : UserControl
    {

        public TopBarControl()
        {
            InitializeComponent();
        }

        public void ChangeTopBarText(String text)
        {
            labelTitleName.Text = text;
        }

        #region Buttons

        /// <summary>
        /// Opens configuration window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfig_Click(object sender, System.EventArgs e)
        {
            ConfigWindow cfw = new ConfigWindow();
            cfw.ShowDialog();
        }

        /// <summary>
        /// Opens help window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHelp_Click(object sender, System.EventArgs e)
        {
            String message = "Left click to +1, right click to -1. \r\nMade by Sławomir Palewski.";
            InfoWindow infoWindow = new InfoWindow("Help", message);
            infoWindow.ShowDialog();
        }

        /// <summary>
        /// Close application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonQuit_Click(object sender, System.EventArgs e)
        {
            Boolean alertExit = Convert.ToBoolean(Properties.Settings.Default["alertExit"]);

            DialogResult dialogResult = DialogResult.No;

            if (alertExit)
            {
                DialogWindow dw = new DialogWindow("Exit confirm", "Close application?");
                dw.ShowDialog();
                dialogResult = dw.DialogResult;
            }
            
            if(dialogResult == DialogResult.Yes || !alertExit)
            {
                if (Application.MessageLoop) Application.Exit();
                else System.Environment.Exit(1);
            }
        }

        #endregion

        #region Bar Movement

        private int _formXprevious, _formYprevious; // App position
        private int _mouseXprevious, _mouseYprevious, _mouseX = MousePosition.X, _mouseY = MousePosition.Y; // Cursor position
        private bool _mouseDownTitle; // Is mouse pressed boolean

        /// <summary>
        /// Method for menu panel. Activate when you stop holding that panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_mouseDownTitle)
            {
                _mouseXprevious = MousePosition.X;
                _mouseYprevious = MousePosition.Y;
            }
            _mouseDownTitle = true;
            _formXprevious = this.Parent.Left;
            _formYprevious = this.Parent.Top;
        }

        /// <summary>
        /// Method of menu panel. Detects holding of that panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDownTitle = false;
        }

        /// <summary>
        /// Method for menu panel. Detects mouse move and moves whole form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDownTitle)
            {
                _mouseX = MousePosition.X;
                _mouseY = MousePosition.Y;
                this.Parent.Location = new Point(_mouseX - (_mouseXprevious - _formXprevious), _mouseY - (_mouseYprevious - _formYprevious));
            }
        }

        #endregion

        #region Additional Properties

        private string _vBarText;
        /// <summary>
        /// Top bar text
        /// </summary>
        [Category("Bar text"), Description("Displayed text of bar.")]
        public String BarText
        {
            get
            {
                return _vBarText;
            }
            set
            {
                _vBarText = value;
                labelTitleName.Text = _vBarText;
                Invalidate();
            }
        }


        private bool _vExitButton;
        [Category("Exit button"), Description("Displayed exit button.")]
        public bool ExitButton
        {
            get
            {
                return _vExitButton;
            }
            set
            {
                _vExitButton = value;
                buttonQuit.Visible = _vExitButton;
                Invalidate();
            }
        }

        private bool _vHelpButton;
        [Category("Help button"), Description("Displayed help button.")]
        public bool HelpButton
        {
            get
            {
                return _vHelpButton;
            }
            set
            {
                _vHelpButton = value;
                buttonHelp.Visible = _vHelpButton;
                Invalidate();
            }
        }

        private bool _vConfigButton;
        [Category("Config button"), Description("Displayed configuration button.")]
        public bool ConfigButton
        {
            get
            {
                return _vConfigButton;
            }
            set
            {
                _vConfigButton = value;
                buttonConfig.Visible = _vConfigButton;
                Invalidate();
            }
        }

        #endregion
    }
}
