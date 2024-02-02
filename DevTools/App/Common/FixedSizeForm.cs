using System.Windows.Forms;

namespace DevTools.App.Common
{
    public class FixedSizeForm : Form
    {
        public FixedSizeForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MAXIMIZE = 0xF030;

            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_MAXIMIZE)
            {
                return;
            }

            base.WndProc(ref m);
        }
    }
}
