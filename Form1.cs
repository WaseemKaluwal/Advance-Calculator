using System;
using System.Windows.Forms;

namespace Advance_Calculator1
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "C")
            {
                display.Text = "0";
                result = 0;
                operation = "";
            }
            else if (button.Text == "CE")
            {
                display.Text = "0";
            }
            else if (button.Text == "⌫")
            {
                if (display.Text.Length > 1)
                {
                    display.Text = display.Text.Remove(display.Text.Length - 1, 1);
                }
                else
                {
                    display.Text = "0";
                }
            }
            else if (button.Text == "±")
            {
                display.Text = (Double.Parse(display.Text) * -1).ToString();
            }
            else if (button.Text == "." && !display.Text.Contains("."))
            {
                display.Text += ".";
            }
            else if (button.Text == "=")
            {
                Calculate();
                operation = "";
            }
            else if (button.Text == "+" || button.Text == "-" || button.Text == "×" || button.Text == "÷" ||
                     button.Text == "%" || button.Text == "1/x" || button.Text == "x²" || button.Text == "√x")
            {
                if (result != 0 && !enterValue)
                {
                    Calculate();
                }
                else
                {
                    result = Double.Parse(display.Text);
                }
                operation = button.Text;
                enterValue = true;
            }
            else
            {
                if ((display.Text == "0") || (enterValue))
                {
                    display.Text = "";
                }
                enterValue = false;
                display.Text += button.Text;
            }
        }

        private void Calculate()
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        result += Double.Parse(display.Text);
                        break;
                    case "-":
                        result -= Double.Parse(display.Text);
                        break;
                    case "×":
                        result *= Double.Parse(display.Text);
                        break;
                    case "÷":
                        if (Double.Parse(display.Text) != 0)
                        {
                            result /= Double.Parse(display.Text);
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "%":
                        result = result * (Double.Parse(display.Text) / 100);
                        break;
                    case "1/x":
                        if (Double.Parse(display.Text) != 0)
                        {
                            display.Text = (1 / Double.Parse(display.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "x²":
                        display.Text = (Math.Pow(Double.Parse(display.Text), 2)).ToString();
                        break;
                    case "√x":
                        display.Text = (Math.Sqrt(Double.Parse(display.Text))).ToString();
                        break;
                }
                display.Text = result.ToString();
                result = Double.Parse(display.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
