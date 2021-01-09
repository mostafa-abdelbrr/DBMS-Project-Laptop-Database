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
    public partial class addLaptop : Form
    {
        Form parent;
        Controller controllerObj;
        string username;
        int id;
        public addLaptop(Form parent, string storeName, int id)
        {
            this.parent = parent;
            controllerObj = new Controller();
            InitializeComponent();
            this.username = storeName;
            this.id = id;
        }

        private void addLaptop_Load(object sender, EventArgs e)
        {
            maker.DataSource = controllerObj.fillManufacturerComboBox();
            maker.DisplayMember = "Name";



            procMaker.DataSource = controllerObj.fillProcMaker();
            procMaker.DisplayMember = "Brand";

            gfxMaker.DataSource = controllerObj.fillGFXMaker();
            gfxMaker.DisplayMember = "Manufacturer";

            ddr.SelectedIndex = 2;
            screenType.SelectedIndex = 0;
            resolution.SelectedIndex = 1;


            osMaker.DataSource = controllerObj.fillosManu();
            osMaker.DisplayMember = "Manufacturer";

            osName.DataSource = controllerObj.fillosName(osMaker.Text);
            osName.DisplayMember = "Name";

            osVer.DataSource = controllerObj.fillosVer(osName.Text);
            osVer.DisplayMember = "Version";

            osMaker.SelectedIndex = 0;

            procModel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            procModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            procModel.AutoCompleteCustomSource = controllerObj.getProcModelAutoCompSrc(procMaker.Text);

            gfxModel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            gfxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gfxModel.AutoCompleteCustomSource = controllerObj.getGFXModelAutoCompSrc(gfxMaker.Text);

            kbType.SelectedIndex = 0;
        }



        private void addLaptop_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }



        private void lapName_TextChanged(object sender, EventArgs e)
        {

        }


        private void add_Click(object sender, EventArgs e)
        {
            bool emptyChecker = false;
            

            if (ram.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;
                

                err.Text = "Pleae Enter Ram Size";

            }



            if (inStock.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter Stock";

            }

            if (price.TextLength == 0)
            {
                 emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter Price";

            }

         

            if (procModel.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter Processor Model Number";

            }

            if (hddM.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter HDD Manufacturer";

            }

            if (ssdM.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter SSD Manufacturer";

            }
            if (hddSize.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter HDD Size";

            }

            if (ssdSize.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter SSD Size";

            }

            if (screenSize.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter Screen Size";
            }

            if (controllerObj.checkLaptopModel(model.Text) != "N/A")
            {
                err.Visible = true;
                err.Text = "Laptop Model Already Exists";
                return;
            }


            if (controllerObj.checkLaptopName(lapName.Text) != "N/A")
            {
                err.Visible = true;
                err.Text = "Laptop Name Already Exists";
                return;
            }

            if (lapName.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;
                err.Text = "Please Enter Laptop Name";

            }

            if (model.TextLength == 0)
            {
                emptyChecker = true;
                err.Visible = true;


                err.Text = "Please Enter Laptop Model Number";

            }


            if (emptyChecker)
            {
                return;
            }

            string light = "No";
            if (yes.Checked)
            {
                light = "Yes";
            }

            if (controllerObj.checkProc(procMaker.Text, procModel.Text) == null){
                err.Visible = true;
                err.Text = "Please Check Processor Model Number";
                return;
            }

            if (controllerObj.checkGPU(gfxMaker.Text, gfxModel.Text) == null)
            {
                err.Visible = true;
                err.Text = "Please Check GPU Model Number";
                return;
            }



            int laptopStatus = controllerObj.newLaptop(model.Text, lapName.Text, releaseDate.Value.ToShortDateString(), maker.Text, controllerObj.getOwner(id.ToString()), price.Text, inStock.Text, ram.Text, ddr.Text, hddM.Text, ssdM.Text, hddSize.Text, ssdSize.Text, kbType.Text, light, usb2.Value.ToString(), usb3.Value.ToString(), screenType.Text, resolution.Text, screenSize.Text, procMaker.Text, procModel.Text, gfxModel.Text, osMaker.Text, osName.Text, osVer.Text);

            if (laptopStatus == -1)
            {
                MessageBox.Show("An Error Has Occured While Adding Laptop. Please Check Your data And Try Again Shortly");
            } else
            {
                MessageBox.Show("Thank You For Choosing LDBS! An Admin Will Review Your Request Shortly");
               // Hide();
                
              //  parent.Show();

            }


            //if (controllerObj.addToLaptop(model.Text, lapName.Text, releaseDate.Value.ToShortDateString()) == 0)
            //{
            //    MessageBox.Show("laptop");
            //}
            //else
            //{
            //    MessageBox.Show("gg");
            //}

            //if (controllerObj.addToManufacturer(maker.Text, model.Text, releaseDate.Value.ToShortDateString()) == 0)
            //{
            //    MessageBox.Show("manufacturer");
            //}
            //else
            //{
            //    MessageBox.Show("fola");
            //}



            //if (controllerObj.addToBoughtFrom(model.Text, controllerObj.getOwner(id.ToString()), price.Text, inStock.Text) == 0)
            //{
            //    MessageBox.Show("instock");
            //}
            //else
            //{
            //    MessageBox.Show("3a444");
            //}

            //if (controllerObj.addToRam(ram.Text, ddr.SelectedItem.ToString(), model.Text) == 0)
            //{
            //    MessageBox.Show("ram");
            //}
            //else
            //{
            //    MessageBox.Show("3a4 ysta walahi");
            //}

            //if (controllerObj.addToScreen(screenType.Text, resolution.Text, screenSize.Text, model.Text) == 0)
            //{
            //    MessageBox.Show("screen");

            //}
            //else
            //{
            //    MessageBox.Show("allah ❤❤❤");
            //}

            //if (controllerObj.addToKeyBoard(kbType.Text, light, model.Text) == 0)
            //{
            //    MessageBox.Show("kb");
            //}
            //else
            //{
            //    MessageBox.Show("iam so proud of you omar");
            //}

            //if (controllerObj.addToUSB(model.Text, usb2.Value.ToString(), usb3.Value.ToString()) == 0)
            //{
            //    MessageBox.Show("usb");
            //}
            //else
            //{
            //    MessageBox.Show("omar = madfa3 bfadl rabena");
            //}

            //if (controllerObj.addToStorage(hddM.Text, ssdM.Text, hddSize.Text, ssdSize.Text, model.Text) == 0)
            //{
            //    MessageBox.Show("storage");
            //}
            //else
            //{
            //    MessageBox.Show("half done");
            //}

        }

        private void inStock_TextChanged(object sender, EventArgs e)
        {

        }



        private void inStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                Point loc = inStock.Location;
                tt.Show("Only numbers allowed ", this, loc, 2000);
            }
        }



        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Back) || (Keys)e.KeyChar == Keys.Decimal)
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point loc = price.Location;

                tt.Show("Only numbers allowed ", this, loc, 2000);
            }
        }

        private void gfxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void gfxMaker_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void osName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void osMaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            osName.DataSource = controllerObj.fillosName(osMaker.Text);
            osName.DisplayMember = "Name";

            osVer.DataSource = controllerObj.fillosVer(osName.Text);
            osVer.DisplayMember = "Version";
        }

        private void procMaker_SelectedIndexChanged(object sender, EventArgs e)
        {

            procModel.AutoCompleteCustomSource = controllerObj.getProcModelAutoCompSrc(procMaker.Text);
            procModel.Text = "";
        }

        private void ram_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                //  Point loc = ram.Location;
                tt.Show("Only numbers allowed ", this, 450, 30, 2000);
            }
        }

        private void size_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Decimal || (Keys)e.KeyChar == Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                Point locl = screenSize.Location;
                // tt.SetToolTip(screenSize, "Only numbers allowed");
                tt.Show("Only numbers allowed ", this, 430, 341, 2000);
            }
        }

        private void screenSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void osMaker_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gfxMaker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            gfxModel.Text = "";
            gfxModel.AutoCompleteCustomSource = controllerObj.getGFXModelAutoCompSrc(gfxMaker.Text);
        }

        private void osMaker_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            osName.DataSource = controllerObj.fillosName(osMaker.Text);
            osVer.DataSource = controllerObj.fillosVer(osName.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void gfxModel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Decimal || (Keys)e.KeyChar == Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                Point locl = screenSize.Location;
                // tt.SetToolTip(screenSize, "Only numbers allowed");
                tt.Show("Only numbers allowed ", this, 430, 341, 2000);
            }
        }

        private void ssdSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssdSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input;
            input = e.KeyChar;

            if (!(char.IsNumber(input) || (Keys)e.KeyChar == Keys.Decimal || (Keys)e.KeyChar == Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;
                Point locl = screenSize.Location;
                // tt.SetToolTip(screenSize, "Only numbers allowed");
                tt.Show("Only numbers allowed ", this, 430, 341, 2000);
            }
        }

        private void addLaptop_Shown(object sender, EventArgs e)
        {

        }
    }
}
