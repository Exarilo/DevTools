using DevTools.App.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevTools
{
    public partial class ToolBar : UserControl
    {
        private ContextMenuStrip contextMenu;
        private List<Page> pageList { get; set; } = new List<Page>();
        private int currentPageIndex { get; set; } = 0;
 
        public ToolBar()
        {
            InitializeComponent();
            var enumValues = Enum.GetValues(typeof(PageTitle)).Cast<PageTitle>();
            nudPageSelector.Minimum = -1;
            nudPageSelector.Maximum = enumValues.Count(); 
            enumValues.ToList().ForEach(x => pageList.Add(new Page(x.ToString())));
            PanelLeft.MouseWheel += PanelLeft_MouseWheel;
            contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Settings", null, Settings_Click);
            PanelLeft.MouseClick += PanelLeft_MouseClick;
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void PanelLeft_MouseWheel(object sender, MouseEventArgs e)
        {
            nudPageSelector.Value += Math.Sign(e.Delta);
        }
        public void AddToPage(PageTitle pageTitle,Button button)
        {
            button.Dock= DockStyle.Left;
            button.Size = new Size(33, 31);
            pageList[(int)pageTitle].Buttons.Add(button);
        }
        public void DisplayPage(PageTitle pageTitle)
        {
            int pageIndex = (int)pageTitle;
            this.PanelLeft.Controls.Clear();
            this.lbTitle.Text = pageList[pageIndex].Title;
            this.lbTitle.Refresh();
            pageList[pageIndex].Buttons.ForEach(x=>this.PanelLeft.Controls.Add(x));
        }

        private void nudPageSelector_ValueChanged(object sender, EventArgs e)
        {
            decimal newValue = nudPageSelector.Value;
            if (newValue < 0)
                newValue = pageList.Count()-1;
            if(newValue == pageList.Count())
                newValue = 0;
            this.nudPageSelector.Value= newValue;
            currentPageIndex = (int)newValue;
            DisplayPage((PageTitle)currentPageIndex);
        }

        private void PanelLeft_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(PanelLeft, e.Location);
            }
        }
    }
    public enum PageTitle
    {
        Snippets,
        Tools
    }
    public class Page
    {
        public List<Button> Buttons { get; set; } = new List<Button>();
        public string Title { get; set; }   
        public Page(string title)
        {
            this.Title = title;
        }
    }
 }
