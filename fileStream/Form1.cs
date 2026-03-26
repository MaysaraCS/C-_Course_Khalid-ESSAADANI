using System.IO;
namespace fileStream
{
    public partial class Form1 : Form
    {
        // Stream
        // file stream
        // network stream
        // memory stream

        public Form1()
        {
            InitializeComponent();
            FileStream fs = new FileStream("source.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("source.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2);
            sw.Write(richTextBox2.Text);
            sw.Close();
        }
    }
}
