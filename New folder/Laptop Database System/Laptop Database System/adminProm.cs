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
    public partial class adminProm : Form
    {
        Controller controllerObj;

        public adminProm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void adminProm_Load(object sender, EventArgs e)
        {
            prom.DataSource = controllerObj.fillPromoTable();
        }
    }
}
