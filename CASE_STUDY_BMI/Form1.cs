using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASE_STUDY_BMI
{
    public partial class Form1 : Form
    {

        string username;
        string password;

        
        public Form1()
        {
            InitializeComponent();
            passText.PasswordChar = '*';
            regPass.PasswordChar = '*';
            regUser.MaxLength = 7;
            userText.MaxLength = 7;
            incInfo.Visible = false;
            username = "";
            password = "";

    }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userText.Text != username || passText.Text != password)
            {
                incInfo.Visible = true;
            }
            else
            {
                incInfo.Visible = false;
                MessageBox.Show("Login Successful");
                Form1 f1 = new Form1();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            password = regPass.Text;
            username = regUser.Text;
            MessageBox.Show("Registration Successful!");
            MessageBox.Show("You may login now!");
            regUser.Text = "";
            regPass.Text = "";

        }
    }

}
