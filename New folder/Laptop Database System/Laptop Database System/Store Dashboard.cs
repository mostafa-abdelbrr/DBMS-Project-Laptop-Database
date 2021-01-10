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
        string username;
        Controller controllerObj;
        public Store_Dashboard(int userID, int approved, string storeName)
        {
            this.username = storeName;
            currentUserID = userID;
            this.approved = approved;
            InitializeComponent();
            controllerObj = new Controller();
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

        public void Store_Dashboard_Load(object sender, EventArgs e)
        {
            laptop.Refresh();
            laptop.Update();






            welcome.Text = "Welcome, " + username + " !";
            if (approved == 0)
            {
                status.Text = "Awaiting Admin Approval";
                status.ForeColor = Color.Tomato;

                addLaptop.Enabled = false;
                modify.Enabled = false;
                promote.Enabled = false;
                refresh.Enabled = false;
            }

            if (approved == 1)
            {
                status.Text = "Verified By LDBS";
                status.ForeColor = Color.MidnightBlue;

                laptop.DataSource = controllerObj.fillDashStore(controllerObj.getOwner(currentUserID.ToString()));
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
            Form foo = new editStore(this, currentUserID);
            foo.Show();
        }

        private void addLaptop_Click(object sender, EventArgs e)
        {
            Hide();
            Form foo = new addLaptop(this, username, currentUserID);
            foo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form foo = new ViewLaptop("yay");
            //foo.Show();
        }

        private void laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form foo = new AdminEdit(currentUserID);
            foo.Show();
        }

        private void Store_Dashboard_Enter(object sender, EventArgs e)
        {

        }

        private void Store_Dashboard_Shown(object sender, EventArgs e)
        {
            if (approved == 1)
            {
                status.Text = "Verified By LDBS";
                status.ForeColor = Color.MidnightBlue;

                laptop.DataSource = controllerObj.fillDashStore(controllerObj.getOwner(currentUserID.ToString()));
                laptop.Refresh();
                laptop.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form foo = new promotion(controllerObj.getOwner(currentUserID.ToString()));
            foo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (laptop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select A Laptop Row The Table (by clicking on the empty cell on the left side of the row), Then Press View Laptop To View Its Properies");
                return;
            }

            int selectedrowindex = laptop.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = laptop.Rows[selectedrowindex];
            string lapModel = Convert.ToString(selectedRow.Cells["Model"].Value);

            Form foo = new ViewLaptop(lapModel,currentUserID);
            foo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            laptop.DataSource = controllerObj.fillDashStore(controllerObj.getOwner(currentUserID.ToString()));
        }
    }
}
