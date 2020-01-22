namespace BECounterNew
{
    partial class InfoWindow
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.topBarMainWindowControl = new BECounterNew.Controls.TopBarControl();
            this.topBarControl = new BECounterNew.Controls.TopBarControl();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelMain.Controls.Add(this.labelText);
            this.panelMain.Controls.Add(this.buttonOk);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(2, 28);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 157);
            this.panelMain.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.labelText.Location = new System.Drawing.Point(12, 22);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(58, 13);
            this.labelText.TabIndex = 8;
            this.labelText.Text = "{labelText}";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonOk.Location = new System.Drawing.Point(59, 114);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 30);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // topBarMainWindowControl
            // 
            this.topBarMainWindowControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.topBarMainWindowControl.BarText = null;
            this.topBarMainWindowControl.ConfigButton = false;
            this.topBarMainWindowControl.ExitButton = false;
            this.topBarMainWindowControl.HelpButton = false;
            this.topBarMainWindowControl.Location = new System.Drawing.Point(0, 0);
            this.topBarMainWindowControl.Name = "topBarMainWindowControl";
            this.topBarMainWindowControl.Size = new System.Drawing.Size(740, 25);
            this.topBarMainWindowControl.TabIndex = 0;
            // 
            // topBarControl
            // 
            this.topBarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.topBarControl.BarText = "{BarText}";
            this.topBarControl.ConfigButton = false;
            this.topBarControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarControl.ExitButton = false;
            this.topBarControl.HelpButton = false;
            this.topBarControl.Location = new System.Drawing.Point(2, 0);
            this.topBarControl.Name = "topBarControl";
            this.topBarControl.Size = new System.Drawing.Size(200, 25);
            this.topBarControl.TabIndex = 2;
            // 
            // InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(204, 187);
            this.Controls.Add(this.topBarControl);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonOk;
        private Controls.TopBarControl topBarMainWindowControl;
        private Controls.TopBarControl topBarControl;
    }
}