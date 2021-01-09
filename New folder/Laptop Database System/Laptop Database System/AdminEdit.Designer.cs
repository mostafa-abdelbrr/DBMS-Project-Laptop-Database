namespace Laptop_Database_System
{
    partial class AdminEdit
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
            this.EditLTdg = new System.Windows.Forms.DataGridView();
            this.ConfirmEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EditLTdg)).BeginInit();
            this.SuspendLayout();
            // 
            // EditLTdg
            // 
            this.EditLTdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditLTdg.Location = new System.Drawing.Point(12, 33);
            this.EditLTdg.Name = "EditLTdg";
            this.EditLTdg.Size = new System.Drawing.Size(776, 375);
            this.EditLTdg.TabIndex = 0;
            this.EditLTdg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditLTdg_KeyDown);
            this.EditLTdg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditLTdg_KeyPress);
            // 
            // ConfirmEdit
            // 
            this.ConfirmEdit.Location = new System.Drawing.Point(633, 415);
            this.ConfirmEdit.Name = "ConfirmEdit";
            this.ConfirmEdit.Size = new System.Drawing.Size(155, 23);
            this.ConfirmEdit.TabIndex = 1;
            this.ConfirmEdit.Text = "Confirm Edits";
            this.ConfirmEdit.UseVisualStyleBackColor = true;
            this.ConfirmEdit.Click += new System.EventHandler(this.ConfirmEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press (DEL) to delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change Values then click confirm edit";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laptop",
            "GPU",
            "CPU",
            "OS"});
            this.comboBox1.Location = new System.Drawing.Point(503, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select what to edit";
            // 
            // AdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmEdit);
            this.Controls.Add(this.EditLTdg);
            this.Name = "AdminEdit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditLTdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditLTdg;
        private System.Windows.Forms.Button ConfirmEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}