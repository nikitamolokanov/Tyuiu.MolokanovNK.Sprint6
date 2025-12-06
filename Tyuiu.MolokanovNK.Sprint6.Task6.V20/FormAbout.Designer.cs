namespace Tyuiu.MolokanovNK.Sprint6.Task6.V20
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
            buttonOk_MNK = new Button();
            labelInfo_MNK = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MNK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_MNK
            // 
            pictureBoxAvatar_MNK.Image = (Image)resources.GetObject("pictureBoxAvatar_MNK.Image");
            pictureBoxAvatar_MNK.Location = new Point(0, 1);
            pictureBoxAvatar_MNK.Name = "pictureBoxAvatar_MNK";
            pictureBoxAvatar_MNK.Size = new Size(205, 208);
            pictureBoxAvatar_MNK.TabIndex = 0;
            pictureBoxAvatar_MNK.TabStop = false;
            // 
            // buttonOk_MNK
            // 
            buttonOk_MNK.Location = new Point(422, 176);
            buttonOk_MNK.Name = "buttonOk_MNK";
            buttonOk_MNK.Size = new Size(75, 23);
            buttonOk_MNK.TabIndex = 1;
            buttonOk_MNK.Text = "Ок";
            buttonOk_MNK.UseVisualStyleBackColor = true;
            buttonOk_MNK.Click += button1_Click;
            // 
            // labelInfo_MNK
            // 
            labelInfo_MNK.AutoSize = true;
            labelInfo_MNK.Location = new Point(206, 1);
            labelInfo_MNK.Name = "labelInfo_MNK";
            labelInfo_MNK.Size = new Size(304, 135);
            labelInfo_MNK.TabIndex = 3;
            labelInfo_MNK.Text = "Разработчик: Молоканов Н.К\r\nГруппа ИБКСБ-25-1\r\n\r\nТюменский Индустриальный Университет(с) 2025\r\nВысшая Школа Цифровых Технологий(с) 2025\r\n\r\nВнутреннее имя: Tyuiu.MolokanovNK.Sprint6.Task6.V20\r\n\r\n\r\n";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 211);
            Controls.Add(labelInfo_MNK);
            Controls.Add(buttonOk_MNK);
            Controls.Add(pictureBoxAvatar_MNK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MNK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_MNK;
        private Button buttonOk_MNK;
        private Label labelInfo_MNK;
    }
}