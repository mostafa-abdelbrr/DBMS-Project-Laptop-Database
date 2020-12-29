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

        public Search()
        {
            InitializeComponent();
            DataTable dt = controllerObj.getramsize();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember="Size";
            comboBox1.Text = "00";
            //comboBox1.Items.Add("Select size");
            //comboBox1.SelectedItem = "Select Size";
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
