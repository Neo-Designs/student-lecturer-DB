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
    public partial class lecturer_registration_form : Form
    {
        public lecturer_registration_form()
        {
            InitializeComponent();
        }

        public string Data { get; set; }
        public lecturer_registration_form(string data)
        {
            InitializeComponent();
            Data = data;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void RegistrationButton2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            RegNoComboBox2.Text = "";
            FirstNameTxtBox2.Text = "";
            LastNameTxtBox2.Text = "";
            dateTimePicker2.Value = System.DateTime.Now;
            AddressTxtBox2.Text = "";
            EmailTxtBox2.Text = "";
            MPhoneTxtBox2.Text = "";
            HPhoneTxtBox2.Text = "";
            ParentNameTxtBox2.Text = "";
            ParentNICTxtBox2.Text = "";
            ContactNoTxtBox2.Text = "";
        }

        private void DeleteButton2_Click(object sender, EventArgs e)
        {

        }

        private void ExitLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
