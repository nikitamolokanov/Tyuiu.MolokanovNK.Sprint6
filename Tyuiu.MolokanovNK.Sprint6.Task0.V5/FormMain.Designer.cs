namespace Tyuiu.MolokanovNK.Sprint6.Task0.V5
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
            groupBox1 = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBoxVarX = new TextBox();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxFormula);
            groupBox1.Controls.Add(textBoxTask);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources._36639845_E2B6_42AD_88F2_9EC4A2A73EA8_;
            pictureBoxFormula.Location = new Point(288, 22);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(288, 50);
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBox1_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(266, 23);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Вычислить выражение по формуле";
            textBoxTask.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(416, 322);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(184, 42);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(358, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(30, 51);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Результат";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBoxVarX);
            groupBox3.Location = new Point(12, 216);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.Text = "Переменная Х";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(50, 51);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 4;
            textBoxVarX.TextChanged += textBox3_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(358, 322);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(50, 42);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 370);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 6 | Молоканов Н.К.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxTask;
        private Button buttonDone;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxVarX;
        private Button buttonHelp;
        private TextBox textBox2;
        private TextBox textBoxResult;
        private TextBox textBox4;
    }
}
