namespace PointOFSale_Software.Screens.ProductFolder
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.CustomeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.DateANDTimeTXT = new System.Windows.Forms.TextBox();
            this.CustomerIDTXT = new System.Windows.Forms.TextBox();
            this.Cus_NameTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cus_NumberTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cus_EmailTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cus_AddressTXT = new System.Windows.Forms.TextBox();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.AddNewCustomerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomeDataGridView
            // 
            this.CustomeDataGridView.AllowUserToAddRows = false;
            this.CustomeDataGridView.AllowUserToDeleteRows = false;
            this.CustomeDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomeDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomeDataGridView.Location = new System.Drawing.Point(13, 73);
            this.CustomeDataGridView.MultiSelect = false;
            this.CustomeDataGridView.Name = "CustomeDataGridView";
            this.CustomeDataGridView.ReadOnly = true;
            this.CustomeDataGridView.Size = new System.Drawing.Size(643, 189);
            this.CustomeDataGridView.TabIndex = 0;
            this.CustomeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomeDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(344, 43);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(312, 27);
            this.SearchTXT.TabIndex = 0;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // DateANDTimeTXT
            // 
            this.DateANDTimeTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateANDTimeTXT.Location = new System.Drawing.Point(366, 268);
            this.DateANDTimeTXT.Name = "DateANDTimeTXT";
            this.DateANDTimeTXT.ReadOnly = true;
            this.DateANDTimeTXT.Size = new System.Drawing.Size(290, 25);
            this.DateANDTimeTXT.TabIndex = 37;
            // 
            // CustomerIDTXT
            // 
            this.CustomerIDTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTXT.Location = new System.Drawing.Point(122, 268);
            this.CustomerIDTXT.Name = "CustomerIDTXT";
            this.CustomerIDTXT.ReadOnly = true;
            this.CustomerIDTXT.Size = new System.Drawing.Size(88, 25);
            this.CustomerIDTXT.TabIndex = 38;
            // 
            // Cus_NameTXT
            // 
            this.Cus_NameTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_NameTXT.Location = new System.Drawing.Point(146, 298);
            this.Cus_NameTXT.Name = "Cus_NameTXT";
            this.Cus_NameTXT.Size = new System.Drawing.Size(217, 25);
            this.Cus_NameTXT.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Product Date/Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Phone Number:";
            // 
            // Cus_NumberTXT
            // 
            this.Cus_NumberTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_NumberTXT.Location = new System.Drawing.Point(146, 329);
            this.Cus_NumberTXT.Name = "Cus_NumberTXT";
            this.Cus_NumberTXT.Size = new System.Drawing.Size(217, 25);
            this.Cus_NumberTXT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email Address:";
            // 
            // Cus_EmailTXT
            // 
            this.Cus_EmailTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_EmailTXT.Location = new System.Drawing.Point(146, 360);
            this.Cus_EmailTXT.Name = "Cus_EmailTXT";
            this.Cus_EmailTXT.Size = new System.Drawing.Size(217, 25);
            this.Cus_EmailTXT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Address:";
            // 
            // Cus_AddressTXT
            // 
            this.Cus_AddressTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_AddressTXT.Location = new System.Drawing.Point(146, 391);
            this.Cus_AddressTXT.Multiline = true;
            this.Cus_AddressTXT.Name = "Cus_AddressTXT";
            this.Cus_AddressTXT.Size = new System.Drawing.Size(217, 62);
            this.Cus_AddressTXT.TabIndex = 4;
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseBTN.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBTN.Location = new System.Drawing.Point(512, 403);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(144, 50);
            this.CloseBTN.TabIndex = 9;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteBTN.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBTN.Location = new System.Drawing.Point(512, 301);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(144, 50);
            this.DeleteBTN.TabIndex = 6;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.RefreshBTN.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshBTN.Location = new System.Drawing.Point(369, 403);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(144, 50);
            this.RefreshBTN.TabIndex = 8;
            this.RefreshBTN.Text = "Refresh";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateBTN.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBTN.Location = new System.Drawing.Point(368, 301);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(144, 50);
            this.UpdateBTN.TabIndex = 5;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // AddNewCustomerBTN
            // 
            this.AddNewCustomerBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.AddNewCustomerBTN.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCustomerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewCustomerBTN.Location = new System.Drawing.Point(369, 352);
            this.AddNewCustomerBTN.Name = "AddNewCustomerBTN";
            this.AddNewCustomerBTN.Size = new System.Drawing.Size(287, 50);
            this.AddNewCustomerBTN.TabIndex = 7;
            this.AddNewCustomerBTN.Text = "Add New Customer";
            this.AddNewCustomerBTN.UseVisualStyleBackColor = false;
            this.AddNewCustomerBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 463);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.RefreshBTN);
            this.Controls.Add(this.AddNewCustomerBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.DateANDTimeTXT);
            this.Controls.Add(this.CustomerIDTXT);
            this.Controls.Add(this.Cus_AddressTXT);
            this.Controls.Add(this.Cus_EmailTXT);
            this.Controls.Add(this.Cus_NumberTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cus_NameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.CustomeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerManagement";
            this.Resizable = false;
            this.Text = "Customer Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.TextBox DateANDTimeTXT;
        private System.Windows.Forms.TextBox CustomerIDTXT;
        private System.Windows.Forms.TextBox Cus_NameTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cus_NumberTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cus_EmailTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cus_AddressTXT;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button AddNewCustomerBTN;
    }
}