namespace BECounterNew
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMain = new System.Windows.Forms.Panel();
            this.countingControl = new BECounterNew.Controls.CountingControl();
            this.topBarControl = new BECounterNew.Controls.TopBarControl();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelMain.Controls.Add(this.countingControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 25);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(601, 493);
            this.panelMain.TabIndex = 1;
            // 
            // countingControl
            // 
            this.countingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countingControl.Location = new System.Drawing.Point(0, 0);
            this.countingControl.Name = "countingControl";
            this.countingControl.Size = new System.Drawing.Size(601, 493);
            this.countingControl.TabIndex = 0;
            // 
            // topBarControl
            // 
            this.topBarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.topBarControl.BarText = "BECounter";
            this.topBarControl.ConfigButton = true;
            this.topBarControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarControl.ExitButton = true;
            this.topBarControl.HelpButton = true;
            this.topBarControl.Location = new System.Drawing.Point(2, 0);
            this.topBarControl.Margin = new System.Windows.Forms.Padding(0);
            this.topBarControl.Name = "topBarControl";
            this.topBarControl.Size = new System.Drawing.Size(601, 25);
            this.topBarControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(605, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.topBarControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(989, 697);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 520);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TopBarControl topBarControl;
        private System.Windows.Forms.Panel panelMain;
        private Controls.CountingControl countingControl;
    }
}

