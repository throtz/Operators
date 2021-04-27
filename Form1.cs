using System;
using System.Windows.Forms;

namespace Operators
{
    public partial class Operators : Form
    {
        public Operators()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox.Items.AddRange(new string[] { "+", "-", "*", "/", "%", ">", "<", "=", ">=", "<=" });
        }
        private void ButtonCheck_Click_1(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            
            Run(a, b);
        }
        private void Run(float a, float b)
        {
            switch (comboBox.SelectedItem.ToString())
            {
                case "+":
                    MessageBox.Show($"Sum of the numbers entered is: {(float)a + b}");
                    break;
                case "-":
                    MessageBox.Show($"Subtraction of the numbers entered is: {(float)a - b}");
                    break;
                case "*":
                    MessageBox.Show($"Multiplication of the numbers entered is: {(float)a * b}");
                    break;
                case "/":
                    MessageBox.Show($"Division of the numbers entered is: {(float)a / b}");
                    break;
                case "%":
                    MessageBox.Show($"Modulo the two numbers is: {(float)a % b}");
                    break;
                case ">":
                    MessageBox.Show("First number is bigger than the secound one " + (a > b));
                    break;
                case "<":
                    MessageBox.Show("First number is smaller than the secound one " + (a < b));
                    break;
                case "=":
                    MessageBox.Show("Numbers are equal: " + (a == b));
                    break;
                case ">=":
                    MessageBox.Show("First number is bigger or equal to number two " + (a >= b));
                    break;
                case "<=":
                    MessageBox.Show("First number is smaller or equal to number two " + (a <= b));
                    break;
                default:
                    MessageBox.Show("Illegal operation.");
                    break;
            }
        }
    }
}
