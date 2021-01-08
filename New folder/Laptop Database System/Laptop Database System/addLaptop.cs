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

            osMaker.DataSource = controllerObj.fillosManu();
            osMaker.DisplayMember = "Manufacturer";

            osName.DataSource = controllerObj.fillosName(osMaker.Text);
            osName.DisplayMember = "Name";

            osVer.DataSource = controllerObj.fillosVer(osName.Text);
            osVer.DisplayMember = "Version";

            ddr.SelectedIndex = 2;
            screenType.SelectedIndex = 0;
            resolution.SelectedIndex = 1;
            osMaker.SelectedIndex = 0;


            procModel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            procModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            procModel.AutoCompleteCustomSource = controllerObj.getProcModelAutoCompSrc(procMaker.Text);

            gfxModel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            gfxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gfxModel.AutoCompleteCustomSource = controllerObj.getGFXModelAutoCompSrc(gfxMaker.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            if (lapName.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point lapNameLoc = lapName.Location;

                tt.Show("Please Enter Laptop Name", this, lapNameLoc, 2000);
                emptyChecker = true;

            }

            if (ram.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point lapNameLoc = ram.Location;

                tt.Show("Please Enter The Ram Size In GB ", this, lapNameLoc, 2000);
                emptyChecker = true;
            }

            if (screenSize.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point scr = screenSize.Location;

                tt.Show("Please Enter The Screen Size In Inches ", this, scr, 2000);
                emptyChecker = true;
            }

            if (inStock.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point lapNameLoc = inStock.Location;

                tt.Show("Please Enter Laptop Name", this, lapNameLoc, 2000);
                emptyChecker = true;
            }

            if (price.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point lapNameLoc = price.Location;

                tt.Show("Please Enter Laptop Name", this, lapNameLoc, 2000);
                emptyChecker = true;
            }

            if (model.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point modelLoc = model.Location;

                tt.Show("Please Enter Laptop Model Number", this, modelLoc, 2000);
                emptyChecker = true;
            }

            if (procModel.TextLength == 0)
            {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.InitialDelay = 0;

                Point modelLoc = procModel.Location;

                tt.Show("Please Enter Processor Model Number", this, modelLoc, 2000);
                emptyChecker = true;
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

            if (emptyChecker)
            {
                return;
            }

            if (controllerObj.addToLaptop(model.Text, lapName.Text, releaseDate.Value.ToShortDateString()) == 0)
            {
                MessageBox.Show("laptop");
            }
            else
            {
                MessageBox.Show("gg");
            }

            if (controllerObj.addToManufacturer(maker.Text, model.Text, releaseDate.Value.ToShortDateString()) == 0)
            {
                MessageBox.Show("manufacturer");
            }
            else
            {
                MessageBox.Show("fola");
            }



            if (controllerObj.addToBoughtFrom(model.Text, controllerObj.getOwner(id.ToString()), price.Text, inStock.Text) == 0)
            {
                MessageBox.Show("instock");
            }
            else
            {
                MessageBox.Show("3a444");
            }

            if (controllerObj.addToRam(ram.Text, ddr.SelectedItem.ToString(), model.Text) == 0)
            {
                MessageBox.Show("ram");
            }
            else
            {
                MessageBox.Show("3a4 ysta walahi");
            }

            if (controllerObj.addToScreen(screenType.Text, resolution.Text, screenSize.Text, model.Text) == 0)
            {
                MessageBox.Show("screen");

            }
            else
            {
                MessageBox.Show("allah ❤❤❤");
            }

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

        private void gfxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void gfxMaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            gfxModel.AutoCompleteCustomSource = controllerObj.getGFXModelAutoCompSrc(gfxMaker.Text);
            gfxModel.Text = "";
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
    }
}
