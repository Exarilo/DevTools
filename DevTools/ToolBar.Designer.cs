namespace DevTools
{
    partial class ToolBar
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
            this.PanelRight = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.nudPageSelector = new System.Windows.Forms.NumericUpDown();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRight
            // 
            this.PanelRight.Controls.Add(this.lbTitle);
            this.PanelRight.Controls.Add(this.nudPageSelector);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(695, 0);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(103, 31);
            this.PanelRight.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(28, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(57, 21);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "label1";
            // 
            // nudPageSelector
            // 
            this.nudPageSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudPageSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPageSelector.Location = new System.Drawing.Point(85, 0);
            this.nudPageSelector.Name = "nudPageSelector";
            this.nudPageSelector.Size = new System.Drawing.Size(18, 31);
            this.nudPageSelector.TabIndex = 6;
            this.nudPageSelector.ValueChanged += new System.EventHandler(this.nudPageSelector_ValueChanged);
            // 
            // PanelLeft
            // 
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(695, 31);
            this.PanelLeft.TabIndex = 5;
            this.PanelLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelLeft_MouseClick);
            // 
            // ToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelRight);
            this.Name = "ToolBar";
            this.Size = new System.Drawing.Size(798, 31);
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.NumericUpDown nudPageSelector;
    }
}
