
namespace Tyuiu.MolokanovNK.Sprint6.Task7.V10
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
            buttonHelp_MNK = new Button();
            groupBoxTask_MNK = new GroupBox();
            textBoxTask_MNK = new TextBox();
            groupBoxIn_MNK = new GroupBox();
            dataGridViewIn_MNK = new DataGridView();
            groupBoxOut_MNK = new GroupBox();
            dataGridViewOut_MNK = new DataGridView();
            buttonSave_MNK = new Button();
            openFileDialogTask_MNK = new OpenFileDialog();
            saveFileDialogMatrix_MNK = new SaveFileDialog();
            toolTipButton_MNK = new ToolTip(components);
            panelTop_MNK = new Panel();
            groupBoxTask_MNK.SuspendLayout();
            groupBoxIn_MNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MNK).BeginInit();
            groupBoxOut_MNK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MNK).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_MNK
            // 
            buttonOpenFile_MNK.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_MNK.Image = Properties.Resources.folder_page;
            buttonOpenFile_MNK.Location = new Point(6, 8);
            buttonOpenFile_MNK.Name = "buttonOpenFile_MNK";
            buttonOpenFile_MNK.Size = new Size(69, 53);
            buttonOpenFile_MNK.TabIndex = 0;
            buttonOpenFile_MNK.UseVisualStyleBackColor = true;
            buttonOpenFile_MNK.Click += buttonOpenFile_MNK_Click;
            buttonOpenFile_MNK.MouseEnter += buttonOpenFile_MNK_MouseEnter;
            // 
            // buttonDone_MNK
            // 
            buttonDone_MNK.FlatStyle = FlatStyle.Flat;
            buttonDone_MNK.Image = Properties.Resources.page_white_go;
            buttonDone_MNK.Location = new Point(81, 8);
            buttonDone_MNK.Name = "buttonDone_MNK";
            buttonDone_MNK.Size = new Size(64, 53);
            buttonDone_MNK.TabIndex = 1;
            buttonDone_MNK.UseVisualStyleBackColor = true;
            buttonDone_MNK.Click += buttonDone_MNK_Click;
            buttonDone_MNK.MouseEnter += buttonDone_MNK_MouseEnter;
            // 
            // buttonHelp_MNK
            // 
            buttonHelp_MNK.FlatStyle = FlatStyle.Flat;
            buttonHelp_MNK.Image = Properties.Resources.help;
            buttonHelp_MNK.Location = new Point(718, 8);
            buttonHelp_MNK.Name = "buttonHelp_MNK";
            buttonHelp_MNK.Size = new Size(75, 54);
            buttonHelp_MNK.TabIndex = 2;
            buttonHelp_MNK.UseVisualStyleBackColor = true;
            buttonHelp_MNK.Click += buttonHelp_MNK_Click;
            buttonHelp_MNK.MouseEnter += buttonHelp_MNK_MouseEnter;
            // 
            // groupBoxTask_MNK
            // 
            groupBoxTask_MNK.Controls.Add(textBoxTask_MNK);
            groupBoxTask_MNK.Location = new Point(0, 67);
            groupBoxTask_MNK.Name = "groupBoxTask_MNK";
            groupBoxTask_MNK.Size = new Size(799, 92);
            groupBoxTask_MNK.TabIndex = 3;
            groupBoxTask_MNK.TabStop = false;
            groupBoxTask_MNK.Text = "Условие";
            // 
            // textBoxTask_MNK
            // 
            textBoxTask_MNK.Location = new Point(11, 22);
            textBoxTask_MNK.Multiline = true;
            textBoxTask_MNK.Name = "textBoxTask_MNK";
            textBoxTask_MNK.ReadOnly = true;
            textBoxTask_MNK.Size = new Size(782, 72);
            textBoxTask_MNK.TabIndex = 1;
            // 
            // groupBoxIn_MNK
            // 
            groupBoxIn_MNK.Controls.Add(dataGridViewIn_MNK);
            groupBoxIn_MNK.Location = new Point(404, 165);
            groupBoxIn_MNK.Name = "groupBoxIn_MNK";
            groupBoxIn_MNK.Size = new Size(395, 285);
            groupBoxIn_MNK.TabIndex = 0;
            groupBoxIn_MNK.TabStop = false;
            groupBoxIn_MNK.Text = "Вывод";
            // 
            // dataGridViewIn_MNK
            // 
            dataGridViewIn_MNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MNK.Location = new Point(6, 22);
            dataGridViewIn_MNK.Name = "dataGridViewIn_MNK";
            dataGridViewIn_MNK.ReadOnly = true;
            dataGridViewIn_MNK.Size = new Size(378, 257);
            dataGridViewIn_MNK.TabIndex = 0;
            // 
            // groupBoxOut_MNK
            // 
            groupBoxOut_MNK.Controls.Add(dataGridViewOut_MNK);
            groupBoxOut_MNK.Location = new Point(0, 165);
            groupBoxOut_MNK.Name = "groupBoxOut_MNK";
            groupBoxOut_MNK.Size = new Size(398, 285);
            groupBoxOut_MNK.TabIndex = 0;
            groupBoxOut_MNK.TabStop = false;
            groupBoxOut_MNK.Text = "Ввод ";
            // 
            // dataGridViewOut_MNK
            // 
            dataGridViewOut_MNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MNK.Location = new Point(11, 22);
            dataGridViewOut_MNK.Name = "dataGridViewOut_MNK";
            dataGridViewOut_MNK.ReadOnly = true;
            dataGridViewOut_MNK.Size = new Size(381, 257);
            dataGridViewOut_MNK.TabIndex = 1;
            // 
            // buttonSave_MNK
            // 
            buttonSave_MNK.FlatStyle = FlatStyle.Flat;
            buttonSave_MNK.Image = Properties.Resources.page_save;
            buttonSave_MNK.Location = new Point(151, 8);
            buttonSave_MNK.Name = "buttonSave_MNK";
            buttonSave_MNK.Size = new Size(76, 53);
            buttonSave_MNK.TabIndex = 4;
            buttonSave_MNK.UseVisualStyleBackColor = true;
            buttonSave_MNK.Click += buttonSave_MNK_Click;
            buttonSave_MNK.MouseEnter += buttonSave_MNK_MouseEnter;
            // 
            // openFileDialogTask_MNK
            // 
            openFileDialogTask_MNK.FileName = "openFileDialog_MNK";
            // 
            // toolTipButton_MNK
            // 
            toolTipButton_MNK.IsBalloon = true;
            toolTipButton_MNK.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_MNK.ToolTipTitle = "Подсказка";
            toolTipButton_MNK.Popup += toolTip1_Popup;
            // 
            // panelTop_MNK
            // 
            panelTop_MNK.Anchor = AnchorStyles.Top;
            panelTop_MNK.Location = new Point(0, 0);
            panelTop_MNK.Name = "panelTop_MNK";
            panelTop_MNK.Size = new Size(799, 71);
            panelTop_MNK.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave_MNK);
            Controls.Add(groupBoxIn_MNK);
            Controls.Add(groupBoxOut_MNK);
            Controls.Add(groupBoxTask_MNK);
            Controls.Add(buttonHelp_MNK);
            Controls.Add(buttonDone_MNK);
            Controls.Add(buttonOpenFile_MNK);
            Controls.Add(panelTop_MNK);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_MNK.ResumeLayout(false);
            groupBoxTask_MNK.PerformLayout();
            groupBoxIn_MNK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MNK).EndInit();
            groupBoxOut_MNK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MNK).EndInit();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button buttonOpenFile_MNK;
        private Button buttonDone_MNK;
        private Button buttonHelp_MNK;
        private GroupBox groupBoxTask_MNK;
        private GroupBox groupBoxIn_MNK;
        private GroupBox groupBoxOut_MNK;
        private TextBox textBoxTask_MNK;
        private Button buttonSave_MNK;
        private OpenFileDialog openFileDialogTask_MNK;
        private SaveFileDialog saveFileDialogMatrix_MNK;
        private ToolTip toolTipButton_MNK;
        private Panel panelTop_MNK;
        private DataGridView dataGridViewIn_MNK;
        private DataGridView dataGridViewOut_MNK;
    }
}
