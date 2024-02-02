namespace DevTools
{
    partial class Overlay
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
            this.toolBarOverlay = new DevTools.ToolBar();
            this.SuspendLayout();
            // 
            // toolBarOverlay
            // 
            this.toolBarOverlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolBarOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBarOverlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarOverlay.Location = new System.Drawing.Point(0, 0);
            this.toolBarOverlay.Name = "toolBarOverlay";
            this.toolBarOverlay.Size = new System.Drawing.Size(800, 31);
            this.toolBarOverlay.TabIndex = 0;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolBarOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ToolBar toolBarOverlay;
    }
}

