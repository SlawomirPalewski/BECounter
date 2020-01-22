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
    public partial class InfoWindow : Form
    {
        public InfoWindow(String topBarText, String labelText)
        {
            InitializeComponent();
            topBarControl.ChangeTopBarText(topBarText);
            this.labelText.Text = labelText;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
