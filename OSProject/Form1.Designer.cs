namespace OSProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numProcNud = new NumericUpDown();
            numProcLbl = new Label();
            numResLbl = new Label();
            numResNud = new NumericUpDown();
            instancesLbl = new Label();
            bankerGrid = new BankerGrid();
            numList = new NumList();
            resultGp = new GroupBox();
            deadlockResLbl = new Label();
            safeResLbl = new Label();
            deadlockLbl = new Label();
            safeLbl = new Label();
            TitleLbl = new Label();
            subLbl = new Label();
            testCaseBtn = new Button();
            testCaseFileDialog = new OpenFileDialog();
            runBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numProcNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResNud).BeginInit();
            resultGp.SuspendLayout();
            SuspendLayout();
            // 
            // numProcNud
            // 
            numProcNud.Location = new Point(151, 98);
            numProcNud.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numProcNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numProcNud.Name = "numProcNud";
            numProcNud.Size = new Size(52, 23);
            numProcNud.TabIndex = 0;
            numProcNud.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numProcNud.ValueChanged += numProcNud_ValueChanged;
            // 
            // numProcLbl
            // 
            numProcLbl.AutoSize = true;
            numProcLbl.Location = new Point(23, 100);
            numProcLbl.Name = "numProcLbl";
            numProcLbl.Size = new Size(122, 15);
            numProcLbl.TabIndex = 1;
            numProcLbl.Text = "Number of processes:";
            // 
            // numResLbl
            // 
            numResLbl.AutoSize = true;
            numResLbl.Location = new Point(23, 137);
            numResLbl.Name = "numResLbl";
            numResLbl.Size = new Size(121, 15);
            numResLbl.TabIndex = 3;
            numResLbl.Text = "Number of resources:";
            // 
            // numResNud
            // 
            numResNud.Location = new Point(151, 135);
            numResNud.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numResNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numResNud.Name = "numResNud";
            numResNud.Size = new Size(52, 23);
            numResNud.TabIndex = 2;
            numResNud.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numResNud.ValueChanged += numResNud_ValueChanged;
            // 
            // instancesLbl
            // 
            instancesLbl.AutoSize = true;
            instancesLbl.Location = new Point(23, 173);
            instancesLbl.Name = "instancesLbl";
            instancesLbl.Size = new Size(127, 15);
            instancesLbl.TabIndex = 6;
            instancesLbl.Text = "Instances per resource:";
            instancesLbl.Visible = false;
            // 
            // bankerGrid
            // 
            bankerGrid.AutoSize = true;
            bankerGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bankerGrid.ColumnCount = 2;
            bankerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            bankerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            bankerGrid.Location = new Point(23, 205);
            bankerGrid.Name = "bankerGrid";
            bankerGrid.RowCount = 2;
            bankerGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            bankerGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            bankerGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            bankerGrid.Size = new Size(700, 360);
            bankerGrid.TabIndex = 7;
            // 
            // numList
            // 
            numList.Location = new Point(149, 168);
            numList.Name = "numList";
            numList.Size = new Size(574, 31);
            numList.TabIndex = 8;
            numList.Visible = false;
            // 
            // resultGp
            // 
            resultGp.Controls.Add(deadlockResLbl);
            resultGp.Controls.Add(safeResLbl);
            resultGp.Controls.Add(deadlockLbl);
            resultGp.Controls.Add(safeLbl);
            resultGp.Location = new Point(23, 603);
            resultGp.Name = "resultGp";
            resultGp.Size = new Size(700, 99);
            resultGp.TabIndex = 9;
            resultGp.TabStop = false;
            resultGp.Text = "Result";
            // 
            // deadlockResLbl
            // 
            deadlockResLbl.AutoSize = true;
            deadlockResLbl.Location = new Point(150, 61);
            deadlockResLbl.Name = "deadlockResLbl";
            deadlockResLbl.Size = new Size(0, 15);
            deadlockResLbl.TabIndex = 3;
            // 
            // safeResLbl
            // 
            safeResLbl.AutoSize = true;
            safeResLbl.Location = new Point(165, 31);
            safeResLbl.Name = "safeResLbl";
            safeResLbl.Size = new Size(0, 15);
            safeResLbl.TabIndex = 2;
            // 
            // deadlockLbl
            // 
            deadlockLbl.AutoSize = true;
            deadlockLbl.ForeColor = SystemColors.ControlDarkDark;
            deadlockLbl.Location = new Point(6, 61);
            deadlockLbl.Name = "deadlockLbl";
            deadlockLbl.Size = new Size(138, 15);
            deadlockLbl.TabIndex = 1;
            deadlockLbl.Text = "Are there any deadlocks?";
            deadlockLbl.Visible = false;
            // 
            // safeLbl
            // 
            safeLbl.AutoSize = true;
            safeLbl.ForeColor = SystemColors.ControlDarkDark;
            safeLbl.Location = new Point(6, 30);
            safeLbl.Name = "safeLbl";
            safeLbl.Size = new Size(154, 15);
            safeLbl.TabIndex = 0;
            safeLbl.Text = "Is the system in a safe state?";
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Calibri Light", 25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLbl.Location = new Point(235, 18);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(296, 41);
            TitleLbl.TabIndex = 10;
            TitleLbl.Text = "Banker's Algorithm";
            // 
            // subLbl
            // 
            subLbl.AutoSize = true;
            subLbl.Location = new Point(244, 59);
            subLbl.Name = "subLbl";
            subLbl.Size = new Size(62, 15);
            subLbl.TabIndex = 11;
            subLbl.Text = "OS Project";
            // 
            // testCaseBtn
            // 
            testCaseBtn.Location = new Point(626, 718);
            testCaseBtn.Name = "testCaseBtn";
            testCaseBtn.Size = new Size(97, 23);
            testCaseBtn.TabIndex = 12;
            testCaseBtn.Text = "Load Test Case";
            testCaseBtn.UseVisualStyleBackColor = true;
            testCaseBtn.Click += testButton_Click;
            // 
            // testCaseFileDialog
            // 
            testCaseFileDialog.FileName = "openFileDialog1";
            testCaseFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            testCaseFileDialog.ReadOnlyChecked = true;
            testCaseFileDialog.RestoreDirectory = true;
            // 
            // runBtn
            // 
            runBtn.Location = new Point(23, 718);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(75, 23);
            runBtn.TabIndex = 13;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 765);
            Controls.Add(runBtn);
            Controls.Add(testCaseBtn);
            Controls.Add(subLbl);
            Controls.Add(TitleLbl);
            Controls.Add(resultGp);
            Controls.Add(numList);
            Controls.Add(bankerGrid);
            Controls.Add(instancesLbl);
            Controls.Add(numResLbl);
            Controls.Add(numResNud);
            Controls.Add(numProcLbl);
            Controls.Add(numProcNud);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Banker's Algorithm";
            ((System.ComponentModel.ISupportInitialize)numProcNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResNud).EndInit();
            resultGp.ResumeLayout(false);
            resultGp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numProcNud;
        private Label numProcLbl;
        private Label numResLbl;
        private NumericUpDown numResNud;
        private Label instancesLbl;
        private BankerGrid bankerGrid;
        private NumList numList;
        private GroupBox resultGp;
        private Label deadlockLbl;
        private Label safeLbl;
        private Label deadlockResLbl;
        private Label safeResLbl;
        private Label TitleLbl;
        private Label subLbl;
        private Button testCaseBtn;
        private OpenFileDialog testCaseFileDialog;
        private Button runBtn;
    }
}