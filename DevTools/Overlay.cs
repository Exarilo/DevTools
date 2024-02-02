using DevTools.App.CodeSnippets;
using DevTools.App.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTools
{
    public partial class Overlay : Form
    {
        private KeyboardHook keyboardHook;
        private Dictionary<MenuButton, IContextMenu> overlayMenus;

        public Overlay()
        {
            InitializeComponent();
            overlayMenus = new Dictionary<MenuButton, IContextMenu>
            {
                {csharpButton,new LanguageContainer(Language.CSharp)},
                {htmlButton,new LanguageContainer(Language.HTM_CSS)},
                {javascriptButton,new LanguageContainer(Language.Javascript)},
                {powershellButton,new LanguageContainer(Language.Powershell)},
                {pythonButton,new LanguageContainer(Language.Python)},
                {CMDButton,new LanguageContainer(Language.CMD)}
            };

            InitializeOverlayMenusAsync();
            this.TransparencyKey = this.BackColor;

            keyboardHook = new KeyboardHook();
            keyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private async void InitializeOverlayMenusAsync()
        {
            await Task.Run(() => overlayMenus.AsParallel().ForAll(x => x.Key.Menu = x.Value.CreateMenu()));
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Invoke((Action)(() =>
                {
                    if (this.Visible)
                        this.Hide();
                    else
                        this.Show();
                }));
            }
        }
        private void colorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                ShowHelp = true

            })

            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    string hexColor = ColorToHex(selectedColor);

                    ColorDialogForm dialogForm = new ColorDialogForm(hexColor);
                    dialogForm.ShowDialog();
                }
            }
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
