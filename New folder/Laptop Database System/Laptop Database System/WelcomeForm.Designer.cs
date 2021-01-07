
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
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(68, 33);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(56, 19);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(68, 71);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(56, 19);
            this.signupbutton.TabIndex = 1;
            this.signupbutton.Text = "Sign Up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // viewallbutton
            // 
            this.viewallbutton.Location = new System.Drawing.Point(68, 110);
            this.viewallbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewallbutton.Name = "viewallbutton";
            this.viewallbutton.Size = new System.Drawing.Size(56, 19);
            this.viewallbutton.TabIndex = 2;
            this.viewallbutton.Text = "View all";
            this.viewallbutton.UseVisualStyleBackColor = true;
            this.viewallbutton.Click += new System.EventHandler(this.viewallbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(68, 154);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(56, 19);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 210);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.viewallbutton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.loginbutton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button viewallbutton;
        private System.Windows.Forms.Button searchbutton;
    }
}