namespace BECounterNew
{
    partial class ConfigWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAlertLoad = new BECounterNew.Components.CustomCheckBox();
            this.checkBoxAlertSave = new BECounterNew.Components.CustomCheckBox();
            this.checkBoxAlertReset = new BECounterNew.Components.CustomCheckBox();
            this.checkBoxAlertExit = new BECounterNew.Components.CustomCheckBox();
            this.checkBoxLoad = new BECounterNew.Components.CustomCheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.topBarControl = new BECounterNew.Controls.TopBarControl();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Controls.Add(this.buttonClose);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(247, 213);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAlertLoad, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAlertSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAlertReset, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAlertExit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLoad, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 127);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // checkBoxAlertLoad
            // 
            this.checkBoxAlertLoad.AutoSize = true;
            this.checkBoxAlertLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAlertLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertLoad.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAlertLoad.Name = "checkBoxAlertLoad";
            this.checkBoxAlertLoad.RectangleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.checkBoxAlertLoad.RectangleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.checkBoxAlertLoad.Size = new System.Drawing.Size(125, 17);
            this.checkBoxAlertLoad.TabIndex = 0;
            this.checkBoxAlertLoad.Text = "Show alert when load";
            this.checkBoxAlertLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlertLoad.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertLoad.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlertSave
            // 
            this.checkBoxAlertSave.AutoSize = true;
            this.checkBoxAlertSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAlertSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertSave.Location = new System.Drawing.Point(3, 28);
            this.checkBoxAlertSave.Name = "checkBoxAlertSave";
            this.checkBoxAlertSave.RectangleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.checkBoxAlertSave.RectangleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.checkBoxAlertSave.Size = new System.Drawing.Size(128, 17);
            this.checkBoxAlertSave.TabIndex = 1;
            this.checkBoxAlertSave.Text = "Show alert when save";
            this.checkBoxAlertSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlertSave.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlertReset
            // 
            this.checkBoxAlertReset.AutoSize = true;
            this.checkBoxAlertReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAlertReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertReset.Location = new System.Drawing.Point(3, 53);
            this.checkBoxAlertReset.Name = "checkBoxAlertReset";
            this.checkBoxAlertReset.RectangleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.checkBoxAlertReset.RectangleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.checkBoxAlertReset.Size = new System.Drawing.Size(128, 17);
            this.checkBoxAlertReset.TabIndex = 2;
            this.checkBoxAlertReset.Text = "Show alert when reset";
            this.checkBoxAlertReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlertReset.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertReset.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlertExit
            // 
            this.checkBoxAlertExit.AutoSize = true;
            this.checkBoxAlertExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAlertExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertExit.Location = new System.Drawing.Point(3, 78);
            this.checkBoxAlertExit.Name = "checkBoxAlertExit";
            this.checkBoxAlertExit.RectangleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.checkBoxAlertExit.RectangleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.checkBoxAlertExit.Size = new System.Drawing.Size(121, 17);
            this.checkBoxAlertExit.TabIndex = 3;
            this.checkBoxAlertExit.Text = "Show alert when exit";
            this.checkBoxAlertExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlertExit.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxAlertExit.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoad
            // 
            this.checkBoxLoad.AutoSize = true;
            this.checkBoxLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxLoad.Location = new System.Drawing.Point(3, 103);
            this.checkBoxLoad.Name = "checkBoxLoad";
            this.checkBoxLoad.RectangleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.checkBoxLoad.RectangleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.checkBoxLoad.Size = new System.Drawing.Size(172, 17);
            this.checkBoxLoad.TabIndex = 4;
            this.checkBoxLoad.Text = "Load recently saved on startup ";
            this.checkBoxLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLoad.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.checkBoxLoad.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonClose.Location = new System.Drawing.Point(157, 173);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 30);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonSave.Location = new System.Drawing.Point(10, 173);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // topBarControl
            // 
            this.topBarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.topBarControl.BarText = "Configuration";
            this.topBarControl.ConfigButton = false;
            this.topBarControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarControl.ExitButton = false;
            this.topBarControl.HelpButton = false;
            this.topBarControl.Location = new System.Drawing.Point(2, 0);
            this.topBarControl.Name = "topBarControl";
            this.topBarControl.Size = new System.Drawing.Size(247, 25);
            this.topBarControl.TabIndex = 3;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(251, 240);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.topBarControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigWindow";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigWindow";
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSave;
        private Controls.TopBarControl topBarControl;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.CustomCheckBox checkBoxAlertLoad;
        private Components.CustomCheckBox checkBoxAlertSave;
        private Components.CustomCheckBox checkBoxAlertReset;
        private Components.CustomCheckBox checkBoxAlertExit;
        private Components.CustomCheckBox checkBoxLoad;
    }
}