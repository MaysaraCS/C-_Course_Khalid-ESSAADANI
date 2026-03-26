using System.IO;
namespace binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file1 = "photo or audio file for example(source)";
            string file2 = "dist";

            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(file2, FileMode.Create, FileAccess.Read);

            // binary reader
            BinaryReader br = new BinaryReader(fs1);

            // binary writer
            BinaryWriter bw = new BinaryWriter(fs2);

            for(int i = 0; i<= br.BaseStream.Length-1; i++)
            {
                bw.Write(br.ReadByte());
            }
            br.Close();
            bw.Close();
        }
    }
}
