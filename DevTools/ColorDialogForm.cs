using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevTools
{
    public class ColorDialogForm : Form
    {
        private TextBox hexColorTextBox;
        private Button copyButton;

        public ColorDialogForm(string hexColor)
        {
            ShowIcon = false;
            hexColorTextBox = new TextBox
            {
                Text = hexColor,
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true
            };

            copyButton = new Button
            {
                Text = "Copier",
                Dock = DockStyle.Bottom
            };
            copyButton.Click += CopyButton_Click;

            Controls.Add(hexColorTextBox);
            Controls.Add(copyButton);
            Size = new Size(150, 100);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hexColorTextBox.Text);
        }
    }
}
