namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1, number2, result;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtCalc.Text = txtCalc.Text + "1";
            txtCalc.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalc.Text += ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '+';
            txtCalc.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '-';
            txtCalc.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '*';
            txtCalc.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtCalc.Text);
            op = '/';
            txtCalc.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(txtCalc.Text);
            switch (op)
            {
                case '+':
                    result = number1 + number2; 
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
            }
            txtCalc.Text = Convert.ToString(result);
        }
    }
}
