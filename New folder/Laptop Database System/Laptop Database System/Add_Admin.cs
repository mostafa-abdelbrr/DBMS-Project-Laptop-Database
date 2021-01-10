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
    
    public partial class Add_Admin : Form
    {
        Controller controllerObj;
        validations validator = new validations();
        public Add_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ERR.Visible = false;
            controllerObj = new Controller();
            
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
            if (controllerObj.checkUser(user.Text) != -1 && controllerObj.checkMail(email.Text) == -1)
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

            if (!validator.email(email.Text))
            {
                ERR.Visible = true;
                ERR.Text = "Please Enter A Valid Email";
                return;
            }
            controllerObj.AddAdmin(email.Text,user.Text,password.Text);
            
        }

        private void Add_Admin_Load(object sender, EventArgs e)
        {
            ERR.Visible = false;
        }
    }
}
