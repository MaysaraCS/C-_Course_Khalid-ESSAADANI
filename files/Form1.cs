using System.IO;
namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Directory 
            foreach(string file in Directory.GetFiles("D:\\JOBS-2025"))
            {
                listBox1.Items.Add(file);
            }
            // DirectoryInfo
            DirectoryInfo d = new DirectoryInfo("D:\\JOBS-2025");
            foreach(FileInfo file in d.GetFiles())
            {
                listBox2.Items.Add(file.Name);
                // listBox2.Items.Add(d+ "\\" +file.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo d = new DriveInfo("C:");
            double Total = d.TotalSize;
            double FreeSpace = d.AvailableFreeSpace;

            double result = FreeSpace / Total * 100;
            MessageBox.Show("Your free space in C drie is : " + result + "%");
        }
    }
}
