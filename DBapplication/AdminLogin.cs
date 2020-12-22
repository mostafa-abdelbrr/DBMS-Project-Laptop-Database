using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AdminLogin : Form
    {
        Form MyParent;
        public AdminLogin(Form p)
        {
            InitializeComponent();
            MyParent = p;
            //You can hide parent to go back to later
            MyParent.Hide();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Passowrd_textBox.Text.ToString() == "1234")//Password can be saved in the DB encrypted rather than being hardcoded.
            {
                //Login successful
                Provided_Functionalities f = new Provided_Functionalities(1,this);
                f.Show();
                
            }
            else
            {
                MessageBox.Show("Password isn't correct, Please Try Again");
            }
           
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }
    }
}
