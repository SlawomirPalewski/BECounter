namespace BECounterNew
{
    partial class DialogWindow
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
            this.topBarControl = new BECounterNew.Controls.TopBarControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
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
            this.topBarControl.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelMain.Controls.Add(this.buttonNo);
            this.panelMain.Controls.Add(this.buttonYes);
            this.panelMain.Controls.Add(this.labelText);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(2, 28);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 157);
            this.panelMain.TabIndex = 1;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonNo.Location = new System.Drawing.Point(110, 117);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(10);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(80, 30);
            this.buttonNo.TabIndex = 11;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = false;
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonYes.Location = new System.Drawing.Point(15, 117);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(10);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(80, 30);
            this.buttonYes.TabIndex = 10;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.labelText.Location = new System.Drawing.Point(12, 22);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(58, 13);
            this.labelText.TabIndex = 9;
            this.labelText.Text = "{labelText}";
            // 
            // DialogWindow
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(204, 187);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.topBarControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TopBarControl topBarControl;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
    }
}