using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FruitListBOX.Items.Add(textBox1.Text);
            Console.WriteLine(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count=FruitListBOX.Items.Count;
            MessageBox.Show("There are "+count.ToString()+" no of Item");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitListBOX.Sorted=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FruitListBOX.Items.Remove(FruitListBOX.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FruitListBOX.Items.Clear();
        }
    }
}
