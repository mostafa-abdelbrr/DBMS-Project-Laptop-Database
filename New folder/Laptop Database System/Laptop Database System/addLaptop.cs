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
    public partial class addLaptop : Form
    {
        Form parent;
        Controller controllerObj;
        public addLaptop(Form parent)
        {
            this.parent = parent;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void addLaptop_Load(object sender, EventArgs e)
        {
            maker.DataSource = controllerObj.fillManufacturerComboBox();
            maker.DisplayMember = "Name";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addLaptop_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void dbg_ADDLAPTOP_Click(object sender, EventArgs e)
        {

            if (lapName.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point lapNameLoc = lapName.Location;

                tt.Show("Please Enter Laptop Name", this, lapNameLoc, 2000);
                
            }

            if (model.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point modelLoc = model.Location;

                tt.Show("Please Enter Laptop Model Number", this, modelLoc, 2000);
                return;
            }

            if ( controllerObj.addToLaptop(model.Text, lapName.Text, releaseDate.Value.ToShortDateString()) == 0)
            {
                MessageBox.Show("3awa2");
            } else
            {
                MessageBox.Show("gg");
            }
               

                   
                
            
            
               
            
        }

        private void lapName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
