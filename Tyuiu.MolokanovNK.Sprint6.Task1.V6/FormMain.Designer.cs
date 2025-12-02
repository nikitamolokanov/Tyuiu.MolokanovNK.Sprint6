namespace Tyuiu.MolokanovNK.Sprint6.Task1.V6
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
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxTask1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxResult = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.AppWorkspace;
            buttonHelp.Location = new Point(280, 210);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 93);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.MenuHighlight;
            buttonDone.Location = new Point(361, 210);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(126, 93);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click_Click;
            // 
            // textBoxTask1
            // 
            textBoxTask1.Location = new Point(6, 22);
            textBoxTask1.Multiline = true;
            textBoxTask1.Name = "textBoxTask1";
            textBoxTask1.Size = new Size(337, 78);
            textBoxTask1.TabIndex = 2;
            textBoxTask1.Text = "Протабулировать функцию  sin(x)  на заданном диапазоне\r\n\r\nрезультат записать в виде таблицы\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Старт шага";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "Конец шага";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 74);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(121, 23);
            textBoxStartStep.TabIndex = 5;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            textBoxStartStep.KeyPress += textBoxStartStep_KeyPress;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(133, 74);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(123, 23);
            textBoxStopStep.TabIndex = 6;
            textBoxStopStep.TextChanged += textBoxStopStep_TextChanged;
            textBoxStopStep.KeyPress += textBoxStopStep_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(188, 261);
            textBoxResult.TabIndex = 7;
            textBoxResult.TextChanged += textBox6_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTask1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 182);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(493, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 291);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStartStep);
            groupBox3.Controls.Add(textBoxStopStep);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(12, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 103);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // FormMain
            // 
            ClientSize = new Size(705, 307);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Name = "FormMain";
            Text = "принт 6 | Таск 1 | Вариант 6 | Молоканов Н.К.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxTask1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private TextBox textBoxResult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
#endregion