using System.Windows.Forms;

namespace DevTools.App.Common
{
    internal interface IContextMenu
    {
        ContextMenuStrip CreateMenu();
    }
}
