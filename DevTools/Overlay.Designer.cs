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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.menuOverlay = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.Button();
            this.line1 = new DevTools.App.Common.Line();
            this.CMDButton = new DevTools.App.Common.MenuButton();
            this.pythonButton = new DevTools.App.Common.MenuButton();
            this.powershellButton = new DevTools.App.Common.MenuButton();
            this.javascriptButton = new DevTools.App.Common.MenuButton();
            this.htmlButton = new DevTools.App.Common.MenuButton();
            this.csharpButton = new DevTools.App.Common.MenuButton();
            this.menuOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOverlay
            // 
            this.menuOverlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuOverlay.Controls.Add(this.colorPicker);
            this.menuOverlay.Controls.Add(this.line1);
            this.menuOverlay.Controls.Add(this.CMDButton);
            this.menuOverlay.Controls.Add(this.pythonButton);
            this.menuOverlay.Controls.Add(this.powershellButton);
            this.menuOverlay.Controls.Add(this.javascriptButton);
            this.menuOverlay.Controls.Add(this.htmlButton);
            this.menuOverlay.Controls.Add(this.csharpButton);
            this.menuOverlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuOverlay.Location = new System.Drawing.Point(0, 0);
            this.menuOverlay.Name = "menuOverlay";
            this.menuOverlay.Size = new System.Drawing.Size(800, 33);
            this.menuOverlay.TabIndex = 1;
            // 
            // colorPicker
            // 
            this.colorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorPicker.BackgroundImage")));
            this.colorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorPicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorPicker.Location = new System.Drawing.Point(199, 0);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(33, 31);
            this.colorPicker.TabIndex = 8;
            this.colorPicker.UseVisualStyleBackColor = true;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Black;
            this.line1.Dock = System.Windows.Forms.DockStyle.Left;
            this.line1.Location = new System.Drawing.Point(198, 0);
            this.line1.Name = "line1";
            this.line1.Orientation = DevTools.App.Common.LineOrientation.Vertical;
            this.line1.Size = new System.Drawing.Size(1, 31);
            this.line1.TabIndex = 7;
            this.line1.Text = "line1";
            // 
            // CMDButton
            // 
            this.CMDButton.BackgroundImage = global::DevTools.Properties.Resources.CMD;
            this.CMDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMDButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CMDButton.Location = new System.Drawing.Point(165, 0);
            this.CMDButton.Name = "CMDButton";
            this.CMDButton.Size = new System.Drawing.Size(33, 31);
            this.CMDButton.TabIndex = 6;
            this.CMDButton.UseVisualStyleBackColor = true;
            // 
            // pythonButton
            // 
            this.pythonButton.BackgroundImage = global::DevTools.Properties.Resources.Python;
            this.pythonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pythonButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pythonButton.Location = new System.Drawing.Point(132, 0);
            this.pythonButton.Name = "pythonButton";
            this.pythonButton.Size = new System.Drawing.Size(33, 31);
            this.pythonButton.TabIndex = 5;
            this.pythonButton.UseVisualStyleBackColor = true;
            // 
            // powershellButton
            // 
            this.powershellButton.BackgroundImage = global::DevTools.Properties.Resources.Powershell;
            this.powershellButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.powershellButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.powershellButton.Location = new System.Drawing.Point(99, 0);
            this.powershellButton.Name = "powershellButton";
            this.powershellButton.Size = new System.Drawing.Size(33, 31);
            this.powershellButton.TabIndex = 4;
            this.powershellButton.UseVisualStyleBackColor = true;
            // 
            // javascriptButton
            // 
            this.javascriptButton.BackgroundImage = global::DevTools.Properties.Resources.Javascript;
            this.javascriptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.javascriptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.javascriptButton.Location = new System.Drawing.Point(66, 0);
            this.javascriptButton.Name = "javascriptButton";
            this.javascriptButton.Size = new System.Drawing.Size(33, 31);
            this.javascriptButton.TabIndex = 3;
            this.javascriptButton.UseVisualStyleBackColor = true;
            // 
            // htmlButton
            // 
            this.htmlButton.BackgroundImage = global::DevTools.Properties.Resources.Html;
            this.htmlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.htmlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.htmlButton.Location = new System.Drawing.Point(33, 0);
            this.htmlButton.Name = "htmlButton";
            this.htmlButton.Size = new System.Drawing.Size(33, 31);
            this.htmlButton.TabIndex = 2;
            this.htmlButton.UseVisualStyleBackColor = true;
            // 
            // csharpButton
            // 
            this.csharpButton.BackgroundImage = global::DevTools.Properties.Resources.CSharp;
            this.csharpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csharpButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.csharpButton.Location = new System.Drawing.Point(0, 0);
            this.csharpButton.Name = "csharpButton";
            this.csharpButton.Size = new System.Drawing.Size(33, 31);
            this.csharpButton.TabIndex = 1;
            this.csharpButton.UseVisualStyleBackColor = true;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuOverlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuOverlay;
        private App.Common.MenuButton csharpButton;
        private App.Common.MenuButton htmlButton;
        private App.Common.MenuButton javascriptButton;
        private App.Common.MenuButton powershellButton;
        private App.Common.MenuButton pythonButton;
        private App.Common.MenuButton CMDButton;
        private App.Common.Line line1;
        private System.Windows.Forms.Button colorPicker;
    }
}

