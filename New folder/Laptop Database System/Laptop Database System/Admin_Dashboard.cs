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
        public Admin_Dashboard()
        {
            InitializeComponent();
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
            AdminEdit a = new AdminEdit();
            a.Show();
        }
    }
}
