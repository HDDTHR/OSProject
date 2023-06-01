using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSProject
{
    internal partial class NumGrid : DataGridView
    {
        public NumGrid() : this(5, 5) { }

        public NumGrid(int width, int height)
        {
            this.AllowUserToAddRows = false;
            this.RowHeadersVisible = true;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            resizeGrid(width, height);

            foreach(DataGridViewRow r in this.Rows)
            {
                foreach(DataGridViewCell c in  r.Cells)
                {
                    c.Value = 0;
                }
            }
        }

        public void resizeGrid(int width, int height)
        {
            int currentWidth = this.Columns.Count;
            int widthChange = width - currentWidth;

            if (widthChange > 0)
            {
                for (int i = currentWidth; i < width; i++)
                {
                    string letter = Convert.ToString(Convert.ToChar(i + 'A'));
                    this.Columns.Add(letter, letter);
                }
            }
            else if (widthChange < 0)
            {
                for (int i = currentWidth - 1; i >= width; i--)
                {
                    this.Columns.RemoveAt(i);
                }
            }

            int currentHeight = this.Rows.Count;
            int heightChange = height - currentHeight;

            if (heightChange > 0)
            {
                for (int i = currentHeight; i < height; i++)
                {
                    string process = "P" + i ;
                    this.Rows.Add();
                    this.Rows[i].HeaderCell.Value = process;
                }
            }
            else if (heightChange < 0)
            {
                for (int i = currentHeight - 1; i >= height; i--)
                {
                    this.Rows.RemoveAt(i);
                }
            }
        }

        public int[,] getGrid()
        {
            int width = this.Columns.Count;
            int height = this.Rows.Count;
            int[,] grid = new int[height,width];

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    grid[j, i] = Convert.ToInt32(this.Rows[j].Cells[i].Value);
                }
            }

            return grid;
        }

        public void setGrid(int[,] grid)
        {
            int width = this.Columns.Count;
            int height = this.Rows.Count;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    this.Rows[j].Cells[i].Value = grid[j, i];
                }
            }
        }
    }
}
