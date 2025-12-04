
namespace Tyuiu.MolokanovNK.Sprint6.Task3.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MNK));
            buttonDone_MNK = new Button();
            buttonHelp_MNK = new Button();
            groupTask_MNK = new GroupBox();
            textCondition_MNK = new TextBox();
            groupResult_MNK = new GroupBox();
            textBoxResult_MNK = new TextBox();
            textResult_MNK = new TextBox();
            dataGridViewMatrix_MNK = new DataGridView();
            groupTask_MNK.SuspendLayout();
            groupResult_MNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MNK).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.Location = new Point(629, 401);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(159, 41);
            buttonDone_MNK.TabIndex = 0;
            buttonDone_MNK.Text = "Выполнить";
            buttonDone_MNK.UseVisualStyleBackColor = true;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            buttonDone_MNK.KeyPress += buttonDone_MNK_KeyPress;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.Location = new Point(558, 401);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(65, 41);
            buttonHelp_MNK.TabIndex = 1;
            buttonHelp_MNK.Text = "?";
            buttonHelp_MNK.UseVisualStyleBackColor = true;
            buttonHelp_MNK.Click += button2_Click;
            // 
            // groupTask_MNK
            // 
            groupTask_MNK.Controls.Add(textCondition_MNK);
            groupTask_MNK.Location = new Point(12, 12);
            groupTask_MNK.Name = "groupTask_MNK";
            groupTask_MNK.Size = new Size(294, 426);
            groupTask_MNK.TabIndex = 2;
            groupTask_MNK.TabStop = false;
            groupTask_MNK.Text = "Условие";
            // 
            // textCondition_MNK
            // 
            textCondition_MNK.Location = new Point(6, 22);
            textCondition_MNK.Multiline = true;
            textCondition_MNK.Name = "textCondition_MNK";
            textCondition_MNK.ReadOnly = true;
            textCondition_MNK.Size = new Size(282, 203);
            textCondition_MNK.TabIndex = 2;
            textCondition_MNK.Text = resources.GetString("textCondition_MNK.Text");
            // 
            // groupResult_MNK
            // 
            groupResult_MNK.Controls.Add(textBoxResult_MNK);
            groupResult_MNK.Controls.Add(textResult_MNK);
            groupResult_MNK.Location = new Point(558, 12);
            groupResult_MNK.Name = "groupResult_MNK";
            groupResult_MNK.Size = new Size(230, 383);
            groupResult_MNK.TabIndex = 0;
            groupResult_MNK.TabStop = false;
            groupResult_MNK.Text = "Вывод данных";
            groupResult_MNK.Enter += groupBox2_Enter;
            // 
            // textBoxResult_MNK
            // 
            textBoxResult_MNK.Location = new Point(6, 51);
            textBoxResult_MNK.Multiline = true;
            textBoxResult_MNK.Name = "textBoxResult_MNK";
            textBoxResult_MNK.ReadOnly = true;
            textBoxResult_MNK.Size = new Size(166, 261);
            textBoxResult_MNK.TabIndex = 0;
            textBoxResult_MNK.TextChanged += textBox1_TextChanged;
            // 
            // textResult_MNK
            // 
            textResult_MNK.Location = new Point(6, 22);
            textResult_MNK.Name = "textResult_MNK";
            textResult_MNK.ReadOnly = true;
            textResult_MNK.Size = new Size(166, 23);
            textResult_MNK.TabIndex = 1;
            textResult_MNK.Text = "Результат:";
            // 
            // dataGridViewMatrix_MNK
            // 
            dataGridViewMatrix_MNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_MNK.ColumnHeadersVisible = false;
            dataGridViewMatrix_MNK.Location = new Point(312, 22);
            dataGridViewMatrix_MNK.Name = "dataGridViewMatrix_MNK";
            dataGridViewMatrix_MNK.RowHeadersVisible = false;
            dataGridViewMatrix_MNK.Size = new Size(240, 420);
            dataGridViewMatrix_MNK.TabIndex = 2;
            dataGridViewMatrix_MNK.CellContentClick += dataGridViewMatrix_MNK_CellContentClick;
            // 
            // FormMain_MNK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMatrix_MNK);
            Controls.Add(groupResult_MNK);
            Controls.Add(groupTask_MNK);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(buttonDone_MNK);
            Name = "FormMain_MNK";
            Text = "Спринт 6 | Таск 3 | Вариант 11 | Молоканов Н.К.";
            Load += FormMain_MNK_Load;
            groupTask_MNK.ResumeLayout(false);
            groupTask_MNK.PerformLayout();
            groupResult_MNK.ResumeLayout(false);
            groupResult_MNK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MNK).EndInit();
            ResumeLayout(false);
        }




        #endregion

        private Button buttonDone_MNK;
        private Button buttonHelp_MNK;
        private GroupBox groupTask_MNK;
        private GroupBox groupResult_MNK;
        private TextBox textBoxResult_MNK;
        private TextBox textResult_MNK;
        private TextBox textCondition_MNK;
        private DataGridView dataGridViewMatrix_MNK;
    }
}
