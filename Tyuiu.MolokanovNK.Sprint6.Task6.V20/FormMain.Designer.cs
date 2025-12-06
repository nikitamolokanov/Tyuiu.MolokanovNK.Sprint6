
namespace Tyuiu.MolokanovNK.Sprint6.Task6.V20
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
            components = new System.ComponentModel.Container();
            buttonOpenFile_MNK = new Button();
            buttonDone_MNK = new Button();
            groupBoxTask_MNK = new GroupBox();
            textBox1 = new TextBox();
            groupBoxOut_MNK = new GroupBox();
            textBoxLoadFromFile_MNK = new TextBox();
            groupBoxIn_MNK = new GroupBox();
            textBoxResult_MNK = new TextBox();
            buttonHelp_MNK = new Button();
            openFileDialogTask_MNK = new OpenFileDialog();
            toolTipTask_MNK = new ToolTip(components);
            groupBoxTask_MNK.SuspendLayout();
            groupBoxOut_MNK.SuspendLayout();
            groupBoxIn_MNK.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_MNK
            // 
            buttonOpenFile_MNK.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile_MNK.Location = new Point(0, 0);
            buttonOpenFile_MNK.Name = "buttonOpenFile_MNK";
            buttonOpenFile_MNK.Size = new Size(85, 57);
            buttonOpenFile_MNK.TabIndex = 0;
            buttonOpenFile_MNK.Text = "Открыть файл";
            toolTipTask_MNK.SetToolTip(buttonOpenFile_MNK, "Открыть файл\r\nВыберете нужный файл для обработки\r\n");
            buttonOpenFile_MNK.UseVisualStyleBackColor = false;
            buttonOpenFile_MNK.Click += buttonOpenFile_MNK_Click;
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_MNK.Location = new Point(91, 0);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(88, 57);
            buttonDone_MNK.TabIndex = 1;
            buttonDone_MNK.Text = "Выполнить";
            buttonDone_MNK.UseVisualStyleBackColor = false;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            // 
            // groupBoxTask_MNK
            // 
            groupBoxTask_MNK.Controls.Add(textBox1);
            groupBoxTask_MNK.Location = new Point(0, 63);
            groupBoxTask_MNK.Name = "groupBoxTask_MNK";
            groupBoxTask_MNK.Size = new Size(800, 100);
            groupBoxTask_MNK.TabIndex = 2;
            groupBoxTask_MNK.TabStop = false;
            groupBoxTask_MNK.Text = "groupBox1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(782, 72);
            textBox1.TabIndex = 3;
            // 
            // groupBoxOut_MNK
            // 
            groupBoxOut_MNK.Controls.Add(textBoxLoadFromFile_MNK);
            groupBoxOut_MNK.Location = new Point(0, 169);
            groupBoxOut_MNK.Name = "groupBoxOut_MNK";
            groupBoxOut_MNK.Size = new Size(391, 280);
            groupBoxOut_MNK.TabIndex = 0;
            groupBoxOut_MNK.TabStop = false;
            groupBoxOut_MNK.Text = "groupBox2";
            groupBoxOut_MNK.Enter += groupBoxOut_MNK_Enter;
            // 
            // textBoxLoadFromFile_MNK
            // 
            textBoxLoadFromFile_MNK.Location = new Point(6, 22);
            textBoxLoadFromFile_MNK.Multiline = true;
            textBoxLoadFromFile_MNK.Name = "textBoxLoadFromFile_MNK";
            textBoxLoadFromFile_MNK.ReadOnly = true;
            textBoxLoadFromFile_MNK.Size = new Size(385, 252);
            textBoxLoadFromFile_MNK.TabIndex = 5;
            textBoxLoadFromFile_MNK.TextChanged += textBoxResult_MNK_TextChanged;
            // 
            // groupBoxIn_MNK
            // 
            groupBoxIn_MNK.Controls.Add(textBoxResult_MNK);
            groupBoxIn_MNK.Location = new Point(397, 169);
            groupBoxIn_MNK.Name = "groupBoxIn_MNK";
            groupBoxIn_MNK.Size = new Size(403, 280);
            groupBoxIn_MNK.TabIndex = 0;
            groupBoxIn_MNK.TabStop = false;
            groupBoxIn_MNK.Text = "groupBox3";
            groupBoxIn_MNK.Enter += groupBoxIn_MNK_Enter;
            // 
            // textBoxResult_MNK
            // 
            textBoxResult_MNK.Location = new Point(0, 22);
            textBoxResult_MNK.Multiline = true;
            textBoxResult_MNK.Name = "textBoxResult_MNK";
            textBoxResult_MNK.ReadOnly = true;
            textBoxResult_MNK.Size = new Size(397, 252);
            textBoxResult_MNK.TabIndex = 4;
            textBoxResult_MNK.TextChanged += textBoxLoadFromFile_MNK_TextChanged;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.BackColor = Color.FromArgb(192, 64, 0);
            buttonHelp_MNK.Location = new Point(725, 0);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(75, 70);
            buttonHelp_MNK.TabIndex = 0;
            buttonHelp_MNK.Text = "Справка";
            toolTipTask_MNK.SetToolTip(buttonHelp_MNK, "Сведение о программе");
            buttonHelp_MNK.UseVisualStyleBackColor = false;
            buttonHelp_MNK.Click += buttonHelp_MNK_Click;
            // 
            // openFileDialogTask_MNK
            // 
            openFileDialogTask_MNK.FileName = "openFileDialog";
            // 
            // toolTipTask_MNK
            // 
            toolTipTask_MNK.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_MNK.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(groupBoxIn_MNK);
            Controls.Add(groupBoxOut_MNK);
            Controls.Add(groupBoxTask_MNK);
            Controls.Add(buttonDone_MNK);
            Controls.Add(buttonOpenFile_MNK);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_MNK.ResumeLayout(false);
            groupBoxTask_MNK.PerformLayout();
            groupBoxOut_MNK.ResumeLayout(false);
            groupBoxOut_MNK.PerformLayout();
            groupBoxIn_MNK.ResumeLayout(false);
            groupBoxIn_MNK.PerformLayout();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button buttonOpenFile_MNK;
        private Button buttonDone_MNK;
        private GroupBox groupBoxTask_MNK;
        private GroupBox groupBoxOut_MNK;
        private GroupBox groupBoxIn_MNK;
        private Button buttonHelp_MNK;
        private ToolTip toolTipTask_MNK;
        private OpenFileDialog openFileDialogTask_MNK;
        private TextBox textBox1;
        private TextBox textBoxLoadFromFile_MNK;
        private TextBox textBoxResult_MNK;
    }
}
