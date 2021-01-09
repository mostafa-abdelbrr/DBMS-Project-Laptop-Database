
namespace Laptop_Database_System
{
    partial class Store_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Button();
            this.addLaptop = new System.Windows.Forms.Button();
            this.laptop = new System.Windows.Forms.DataGridView();
            this.editAcc = new System.Windows.Forms.Button();
            this.viewAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.laptop)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(7, 565);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(75, 13);
            this.status.TabIndex = 0;
            this.status.Text = "STATUS_LBL";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(7, 551);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(87, 13);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "WELCOME_LBL";
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(9, 581);
            this.signOut.Margin = new System.Windows.Forms.Padding(2);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(93, 28);
            this.signOut.TabIndex = 3;
            this.signOut.Text = "Sign Out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // addLaptop
            // 
            this.addLaptop.Location = new System.Drawing.Point(9, 17);
            this.addLaptop.Margin = new System.Windows.Forms.Padding(2);
            this.addLaptop.Name = "addLaptop";
            this.addLaptop.Size = new System.Drawing.Size(93, 28);
            this.addLaptop.TabIndex = 0;
            this.addLaptop.Text = "Add Laptop";
            this.addLaptop.UseVisualStyleBackColor = true;
            this.addLaptop.Click += new System.EventHandler(this.addLaptop_Click);
            // 
            // laptop
            // 
            this.laptop.AllowUserToAddRows = false;
            this.laptop.AllowUserToDeleteRows = false;
            this.laptop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.laptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laptop.GridColor = System.Drawing.SystemColors.Control;
            this.laptop.Location = new System.Drawing.Point(176, 17);
            this.laptop.Margin = new System.Windows.Forms.Padding(2);
            this.laptop.Name = "laptop";
            this.laptop.RowHeadersWidth = 51;
            this.laptop.RowTemplate.Height = 24;
            this.laptop.Size = new System.Drawing.Size(1062, 610);
            this.laptop.TabIndex = 4;
            this.laptop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.laptop_CellContentClick);
            // 
            // editAcc
            // 
            this.editAcc.Location = new System.Drawing.Point(9, 614);
            this.editAcc.Margin = new System.Windows.Forms.Padding(2);
            this.editAcc.Name = "editAcc";
            this.editAcc.Size = new System.Drawing.Size(93, 28);
            this.editAcc.TabIndex = 2;
            this.editAcc.Text = "Edit Account";
            this.editAcc.UseVisualStyleBackColor = true;
            this.editAcc.Click += new System.EventHandler(this.editAcc_Click);
            // 
            // viewAll
            // 
            this.viewAll.Location = new System.Drawing.Point(9, 105);
            this.viewAll.Margin = new System.Windows.Forms.Padding(2);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(93, 28);
            this.viewAll.TabIndex = 1;
            this.viewAll.Text = "View All Laptops";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modify Laptops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Promote ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Store_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.editAcc);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.addLaptop);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.status);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Store_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Store_Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Store_Dashboard_Load);
            this.Shown += new System.EventHandler(this.Store_Dashboard_Shown);
            this.Enter += new System.EventHandler(this.Store_Dashboard_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.laptop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button addLaptop;
        private System.Windows.Forms.DataGridView laptop;
        private System.Windows.Forms.Button editAcc;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}