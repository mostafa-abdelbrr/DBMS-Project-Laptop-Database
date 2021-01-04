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
    public partial class Store_Dashboard : Form
    {
        public int currentUserID = -1;
        int approved = 0;
        string storeName;
        public Store_Dashboard(int userID,int approved,string storeName)
        {
            this.storeName = storeName;
            currentUserID = userID;
            this.approved = approved;
            InitializeComponent();
        }

        private void Store_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            Hide();
            Form foo = new Login();
            foo.Show();
        }

        private void Store_Dashboard_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome, " + storeName + " !";
            if(approved == 0)
            {
                status.Text = "Awaiting Admin Approval";
                status.ForeColor = Color.Tomato;
            }

            if (approved == 1)
            {
                status.Text = "Verified By LDBS";
                status.ForeColor = Color.MidnightBlue;
            }


        }

        private void viewAll_Click(object sender, EventArgs e)
        {
           
            Form foo = new ViewAll();
            foo.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void editAcc_Click(object sender, EventArgs e)
        {
            Hide();
            Form foo = new editStore(this,currentUserID);
            foo.Show();
        }
    }
}
