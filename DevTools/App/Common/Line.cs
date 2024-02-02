using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevTools.App.Common
{
    public enum LineOrientation
    {
        Vertical,
        Horizontal
    }

    public class Line : Control
    {
        private LineOrientation orientation;

        public LineOrientation Orientation
        {
            get { return orientation; }
            set
            {
                orientation = value;
                UpdateLineAppearance();
            }
        }

        public Line()
        {
            this.AutoSize = false;
            this.BackColor = Color.Black;
            this.Orientation = LineOrientation.Horizontal;
            UpdateLineAppearance();
            this.ParentChanged += Line_ParentChanged;
        }

        private void Line_ParentChanged(object sender, EventArgs e)
        {
            UpdateLineAppearance();
        }

        private void UpdateLineAppearance()
        {
            if (orientation == LineOrientation.Horizontal)
            {
                this.Width = this.Parent?.Width ?? 500;
                this.Height = 1;
            }
            else if (orientation == LineOrientation.Vertical)
            {
                this.Width = 1;
                this.Height = this.Parent?.Height ?? 500;
            }
        }

    }
}
