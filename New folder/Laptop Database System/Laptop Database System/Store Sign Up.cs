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

    public partial class Store_Sign_Up : Form
    {
        Controller controllerObj;
        Form parent;
        public Store_Sign_Up(Form parent)
        {
            this.parent = parent;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Store_Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void signStore_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
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

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("No spaces allowed ", this, 400, 65, 2000);

            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!char.IsNumber(input))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                tt.Show("Only numbers allowed ", this, 400, 230, 2000);
            }
        }

        private void signUser_Click(object sender, EventArgs e)
        {
            if (user.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your Username", this, 400, 65, 2000);
            }

            if (email.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your Email", this, 400, 20, 2000);
            }

            if (password.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your password", this, 400, 110, 2000);
            }

            if (storename.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your store name", this, 400, 155, 2000);
            }

            if (address.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your store sddress", this, 400, 200, 2000);
            }

            if (phone.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Your store phone number", this, 400, 245, 2000);
            }

            if (phone.TextLength == 0 || address.TextLength == 0 || storename.TextLength == 0 || password.TextLength == 0 || email.TextLength == 0 || user.TextLength == 0)
            {
                validation.Visible = true;
                return;
            }

        }
    }
}
