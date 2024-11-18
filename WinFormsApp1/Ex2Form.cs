using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Ex2Form : Form
    {
        double number1;
        double number2;
        double result;
        string operation = "";
        public Ex2Form()
        {
            InitializeComponent();
            AddRadioButton.Checked = true;
            operation = "+";
        }

        private void Ex2Form_Load(object sender, EventArgs e)
        {

        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void SubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void DivineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            bool number1k = double.TryParse(FirstNumberTextBox.Text, out number1);
            bool number2k = double.TryParse(SecondNumberTextBox.Text,out number2);
            if (number1k && number2k) { 
            switch (operation)
            { 
                case "+":
                    result = number1 + number2;
                    CalculateLabel.Text = "Результат: " + result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                        CalculateLabel.Text = "Результат: " + result.ToString(); ;
                    break;
                case "*":
                    result = number2 * number1;
                        CalculateLabel.Text = "Результат: " + result.ToString();
                        break;
                case "/":
                    result = number1 / number2;
                        CalculateLabel.Text = "Результат: " + result.ToString();
                        break;
            }
            }
        }
    }
}
