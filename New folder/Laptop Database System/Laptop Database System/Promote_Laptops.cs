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
    public partial class Promote_Laptops : Form
    {
        Controller controllerObj;
        public Promote_Laptops()
        {
            InitializeComponent();
        }

        private void Promote_Laptops_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.SelectLapsToPromote();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                controllerObj.promoteLaptops(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
            }
            dataGridView1.DataSource = controllerObj.SelectLapsToPromote();
        }
    }
}
