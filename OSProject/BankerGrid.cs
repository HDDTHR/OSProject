using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject
{
    internal partial class BankerGrid : TableLayoutPanel
    {
        private NumGrid allocGrid;
        private Label allocLbl;

        private NumGrid maxGrid;
        private Label maxLbl;

        private NumGrid avaGrid;
        private Label avaLbl;

        public BankerGrid()
        {
            allocGrid = new NumGrid(10, 10);
            allocGrid.Dock = DockStyle.Fill;
            allocLbl = new Label();
            allocLbl.Text = "Allocation";
            allocGrid.ColumnAdded += fillZeroRowsColumns;
            allocGrid.RowsAdded += fillZeroRowsColumns;
            allocGrid.CellValidating += validatePositive;

            maxGrid = new NumGrid(10, 10);
            maxGrid.Dock = DockStyle.Fill;
            maxLbl = new Label();
            maxLbl.Text = "Maximum";
            maxGrid.ColumnAdded += fillZeroRowsColumns;
            maxGrid.RowsAdded += fillZeroRowsColumns;
            maxGrid.CellValidating += validatePositive;

            avaGrid = new NumGrid(10, 1);
            avaGrid.Dock = DockStyle.Fill;
            avaGrid.RowHeadersVisible = false;
            avaLbl = new Label();
            avaLbl.Text = "Available";
            avaGrid.ColumnAdded += fillZeroRowsColumns;
            avaGrid.RowsAdded += fillZeroRowsColumns;
            avaGrid.CellValidating += validatePositive;

            this.Controls.Add(allocLbl, 0, 0);
            this.Controls.Add(allocGrid, 1, 0);

            this.Controls.Add(maxLbl, 0, 1);
            this.Controls.Add(maxGrid, 1, 1);

            this.Controls.Add(avaLbl, 0, 2);
            this.Controls.Add(avaGrid, 1, 2);

            this.AutoSize = true;
        }

        private void fillZeroRowsColumns(object sender, EventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                // Handle rows added event
                if (e is DataGridViewRowsAddedEventArgs rowsAddedEventArgs)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows.Cast<DataGridViewRow>().Skip(rowsAddedEventArgs.RowIndex))
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Value = 0;
                        }
                    }
                }
                // Handle columns added event
                else if (e is DataGridViewColumnEventArgs columnAddedEventArgs)
                {
                    if (columnAddedEventArgs.Column is DataGridViewTextBoxColumn textBoxColumn)
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            textBoxColumn.DefaultCellStyle.NullValue = "0";
                            row.Cells[columnAddedEventArgs.Column.Index].Value = "0";
                        }
                    }
                }
            }
        }

        private void validatePositive(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            bool valid = int.TryParse(e.FormattedValue.ToString(), out int number);
            if(!valid || !(number >= 0))
            {
                e.Cancel = true;
                return;
            }
        }

        public void resizeGrids(int res, int proc)
        {
            allocGrid.resizeGrid(res, proc);
            maxGrid.resizeGrid(res, proc);
            avaGrid.resizeGrid(res, 1);
        }


        public int[,] getAlloc()
        {
            return this.allocGrid.getGrid();
        }

        public int[,] getMax()
        {
            return this.maxGrid.getGrid();
        }

        public int[,] getava()
        {
            return this.avaGrid.getGrid();
        }

        public void setAlloc(int[,] grid)
        {
            this.allocGrid.setGrid(grid);
        }

        public void setMax(int[,] grid)
        {
            this.maxGrid.setGrid(grid);
        }

        public void setAva(int[] arr)
        {
            int[,] grid = new int[1, arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                grid[0, i] = arr[i];
            }
            this.avaGrid.setGrid(grid);
        }
    }
}
