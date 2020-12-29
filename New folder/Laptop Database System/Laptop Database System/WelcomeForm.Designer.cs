
namespace Laptop_Database_System
{
    partial class WelcomeForm
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.viewallbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchlaptopbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.laptopnametxt = new System.Windows.Forms.TextBox();
            this.dashboardbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(30, 127);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(92, 23);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(148, 127);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(92, 23);
            this.signupbutton.TabIndex = 1;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // viewallbutton
            // 
            this.viewallbutton.Location = new System.Drawing.Point(673, 127);
            this.viewallbutton.Name = "viewallbutton";
            this.viewallbutton.Size = new System.Drawing.Size(75, 23);
            this.viewallbutton.TabIndex = 2;
            this.viewallbutton.Text = "View all";
            this.viewallbutton.UseVisualStyleBackColor = true;
            this.viewallbutton.Click += new System.EventHandler(this.viewallbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(592, 127);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 364);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!";
            // 
            // searchlaptopbutton
            // 
            this.searchlaptopbutton.Location = new System.Drawing.Point(594, 98);
            this.searchlaptopbutton.Name = "searchlaptopbutton";
            this.searchlaptopbutton.Size = new System.Drawing.Size(154, 23);
            this.searchlaptopbutton.TabIndex = 0;
            this.searchlaptopbutton.Text = "Search by name";
            this.searchlaptopbutton.UseVisualStyleBackColor = true;
            this.searchlaptopbutton.Click += new System.EventHandler(this.searchlaptopbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Laptop name:";
            // 
            // laptopnametxt
            // 
            this.laptopnametxt.Location = new System.Drawing.Point(148, 49);
            this.laptopnametxt.Name = "laptopnametxt";
            this.laptopnametxt.Size = new System.Drawing.Size(180, 22);
            this.laptopnametxt.TabIndex = 7;
            // 
            // dashboardbutton
            // 
            this.dashboardbutton.Location = new System.Drawing.Point(272, 127);
            this.dashboardbutton.Name = "dashboardbutton";
            this.dashboardbutton.Size = new System.Drawing.Size(92, 23);
            this.dashboardbutton.TabIndex = 8;
            this.dashboardbutton.Text = "Dashboard";
            this.dashboardbutton.UseVisualStyleBackColor = true;
            this.dashboardbutton.Click += new System.EventHandler(this.dashboardbutton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 550);
            this.Controls.Add(this.dashboardbutton);
            this.Controls.Add(this.laptopnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchlaptopbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.viewallbutton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.loginbutton);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button viewallbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchlaptopbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laptopnametxt;
        private System.Windows.Forms.Button dashboardbutton;
    }
}