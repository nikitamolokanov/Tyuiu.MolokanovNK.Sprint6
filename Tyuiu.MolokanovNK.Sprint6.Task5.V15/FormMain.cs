
using System.IO;
using Tyuiu.MolokanovNK.Sprint6.Task5.V15.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V15.txt");
        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MNK.ColumnCount = 2;
            dataGridViewResult_MNK.Columns[0].Width = 20;
            dataGridViewResult_MNK.Columns[0].Width = 50;

            this.chartGraph_MNK.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph_MNK.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraph_MNK.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_MNK.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartGraph_MNK.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_MNK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MNK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Молоканов Никита Константинович", "Сообщение");
        }
    }
}
