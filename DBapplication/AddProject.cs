using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AddProject : Form
    {
        Controller controllerObj;
        public AddProject()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepNum();
            DepartmentNo_ComboBox.DataSource = dt;
            DepartmentNo_ComboBox.DisplayMember = "Dname";
            DepartmentNo_ComboBox.ValueMember = "Dnumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProjectName_textBox.Text=="" || ProjectNo_textBox.Text=="" || ProjectLocation_textBox.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object PNO = ValidationClass.isPositiveInteger(ProjectNo_textBox.Text,err);
                Object DNO = ValidationClass.isPositiveInteger(DepartmentNo_ComboBox.SelectedValue.ToString(), err);
                if (PNO == null || DNO == null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r = controllerObj.InsertProject(ProjectName_textBox.Text, (int)PNO, ProjectLocation_textBox.Text, (int)DNO);
                    MessageBox.Show("Project inserted successfully");
                }
            }
        }
    }
}
