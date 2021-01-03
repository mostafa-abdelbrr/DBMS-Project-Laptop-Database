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

    public partial class Login : Form
    {
        Controller controllerObj;
        public Login()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void guest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("this button should redirect the guest to the landing page, and this message box should be removed after implementation is complete");
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your Username", this, 200, 21, 2000);
            }
            if (password.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your Password", this, 200, 50, 2000);
            }
            if (username.TextLength == 0 || password.TextLength == 0)
            {
                return;
            }

            int userId = -1;
            userId = controllerObj.checkUser(username.Text, password.Text);

            string user = "n/a";

            string role = "n/a";
            controllerObj.getUserDataFromID(userId, ref user, ref role);

            if(userId == -1)
            {
                incorrect.Visible = true;
            } else
            {
                string message = user + " " + role + " " + userId;
                MessageBox.Show(message);

                if (role == "Store")
                {
                    Hide();
                    Form foo = new Store_Dashboard(userId, true);
                    foo.Show();
                } else if (role == "Store_WAITING_APPROVAL")
                {
                    Form foo = new Store_Dashboard(userId, false);
                    foo.Show();
                }

            }
           

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form foo = new Sign_Up(this);
            foo.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("No spaces allowed ", this, 200, 20, 2000);

            }
        }
    }
}
