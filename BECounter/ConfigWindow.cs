using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounterNew
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow()
        {
            InitializeComponent();
            LoadConfigIntoCheckBox();
        }

        private void LoadConfigIntoCheckBox()
        {
            checkBoxAlertLoad.Checked = Convert.ToBoolean(Properties.Settings.Default["alertLoad"]);
            checkBoxAlertSave.Checked = Convert.ToBoolean(Properties.Settings.Default["alertSave"]);
            checkBoxAlertReset.Checked = Convert.ToBoolean(Properties.Settings.Default["alertReset"]);
            checkBoxAlertExit.Checked = Convert.ToBoolean(Properties.Settings.Default["alertExit"]);
            checkBoxLoad.Checked = Convert.ToBoolean(Properties.Settings.Default["loadRecently"]);
        }

        private void SaveConfigFromCheckBox()
        {
            Properties.Settings.Default["alertLoad"] = checkBoxAlertLoad.Checked;
            Properties.Settings.Default["alertSave"] = checkBoxAlertSave.Checked;
            Properties.Settings.Default["alertReset"] = checkBoxAlertReset.Checked;
            Properties.Settings.Default["alertExit"] = checkBoxAlertExit.Checked;
            Properties.Settings.Default["loadRecently"] = checkBoxLoad.Checked;
            Properties.Settings.Default.Save();
        }

        #region Buttons

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveConfigFromCheckBox();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
