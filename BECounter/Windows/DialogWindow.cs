using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECounter
{
    public partial class DialogWindow : Form
    {
        public DialogWindow(String topBarText, String labelText)
        {
            InitializeComponent();
            topBarControl.ChangeTopBarText(topBarText);
            this.labelText.Text = labelText;
        }
    }
}
