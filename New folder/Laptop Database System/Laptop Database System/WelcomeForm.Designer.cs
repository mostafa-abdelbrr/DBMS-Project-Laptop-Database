
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Csearch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Parts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 265);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}