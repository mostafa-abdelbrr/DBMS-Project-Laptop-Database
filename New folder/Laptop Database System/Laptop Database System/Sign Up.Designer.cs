
namespace Laptop_Database_System
{
    partial class Sign_Up
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
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.consent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signStore = new System.Windows.Forms.Button();
            this.signUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ERR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(195, 32);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(223, 22);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.email_KeyPress);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(195, 124);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 22);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(195, 79);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(223, 22);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            this.user.Validating += new System.ComponentModel.CancelEventHandler(this.user_Validating);
            // 
            // consent
            // 
            this.consent.AutoSize = true;
            this.consent.Location = new System.Drawing.Point(96, 173);
            this.consent.Name = "consent";
            this.consent.Size = new System.Drawing.Size(276, 21);
            this.consent.TabIndex = 4;
            this.consent.Text = "I Agree To Share My Data With LDBS™";
            this.consent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // signStore
            // 
            this.signStore.Location = new System.Drawing.Point(21, 213);
            this.signStore.Name = "signStore";
            this.signStore.Size = new System.Drawing.Size(148, 32);
            this.signStore.TabIndex = 6;
            this.signStore.Text = "For Store Owners";
            this.signStore.UseVisualStyleBackColor = true;
            this.signStore.Click += new System.EventHandler(this.signStore_Click);
            // 
            // signUser
            // 
            this.signUser.Location = new System.Drawing.Point(195, 213);
            this.signUser.Name = "signUser";
            this.signUser.Size = new System.Drawing.Size(148, 32);
            this.signUser.TabIndex = 5;
            this.signUser.Text = "Sign Up";
            this.signUser.UseVisualStyleBackColor = true;
            this.signUser.Click += new System.EventHandler(this.signUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ERR
            // 
            this.ERR.AutoSize = true;
            this.ERR.ForeColor = System.Drawing.Color.Red;
            this.ERR.Location = new System.Drawing.Point(192, 153);
            this.ERR.Name = "ERR";
            this.ERR.Size = new System.Drawing.Size(88, 17);
            this.ERR.TabIndex = 8;
            this.ERR.Text = "ERR_LABEL";
            this.ERR.Visible = false;
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 272);
            this.Controls.Add(this.ERR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signUser);
            this.Controls.Add(this.signStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consent);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sign_Up_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.CheckBox consent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signStore;
        private System.Windows.Forms.Button signUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ERR;
    }
}