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
    public partial class Provided_Functionalities : Form
    {
        Form Parent;
        public Provided_Functionalities(int a,Form Parent)
        {
            InitializeComponent();
            if (a == 0) //1 for admin, 0 for other
            {
                this.button1.Enabled = false;
            }
            this.Parent = Parent;
            if(Parent != null)
            Parent.Hide();
        }

        private void ViewProjectsButton_Click(object sender, EventArgs e)
        {
            RetrieveProjects RP = new RetrieveProjects();
            RP.Show();
           
        }

        private void ViewEmployeesButton_Click(object sender, EventArgs e)
        {
            ViewEmployees v = new ViewEmployees();
            v.Show();
           
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            AddProject p = new AddProject();
            p.Show();
        }

        private void Provided_Functionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Parent != null)
                Parent.Show();
        }
    }
}
