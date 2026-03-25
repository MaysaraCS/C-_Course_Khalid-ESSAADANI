namespace Bars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            Button btn = new Button();
            btn.BackColor = button1.BackColor;
            button1.BackColor = button2.BackColor;
            button2.BackColor = btn.BackColor;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Download Finished");
            }
        }
    }
}
