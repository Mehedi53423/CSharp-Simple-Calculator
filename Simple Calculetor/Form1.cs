using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculetor
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double addResult = number1 + number2;
            MessageBox.Show("The Sum Is : "+addResult);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double addResult = number1 - number2;
            MessageBox.Show("The Subtraction Is : " + addResult);
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double addResult = number1 * number2;
            MessageBox.Show("The Multiplication Is : " + addResult);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double addResult = number1 / number2;
            MessageBox.Show("The Divition Is : " + addResult);
        }
    }
}
