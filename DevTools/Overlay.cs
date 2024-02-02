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

            Parallel.Invoke(
                () => InitSnippetPage(),
                () => InitToolsPage()
            );
            toolBarOverlay.DisplayPage(PageTitle.Snippets);
            this.TransparencyKey = this.BackColor;

            keyboardHook = new KeyboardHook();
            keyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private void InitSnippetPage()
        {
            new[]
            {
                new { Language = Language.CMD, ImageResource = Properties.Resources.CMD },
                new { Language = Language.CSharp, ImageResource = Properties.Resources.CSharp },
                new { Language = Language.HTM_CSS, ImageResource = Properties.Resources.Html },
                new { Language = Language.Javascript, ImageResource = Properties.Resources.Javascript },
                new { Language = Language.Powershell, ImageResource = Properties.Resources.Powershell },
            }
            .Select(snippet => new MenuButton(new LanguageContainer(snippet.Language).CreateMenu()) { BackgroundImage = snippet.ImageResource })
            .ToList()
            .ForEach(button => toolBarOverlay.AddToPage(PageTitle.Snippets, button));
        }

        private void InitToolsPage()
        {
            MenuButton colorPickerButton = new MenuButton();
            colorPickerButton.BackgroundImage = Properties.Resources.palette;
            colorPickerButton.Click += colorPicker_Click;
            toolBarOverlay.AddToPage(PageTitle.Tools, colorPickerButton);
        }
        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Invoke((Action)(() =>{this.Visible = this.Visible ? false : true;}));
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
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    string hexColor = ColorToHex(selectedColor);
                    new ColorDialogForm(hexColor).ShowDialog();
                }
        }


        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
