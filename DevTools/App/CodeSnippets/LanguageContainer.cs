using DevTools.App.Common;
using DevTools.App.CSharp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DevTools.App.CodeSnippets
{
    internal class LanguageContainer : IContextMenu
    {
        private SnippetManager snippetManager;
        private Language language;

        public LanguageContainer(Language language)
        {
            this.language = language;
        }

        public ContextMenuStrip CreateMenu()
        {
            snippetManager = SnippetManager.Instance;

            ContextMenuStrip menuStrip = new ContextMenuStrip();
            snippetManager.GetSnippetItems(language).ForEach(x => RecursiveAddItems(x, menuStrip.Items));
            return menuStrip;
        }

        private void RecursiveAddItems(CodeSnippet item, ToolStripItemCollection items)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Name);
            items.Add(menuItem);

            if (item.Children?.Count() == 0)
            {
                menuItem.Tag = item;
                menuItem.Click += LastLevelItemClick;
            }
            else
            {
                foreach (var child in item.Children)
                {
                    RecursiveAddItems(child, menuItem.DropDownItems);
                }
            }
        }

        private void LastLevelItemClick(object sender, EventArgs e)
        {
            var selectedItem = (sender as ToolStripMenuItem).Tag;
            if (selectedItem != null)
            {
                CodeViewer codeViewer = new CodeViewer(selectedItem as CodeSnippet);
                codeViewer.Show();
            }
        }
    }
}
