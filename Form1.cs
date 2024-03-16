using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dzienniczekv2
{
    public partial class Form1 : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";

        public Form1()
        {
            InitializeComponent();
        }



        private void button_reset_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valuefirst = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                operators = "%";
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            valuefirst = 0.0m;
            valuesecond = 0.0m;
            textBox1.Text = "0";
        }

        private void button_slash_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valuefirst = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                operators = "/";
            }
        }



        private void button77_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valuefirst = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                operators = "-";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valuefirst = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                operators = "+";
            }
        }

        private void button_rownasie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (operators)
                {
                    case "-":
                        {
                            valuesecond = decimal.Parse(textBox1.Text);
                            Result = valuefirst - valuesecond;
                            textBox1.Text = Result.ToString();
                            break;
                        }
                    case "+":
                        {
                            valuesecond = decimal.Parse(textBox1.Text);
                            Result = valuefirst + valuesecond;
                            textBox1.Text = Result.ToString();
                            break;
                        }
                    case "*":
                        {
                            valuesecond = decimal.Parse(textBox1.Text);
                            Result = valuefirst * valuesecond;
                            textBox1.Text = Result.ToString();
                            break;
                        }
                    case "/":
                        {
                            valuesecond = decimal.Parse(textBox1.Text);
                            Result = valuefirst / valuesecond;
                            textBox1.Text = Result.ToString();
                            break;
                        }
                    case "%":
                        {
                            valuesecond = decimal.Parse(textBox1.Text);
                            Result = valuefirst % valuesecond;
                            textBox1.Text = Result.ToString();
                            break;
                        }
                }
            }
        }

        private void button_kropka_Click(object sender, EventArgs e)
        {
           if(!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";

            }
        }


        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += 0;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }    
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void btn8s_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text += "8";
                }
            }
        }

        private void button_plusminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Contains("-"))
                {
                    textBox1.Text = textBox1.Text.Trim('-');
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_mnozenie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valuefirst = decimal.Parse(textBox1.Text);
                textBox1.Clear();
                operators = "*";
            }
        }
    }
}
