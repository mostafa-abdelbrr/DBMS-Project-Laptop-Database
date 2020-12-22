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
    public partial class Misc : Form
    {
        Controller controllerObj = new Controller();

        public Misc()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectDepartment();
            dept_comboBox.DataSource = dt;
            dept_comboBox.DisplayMember = "Dname";
            dt = controllerObj.SelectDepLoc();
            deptloc_comboBox.DataSource = dt;
            deptloc_comboBox.DisplayMember = "Dlocation";
            DataTable dt1 = controllerObj.SelectDepLoc();
            deptloc1_comboBox.DataSource = dt1;
            deptloc1_comboBox.DisplayMember = "Dlocation";
            DataTable dt2 = controllerObj.SelectDepLoc();
            deptloc2_comboBox.DataSource = dt2;
            deptloc2_comboBox.DisplayMember = "Dlocation";
        }

        private void getemployeeswithlesssalarybutton_Click(object sender, EventArgs e)
        {

            if (salary_textBox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert a value for base salary.");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object salary = ValidationClass.isPositiveInteger(salary_textBox.Text, err);
                if (salary == null)
                {
                    MessageBox.Show("Salary has an incorrect value " + err.ToString());
                }
                else
                {
                    DataTable dt = controllerObj.SelectAllEmployeesWithSalaryLessThan(salary_textBox.Text);
                    EmployeeLessSalary_ComboBox.DataSource = dt;
                }
            }
        }

        private void geds_button_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (comboBox1.Text == "" || dept_comboBox.Text == "")//validation part
            {
                MessageBox.Show("Please choose values for Sex and/or Department.");
            }
            else
            {
                DataTable dt = controllerObj.SelectEmployeesinDeptBySex(comboBox1.Text, dept_comboBox.Text);
                EmployeeLessSalary_ComboBox.DataSource = dt;
            }
        }

        private void gdlbdn_button_Click(object sender, EventArgs e)
        {
            if (deptloc_comboBox.Text == "")//validation part
            {
                MessageBox.Show("Please choose value for department location.");
            }
            else
            {
                DataTable dt = controllerObj.GetDepartmentNamesAtLocation(deptloc_comboBox.Text);
                EmployeeLessSalary_ComboBox.DataSource = dt;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertdept_button_Click(object sender, EventArgs e)
        {
            if (newdeptmgrstartd_textbox.Text == "" || newdeptmgr_textbox.Text == "" || newdept_textbox.Text == "" || newdno_textbox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert values for required data (new department's name, new dept. ID, newdept. manager's SSN, new dept. manager's start date .");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object startd = ValidationClass.isPositiveInteger(newdeptmgrstartd_textbox.Text, err);
                Object dmgr = ValidationClass.isPositiveInteger(newdeptmgr_textbox.Text, err);
                Object newd = ValidationClass.isPositiveInteger(newdept_textbox.Text, err);
                Object dno = ValidationClass.isPositiveInteger(newdno_textbox.Text, err);
                if (startd == null || dmgr == null || newd != null || dno == null)
                {
                    MessageBox.Show("An entered data has incorrect value " + err.ToString());
                }
                else
                {
                    DataTable dt = controllerObj.InsertDept(newdept_textbox.Text,newdno_textbox.Text,newdeptmgr_textbox.Text,newdeptmgrstartd_textbox.Text);
                    EmployeeLessSalary_ComboBox.DataSource = dt;
                }
            }
        }

        private void getemployeeswithlesshours_button_Click(object sender, EventArgs e)
        {


            if (hours_textbox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert a value for hours.");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object hours = ValidationClass.isPositiveInteger(hours_textbox.Text, err);
                if (hours == null)
                {
                    MessageBox.Show("Hours has an incorrect value " + err.ToString());
                }
                else
                {
                    DataTable dt = controllerObj.GetEmployeesWithLessHours(hours_textbox.Text, deptloc1_comboBox.Text, deptloc2_comboBox.Text);
                    EmployeeLessSalary_ComboBox.DataSource = dt;
                }
            }

        }

        private void getemplbyprojordept_button_Click(object sender, EventArgs e)
        {
            if (dept_comboBox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert a value for Department.");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                {
                    DataTable dt = controllerObj.GetNSworkinginorcontrolledby(dept_comboBox.Text);
                    EmployeeLessSalary_ComboBox.DataSource = dt;
                }
            }

        }

        private void Misc_Load(object sender, EventArgs e)
        {

        }

        private void updatesalary_button_Click(object sender, EventArgs e)
        {
            if (ussn_textbox.Text == "" || usalary_textbox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert a value for SSN & New Salary.");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object ssn = ValidationClass.isPositiveInteger(ussn_textbox.Text, err);
                Object salary = ValidationClass.isPositiveInteger(usalary_textbox.Text, err);
                if (ssn == null || salary == null)
                {
                    MessageBox.Show("SSN and/or Salary has an incorrect value " + err.ToString());
                }
                else
                {
                    DataTable dt = controllerObj.EditSalarybySSN(ussn_textbox.Text, usalary_textbox.Text);
                    EmployeeLessSalary_ComboBox.DataSource = dt;
                }
            }
        }

        private void getmgrlname_button_Click(object sender, EventArgs e)
        {
            EmployeeLessSalary_ComboBox.DataSource = controllerObj.GetLnameofManagers();
        }

        private void maxminavg_button_Click(object sender, EventArgs e)
        {
            EmployeeLessSalary_ComboBox.DataSource = controllerObj.GetMaxMinAvg();
        }
    }
}
