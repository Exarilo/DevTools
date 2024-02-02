using System.ComponentModel;
using System.Windows.Forms;

namespace DevTools.App.Common
{
    public class MenuButton : Button
    {
        [DefaultValue(null), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ContextMenuStrip Menu { get; set; }

        [DefaultValue(20), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SplitWidth { get; set; }
        public MenuButton()
        {
            SplitWidth = 20;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public MenuButton(ContextMenuStrip contextMenuStrip)
        {
            SplitWidth = 20;
            this.Menu = contextMenuStrip;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            // Figure out if the button click was on the button itself or the menu split
            if (Menu != null &&
                mevent.Button == MouseButtons.Left)
            {
                Menu.Show(this, 0, this.Height);    // Shows menu under button
                                                    //Menu.Show(this, mevent.Location); // Shows menu at click location
            }
            else
            {
                base.OnMouseDown(mevent);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }
    }
}
