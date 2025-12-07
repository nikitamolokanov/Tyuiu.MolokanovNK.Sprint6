using Tyuiu.MolokanovNK.Sprint6.Task7.V10.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MNK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*,*)|*,*";
            saveFileDialogMatrix_MNK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*,*)|*,*";
        }
        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V10.csv");
        static int column;
        static int rows;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filepath)
        {
            string fileData = File.ReadAllText(filepath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            column = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, column];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < column; c++)
                {
                    
                    
                        arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                    
                }
                
            }
            
            return arrayValues;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonOpenFile_MNK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MNK.ShowDialog();
            openFilePath = openFileDialogTask_MNK.FileName;
            int[,] arrayValues = new int[rows, column];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewOut_MNK.ColumnCount = column;
            dataGridViewOut_MNK.RowCount = rows;
            dataGridViewIn_MNK.RowCount = rows;
            dataGridViewIn_MNK.ColumnCount = column;

            for (int i = 0; i < column; i++)
            {
                dataGridViewOut_MNK.Columns[i].Width = 25;
                dataGridViewIn_MNK.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    dataGridViewOut_MNK.Rows[r].Cells[c].Value = arrayValues[r, c];
                }

            }

            buttonDone_MNK.Enabled = true;
        }

        private void buttonHelp_MNK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows,column];
             arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    dataGridViewIn_MNK.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_MNK.Enabled = true;
        }

        private void buttonSave_MNK_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MNK.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MNK.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MNK.ShowDialog();

            string path = saveFileDialogMatrix_MNK.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_MNK.Rows.Count;
            int colums = dataGridViewOut_MNK.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOut_MNK.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_MNK.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MNK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MNK.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MNK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MNK.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MNK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MNK.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MNK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MNK.ToolTipTitle = "Справка";
        }
    }
}
