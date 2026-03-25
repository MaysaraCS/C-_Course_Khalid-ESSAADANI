namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.notifyIcon1.Icon = this.Icon;
            //this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //this.notifyIcon1.BalloonTipText = "Please update your program";
            //this.notifyIcon1.BalloonTipTitle = "Warning Update";
            this.notifyIcon1.ShowBalloonTip(12, "Error", "Some Errors Happend", ToolTipIcon.Error);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello NotifyIcon");
        }
    }
}
