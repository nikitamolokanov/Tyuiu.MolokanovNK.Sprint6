
namespace Tyuiu.MolokanovNK.Sprint6.Task7.V10
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_MNK = new PictureBox();
            labelInfo_MNK = new Label();
            buttonOk_MNK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MNK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_MNK
            // 
            pictureBoxAvatar_MNK.Image = (Image)resources.GetObject("pictureBoxAvatar_MNK.Image");
            pictureBoxAvatar_MNK.Location = new Point(-1, -3);
            pictureBoxAvatar_MNK.Name = "pictureBoxAvatar_MNK";
            pictureBoxAvatar_MNK.Size = new Size(205, 208);
            pictureBoxAvatar_MNK.TabIndex = 1;
            pictureBoxAvatar_MNK.TabStop = false;
            // 
            // labelInfo_MNK
            // 
            labelInfo_MNK.AutoSize = true;
            labelInfo_MNK.Location = new Point(210, 9);
            labelInfo_MNK.Name = "labelInfo_MNK";
            labelInfo_MNK.Size = new Size(304, 135);
            labelInfo_MNK.TabIndex = 4;
            labelInfo_MNK.Text = "Разработчик: Молоканов Н.К\r\nГруппа ИБКСБ-25-1\r\n\r\nТюменский Индустриальный Университет(с) 2025\r\nВысшая Школа Цифровых Технологий(с) 2025\r\n\r\nВнутреннее имя: Tyuiu.MolokanovNK.Sprint6.Task6.V20\r\n\r\n\r\n";
            labelInfo_MNK.Click += this.labelInfo_MNK_Click;
            // 
            // buttonOk_MNK
            // 
            buttonOk_MNK.Location = new Point(430, 168);
            buttonOk_MNK.Name = "buttonOk_MNK";
            buttonOk_MNK.Size = new Size(75, 23);
            buttonOk_MNK.TabIndex = 5;
            buttonOk_MNK.Text = "Ок";
            buttonOk_MNK.UseVisualStyleBackColor = true;
            buttonOk_MNK.Click += this.buttonOk_MNK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 203);
            Controls.Add(buttonOk_MNK);
            Controls.Add(labelInfo_MNK);
            Controls.Add(pictureBoxAvatar_MNK);
            Name = "FormAbout";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MNK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        private void labelInfo_MNK_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private PictureBox pictureBoxAvatar_MNK;
        private Label labelInfo_MNK;
        private Button buttonOk_MNK;
    }
}