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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public string Data { get; set; }
        public MainMenu(string data)
        {
            InitializeComponent();
            Data = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "student registration form";
            student_registration_form form2 = new student_registration_form(data);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "student registration form";
            lecturer_registration_form form2 = new lecturer_registration_form(data);
            form2.Show();
        }
    }
}
