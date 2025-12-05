using System.Drawing.Drawing2D;
using Tyuiu.MolokanovNK.Sprint6.Task3.V11.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task3.V11
{
    public partial class FormMain_MNK : Form
    {
        public FormMain_MNK()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]

                                  { { 27, -15, 14, 2, 27 },
                                    { -8, 14, -10, 33, 0 },
                                    { 1, 7, -11, -11, 2 },
                                    { -13, -20, 15, -16, 34 },
                                    { -3, 1, -1, 5, 1 } };

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Молоканов Никита Константинович", "Сообщение");
        }

        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {


            int[,] sortedMatrix = ds.Calculate(mtrx);


            dataGridViewMatrix_MNK.RowCount = 5;
            dataGridViewMatrix_MNK.ColumnCount = 5;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_MNK.Rows[i].Cells[j].Value = sortedMatrix[i, j];
                }
            }
        }
        private void FormMain_MNK_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MNK.ColumnCount = columns;
            dataGridViewMatrix_MNK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MNK.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MNK.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void dataGridViewMatrix_MNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
