
namespace Laptop_Database_System
{
    partial class Store_Sign_Up
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
            this.signUser = new System.Windows.Forms.Button();
            this.signStore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consent = new System.Windows.Forms.CheckBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.storename = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUser
            // 
            this.signUser.Location = new System.Drawing.Point(415, 395);
            this.signUser.Name = "signUser";
            this.signUser.Size = new System.Drawing.Size(148, 32);
            this.signUser.TabIndex = 12;
            this.signUser.Text = "Sign Up";
            this.signUser.UseVisualStyleBackColor = true;
            this.signUser.Click += new System.EventHandler(this.signUser_Click);
            // 
            // signStore
            // 
            this.signStore.Location = new System.Drawing.Point(234, 395);
            this.signStore.Name = "signStore";
            this.signStore.Size = new System.Drawing.Size(148, 32);
            this.signStore.TabIndex = 14;
            this.signStore.Text = "Back";
            this.signStore.UseVisualStyleBackColor = true;
            this.signStore.Click += new System.EventHandler(this.signStore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // consent
            // 
            this.consent.AutoSize = true;
            this.consent.Location = new System.Drawing.Point(234, 356);
            this.consent.Name = "consent";
            this.consent.Size = new System.Drawing.Size(276, 21);
            this.consent.TabIndex = 11;
            this.consent.Text = "I Agree To Share My Data With LDBS™";
            this.consent.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(340, 87);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(223, 22);
            this.user.TabIndex = 8;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(340, 132);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 22);
            this.password.TabIndex = 9;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(340, 40);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(223, 22);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.email_KeyPress);
            // 
            // storename
            // 
            this.storename.Location = new System.Drawing.Point(340, 183);
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(223, 22);
            this.storename.TabIndex = 16;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(340, 233);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(223, 22);
            this.address.TabIndex = 17;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(340, 279);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(223, 22);
            this.phone.TabIndex = 18;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Store Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone Number";
            // 
            // validation
            // 
            this.validation.AutoSize = true;
            this.validation.ForeColor = System.Drawing.Color.Red;
            this.validation.Location = new System.Drawing.Point(337, 314);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(79, 17);
            this.validation.TabIndex = 22;
            this.validation.Text = "ERR_LABL";
            this.validation.Visible = false;
            // 
            // Store_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.address);
            this.Controls.Add(this.storename);
            this.Controls.Add(this.signUser);
            this.Controls.Add(this.signStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consent);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Store_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Store_Sign_Up_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUser;
        private System.Windows.Forms.Button signStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox consent;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox storename;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label validation;
    }
}