using Tyuiu.MolokanovNK.Sprint6.Task4.V30.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task4.V30
{
    public partial class FormMain_MNK : Form
    {
        public FormMain_MNK()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonSave_MNK_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.V30.txt");
                File.WriteAllText(path, textBoxResult_MNK.Text);

                DialogResult dialogResult = MessageBox.Show(" Файл " + path + " Сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textStartStep_MNK.Text);
                int stoptStep = Convert.ToInt32(textStopStep_MNK.Text);


                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);

                this.chartGraph_MNK.Titles.Add("График функции sin(x)");

                this.chartGraph_MNK.ChartAreas[0].AxisX.Title = "Ось Y";
                this.chartGraph_MNK.ChartAreas[0].AxisX.Title = "Ось X";

                textBoxResult_MNK.Text = "";

                chartGraph_MNK.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartGraph_MNK.Series[0].Points.AddXY(startStep, stoptStep);
                    textBoxResult_MNK.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonHelp_MNK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Молоканов Никита Константинович", "Сообщение");
        }
    }
}
