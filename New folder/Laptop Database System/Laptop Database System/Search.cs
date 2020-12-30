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
            if (laptopnametxt.Text=="" && ktypetxt.Text=="" && klighttxt.Text == "" && 
                pbrandtxt.Text == "" && pmodeltxt.Text == "" && rsizetxt.Text == "" && 
                rddrtxt.Text == "" && gpumodeltxt.Text == "" && ostxt.Text == "" && 
                ssizetxt.Text == "" && smanufacturertxt.Text == "" && sctypetxt.Text == "" && 
                screstxt.Text == "" && scsizetxt.Text == "")
            {
                MessageBox.Show("Please enter at least one search criteria to filter by!");
            }
            {
               dataGridView1.DataSource = controllerObj.getlaptopbyfeatures(laptopnametxt.Text, ktypetxt.Text, klighttxt.Text,
                                                  pbrandtxt.Text, pmodeltxt.Text, rsizetxt.Text,
                                                  rddrtxt.Text, gpumodeltxt.Text, ostxt.Text,
                                                  ssizetxt.Text, smanufacturertxt.Text, sctypetxt.Text,
                                                  screstxt.Text, scsizetxt.Text);
            }
        }
    }
}
