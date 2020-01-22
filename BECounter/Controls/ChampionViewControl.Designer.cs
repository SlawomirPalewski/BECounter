namespace BECounterNew.Controls
{
    partial class ChampionViewControl
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
            this.panelScrollBarOut = new System.Windows.Forms.Panel();
            this.panelScrollBarMid = new System.Windows.Forms.Panel();
            this.panelScrollBarIn = new System.Windows.Forms.Panel();
            this.flowLayoutPanelChampionView = new System.Windows.Forms.FlowLayoutPanel();
            this.panelScrollBarOut.SuspendLayout();
            this.panelScrollBarMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScrollBarOut
            // 
            this.panelScrollBarOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelScrollBarOut.Controls.Add(this.panelScrollBarMid);
            this.panelScrollBarOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelScrollBarOut.Location = new System.Drawing.Point(536, 0);
            this.panelScrollBarOut.Margin = new System.Windows.Forms.Padding(0);
            this.panelScrollBarOut.Name = "panelScrollBarOut";
            this.panelScrollBarOut.Padding = new System.Windows.Forms.Padding(7);
            this.panelScrollBarOut.Size = new System.Drawing.Size(41, 417);
            this.panelScrollBarOut.TabIndex = 0;
            // 
            // panelScrollBarMid
            // 
            this.panelScrollBarMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.panelScrollBarMid.Controls.Add(this.panelScrollBarIn);
            this.panelScrollBarMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScrollBarMid.Location = new System.Drawing.Point(7, 7);
            this.panelScrollBarMid.Margin = new System.Windows.Forms.Padding(7);
            this.panelScrollBarMid.Name = "panelScrollBarMid";
            this.panelScrollBarMid.Padding = new System.Windows.Forms.Padding(3);
            this.panelScrollBarMid.Size = new System.Drawing.Size(27, 403);
            this.panelScrollBarMid.TabIndex = 0;
            // 
            // panelScrollBarIn
            // 
            this.panelScrollBarIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelScrollBarIn.Location = new System.Drawing.Point(6, 6);
            this.panelScrollBarIn.Name = "panelScrollBarIn";
            this.panelScrollBarIn.Size = new System.Drawing.Size(15, 40);
            this.panelScrollBarIn.TabIndex = 0;
            this.panelScrollBarIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelScrollBarIn_MouseDown);
            this.panelScrollBarIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelScrollBarIn_MouseMove);
            this.panelScrollBarIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelScrollBarIn_MouseUp);
            // 
            // flowLayoutPanelChampionView
            // 
            this.flowLayoutPanelChampionView.AutoSize = true;
            this.flowLayoutPanelChampionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChampionView.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelChampionView.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelChampionView.Name = "flowLayoutPanelChampionView";
            this.flowLayoutPanelChampionView.Padding = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.flowLayoutPanelChampionView.Size = new System.Drawing.Size(536, 417);
            this.flowLayoutPanelChampionView.TabIndex = 1;
            this.flowLayoutPanelChampionView.MouseHover += new System.EventHandler(this.FlowLayoutPanelChampionView_MouseHover);
            this.flowLayoutPanelChampionView.Resize += new System.EventHandler(this.FlowLayoutPanelChampionView_Resize);
            // 
            // ChampionViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.flowLayoutPanelChampionView);
            this.Controls.Add(this.panelScrollBarOut);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChampionViewControl";
            this.Size = new System.Drawing.Size(577, 417);
            this.panelScrollBarOut.ResumeLayout(false);
            this.panelScrollBarMid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelScrollBarOut;
        private System.Windows.Forms.Panel panelScrollBarMid;
        private System.Windows.Forms.Panel panelScrollBarIn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChampionView;
    }
}
