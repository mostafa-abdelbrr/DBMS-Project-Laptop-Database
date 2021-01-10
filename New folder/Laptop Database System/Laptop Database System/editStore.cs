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
        long oldPhone;
        string oldName;
        string oldAddress;
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

            oldAddress = address.Text;
            oldName = storename.Text;
            oldPhone = Convert.ToInt64( phone.Text);
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
            bool emptyChecker = false;
            int con = 0;
            if (consent.Checked)
            {
                con = 1;
            }

            if (email.TextLength == 0)
            {
                emptyChecker = true;

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
                emptyChecker = true;

                tt.Show("Please Enter Your password", this, 400, 110, 2000);
            }
            if (storename.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                emptyChecker = true;
                tt.Show("Please Enter Your store name", this, 400, 155, 2000);
            }

            if (address.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                emptyChecker = true;
                tt.Show("Please Enter Your store sddress", this, 400, 200, 2000);
            }

            if (phone.Text == "")
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                emptyChecker = true;
                tt.Show("Please Enter Your store phone number", this, 400, 245, 2000);
                return;

            }

            if (controllerObj.checkMail(email.Text) != -1 && controllerObj.checkMail(email.Text) != userID)
            {
                validation.Visible = true;
                validation.Text = "Email Already Exists";
                return;
            }

            if (controllerObj.checkStorePhone(Convert.ToInt64(phone.Text)) != "N/A" && controllerObj.checkStorePhone(Convert.ToInt64(phone.Text)) == oldPhone.ToString() )
            {
                validation.Visible = true;
                validation.Text = "Phone Number Already Exists";
                return;
            }

            if (controllerObj.checkStoreName(storename.Text) != "N/A" && controllerObj.checkStoreName(storename.Text) != oldName)
            {
                validation.Visible = true;
                validation.Text = "Store Name Exists";
                return;
            }

            if (controllerObj.checkStoreAddress(address.Text) != "N/A" && controllerObj.checkStoreAddress(address.Text) == oldAddress)
            {
                validation.Visible = true;
                validation.Text = "Store Address Exists";
                return;
            }

            

            if (!validator.email(email.Text))
            {
                validation.Text = "Please Enter A Valid Email";
                validation.Visible = true;
                return;
            }

            if (phone.TextLength < 7 || phone.TextLength > 15)
            {
                validation.Visible = true;
                validation.Text = "Please Enter A Valid Phone Number";
                return;
            }

            if (emptyChecker)
            {
                validation.Text = "Please Enter All Data";
                validation.Visible = true;
            }

            if (controllerObj.editUser(userID, user.Text, password.Text, email.Text, con) == 0 && controllerObj.editStore(storename.Text, phone.Text, address.Text, oldName)== 0)
            {
                MessageBox.Show("An Error Happened While Updating Your Data.");
            } else
            {
                controllerObj.editStore(storename.Text, phone.Text, address.Text, oldName) ;
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
