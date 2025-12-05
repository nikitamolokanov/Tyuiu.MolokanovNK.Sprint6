using Tyuiu.MolokanovNK.Sprint6.Task2.V27.Lib;
namespace Tyuiu.MolokanovNK.Sprint6.Task2.V27
{
    public partial class FormMain_MNK : Form
    {
        public FormMain_MNK()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textCondition_MNK_TextChanged(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();

        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MNK.Text);
                int stoptStep = Convert.ToInt32(textBoxStopStep_MNK.Text);


                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);

                this.chartFunction_MNK.Titles.Add("График функции sin(x)");

                this.chartFunction_MNK.ChartAreas[0].AxisX.Title = "Ось Y";
                this.chartFunction_MNK.ChartAreas[0].AxisX.Title = "Ось X";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MNK.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_MNK.Series[0].Points.AddXY(startStep, valueArray[i]);

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
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Молоканов Никита Константинович", "Сообщение");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_MNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_MNK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStopStep_MNK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
