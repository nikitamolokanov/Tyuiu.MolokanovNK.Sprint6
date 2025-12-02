using Tyuiu.MolokanovNK.Sprint6.Task1.V6.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonDone_Click_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStartStep.Text);
                int stoptstep = Convert.ToInt32(textBoxStopStep.Text);

                string strline;
                int len = ds.GetMassFunction(startstep, stoptstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stoptstep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("|    x    |    f(x) |" + Environment.NewLine);
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |    {1, 5:f2}   | ", startstep, valueArray[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    startstep++;

                }
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Молоканов Никита Константинович", "Сообщение");
        }

        private void textBoxStartStep_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStopStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
