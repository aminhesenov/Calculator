namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char operation;
        bool click;
        double amount;
        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
        double h = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(richTextBox1.Text);
            if (richTextBox1.Text == string.Empty || richTextBox1.Text == "0")
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        h = amount + a1;
                        break;
                    case '-':
                        h = amount - a1;
                        break;
                    case 'x':
                        h = amount * a1;
                        break;
                    case '/':
                        h = amount / a1;
                        break;
                    case 'c':
                        h = 1 / amount;
                        break;
                }
                richTextBox1.Text = h.ToString();
                listBox1.Items.Add("" + amount + " " + operation + " " + a1 + " = " + h);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }

            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            richTextBox1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '+';
                click = true;
                amount = Convert.ToDouble(richTextBox1.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '-';
                click = true;
                amount = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = 'x';
                click = true;
                amount = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '/';
                click = true;
                amount = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
           
                if (!richTextBox1.Text.Contains("."))
                {
                    richTextBox1.Text += ".";
                  
                }
                                               
        }
        double k;
        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            k = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text += "\nSqrt(" + k + ")" + "=" + Math.Sqrt(k);
            listBox1.Items.Add("\nSqrt(" + k + ")" + "=" + Math.Sqrt(k));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = 'x';
                click = true;
                amount = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Text = "";
            k=Convert.ToDouble(richTextBox1.Text);
            double faiz=k/100;
            richTextBox1.Text = "";
            richTextBox1.Text += faiz.ToString();
            listBox1.Items.Add("Faiz("+k+") = "+faiz);
        }
    }
}
