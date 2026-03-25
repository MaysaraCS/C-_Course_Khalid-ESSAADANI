using System.IO;
namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files |*.txt";
            saveFileDialog1.InitialDirectory = "D:\\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                MessageBox.Show("Saved Successfully","Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
