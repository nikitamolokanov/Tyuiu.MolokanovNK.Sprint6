
namespace Tyuiu.MolokanovNK.Sprint6.Task2.V27
{
    partial class FormMain_MNK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxStopStep_MNK = new TextBox();
            textBoxStartStep_MNK = new TextBox();
            textStop_MNK = new TextBox();
            textStart_MNK = new TextBox();
            buttonDone_MNK = new Button();
            buttonHelp_MNK = new Button();
            groupTask_MNK = new GroupBox();
            textCondition_MNK = new TextBox();
            groupInput_MNK = new GroupBox();
            groupResult_MNK = new GroupBox();
            dataGridViewFunction_MNK = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Columns = new DataGridViewTextBoxColumn();
            chartFunction_MNK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupTask_MNK.SuspendLayout();
            groupInput_MNK.SuspendLayout();
            groupResult_MNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MNK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MNK).BeginInit();
            SuspendLayout();
            // 
            // textBoxStopStep_MNK
            // 
            textBoxStopStep_MNK.Location = new Point(146, 71);
            textBoxStopStep_MNK.Name = "textBoxStopStep_MNK";
            textBoxStopStep_MNK.Size = new Size(121, 23);
            textBoxStopStep_MNK.TabIndex = 1;
            textBoxStopStep_MNK.TextChanged += textBoxStopStep_MNK_TextChanged;
            // 
            // textBoxStartStep_MNK
            // 
            textBoxStartStep_MNK.Location = new Point(6, 71);
            textBoxStartStep_MNK.Name = "textBoxStartStep_MNK";
            textBoxStartStep_MNK.Size = new Size(111, 23);
            textBoxStartStep_MNK.TabIndex = 2;
            // 
            // textStop_MNK
            // 
            textStop_MNK.Location = new Point(146, 42);
            textStop_MNK.Name = "textStop_MNK";
            textStop_MNK.Size = new Size(121, 23);
            textStop_MNK.TabIndex = 3;
            textStop_MNK.Text = "Конец шага";
            // 
            // textStart_MNK
            // 
            textStart_MNK.Location = new Point(6, 42);
            textStart_MNK.Name = "textStart_MNK";
            textStart_MNK.Size = new Size(111, 23);
            textStart_MNK.TabIndex = 4;
            textStart_MNK.Text = "Старт шага";
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.BackColor = Color.Silver;
            buttonDone_MNK.Location = new Point(372, 344);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(152, 90);
            buttonDone_MNK.TabIndex = 5;
            buttonDone_MNK.Text = "Выполнить";
            buttonDone_MNK.UseVisualStyleBackColor = false;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            buttonDone_MNK.KeyPress += buttonDone_MNK_KeyPress;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.BackColor = Color.Gray;
            buttonHelp_MNK.Location = new Point(291, 344);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(75, 90);
            buttonHelp_MNK.TabIndex = 6;
            buttonHelp_MNK.Text = "Справка";
            buttonHelp_MNK.UseVisualStyleBackColor = false;
            buttonHelp_MNK.Click += buttonHelp_MNK_Click;
            // 
            // groupTask_MNK
            // 
            groupTask_MNK.Controls.Add(textCondition_MNK);
            groupTask_MNK.Location = new Point(0, 0);
            groupTask_MNK.Name = "groupTask_MNK";
            groupTask_MNK.Size = new Size(524, 328);
            groupTask_MNK.TabIndex = 7;
            groupTask_MNK.TabStop = false;
            groupTask_MNK.Text = "Условие";
            // 
            // textCondition_MNK
            // 
            textCondition_MNK.Location = new Point(3, 19);
            textCondition_MNK.Multiline = true;
            textCondition_MNK.Name = "textCondition_MNK";
            textCondition_MNK.Size = new Size(440, 94);
            textCondition_MNK.TabIndex = 0;
            textCondition_MNK.Text = "Протабулировать функцию sin(x) на заданном диапазоне\r\nРезультат вывести в DataGrivView и построить график функций\r\n";
            textCondition_MNK.TextChanged += textCondition_MNK_TextChanged;
            // 
            // groupInput_MNK
            // 
            groupInput_MNK.Controls.Add(textBoxStartStep_MNK);
            groupInput_MNK.Controls.Add(textBoxStopStep_MNK);
            groupInput_MNK.Controls.Add(textStart_MNK);
            groupInput_MNK.Controls.Add(textStop_MNK);
            groupInput_MNK.Location = new Point(12, 334);
            groupInput_MNK.Name = "groupInput_MNK";
            groupInput_MNK.Size = new Size(273, 100);
            groupInput_MNK.TabIndex = 0;
            groupInput_MNK.TabStop = false;
            groupInput_MNK.Text = "Ввод данных";
            // 
            // groupResult_MNK
            // 
            groupResult_MNK.Controls.Add(dataGridViewFunction_MNK);
            groupResult_MNK.Location = new Point(530, 0);
            groupResult_MNK.Name = "groupResult_MNK";
            groupResult_MNK.Size = new Size(463, 434);
            groupResult_MNK.TabIndex = 0;
            groupResult_MNK.TabStop = false;
            groupResult_MNK.Text = "Вывод данных";
            // 
            // dataGridViewFunction_MNK
            // 
            dataGridViewFunction_MNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MNK.Columns.AddRange(new DataGridViewColumn[] { X, Columns });
            dataGridViewFunction_MNK.Location = new Point(6, 19);
            dataGridViewFunction_MNK.Name = "dataGridViewFunction_MNK";
            dataGridViewFunction_MNK.RowHeadersVisible = false;
            dataGridViewFunction_MNK.Size = new Size(103, 409);
            dataGridViewFunction_MNK.TabIndex = 9;
            dataGridViewFunction_MNK.CellContentClick += dataGridViewFunction_MNK_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Columns
            // 
            Columns.HeaderText = "F(X)";
            Columns.Name = "Columns";
            Columns.Width = 50;
            // 
            // chartFunction_MNK
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MNK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_MNK.Legends.Add(legend1);
            chartFunction_MNK.Location = new Point(645, 19);
            chartFunction_MNK.Name = "chartFunction_MNK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MNK.Series.Add(series1);
            chartFunction_MNK.Size = new Size(567, 409);
            chartFunction_MNK.TabIndex = 8;
            chartFunction_MNK.Text = "chart1";
            chartFunction_MNK.Click += chart1_Click;
            // 
            // FormMain_MNK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 450);
            Controls.Add(groupInput_MNK);
            Controls.Add(chartFunction_MNK);
            Controls.Add(groupResult_MNK);
            Controls.Add(groupTask_MNK);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(buttonDone_MNK);
            Name = "FormMain_MNK";
            Text = "Спринт 6 | Таск 2 | Вариант 6 | Молоканов Н.К.";
            Load += Form1_Load;
            groupTask_MNK.ResumeLayout(false);
            groupTask_MNK.PerformLayout();
            groupInput_MNK.ResumeLayout(false);
            groupInput_MNK.PerformLayout();
            groupResult_MNK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MNK).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MNK).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TextBox textBoxStopStep_MNK;
        private TextBox textBoxStartStep_MNK;
        private TextBox textStop_MNK;
        private TextBox textStart_MNK;
        private Button buttonDone_MNK;
        private Button buttonHelp_MNK;
        private GroupBox groupTask_MNK;
        private GroupBox groupInput_MNK;
        private GroupBox groupResult_MNK;
        private TextBox textCondition_MNK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MNK;
        private DataGridView dataGridViewFunction_MNK;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Columns;
    }
}
