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
    public partial class promotion : Form
    {
        Controller controllerObj;

        public promotion()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void promotion_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void promotion_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.fillPromoBox("z");
            comboBox1.DisplayMember = "Laptop_Model";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
           if( controllerObj.promote(comboBox1.Text) != 0)
            {
                MessageBox.Show("Thank You, An Admin Will Review Your Request Shortly.");
            }
        }
    }
}
