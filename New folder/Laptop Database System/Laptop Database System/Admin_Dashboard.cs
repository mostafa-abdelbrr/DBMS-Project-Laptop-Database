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
    public partial class Admin_Dashboard : Form
    {
        int id;
        public Admin_Dashboard(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_search c = new check_search();
            c.Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            AddParts a = new AddParts();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEdit a = new AdminEdit(id);
            a.Show();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Stores_To_Approve s = new Stores_To_Approve();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Promote_Laptops p = new Promote_Laptops();
            p.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_Admin a = new Add_Admin();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin_Change_Pass a = new Admin_Change_Pass(this.id);
            a.Show();
        }
    }
}
