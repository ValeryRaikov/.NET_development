using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string operation;
        private double number1, number2, result;
        private bool operationSelected = false;

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (button.Text == "." && txtDisplay.Text.Contains("."))
                    return;

                if (operationSelected)
                {
                    txtDisplay.Clear();
                    operationSelected = false;
                }

                txtDisplay.Text += button.Text;
            }
        }

        private void addBtn_Click(object sender, EventArgs e) 
        {
            PerformOperation("+");
            txtDisplay.Clear();
        } 
        private void subtractBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
            txtDisplay.Clear();
        }
        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
            txtDisplay.Clear();
        }
        private void DivideBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
            txtDisplay.Clear();
        }

        private void PerformOperation(string op)
        {
            if (!double.TryParse(txtDisplay.Text, out number1))
            {
                txtDisplay.Text = "Invalid input!";
                return;
            }

            operation = op;
            operationSelected = true;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out number2))
            {
                txtDisplay.Text = "Invalid input!";
                return;
            }

            switch (operation)
            {
                case "+": 
                    result = number1 + number2; 
                    break;
                case "-": 
                    result = number1 - number2; 
                    break;
                case "*": 
                    result = number1 * number2; 
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        txtDisplay.Text = "Error: Cannot divide by zero!";
                        return;
                    }
                    result = number1 / number2;
                    break;
                default:
                    txtDisplay.Text = "No operation selected!";
                    return;
            }

            txtDisplay.Text = result.ToString();
            operationSelected = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            number1 = 0;
            number2 = 0;
            result = 0;
            operationSelected = false;
        }
    }
}
