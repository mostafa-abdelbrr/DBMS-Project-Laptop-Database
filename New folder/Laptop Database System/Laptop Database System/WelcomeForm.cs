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

    public partial class WelcomeForm : Form
    {
        Controller controllerObj;
        String role = "";
        String ID = "";
        public WelcomeForm(string userrole = "Guest",string userid = "")
        {
            InitializeComponent();
            ID = userid;
            role = userrole;
            if (role != "Guest")
            {
                loginbutton.Hide();
                signupbutton.Hide();
                Search s = new Search();
                this.Hide();
                s.Show();
            }
            else
            {

            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up(this);
            signup.Show();
            this.Hide();

        }

        private void viewallbutton_Click(object sender, EventArgs e)
        {
            ViewAll view = new ViewAll();
            view.Show();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Form foo = new Search();
            Hide();
            foo.Show();
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                System.Environment.Exit(0);
        }
    }
}
