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
    
    public partial class AdminEdit : Form
    {
        Controller controllerObj;
        public AdminEdit()
        {
            InitializeComponent();
        }

        private void AdminEdit_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            EditLTdg.DataSource = controllerObj.SelectEdits();
            EditLTdg.Columns[0].ReadOnly = true;
            EditLTdg.Columns[7].ReadOnly = true;
        }

        private void ConfirmEdit_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
            {
                int result = controllerObj.EditLaps(EditLTdg.Rows[i].Cells[0].Value.ToString(), EditLTdg.Rows[i].Cells[1].Value.ToString(), EditLTdg.Rows[i].Cells[2].Value.ToString(), EditLTdg.Rows[i].Cells[3].Value.ToString(), EditLTdg.Rows[i].Cells[4].Value.ToString(), EditLTdg.Rows[i].Cells[5].Value.ToString(), EditLTdg.Rows[i].Cells[6].Value.ToString(), EditLTdg.Rows[i].Cells[7].Value.ToString(), EditLTdg.Rows[i].Cells[8].Value.ToString(), EditLTdg.Rows[i].Cells[9].Value.ToString(), EditLTdg.Rows[i].Cells[10].Value.ToString(), EditLTdg.Rows[i].Cells[11].Value.ToString(), EditLTdg.Rows[i].Cells[12].Value.ToString(), EditLTdg.Rows[i].Cells[13].Value.ToString(), EditLTdg.Rows[i].Cells[14].Value.ToString(), EditLTdg.Rows[i].Cells[15].Value.ToString(), EditLTdg.Rows[i].Cells[16].Value.ToString(), EditLTdg.Rows[i].Cells[17].Value.ToString(), EditLTdg.Rows[i].Cells[18].Value.ToString());
            }

            EditLTdg.DataSource = controllerObj.SelectEdits();
            EditLTdg.Columns[0].ReadOnly = true;
            EditLTdg.Columns[7].ReadOnly = true;
        }
    }
}
