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
        int currentUserID = -1;
        bool approved = false;
        public Store_Dashboard(int userID,bool approved)
        {
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
    }
}
