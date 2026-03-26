using System.IO;
namespace fileInfo
{
    public partial class Form1 : Form
    {
        FileInfo myFile = new FileInfo("file source");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Move("source", "distination");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("file name"))
            {
                richTextBox1.Lines = File.ReadAllLines("same file name ");
                //richTextBox1.Text = File.ReadAllText("same file name ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("same file name", richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myFile.Delete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myFile.MoveTo("Distination");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myFile.CopyTo("DISTINATION");
        }
    }
}
