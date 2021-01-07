namespace Laptop_Database_System
{
    partial class check_search
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
            this.SearchDG = new System.Windows.Forms.DataGridView();
            this.userSearchDG = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSearchDG)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDG
            // 
            this.SearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDG.Location = new System.Drawing.Point(12, 410);
            this.SearchDG.Name = "SearchDG";
            this.SearchDG.Size = new System.Drawing.Size(1007, 232);
            this.SearchDG.TabIndex = 0;
            // 
            // userSearchDG
            // 
            this.userSearchDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userSearchDG.Location = new System.Drawing.Point(12, 48);
            this.userSearchDG.Name = "userSearchDG";
            this.userSearchDG.Size = new System.Drawing.Size(1007, 314);
            this.userSearchDG.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // check_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 654);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.userSearchDG);
            this.Controls.Add(this.SearchDG);
            this.Name = "check_search";
            this.Text = "check_search";
            this.Load += new System.EventHandler(this.check_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSearchDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchDG;
        private System.Windows.Forms.DataGridView userSearchDG;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}