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
    public partial class Admin_Change_Pass : Form
    {
        Controller controllerObj;
        int id;
        public Admin_Change_Pass(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_Change_Pass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (password.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;


                tt.Show("Please Enter Password", this, 200, 110, 2000);
                return;
            }
           int result= controllerObj.AdminChangePass(id.ToString(), password.Text);
            if (result == 1)
            {
                password.Text = "";
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Password not changed");
            }
        }
        
    }
}
