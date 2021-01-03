﻿using System;
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


                tt.Show("No spaces allowed ", this, 400, 20, 2000);

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

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Back))
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

            if (phone.TextLength < 7 || phone.TextLength > 15)
            {
                validation.Visible = true;
                validation.Text = "Please Enter A Valid Phone Number";
                return;
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

            if (controllerObj.checkUser(user.Text) != -1 && controllerObj.checkMail(email.Text) == -1)
            {
                validation.Visible = true;
                validation.Text = "Username Already Exists";
                return;
            }
            if (controllerObj.checkUser(user.Text) == -1 && controllerObj.checkMail(email.Text) != -1)
            {
                validation.Visible = true;
                validation.Text = "Email Already Exists";
                return;
            }
            if (controllerObj.checkUser(user.Text) != -1 && controllerObj.checkMail(email.Text) != -1)
            {
                validation.Visible = true;
                validation.Text = "Email And Username Already Exist";
                return;
            }

            if (phone.TextLength == 0 || address.TextLength == 0 || storename.TextLength == 0 || password.TextLength == 0 || email.TextLength == 0 || user.TextLength == 0)
            {
                validation.Text = "Please Enter All Data";
                validation.Visible = true;
                return;
            }

            if (!(email.Text.Contains('@') && email.Text.Contains('.') && email.Text.IndexOf('@') < email.Text.IndexOf('.', email.Text.IndexOf('@'))))
            {
                validation.Visible = true;
                validation.Text = "Please Enter A Valid Email";
                return;
            }
            if (controllerObj.signUp(email.Text, user.Text, password.Text, consent.Checked, "Store") == 0)
            {
                MessageBox.Show("Problem while adding to S_Users");
            }

            if (controllerObj.addStore(storename.Text, long.Parse(phone.Text), address.Text) == 0)
            {
                MessageBox.Show("Problem while adding to store");
            }

            if (controllerObj.addStoreOwner(storename.Text, controllerObj.checkUser(user.Text)) == 0)
            {
                MessageBox.Show("Problem while adding to owner");
            }


        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
