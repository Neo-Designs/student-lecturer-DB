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
    public partial class student_registration_form : Form
    {
        public student_registration_form()
        {
            InitializeComponent();
        }

        public string Data { get; set; }
        public student_registration_form(string data)
        {
            InitializeComponent();
            Data = data;
        }


        private void RegistrationButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RegNoComboBox.Text = "";
            FirstNameTxtBox.Text = "";
            LastNameTxtBox.Text = "";
            dateTimePicker.Value = System.DateTime.Now;
            AddressTxtBox.Text = "";
            EmailTxtBox.Text = "";
            MPhoneTxtBox.Text = "";
            HPhoneTxtBox.Text = "";
            ParentNameTxtBox.Text = "";
            ParentNICTxtBox.Text = "";
            ContactNoTxtBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void student_registration_form_Load(object sender, EventArgs e)
        {

        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
