using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skills_international__udeshi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }

            // Set focus on the first textbox
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "Admin" && password == "Skills@123")
            {
              
                 MainMenu obj = new MainMenu();
                string data = "login";
                MainMenu form2 = new MainMenu(data);
                form2.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login credentials, Please check Username and Password and try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {

            }
            else
                Application.Exit();
        }
    }
    }

