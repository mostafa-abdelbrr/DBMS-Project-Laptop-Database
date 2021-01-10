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
    public partial class ViewLaptop : Form
    {
        string LaptopID;
        int UserId;
        string UserName, UserRole;
        Controller ControlObj;
        public ViewLaptop(string Name,int Id)
        {
            InitializeComponent();
            ControlObj = new Controller();
            LaptopID = Name;
            UserId = Id;
            ControlObj.getUserDataFromID(UserId, ref UserName, ref UserRole);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ProcessorsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void ViewLaptop_Load(object sender, EventArgs e)
        {
            //Show Laptop Rating 
            DataTable dt = ControlObj.GetRating(LaptopID);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();

            //Show Rating
            if (UserRole=="3")
            {
                Rate.Visible = true;
                RateText.Visible = true;
                RateButton.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;
            DataTable dt;
            if (combo == "Processor")
                dt = ControlObj.GetProcessor(LaptopID);
            else if (combo == "Graphics Card")
                dt = ControlObj.GetGarphicsCard(LaptopID);
            else if (combo == "RAM")
                dt = ControlObj.GetRAM(LaptopID);
            else if (combo == "Keyboard")
                dt = ControlObj.GetKeyboard(LaptopID);
            else if (combo == "Screen")
                dt = ControlObj.GetScreen(LaptopID);
            else if (combo == "Operation System")
                dt = ControlObj.GetOS(LaptopID);
            else if (combo == "USB Port")
                dt = ControlObj.GetUSB(LaptopID);
            else if (combo == "Storage")
                dt = ControlObj.GetStorage(LaptopID);
            else if (combo == "Manufacturer Information")
                dt = ControlObj.GetManufacturer(LaptopID);
            else if (combo == "Store Information")
                dt = ControlObj.GetStore(LaptopID);
            else
                dt = ControlObj.GetInformation(LaptopID);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlObj.Rate(LaptopID, UserId, RateText.Text);
        }
    }
}
