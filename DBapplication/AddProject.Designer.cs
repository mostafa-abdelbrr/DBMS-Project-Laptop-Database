namespace DBapplication
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectName_textBox = new System.Windows.Forms.TextBox();
            this.ProjectNo_textBox = new System.Windows.Forms.TextBox();
            this.ProjectLocation_textBox = new System.Windows.Forms.TextBox();
            this.DepartmentNo_ComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department number";
            // 
            // textBox1
            // 
            this.ProjectName_textBox.Location = new System.Drawing.Point(191, 43);
            this.ProjectName_textBox.Name = "textBox1";
            this.ProjectName_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectName_textBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.ProjectNo_textBox.Location = new System.Drawing.Point(191, 82);
            this.ProjectNo_textBox.Name = "textBox2";
            this.ProjectNo_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectNo_textBox.TabIndex = 5;
            // 
            // textBox3
            // 
            this.ProjectLocation_textBox.Location = new System.Drawing.Point(191, 124);
            this.ProjectLocation_textBox.Name = "textBox3";
            this.ProjectLocation_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectLocation_textBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.DepartmentNo_ComboBox.FormattingEnabled = true;
            this.DepartmentNo_ComboBox.Location = new System.Drawing.Point(191, 176);
            this.DepartmentNo_ComboBox.Name = "comboBox1";
            this.DepartmentNo_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentNo_ComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DepartmentNo_ComboBox);
            this.Controls.Add(this.ProjectLocation_textBox);
            this.Controls.Add(this.ProjectNo_textBox);
            this.Controls.Add(this.ProjectName_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProjectName_textBox;
        private System.Windows.Forms.TextBox ProjectNo_textBox;
        private System.Windows.Forms.TextBox ProjectLocation_textBox;
        private System.Windows.Forms.ComboBox DepartmentNo_ComboBox;
        private System.Windows.Forms.Button button1;
    }
}