namespace DevTools.App.CSharp
{
    partial class CodeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeViewer));
            this.TextPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCopy = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextPanel
            // 
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(0, 51);
            this.TextPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(760, 608);
            this.TextPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCopy);
            this.panel1.Controls.Add(this.lbFileName);
            this.panel1.Controls.Add(this.btCopy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 51);
            this.panel1.TabIndex = 4;
            // 
            // lbCopy
            // 
            this.lbCopy.AutoSize = true;
            this.lbCopy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopy.Location = new System.Drawing.Point(652, 14);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(58, 18);
            this.lbCopy.TabIndex = 1;
            this.lbCopy.Text = "Copié !";
            this.lbCopy.Visible = false;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbFileName.Location = new System.Drawing.Point(12, 9);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(52, 30);
            this.lbFileName.TabIndex = 2;
            this.lbFileName.Text = "Title";
            // 
            // btCopy
            // 
            this.btCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopy.BackColor = System.Drawing.Color.Transparent;
            this.btCopy.BackgroundImage = global::DevTools.Properties.Resources.btCopy;
            this.btCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCopy.Location = new System.Drawing.Point(716, 6);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(32, 33);
            this.btCopy.TabIndex = 0;
            this.btCopy.UseVisualStyleBackColor = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // CodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 659);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeViewer";
            this.Text = "CodeViewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCopy;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Button btCopy;
    }
}