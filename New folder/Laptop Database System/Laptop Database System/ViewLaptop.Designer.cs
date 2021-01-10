
namespace Laptop_Database_System
{
    partial class ViewLaptop
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
            this.Rate = new System.Windows.Forms.Label();
            this.RateText = new System.Windows.Forms.TextBox();
            this.RateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(79, 434);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(105, 17);
            this.Rate.TabIndex = 24;
            this.Rate.Text = "Add your rating";
            this.Rate.Visible = false;
            // 
            // RateText
            // 
            this.RateText.Location = new System.Drawing.Point(248, 431);
            this.RateText.Name = "RateText";
            this.RateText.Size = new System.Drawing.Size(246, 22);
            this.RateText.TabIndex = 25;
            this.RateText.Visible = false;
            // 
            // RateButton
            // 
            this.RateButton.Location = new System.Drawing.Point(574, 434);
            this.RateButton.Name = "RateButton";
            this.RateButton.Size = new System.Drawing.Size(147, 23);
            this.RateButton.TabIndex = 26;
            this.RateButton.Text = "Rate";
            this.RateButton.UseVisualStyleBackColor = true;
            this.RateButton.Visible = false;
            this.RateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Main Information",
            "Processor",
            "Graphics Card",
            "RAM",
            "Keyboard",
            "Screen",
            "Operation System",
            "USB Port",
            "Storage",
            "Manufacturer Information",
            "Store Information"});
            this.comboBox1.Location = new System.Drawing.Point(248, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select Specifications";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 126);
            this.dataGridView1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ratings";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 282);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(739, 123);
            this.dataGridView2.TabIndex = 32;
            // 
            // ViewLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 494);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RateButton);
            this.Controls.Add(this.RateText);
            this.Controls.Add(this.Rate);
            this.Name = "ViewLaptop";
            this.Text = "View Laptop";
            this.Load += new System.EventHandler(this.ViewLaptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox RateText;
        private System.Windows.Forms.Button RateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}