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
    public partial class AddParts : Form
    {
        Controller controllerObj;
        public AddParts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.addGPU(T1.Text, T2.Text, T3.Text, T4.Text);
            if (result == 1)
            {
                MessageBox.Show("insertion successful");
            }
            else
            {
                MessageBox.Show("insertion failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.addCPU(T5.Text, T6.Text);
            if (result == 1)
            {
                MessageBox.Show("insertion successful");
            }
            else
            {
                MessageBox.Show("insertion failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.addOS(T7.Text, T8.Text, T9.Text);
            if (result == 1)
            {
                MessageBox.Show("insertion successful");
            }
            else
            {
                MessageBox.Show("insertion failed");
            }
        }
    }
}
