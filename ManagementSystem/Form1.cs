using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Homepg hm = new Homepg();
                Form1 login = new Form1();
                string admin_username = "123";
                string username = textBox1.Text;
                string admin_password = "123";
                string password = textBox2.Text;
                if (admin_username == username)
                {
                    if (admin_password == password)
                    {
                        hm.Show();
                        login.Hide();
                    }
                    else
                        throw new Exception("Incorrect password");
                }
                else
                    throw new Exception("Incorrect Username");
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}
