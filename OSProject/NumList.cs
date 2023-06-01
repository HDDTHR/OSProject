using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSProject
{
    internal partial class NumList : FlowLayoutPanel
    {
        public NumList() : this(10) { }

        public NumList(int width)
        {
            resizeList(width);
        }

        public void resizeList(int width)
        {
            int currentWidth = this.Controls.Count;
            int widthChange = width - currentWidth;

            if (widthChange > 0)
            {
                for (int i = currentWidth; i < width; i++)
                {
                    NumericUpDown numControl = new NumericUpDown();
                    numControl.Width = 50;
                    numControl.Minimum = 1;
                    numControl.Increment = 1;
                    this.Controls.Add(numControl);
                }
            }
            
            else if (widthChange < 0)
            {
                for (int i = currentWidth - 1; i >= width; i--)
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
        }
    }
}
