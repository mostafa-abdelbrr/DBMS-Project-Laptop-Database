
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
            ((System.ComponentModel.ISupportInitialize)(this.laptop)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(9, 344);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(96, 17);
            this.status.TabIndex = 0;
            this.status.Text = "STATUS_LBL";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(9, 327);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(111, 17);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "WELCOME_LBL";
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(12, 364);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(124, 35);
            this.signOut.TabIndex = 2;
            this.signOut.Text = "Sign Out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // addLaptop
            // 
            this.addLaptop.Location = new System.Drawing.Point(12, 21);
            this.addLaptop.Name = "addLaptop";
            this.addLaptop.Size = new System.Drawing.Size(124, 35);
            this.addLaptop.TabIndex = 3;
            this.addLaptop.Text = "Add Laptop";
            this.addLaptop.UseVisualStyleBackColor = true;
            // 
            // laptop
            // 
            this.laptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laptop.Location = new System.Drawing.Point(235, 21);
            this.laptop.Name = "laptop";
            this.laptop.RowHeadersWidth = 51;
            this.laptop.RowTemplate.Height = 24;
            this.laptop.Size = new System.Drawing.Size(553, 417);
            this.laptop.TabIndex = 4;
            // 
            // editAcc
            // 
            this.editAcc.Location = new System.Drawing.Point(12, 405);
            this.editAcc.Name = "editAcc";
            this.editAcc.Size = new System.Drawing.Size(124, 35);
            this.editAcc.TabIndex = 5;
            this.editAcc.Text = "Edit Account";
            this.editAcc.UseVisualStyleBackColor = true;
            this.editAcc.Click += new System.EventHandler(this.editAcc_Click);
            // 
            // viewAll
            // 
            this.viewAll.Location = new System.Drawing.Point(12, 72);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(124, 35);
            this.viewAll.TabIndex = 6;
            this.viewAll.Text = "View All Laptops";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // Store_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.editAcc);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.addLaptop);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.status);
            this.Name = "Store_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Store_Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Store_Dashboard_Load);
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
    }
}