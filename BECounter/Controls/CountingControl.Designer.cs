namespace BECounter.Controls
{
    partial class CountingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCountingControl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label90 = new System.Windows.Forms.Label();
            this.label270 = new System.Windows.Forms.Label();
            this.label630 = new System.Windows.Forms.Label();
            this.label960 = new System.Windows.Forms.Label();
            this.label1260 = new System.Windows.Forms.Label();
            this.label1560 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSaveLoad = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCurrentBE = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.championViewControl = new BECounter.Controls.ChampionViewControl();
            this.panelCountingControl.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelSaveLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCountingControl
            // 
            this.panelCountingControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelCountingControl.Controls.Add(this.tableLayoutPanel);
            this.panelCountingControl.Controls.Add(this.labelScore);
            this.panelCountingControl.Controls.Add(this.labelTotal);
            this.panelCountingControl.Controls.Add(this.panelButtons);
            this.panelCountingControl.Controls.Add(this.labelCurrentBE);
            this.panelCountingControl.Controls.Add(this.numericUpDown);
            this.panelCountingControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCountingControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panelCountingControl.Location = new System.Drawing.Point(467, 0);
            this.panelCountingControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelCountingControl.Name = "panelCountingControl";
            this.panelCountingControl.Padding = new System.Windows.Forms.Padding(10);
            this.panelCountingControl.Size = new System.Drawing.Size(154, 498);
            this.panelCountingControl.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label90, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label270, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label630, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label960, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.label1260, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label1560, 0, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, 157);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(150, 225);
            this.tableLayoutPanel.TabIndex = 26;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Dock = System.Windows.Forms.DockStyle.Left;
            this.label90.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label90.Location = new System.Drawing.Point(3, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(54, 37);
            this.label90.TabIndex = 9;
            this.label90.Text = "0 x 90";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label270
            // 
            this.label270.AutoSize = true;
            this.label270.Dock = System.Windows.Forms.DockStyle.Left;
            this.label270.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label270.Location = new System.Drawing.Point(3, 37);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(64, 37);
            this.label270.TabIndex = 10;
            this.label270.Text = "0 x 270";
            this.label270.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label630
            // 
            this.label630.AutoSize = true;
            this.label630.Dock = System.Windows.Forms.DockStyle.Left;
            this.label630.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label630.Location = new System.Drawing.Point(3, 74);
            this.label630.Name = "label630";
            this.label630.Size = new System.Drawing.Size(64, 37);
            this.label630.TabIndex = 11;
            this.label630.Text = "0 x 630";
            this.label630.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label960
            // 
            this.label960.AutoSize = true;
            this.label960.Dock = System.Windows.Forms.DockStyle.Left;
            this.label960.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label960.Location = new System.Drawing.Point(3, 111);
            this.label960.Name = "label960";
            this.label960.Size = new System.Drawing.Size(64, 37);
            this.label960.TabIndex = 12;
            this.label960.Text = "0 x 960";
            this.label960.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1260
            // 
            this.label1260.AutoSize = true;
            this.label1260.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1260.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1260.Location = new System.Drawing.Point(3, 148);
            this.label1260.Name = "label1260";
            this.label1260.Size = new System.Drawing.Size(74, 37);
            this.label1260.TabIndex = 13;
            this.label1260.Text = "0 x 1260";
            this.label1260.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1560
            // 
            this.label1560.AutoSize = true;
            this.label1560.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1560.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1560.Location = new System.Drawing.Point(3, 185);
            this.label1560.Name = "label1560";
            this.label1560.Size = new System.Drawing.Size(74, 40);
            this.label1560.TabIndex = 14;
            this.label1560.Text = "0 x 1560";
            this.label1560.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelScore.Location = new System.Drawing.Point(57, 118);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(45, 18);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "0 BE";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelTotal.Location = new System.Drawing.Point(7, 118);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 18);
            this.labelTotal.TabIndex = 25;
            this.labelTotal.Text = "Total: ";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.tableLayoutPanelSaveLoad);
            this.panelButtons.Controls.Add(this.buttonReset);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(10, 10);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(134, 87);
            this.panelButtons.TabIndex = 17;
            // 
            // tableLayoutPanelSaveLoad
            // 
            this.tableLayoutPanelSaveLoad.ColumnCount = 3;
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSaveLoad.Controls.Add(this.buttonSave, 0, 1);
            this.tableLayoutPanelSaveLoad.Controls.Add(this.buttonLoad, 2, 1);
            this.tableLayoutPanelSaveLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSaveLoad.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanelSaveLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSaveLoad.Name = "tableLayoutPanelSaveLoad";
            this.tableLayoutPanelSaveLoad.RowCount = 2;
            this.tableLayoutPanelSaveLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelSaveLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSaveLoad.Size = new System.Drawing.Size(134, 52);
            this.tableLayoutPanelSaveLoad.TabIndex = 18;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonSave.Location = new System.Drawing.Point(0, 12);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0, 2, 1, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(61, 36);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AutoSize = true;
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonLoad.Location = new System.Drawing.Point(73, 12);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(1, 2, 0, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(61, 36);
            this.buttonLoad.TabIndex = 18;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonReset.Location = new System.Drawing.Point(0, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(134, 35);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset values";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelCurrentBE
            // 
            this.labelCurrentBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentBE.AutoSize = true;
            this.labelCurrentBE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelCurrentBE.Location = new System.Drawing.Point(7, 440);
            this.labelCurrentBE.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelCurrentBE.Name = "labelCurrentBE";
            this.labelCurrentBE.Size = new System.Drawing.Size(97, 18);
            this.labelCurrentBE.TabIndex = 16;
            this.labelCurrentBE.Text = "Current BE";
            this.labelCurrentBE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.numericUpDown.Location = new System.Drawing.Point(10, 466);
            this.numericUpDown.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(134, 22);
            this.numericUpDown.TabIndex = 15;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.CountingLabelReload);
            // 
            // championViewControl
            // 
            this.championViewControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.championViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.championViewControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.championViewControl.Location = new System.Drawing.Point(0, 0);
            this.championViewControl.Margin = new System.Windows.Forms.Padding(0);
            this.championViewControl.Name = "championViewControl";
            this.championViewControl.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.championViewControl.Size = new System.Drawing.Size(467, 498);
            this.championViewControl.TabIndex = 3;
            // 
            // CountingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.championViewControl);
            this.Controls.Add(this.panelCountingControl);
            this.DoubleBuffered = true;
            this.Name = "CountingControl";
            this.Size = new System.Drawing.Size(621, 498);
            this.panelCountingControl.ResumeLayout(false);
            this.panelCountingControl.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelSaveLoad.ResumeLayout(false);
            this.tableLayoutPanelSaveLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCountingControl;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelCurrentBE;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSaveLoad;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label270;
        private System.Windows.Forms.Label label630;
        private System.Windows.Forms.Label label960;
        private System.Windows.Forms.Label label1260;
        private System.Windows.Forms.Label label1560;
        private ChampionViewControl championViewControl;
    }
}
