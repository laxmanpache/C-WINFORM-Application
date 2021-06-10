using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinFOrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please fill both Field");
            }
            else
            { 
                    var num1 = Convert.ToDouble(textBox1.Text);
                    var num2 = Convert.ToDouble(textBox2.Text);
                    double result = num1 + num2;
                    label4.Text = "Addition : " + result.ToString();
                    label4.Visible = true;
            }
           // MessageBox.Show(result.ToString(),num1.ToString()+" + " + num2.ToString());
        }

        private void Subb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please fill both Field");
            }
            else
            {
                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);
                double result = num1 - num2;
                label4.Text = "Subtraction  : " + result.ToString();
                label4.Visible = true;
            }
            // MessageBox.Show(result.ToString(), num1.ToString() + " - " + num2.ToString());
        }

        private void Mulb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please fill both Field");
            }
            else
            {
                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);
                double result = num1 * num2;
                label4.Text = "Multiplication : " + result.ToString();
                label4.Visible = true;
            }
            // MessageBox.Show(result.ToString(), num1.ToString() + " * " + num2.ToString());
        }

        private void Divb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please fill both Field");
            }
            else
            {

                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);
                double result = num1 / num2;
                label4.Text = "Division : " + result.ToString();
                label4.Visible = true;
            }
            //  MessageBox.Show(result.ToString(), num1.ToString() + " / " + num2.ToString());
        }
    }
}
