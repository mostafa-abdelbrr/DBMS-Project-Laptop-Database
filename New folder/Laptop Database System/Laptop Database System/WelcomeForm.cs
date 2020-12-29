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
        Controller controllerObj = new Controller();
        public WelcomeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = controllerObj.getall();
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
            Search search = new Search();
            this.Hide();
            search.Show();
        }

        private void searchlaptopbutton_Click(object sender, EventArgs e)
        {
            if (laptopnametxt.Text == "")
            {
                MessageBox.Show("Please enter a laptop name to search for");
            }
            else
            {
                dataGridView1.DataSource = controllerObj.searchbylaptopname(laptopnametxt.Text);
            }
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This should be removed and code should redirect to a dashboard form");
        }
    }
}
