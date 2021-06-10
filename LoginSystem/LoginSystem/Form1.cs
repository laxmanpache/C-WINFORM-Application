using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("dfdsfds");
            SqlConnection con = new SqlConnection(@"integrated security=true; data source=DESKTOP-RB3HGFJ\SQLEXPRESS;initial catalog=Traning");
            SqlDataAdapter ad = new SqlDataAdapter("Select Count(*) from EMPLOY where ENO='"+ textBox1.Text+"'and ENAME= '"+ textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Enter Correct Uname And Pass");
            }

            
        }
    }
}
