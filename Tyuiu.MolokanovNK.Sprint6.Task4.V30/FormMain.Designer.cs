
namespace Tyuiu.MolokanovNK.Sprint6.Task4.V30
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartGraph_MNK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupInput_MNK = new GroupBox();
            textStopStep_MNK = new TextBox();
            textStartStep_MNK = new TextBox();
            textStop_MNK = new TextBox();
            textStart_MNK = new TextBox();
            groupResult_MNK = new GroupBox();
            textBoxResult_MNK = new TextBox();
            groupTask_MNK = new GroupBox();
            textBox5 = new TextBox();
            buttonDone_MNK = new Button();
            buttonSave_MNK = new Button();
            buttonHelp_MNK = new Button();
            ((System.ComponentModel.ISupportInitialize)chartGraph_MNK).BeginInit();
            groupInput_MNK.SuspendLayout();
            groupResult_MNK.SuspendLayout();
            groupTask_MNK.SuspendLayout();
            SuspendLayout();
            // 
            // chartGraph_MNK
            // 
            chartArea2.Name = "ChartArea1";
            chartGraph_MNK.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGraph_MNK.Legends.Add(legend2);
            chartGraph_MNK.Location = new Point(385, 91);
            chartGraph_MNK.Name = "chartGraph_MNK";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGraph_MNK.Series.Add(series2);
            chartGraph_MNK.Size = new Size(516, 347);
            chartGraph_MNK.TabIndex = 0;
            chartGraph_MNK.Text = "chart1";
            title2.Name = "Title_MNK";
            title2.Text = "График функции sin(x)";
            chartGraph_MNK.Titles.Add(title2);
            // 
            // groupInput_MNK
            // 
            groupInput_MNK.Controls.Add(textStopStep_MNK);
            groupInput_MNK.Controls.Add(textStartStep_MNK);
            groupInput_MNK.Controls.Add(textStop_MNK);
            groupInput_MNK.Controls.Add(textStart_MNK);
            groupInput_MNK.Location = new Point(385, 12);
            groupInput_MNK.Name = "groupInput_MNK";
            groupInput_MNK.Size = new Size(224, 73);
            groupInput_MNK.TabIndex = 1;
            groupInput_MNK.TabStop = false;
            groupInput_MNK.Text = "Ввод данных";
            // 
            // textStopStep_MNK
            // 
            textStopStep_MNK.Location = new Point(118, 44);
            textStopStep_MNK.Name = "textStopStep_MNK";
            textStopStep_MNK.Size = new Size(100, 23);
            textStopStep_MNK.TabIndex = 3;
            // 
            // textStartStep_MNK
            // 
            textStartStep_MNK.Location = new Point(6, 43);
            textStartStep_MNK.Name = "textStartStep_MNK";
            textStartStep_MNK.Size = new Size(100, 23);
            textStartStep_MNK.TabIndex = 2;
            // 
            // textStop_MNK
            // 
            textStop_MNK.Location = new Point(118, 14);
            textStop_MNK.Name = "textStop_MNK";
            textStop_MNK.ReadOnly = true;
            textStop_MNK.Size = new Size(100, 23);
            textStop_MNK.TabIndex = 1;
            textStop_MNK.Text = "Конец шага:";
            // 
            // textStart_MNK
            // 
            textStart_MNK.Location = new Point(6, 14);
            textStart_MNK.Name = "textStart_MNK";
            textStart_MNK.ReadOnly = true;
            textStart_MNK.Size = new Size(100, 23);
            textStart_MNK.TabIndex = 0;
            textStart_MNK.Text = "Старт шага:";
            // 
            // groupResult_MNK
            // 
            groupResult_MNK.Controls.Add(textBoxResult_MNK);
            groupResult_MNK.Location = new Point(12, 108);
            groupResult_MNK.Name = "groupResult_MNK";
            groupResult_MNK.Size = new Size(241, 330);
            groupResult_MNK.TabIndex = 0;
            groupResult_MNK.TabStop = false;
            groupResult_MNK.Text = "Вывод данных";
            // 
            // textBoxResult_MNK
            // 
            textBoxResult_MNK.Location = new Point(6, 22);
            textBoxResult_MNK.Multiline = true;
            textBoxResult_MNK.Name = "textBoxResult_MNK";
            textBoxResult_MNK.ReadOnly = true;
            textBoxResult_MNK.Size = new Size(229, 291);
            textBoxResult_MNK.TabIndex = 0;
            // 
            // groupTask_MNK
            // 
            groupTask_MNK.Controls.Add(textBox5);
            groupTask_MNK.Location = new Point(12, 12);
            groupTask_MNK.Name = "groupTask_MNK";
            groupTask_MNK.Size = new Size(367, 90);
            groupTask_MNK.TabIndex = 0;
            groupTask_MNK.TabStop = false;
            groupTask_MNK.Text = "Условие";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 13);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(355, 72);
            textBox5.TabIndex = 4;
            textBox5.Text = "Протабулировать функцию sin(x) от -5 до 5 \r\nРезультат вывести в textBox, построить график и сохранить \r\nв файл \r\nOutPutTask4V30.txt по нажатию кнопки\r\n";
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.BackColor = Color.Yellow;
            buttonDone_MNK.Location = new Point(621, 25);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(83, 60);
            buttonDone_MNK.TabIndex = 4;
            buttonDone_MNK.Text = "Выполнить";
            buttonDone_MNK.UseVisualStyleBackColor = false;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            // 
            // buttonSave_MNK
            // 
            buttonSave_MNK.BackColor = Color.FromArgb(0, 192, 0);
            buttonSave_MNK.Location = new Point(710, 25);
            buttonSave_MNK.Name = "buttonSave_MNK";
            buttonSave_MNK.Size = new Size(86, 60);
            buttonSave_MNK.TabIndex = 5;
            buttonSave_MNK.Text = "Сохранить";
            buttonSave_MNK.UseVisualStyleBackColor = false;
            buttonSave_MNK.Click += buttonSave_MNK_Click;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.BackColor = SystemColors.ActiveCaption;
            buttonHelp_MNK.Location = new Point(802, 26);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(99, 59);
            buttonHelp_MNK.TabIndex = 6;
            buttonHelp_MNK.Text = "Справка";
            buttonHelp_MNK.UseVisualStyleBackColor = false;
            buttonHelp_MNK.Click += buttonHelp_MNK_Click;
            // 
            // FormMain_MNK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(buttonDone_MNK);
            Controls.Add(buttonSave_MNK);
            Controls.Add(groupResult_MNK);
            Controls.Add(groupTask_MNK);
            Controls.Add(groupInput_MNK);
            Controls.Add(chartGraph_MNK);
            Name = "FormMain_MNK";
            Text = "Спринт 6 | Таск 4 | Вариант 30 | Молоканов Н.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chartGraph_MNK).EndInit();
            groupInput_MNK.ResumeLayout(false);
            groupInput_MNK.PerformLayout();
            groupResult_MNK.ResumeLayout(false);
            groupResult_MNK.PerformLayout();
            groupTask_MNK.ResumeLayout(false);
            groupTask_MNK.PerformLayout();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_MNK;
        private GroupBox groupInput_MNK;
        private GroupBox groupResult_MNK;
        private GroupBox groupTask_MNK;
        private TextBox textStopStep_MNK;
        private TextBox textStartStep_MNK;
        private TextBox textStop_MNK;
        private TextBox textStart_MNK;
        private TextBox textBox5;
        private Button buttonDone_MNK;
        private Button buttonSave_MNK;
        private TextBox textBoxResult_MNK;
        private Button buttonHelp_MNK;
    }
}
