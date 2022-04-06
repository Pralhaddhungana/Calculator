using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "0")
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text += "1";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "5")
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "/";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "7")
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "*";
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "0")
            {
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text += "0";
            }
        }

        private void Dotbtn_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "2")
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "3")
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "4")
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "6")
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "8")
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "9")
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Contains("-"))
            {
               txtBox.Text = txtBox.Text.Trim('-');
            }
            else
            {
                txtBox.Text = "-" + txtBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "+";
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "%";
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst - valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst + valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst * valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst / valueSecond;
                    txtBox.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(txtBox.Text);
                    Result = valueFirst % valueSecond;
                    txtBox.Text = Result.ToString();
                    break;

            }
        }

        private void ACBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtBox.Text = "0";
        }
    }
}
