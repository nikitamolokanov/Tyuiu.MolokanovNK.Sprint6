
namespace Tyuiu.MolokanovNK.Sprint6.Task5.V15
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartGraph_MNK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupTask_MNK = new GroupBox();
            textBoxTask_MNK = new TextBox();
            dataGridViewResult_MNK = new DataGridView();
            buttonDone_MNK = new Button();
            buttonOpenFile_MNK = new Button();
            buttonHelp_MNK = new Button();
            groupBoxResult_MNK = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chartGraph_MNK).BeginInit();
            groupTask_MNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MNK).BeginInit();
            groupBoxResult_MNK.SuspendLayout();
            SuspendLayout();
            // 
            // chartGraph_MNK
            // 
            chartArea1.Name = "ChartArea1";
            chartGraph_MNK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGraph_MNK.Legends.Add(legend1);
            chartGraph_MNK.Location = new Point(155, 87);
            chartGraph_MNK.Name = "chartGraph_MNK";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraph_MNK.Series.Add(series1);
            chartGraph_MNK.Size = new Size(633, 351);
            chartGraph_MNK.TabIndex = 0;
            chartGraph_MNK.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "Sin(X)";
            chartGraph_MNK.Titles.Add(title1);
            // 
            // groupTask_MNK
            // 
            groupTask_MNK.Controls.Add(textBoxTask_MNK);
            groupTask_MNK.Location = new Point(12, 12);
            groupTask_MNK.Name = "groupTask_MNK";
            groupTask_MNK.Size = new Size(458, 69);
            groupTask_MNK.TabIndex = 1;
            groupTask_MNK.TabStop = false;
            groupTask_MNK.Text = "Условие";
            // 
            // textBoxTask_MNK
            // 
            textBoxTask_MNK.Location = new Point(6, 22);
            textBoxTask_MNK.Multiline = true;
            textBoxTask_MNK.Name = "textBoxTask_MNK";
            textBoxTask_MNK.ReadOnly = true;
            textBoxTask_MNK.Size = new Size(446, 41);
            textBoxTask_MNK.TabIndex = 7;
            // 
            // dataGridViewResult_MNK
            // 
            dataGridViewResult_MNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MNK.Location = new Point(6, 22);
            dataGridViewResult_MNK.Name = "dataGridViewResult_MNK";
            dataGridViewResult_MNK.Size = new Size(125, 323);
            dataGridViewResult_MNK.TabIndex = 2;
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.Location = new Point(476, 22);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(94, 59);
            buttonDone_MNK.TabIndex = 3;
            buttonDone_MNK.Text = "Выполнить";
            buttonDone_MNK.UseVisualStyleBackColor = true;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            // 
            // buttonOpenFile_MNK
            // 
            buttonOpenFile_MNK.Location = new Point(576, 22);
            buttonOpenFile_MNK.Name = "buttonOpenFile_MNK";
            buttonOpenFile_MNK.Size = new Size(103, 59);
            buttonOpenFile_MNK.TabIndex = 4;
            buttonOpenFile_MNK.Text = "Открыть файл";
            buttonOpenFile_MNK.UseVisualStyleBackColor = true;
            buttonOpenFile_MNK.Click += buttonOpenFile_MNK_Click;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.Location = new Point(685, 22);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(103, 59);
            buttonHelp_MNK.TabIndex = 5;
            buttonHelp_MNK.Text = "Справка";
            buttonHelp_MNK.UseVisualStyleBackColor = true;
            buttonHelp_MNK.Click += buttonHelp_MNK_Click;
            // 
            // groupBoxResult_MNK
            // 
            groupBoxResult_MNK.Controls.Add(dataGridViewResult_MNK);
            groupBoxResult_MNK.Location = new Point(12, 87);
            groupBoxResult_MNK.Name = "groupBoxResult_MNK";
            groupBoxResult_MNK.Size = new Size(137, 351);
            groupBoxResult_MNK.TabIndex = 6;
            groupBoxResult_MNK.TabStop = false;
            groupBoxResult_MNK.Text = "Вывод данных";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(textBox1);
            Controls.Add(groupBoxResult_MNK);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(buttonOpenFile_MNK);
            Controls.Add(buttonDone_MNK);
            Controls.Add(groupTask_MNK);
            Controls.Add(chartGraph_MNK);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Молоканов Н.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chartGraph_MNK).EndInit();
            groupTask_MNK.ResumeLayout(false);
            groupTask_MNK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MNK).EndInit();
            groupBoxResult_MNK.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_MNK;
        private GroupBox groupTask_MNK;
        private TextBox textBoxTask_MNK;
        private DataGridView dataGridViewResult_MNK;
        private Button buttonDone_MNK;
        private Button buttonOpenFile_MNK;
        private Button buttonHelp_MNK;
        private GroupBox groupBoxResult_MNK;
        private TextBox textBox1;
    }
}
