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
            //The Information of the latop 
            DataTable dt = ControlObj.GetInformation(LaptopID);
            InformationDataGrid.DataSource = dt;
            InformationDataGrid.Refresh();

            //The Processor Information
            dt = ControlObj.GetProcessor(LaptopID);
            ProcessorsDataGrid.DataSource = dt;
            ProcessorsDataGrid.Refresh();

            //The GraphicsCard Information
            dt = ControlObj.GetGarphicsCard(LaptopID);
            GrahicsCardDataGrid.DataSource = dt;
            GrahicsCardDataGrid.Refresh();

            //The RAM Information 
            dt = ControlObj.GetRAM(LaptopID);
            RAMDataGrid.DataSource = dt;
            RAMDataGrid.Refresh();

            //The OperationSystem Information 
            dt = ControlObj.GetOS(LaptopID);
            OSDataGrid.DataSource = dt;
            OSDataGrid.Refresh();

            //The Storage Information 
            dt = ControlObj.GetStorage(LaptopID);
            StorageDataGrid.DataSource = dt;
            StorageDataGrid.Refresh();

            //The USB Information
            dt = ControlObj.GetUSB(LaptopID);
            USBDataGrid.DataSource = dt;
            USBDataGrid.Refresh();

            //The Screen Information
            dt = ControlObj.GetScreen(LaptopID);
            ScreenDataGrid.DataSource = dt;
            ScreenDataGrid.Refresh();

            //The Manufacturer Information
            dt = ControlObj.GetManufacturer(LaptopID);
            ManufacturerDataGrid.DataSource = dt;
            ManufacturerDataGrid.Refresh();

            //The Store Information
            dt = ControlObj.GetStore(LaptopID);
            StoreDataGrid.DataSource = dt;
            StoreDataGrid.Refresh();

            //The KeyBoard Infromation
            dt = ControlObj.GetKeyboard(LaptopID);
            KeyboradDataGrid.DataSource = dt;
            KeyboradDataGrid.Refresh();

            //Show Laptop Rating 
            string LapRating = ControlObj.GetRating(LaptopID);
            RatingView.Text = LapRating;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ControlObj.Rate(LaptopID, UserId, RateText.Text);
        }
    }
}
