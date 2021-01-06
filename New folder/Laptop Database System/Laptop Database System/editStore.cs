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
    public partial class editStore : Form
    {
        Form parent;
        Controller controllerObj;
        validations validator;
        int userID;
        public editStore(Form parent, int id)
        {
            controllerObj = new Controller();
            validator = new validations();
            InitializeComponent();
            this.parent = parent;
            userID = id;
        }

        private void editStore_Load(object sender, EventArgs e)
        {
            string userName = "";
            string role = "";
            controllerObj.getUserDataFromID(userID,ref userName,ref role);
            email.Text = controllerObj.getEmail(userID);
            user.Text = userName;

            password.Text = controllerObj.getPassword(userID);
            storename.Text = controllerObj.getStoreName(userID);
            address.Text = controllerObj.getStoreAddress(userID);
            phone.Text = controllerObj.getStoreNumber(userID).ToString();
            consent.Checked = controllerObj.getConsent(userID);
        }

        private void editStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void signStore_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void signUser_Click(object sender, EventArgs e)
        {
            int con = 0;
            if (consent.Checked)
            {
                con = 1;
            }

            if (!validator.email(email.Text))
            {
                validation.Text = "Please Enter A Valid Email";
                validation.Visible = true;
                return;
            }

            if (controllerObj.editUser(userID, user.Text, password.Text, email.Text, con) == 0)
            {
                MessageBox.Show("An Error Happened While Updating Your Data.");
            } else
            {
                MessageBox.Show("Your Profile Has Been Updated Successfully. Please Re-Login To See The New Changes.");
                Hide();
                parent.Show();
            }
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
    }
}
