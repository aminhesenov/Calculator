namespace Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        char operation;
        bool click;
        double result;
        private void button1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
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
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }



        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '+';
                click = true;
                result = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '-';
                click = true;
                result = Convert.ToDouble(richTextBox1.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '*';
                click = true;
                result = Convert.ToDouble(richTextBox1.Text);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                richTextBox1.Text += ".";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operation = '/';
                click = true;
                result = Convert.ToDouble(richTextBox1.Text);
            }
        }

        double h = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(richTextBox1.Text);
            if (richTextBox1.Text == string.Empty || (a1 == 0 && operation == '/'))
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        h = result + a1;
                        break;
                    case '-':
                        h = result - a1;
                        break;
                    case '*':
                        h = result * a1;
                        break;
                    case '/':
                        h = result / a1;
                        break;
                }

                richTextBox1.Text = h.ToString();
                listBox1.Items.Add("" + result + " " + operation + " " + a1 + " = " + h);
            }


        }
        private void button20_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(richTextBox1.Text);
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "\nSqrt(" + b + ") = " + Math.Sqrt(b);
            listBox1.Items.Add("\nSqrt(" + b + ") = " + Math.Sqrt(b));

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(richTextBox1.Text);
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "\nFaiz(" + b + ") = " + b/100;
            listBox1.Items.Add("\nFaiz(" + b + ") = " + b/100);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(richTextBox1.Text);
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "\nPow(" + b + ") = " + Math.Pow(b,2);
            listBox1.Items.Add("\nPow(" + b + ") = " + Math.Pow(b,2));
        }
    }
}
