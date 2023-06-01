
using System.Windows.Forms;
using System.Text.Json;

namespace OSProject
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numProcNud_ValueChanged(object sender, EventArgs e)
        {
            updateGridStructure();
        }

        private void numResNud_ValueChanged(object sender, EventArgs e)
        {
            //this.numList.resizeList((int)this.numResNud.Value);
            updateGridStructure();
        }

        private void updateGridStructure()
        {
            this.bankerGrid.resizeGrids((int)numResNud.Value, (int)numProcNud.Value);
        }

        private void bankersAlgorithm()
        {
            int proc = (int)numProcNud.Value;
            int res = (int)numResNud.Value;

            int[,] alloc = this.bankerGrid.getAlloc();
            int[,] max = this.bankerGrid.getMax();
            int[,] ava = this.bankerGrid.getava();

            int[] work = new int[res];
            bool[] finish = new bool[proc];
            int[,] need = new int[proc, res];
            string sequence = String.Empty;

            //Initialize work to available
            for (int i = 0; i < res; i++)
            {
                work[i] = ava[0, i];
            }

            //Initialize need to max - allocation
            for (int i = 0; i < proc; i++)
            {
                for (int j = 0; j < res; j++)
                {
                    need[i, j] = max[i, j] - alloc[i, j];
                }
            }

            //Step 2
            int ittr = 0;
            while (ittr < proc)
            {
                bool found = false;
                for (int i = 0; i < proc; i++)
                {
                    if (!finish[i])
                    {
                        int j;
                        for (j = 0; j < res; j++)
                        {
                            if (need[i, j] > work[j])
                            {
                                break;
                            }
                        }
                        //Step 3
                        if (j == res)
                        {
                            for (int k = 0; k < res; k++)
                            {
                                work[k] += alloc[i, k];
                            }
                            finish[i] = true;
                            sequence += "P" + i.ToString() + " ";
                            ittr++;
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    break;
                }
            }

            //Step 4
            bool safeState = true;
            for (int i = 0; i < proc; i++)
            {
                if (!finish[i])
                {
                    safeState = false;
                    break;
                }
            }

            this.safeResLbl.Text = (safeState ? "Yes < " : "No < ") + sequence + ">";
            this.safeResLbl.ForeColor = safeState ? Color.Green : Color.Red;

            //this.deadlockResLbl.Text = safeState ? "No" : "Yes";
            //this.deadlockResLbl.ForeColor = safeState ? Color.Green : Color.Red;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string fileData = String.Empty;

            if (testCaseFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream file = testCaseFileDialog.OpenFile();

                using (StreamReader sr = new StreamReader(file))
                {
                    fileData = sr.ReadToEnd();
                }
            }
            else
            {
                return;
            }

            try
            {
                JsonDocument fileJson = JsonDocument.Parse(fileData);
                JsonElement root = fileJson.RootElement;

                int proc = root.GetProperty("Processes").GetInt32();
                int res = root.GetProperty("Resources").GetInt32();

                JsonElement alloc = root.GetProperty("Allocation");
                JsonElement max = root.GetProperty("Maximum");
                JsonElement ava = root.GetProperty("Available");

                int[,] allocGrid = new int[proc, res];
                int[,] maxGrid = new int[proc, res];
                int[] avaList = new int[res];

                //Allocation validation
                if (alloc.GetArrayLength() != proc)
                {
                    throw new Exception();
                }
                for (int i = 0; i < proc; i++)
                {
                    if (alloc[i].GetArrayLength() != res)
                    {
                        throw new Exception();
                    }
                    for (int j = 0; j < res; j++)
                    {
                        int value = alloc[i][j].GetInt32();
                        if (value < 0)
                        {
                            throw new Exception();
                        }
                        allocGrid[i, j] = value;
                    }
                }

                //Maximum validation
                if (max.GetArrayLength() != proc)
                {
                    throw new Exception();
                }
                for (int i = 0; i < proc; i++)
                {
                    if (max[i].GetArrayLength() != res)
                    {
                        throw new Exception();
                    }
                    for (int j = 0; j < res; j++)
                    {
                        int value = max[i][j].GetInt32();
                        if (value < 0)
                        {
                            throw new Exception();
                        }
                        maxGrid[i, j] = value;
                    }
                }

                //Available Validation
                if (ava.GetArrayLength() != res)
                {
                    throw new Exception();
                }
                for (int i = 0; i < res; i++)
                {
                    int value = ava[i].GetInt32();
                    if (value < 0)
                    {
                        throw new Exception();
                    }
                    avaList[i] = value;
                }

                //Set values in form
                this.numProcNud.ValueChanged -= numProcNud_ValueChanged;
                this.numResNud.ValueChanged -= numResNud_ValueChanged;

                this.numProcNud.Value = proc;
                this.numResNud.Value = res;

                this.numProcNud.ValueChanged += numProcNud_ValueChanged;
                this.numResNud.ValueChanged += numResNud_ValueChanged;
                updateGridStructure();
                this.bankerGrid.setAlloc(allocGrid);
                this.bankerGrid.setMax(maxGrid);
                this.bankerGrid.setAva(avaList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid JSON file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            bankersAlgorithm();
        }
    }
}