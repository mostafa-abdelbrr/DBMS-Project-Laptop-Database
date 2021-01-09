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
    public partial class Stores_To_Approve : Form
    {
        Controller controllerObj;
        public Stores_To_Approve()
        {
            InitializeComponent();
        }

        private void Stores_To_Approve_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.SelectStorOwnersTobeApproved();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (dataGridView1.Rows.Count <= 1)
            {
                return; 
            }
            for (int i = 0; i < dataGridView1.SelectedRows.Count ; i++)
            {
                controllerObj.ApproveStore(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());   
            }
            dataGridView1.DataSource = controllerObj.SelectStorOwnersTobeApproved();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (dataGridView1.Rows.Count <= 1)
            {
                return;
            }
            for (int i = 0; i < dataGridView1.SelectedRows.Count ; i++)
            {
                controllerObj.DenyStore(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
            }
            dataGridView1.DataSource = controllerObj.SelectStorOwnersTobeApproved();
        }
    }
}
