using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Database_System
{
    public partial class Sign_Up : Form
    {
        Controller controllerObj;
        Form parent;
        public Sign_Up(Form parent)
        {
            controllerObj = new Controller();
            this.parent = parent;
            InitializeComponent();
        }

        private void signUser_Click(object sender, EventArgs e)
        {
            if (user.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Username", this, 200, 70, 2000);

            }

            if (password.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Password", this, 200, 110, 2000);

            }

            if (email.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Email", this, 200, 30, 2000);

            }

            if (user.TextLength == 0 || password.TextLength == 0 || email.TextLength == 0)
            {
                return;
            }
            if(controllerObj.checkUser(user.Text) != -1 && controllerObj.checkMail(email.Text) == -1)
            {
                ERR.Visible = true;
                ERR.Text = "Username Already Exists";
                return;
            }
            if (controllerObj.checkUser(user.Text) == -1 && controllerObj.checkMail(email.Text) != -1)
            {
                ERR.Visible = true;
                ERR.Text = "Email Already Exists";
                return;
            }
            if (controllerObj.checkUser(user.Text) != -1 && controllerObj.checkMail(email.Text) != -1)
            {
                ERR.Visible = true;
                ERR.Text = "Email And Username Already Exist";
                return;
            }

            if (controllerObj.signUp(email.Text, user.Text, password.Text, consent.Checked, "User") == 1)
            {
                MessageBox.Show("Welcome To LDBS, " + user.Text + ".");
            }
            else
            {
                MessageBox.Show("An Error has occured while creating a new account.");
            }
        }

        private void Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void user_TextChanged(object sender, EventArgs e)
        {


        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("No spaces allowed ", this, 200, 70, 2000);

            }
        }

        private void user_Validating(object sender, CancelEventArgs e)
        {

        }

        private void signStore_Click(object sender, EventArgs e)
        {
            Hide();
            Form foo = new Store_Sign_Up(this);
            foo.Show();
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("No spaces allowed ", this, 200, 30, 2000);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            Hide();
        }
    }
}
