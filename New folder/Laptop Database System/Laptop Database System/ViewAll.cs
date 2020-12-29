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
    public partial class ViewAll : Form
    {
        Controller controllerObj = new Controller();
        public ViewAll()
        {
            InitializeComponent();
            DataTable dt = controllerObj.getall();
            dataGridView1.DataSource = dt;
        }
    }
}
