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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            
            AdminLogin a = new AdminLogin(this);
            a.Show();
             
        }

        private void OthersButton_Click(object sender, EventArgs e)
        {
            Provided_Functionalities f = new Provided_Functionalities(0, this);//for admin
            f.Show();
        }

        private void ValidationButton_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder() ;
            Object data = ValidationClass.isPositiveInteger(textBox1.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
            }
            else
            {
                int x = (int)data;
                MessageBox.Show("The entered data is " + x);
            }
        }
    }
}
