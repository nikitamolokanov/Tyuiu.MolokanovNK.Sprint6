using Tyuiu.MolokanovNK.Sprint6.Task6.V20.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V20.txt");
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_MNK_Click(object sender, EventArgs e)
        {

            textBoxResult_MNK.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void textBoxResult_MNK_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_MNK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MNK.ShowDialog();
            openFilePath = openFileDialogTask_MNK.FileName;
            textBoxLoadFromFile_MNK.Text = File.ReadAllText(openFilePath);
            groupBoxOut_MNK.Text = groupBoxOut_MNK.Text + " " + openFileDialogTask_MNK.FileName;
            buttonDone_MNK.Enabled = true;
        }

        private void buttonHelp_MNK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxLoadFromFile_MNK_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOut_MNK_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxIn_MNK_Enter(object sender, EventArgs e)
        {

        }
    }
}
