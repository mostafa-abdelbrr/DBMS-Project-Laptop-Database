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
        string role; // 34an nefara2 been store aw admin
        int id;
        string username;
        //public AdminEdit(int id);
        string[] GPUomn,CPUmn,OSn,OSman,OSv;

        public AdminEdit(int id)
        {
            InitializeComponent();
            this.id = id;
            role = "";
            username = "";
        }

        private void AdminEdit_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            controllerObj.getUserDataFromID(id,ref username,ref role);

            comboBox1.SelectedIndex = 0;

            if (role == "Admin")
            {

              // EditLTdg.DataSource = controllerObj.SelectEdits();
                  EditLTdg.DataSource = controllerObj.SelectEdits();
                if (EditLTdg.Rows.Count > 1)
                {
                    EditLTdg.Columns[0].ReadOnly = true;
                        EditLTdg.Columns[3].ReadOnly = true;
                        EditLTdg.Columns[11].ReadOnly = true;
                        EditLTdg.Columns[12].ReadOnly = true;
                        EditLTdg.Columns[13].ReadOnly = true;
                        EditLTdg.Columns[4].ReadOnly = true;
                        EditLTdg.Columns[7].ReadOnly = true;
                }
                
            } else if (role == "Store")
            {
                comboBox1.Visible = false;
                label3.Visible = false;
                label1.Text = "Press DEL to Delete";
                EditLTdg.DataSource = controllerObj.SelectEditsStore(controllerObj.getOwner(id.ToString()));
                 if (EditLTdg.Rows.Count > 1)
            {
                EditLTdg.Columns[0].ReadOnly = true;
                EditLTdg.Columns[7].ReadOnly = true;
            }
            }
           // EditLTdg.Columns[0].ReadOnly = true;
           // EditLTdg.Columns[7].ReadOnly = true;
        }

        private void ConfirmEdit_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {

                    case "Laptop":

                    if (EditLTdg.Rows.Count <= 1)
                    {
                        return;
                    }

                    controllerObj = new Controller();
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        int result = controllerObj.EditLaps(EditLTdg.Rows[i].Cells[0].Value.ToString(), EditLTdg.Rows[i].Cells[1].Value.ToString(), EditLTdg.Rows[i].Cells[2].Value.ToString(), EditLTdg.Rows[i].Cells[3].Value.ToString(), EditLTdg.Rows[i].Cells[4].Value.ToString(), EditLTdg.Rows[i].Cells[5].Value.ToString(), EditLTdg.Rows[i].Cells[6].Value.ToString(), EditLTdg.Rows[i].Cells[7].Value.ToString(), EditLTdg.Rows[i].Cells[8].Value.ToString(), EditLTdg.Rows[i].Cells[9].Value.ToString(), EditLTdg.Rows[i].Cells[10].Value.ToString(), EditLTdg.Rows[i].Cells[11].Value.ToString(), EditLTdg.Rows[i].Cells[12].Value.ToString(), EditLTdg.Rows[i].Cells[13].Value.ToString(), EditLTdg.Rows[i].Cells[14].Value.ToString(), EditLTdg.Rows[i].Cells[15].Value.ToString(), EditLTdg.Rows[i].Cells[16].Value.ToString(), EditLTdg.Rows[i].Cells[17].Value.ToString(), EditLTdg.Rows[i].Cells[18].Value.ToString(), EditLTdg.Rows[i].Cells[19].Value.ToString(), EditLTdg.Rows[i].Cells[20].Value.ToString(), EditLTdg.Rows[i].Cells[21].Value.ToString(), EditLTdg.Rows[i].Cells[22].Value.ToString());
                       // MessageBox.Show(result.ToString());
                    }
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectEdits();
                    EditLTdg.Columns[0].ReadOnly = true;
                    EditLTdg.Columns[3].ReadOnly = true;
                    EditLTdg.Columns[4].ReadOnly = true;
                    EditLTdg.Columns[11].ReadOnly = true;
                    EditLTdg.Columns[12].ReadOnly = true;
                    EditLTdg.Columns[13].ReadOnly = true;
                    EditLTdg.Columns[7].ReadOnly = true;
                    break;
                case "GPU":


                    if (EditLTdg.Rows.Count <= 1)
                    {
                        return;
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        controllerObj.EditGpu(GPUomn[i], EditLTdg.Rows[i].Cells[0].Value.ToString(), EditLTdg.Rows[i].Cells[1].Value.ToString(), EditLTdg.Rows[i].Cells[2].Value.ToString(), EditLTdg.Rows[i].Cells[3].Value.ToString());
                    }
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectGPUs();
                    GPUomn = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        GPUomn[i] = EditLTdg.Rows[i].Cells[0].Value.ToString();
                    }
                    break;
                case "CPU":
                    if (EditLTdg.Rows.Count <= 1)
                    {
                        return;
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        controllerObj.EditCpu(CPUmn[i], EditLTdg.Rows[i].Cells[0].Value.ToString(), EditLTdg.Rows[i].Cells[1].Value.ToString());
                    }
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectCPUs();
                    CPUmn = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        CPUmn[i] = EditLTdg.Rows[i].Cells[1].Value.ToString();
                    }

                    break;
                case "OS":
                    if (EditLTdg.Rows.Count <= 1)
                    {
                        return;
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        controllerObj.EditOs(OSn[i],OSman[i],OSv[i], EditLTdg.Rows[i].Cells[0].Value.ToString(), EditLTdg.Rows[i].Cells[1].Value.ToString(), EditLTdg.Rows[i].Cells[2].Value.ToString());

                    }
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectOSs();
                    OSn = new string[EditLTdg.Rows.Count - 1];
                    OSman = new string[EditLTdg.Rows.Count - 1];
                    OSv = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSn[i] = EditLTdg.Rows[i].Cells[0].Value.ToString();
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSman[i] = EditLTdg.Rows[i].Cells[1].Value.ToString();
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSv[i] = EditLTdg.Rows[i].Cells[2].Value.ToString();
                    }
                    break;
            }
            //   if (role == "Admin")
            //{

            //    EditLTdg.DataSource = controllerObj.SelectEdits();
            //}
            //else if (role == "Store")
            //{
            //    EditLTdg.DataSource = controllerObj.SelectEditsStore(controllerObj.getOwner(id.ToString()));
            //}
            //EditLTdg.Columns[0].ReadOnly = true;
            //EditLTdg.Columns[7].ReadOnly = true;

        }

        private void EditLTdg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void EditLTdg_KeyDown(object sender, KeyEventArgs e)
        {
            controllerObj = new Controller();
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("If you delete the search logs will also dissappear. are you sure?","Delete Confirmation",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < EditLTdg.SelectedRows.Count; i++)
                    {
                        int result = controllerObj.RemoveLaptop(EditLTdg.SelectedRows[i].Cells[0].Value.ToString());
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            switch (comboBox1.Text)
            {
                case "Laptop":
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectEdits();
                    if (EditLTdg.Rows.Count > 1)
                    {
                        EditLTdg.Columns[0].ReadOnly = true;
                        EditLTdg.Columns[3].ReadOnly = true;
                        EditLTdg.Columns[4].ReadOnly = true;
                        EditLTdg.Columns[11].ReadOnly = true;
                        EditLTdg.Columns[12].ReadOnly = true;
                        EditLTdg.Columns[13].ReadOnly = true;
                        EditLTdg.Columns[7].ReadOnly = true;
                    }
                    break;
                case "GPU":
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectGPUs();
                    GPUomn = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        GPUomn[i] = EditLTdg.Rows[i].Cells[0].Value.ToString();
                    }
                    break;
                case "CPU":
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectCPUs();
                    CPUmn = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        CPUmn[i] = EditLTdg.Rows[i].Cells[1].Value.ToString();
                    }
                    break;
                case "OS":
                    EditLTdg.DataSource = null;
                    EditLTdg.DataSource = controllerObj.SelectOSs();
                    OSn = new string[EditLTdg.Rows.Count - 1];
                    OSman = new string[EditLTdg.Rows.Count - 1];
                    OSv = new string[EditLTdg.Rows.Count - 1];
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSn[i] = EditLTdg.Rows[i].Cells[0].Value.ToString();
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSman[i] = EditLTdg.Rows[i].Cells[1].Value.ToString();
                    }
                    for (int i = 0; i < EditLTdg.Rows.Count - 1; i++)
                    {
                        OSv[i] = EditLTdg.Rows[i].Cells[2].Value.ToString();
                    }
                    break;
            }
        }
    }
}
