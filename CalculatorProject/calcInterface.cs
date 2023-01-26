using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class calcInterface : Form
    {
        double FirstNumber;
        private double memory;
        string Operation;
        public calcInterface()
        {
            InitializeComponent();
            reset();
            btnClearMemory.Enabled = false;
            memRecall.Enabled = false;
        }
        private void reset()
        {
            memory = 0;
            calcTextBox.Text = "0";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "1";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "2";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "3";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "4";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "5";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "6";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "7";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "8";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "9";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text == "0" && calcTextBox.Text != null)
            {
                calcTextBox.Text = "0";
            }
            else
            {
                calcTextBox.Text = calcTextBox.Text + "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = "0";
            Operation = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = "0";
            Operation = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = "0";
            Operation = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = "0";
            Operation = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!calcTextBox.Text.Contains("."))
            {
                calcTextBox.Text = calcTextBox.Text + ".";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(calcTextBox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                calcTextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                calcTextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                calcTextBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    calcTextBox.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    calcTextBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void calcInterface_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;

                case "1":
                    button1.PerformClick();
                    break;

                case "2":
                    button2.PerformClick();
                    break;

                case "3":
                    button3.PerformClick();
                    break;

                case "4":
                    button4.PerformClick();
                    break;

                case "5":
                    button5.PerformClick();
                    break;

                case "6":
                    button6.PerformClick();
                    break;

                case "7":
                    button7.PerformClick();
                    break;

                case "8":
                    button8.PerformClick();
                    break;

                case "9":
                    button9.PerformClick();
                    break;

                case ".":
                    btnDecimal.PerformClick();
                    break;

                case "/":
                    btnDivision.PerformClick();
                    break;

                case "*":
                    btnMulti.PerformClick();
                    break;

                case "-":
                    btnMinus.PerformClick();
                    break;

                case "+":
                    btnPlus.PerformClick();
                    break;

                case "=":
                    btnEquals.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text != string.Empty)
            {
                int txtlength = calcTextBox.Text.Length;
                if (txtlength != 1)
                {
                    calcTextBox.Text = calcTextBox.Text.Remove(txtlength - 1);
                }
                else
                {
                    calcTextBox.Text = 0.ToString();
                }
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (calcTextBox.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                calcTextBox.Text = calcTextBox.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(calcTextBox.Text) && decimal.Parse(calcTextBox.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                calcTextBox.Text = "-" + calcTextBox.Text;
            }
        }

        private void memMinus_Click(object sender, EventArgs e)
        {
            memory = memory - Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = memory.ToString();
        }

        private void memPlus_Click(object sender, EventArgs e)
        {
            memory = memory - Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = memory.ToString();
        }

        private void memRecall_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = memory.ToString();
        }

        private void btnClearMemory_Click(object sender, EventArgs e)
        {
            memory = 0;
            btnClearMemory.Enabled = false;
            memRecall.Enabled = false;
            calcTextBox.Text = "0";
        }

        private void memStore_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(calcTextBox.Text);
            calcTextBox.Text = "0";
            btnClearMemory.Enabled = true;
            memRecall.Enabled = true;
        }
    }
}
