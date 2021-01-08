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
            // AdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmEdit);
            this.Controls.Add(this.EditLTdg);
            this.Name = "AdminEdit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditLTdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditLTdg;
        private System.Windows.Forms.Button ConfirmEdit;
    }
}