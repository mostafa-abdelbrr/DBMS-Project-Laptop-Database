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
    public partial class check_search : Form
    {
        Controller controllerObj;
        public check_search()
        {
            InitializeComponent();
        }

        private void check_search_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            SearchDG.DataSource = controllerObj.SortMostSearched();
            comboBox1.DisplayMember = "ID";
            comboBox1.DataSource = controllerObj.SelectUsers();
            userSearchDG.DataSource = controllerObj.UserSearched(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSearchDG.DataSource = controllerObj.UserSearched(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchDG.DataSource = controllerObj.SortMostSearched();
        }
    }
}
