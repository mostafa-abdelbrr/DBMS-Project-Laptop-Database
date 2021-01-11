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
    public partial class Search : Form
    {
        Controller controllerObj = new Controller();
        string ID = "";

        public Search(string userid = "Guest",string user = "")
        {
            InitializeComponent();
            ID = userid;
            laptop1combobox.DataSource = controllerObj.getlaptop();
            laptop2combobox.DataSource = controllerObj.getlaptop();
            laptop1combobox.DisplayMember = "Name";
            laptop2combobox.DisplayMember = "Name";
            if(userid == "new" && user!="")
            {
                ID = controllerObj.checkUser(user).ToString();
                string username = user;
                usernametxt.Text = username;
            }
            else if (userid == "Guest")
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
            else
            {
                string username = user;
                string role = "";
                controllerObj.getUserDataFromID(int.Parse(ID), ref username, ref role);
                usernametxt.Text = username;
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (laptopnametxt.Text == "" && ktypetxt.Text == "" && klighttxt.Text == "" &&
                pbrandtxt.Text == "" && pmodeltxt.Text == "" && rsizetxt.Text == "" &&
                rddrtxt.Text == "" && gpumodeltxt.Text == "" && ostxt.Text == "" &&
                ssizetxt.Text == "" && smanufacturertxt.Text == "" && sctypetxt.Text == "" &&
                screstxt.Text == "" && scsizetxt.Text == "" && hddmanufacturertxt.Text == "" &&
                hddsizetxt.Text == "" && promotedtxt.Text == "" && osmanufacturertxt.Text == "" && osversiontxt.Text == "")
            {
                MessageBox.Show("Please enter at least one search criteria to filter by!");
            }
            {
               dataGridView1.DataSource = controllerObj.getlaptop(ID, laptopnametxt.Text, ktypetxt.Text, klighttxt.Text,
                                                  pbrandtxt.Text, pmodeltxt.Text, rsizetxt.Text,
                                                  rddrtxt.Text, gpumodeltxt.Text, osmanufacturertxt.Text, ostxt.Text, osversiontxt.Text,
                                                  ssizetxt.Text, smanufacturertxt.Text,hddsizetxt.Text,hddmanufacturertxt.Text,
                                                  sctypetxt.Text, screstxt.Text, scsizetxt.Text,promotedtxt.Text);
            }
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ID == "Guest")
            {
                Form w = new WelcomeForm();
                this.Hide();
                w.Show();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getlaptop();
            dataGridView2.DataSource = dt;
        }

        private void searchbynamebtn_Click(object sender, EventArgs e)
        {
            if (lnametxt.Text=="")
            {
                MessageBox.Show("Please enter a laptop name to search for!");
            }
            else
            {
                dataGridView2.DataSource = controllerObj.getlaptop(lnametxt.Text);
            }
        }

        private void viewpromotedbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = controllerObj.getpromoted();
        }

        private void comparebtn_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = controllerObj.comparelaptops(laptop1combobox.Text, laptop2combobox.Text);
        }

        private void doubleclicktoview(object sender, DataGridViewCellEventArgs e)
        {
            Form v = new ViewLaptop(dataGridView2.Rows[e.RowIndex].Cells["Name"].ToString(), int.Parse(ID));
        }

        private void doubleclicktoview2(object sender, DataGridViewCellEventArgs e)
        {
            Form v = new ViewLaptop(dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString(), int.Parse(ID));
        }

        private void doubleclicktoview3(object sender, DataGridViewCellEventArgs e)
        {
            Form v = new ViewLaptop(dataGridView3.Rows[e.RowIndex].Cells["Name"].Value.ToString(), int.Parse(ID));
        }

        private void changepasswdbtn_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (newpasstxt.Text == "" || confirmpasstxt.Text=="" || oldpasstxt.Text=="")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            if (confirmpasstxt.Text == newpasstxt.Text)
            {
                int result = controllerObj.updatepassword(oldpasstxt.Text, newpasstxt.Text, ID);
                if (result == 1)
                {
                    newpasstxt.Text = "";
                    MessageBox.Show("Password Changed!");
                    return;
                }
                else
                {
                    MessageBox.Show("Password not changed, wrong old password.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("New and confirmation passwords don't match!");
                return;
            }
        }

        private void changemailbtn_Click(object sender, EventArgs e)
        {
            if(newemailtxt.Text=="")
            {
                MessageBox.Show("Please enter value for new email!");
                return;
            }
            else
            {
                if (controllerObj.updateemail(newemailtxt.Text,ID)==1)
                {
                    MessageBox.Show("Email updated succefully!");
                    return;
                }
                else
                {
                    MessageBox.Show("Email failed to update");
                    return;
                }
            }
        }

        private void changeconsentbtn_Click(object sender, EventArgs e)
        {
            if (consentcombobox.Text == "")
            {
                MessageBox.Show("Please enter your choice for data sharing!");
                return;
            }
            else
            {
                if (controllerObj.updateconsent(consentcombobox.Text, ID) == 1)
                {
                    MessageBox.Show("Consent updated successfully!");
                    return;
                }
                else
                {
                    MessageBox.Show("Consent failed to update");
                    return;
                }
            }

        }
    }
}
