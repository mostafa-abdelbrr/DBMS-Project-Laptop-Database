
namespace Laptop_Database_System
{
    partial class adminProm
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
            this.prom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prom)).BeginInit();
            this.SuspendLayout();
            // 
            // prom
            // 
            this.prom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prom.Location = new System.Drawing.Point(12, 34);
            this.prom.Name = "prom";
            this.prom.Size = new System.Drawing.Size(776, 381);
            this.prom.TabIndex = 0;
            // 
            // adminProm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prom);
            this.Name = "adminProm";
            this.Text = "adminProm";
            this.Load += new System.EventHandler(this.adminProm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prom;
    }
}