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
        string LaptopName;
        Controller ControlObj;
        public ViewLaptop(string Name)
        {
            InitializeComponent();
            ControlObj = new Controller();
            LaptopName = Name;
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
            DataTable dt = ControlObj.GetInformation(Name);
            InformationDataGrid.DataSource = dt;
            InformationDataGrid.Refresh();

            //The Processor Information
            dt = ControlObj.GetProcessor(Name);
            ProcessorsDataGrid.DataSource = dt;
            ProcessorsDataGrid.Refresh();

            //The GraphicsCard Information
            dt = ControlObj.GetGarphicsCard(Name);
            GrahicsCardDataGrid.DataSource = dt;
            GrahicsCardDataGrid.Refresh();

            //The RAM Information 
            dt = ControlObj.GetRAM(Name);
            RAMDataGrid.DataSource = dt;
            RAMDataGrid.Refresh();

            //The OperationSystem Information 
            dt = ControlObj.GetOS(Name);
            OSDataGrid.DataSource = dt;
            OSDataGrid.Refresh();

            //The Storage Information 
            dt = ControlObj.GetStorage(Name);
            StorageDataGrid.DataSource = dt;
            StorageDataGrid.Refresh();

            //The USB Information
            dt = ControlObj.GetUSB(Name);
            USBDataGrid.DataSource = dt;
            USBDataGrid.Refresh();

            //The Screen Information
            dt = ControlObj.GetScreen(Name);
            ScreenDataGrid.DataSource = dt;
            ScreenDataGrid.Refresh();

            //The Manufacturer Information
            dt = ControlObj.GetManufacturer(Name);
            ManufacturerDataGrid.DataSource = dt;
            ManufacturerDataGrid.Refresh();

            //The Store Information
            dt = ControlObj.GetStore(Name);
            StoreDataGrid.DataSource = dt;
            StoreDataGrid.Refresh();

            //The KeyBoard Infromation
            dt = ControlObj.GetKeyboard(Name);
            KeyboradDataGrid.DataSource = dt;
            KeyboradDataGrid.Refresh();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
