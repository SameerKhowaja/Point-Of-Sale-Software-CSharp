namespace PointOFSale_Software.Screens.ProductFolder
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrandNameComboTxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryComboTXT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SellingPriceTXT = new System.Windows.Forms.TextBox();
            this.PurchasePriceTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UploadImageBTN = new System.Windows.Forms.Button();
            this.ProductImageBox = new System.Windows.Forms.PictureBox();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductIDTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DateANDTimeTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ProductGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductGridView.Location = new System.Drawing.Point(7, 63);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.Size = new System.Drawing.Size(668, 215);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(299, 34);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(376, 27);
            this.SearchTXT.TabIndex = 0;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // ProductNameTXT
            // 
            this.ProductNameTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTXT.Location = new System.Drawing.Point(126, 315);
            this.ProductNameTXT.Name = "ProductNameTXT";
            this.ProductNameTXT.Size = new System.Drawing.Size(217, 25);
            this.ProductNameTXT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Product Name:";
            // 
            // BrandNameComboTxt
            // 
            this.BrandNameComboTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BrandNameComboTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BrandNameComboTxt.DisplayMember = "None";
            this.BrandNameComboTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandNameComboTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameComboTxt.FormattingEnabled = true;
            this.BrandNameComboTxt.Location = new System.Drawing.Point(126, 345);
            this.BrandNameComboTxt.Name = "BrandNameComboTxt";
            this.BrandNameComboTxt.Size = new System.Drawing.Size(217, 27);
            this.BrandNameComboTxt.TabIndex = 2;
            this.BrandNameComboTxt.SelectedIndexChanged += new System.EventHandler(this.BrandNameComboTxt_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Brand Name:";
            // 
            // CategoryComboTXT
            // 
            this.CategoryComboTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CategoryComboTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryComboTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboTXT.FormattingEnabled = true;
            this.CategoryComboTXT.Location = new System.Drawing.Point(125, 378);
            this.CategoryComboTXT.Name = "CategoryComboTXT";
            this.CategoryComboTXT.Size = new System.Drawing.Size(218, 27);
            this.CategoryComboTXT.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Category:";
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTXT.Location = new System.Drawing.Point(14, 432);
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(87, 25);
            this.QuantityTXT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Purchase Price:";
            // 
            // SellingPriceTXT
            // 
            this.SellingPriceTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPriceTXT.Location = new System.Drawing.Point(240, 432);
            this.SellingPriceTXT.Name = "SellingPriceTXT";
            this.SellingPriceTXT.Size = new System.Drawing.Size(102, 25);
            this.SellingPriceTXT.TabIndex = 6;
            // 
            // PurchasePriceTXT
            // 
            this.PurchasePriceTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceTXT.Location = new System.Drawing.Point(115, 432);
            this.PurchasePriceTXT.Name = "PurchasePriceTXT";
            this.PurchasePriceTXT.Size = new System.Drawing.Size(109, 25);
            this.PurchasePriceTXT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Selling Price:";
            // 
            // DescriptionTXT
            // 
            this.DescriptionTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTXT.Location = new System.Drawing.Point(104, 462);
            this.DescriptionTXT.Multiline = true;
            this.DescriptionTXT.Name = "DescriptionTXT";
            this.DescriptionTXT.Size = new System.Drawing.Size(239, 49);
            this.DescriptionTXT.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Description:";
            // 
            // UploadImageBTN
            // 
            this.UploadImageBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.UploadImageBTN.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadImageBTN.Location = new System.Drawing.Point(364, 475);
            this.UploadImageBTN.Name = "UploadImageBTN";
            this.UploadImageBTN.Size = new System.Drawing.Size(143, 36);
            this.UploadImageBTN.TabIndex = 8;
            this.UploadImageBTN.Text = "Upload";
            this.UploadImageBTN.UseVisualStyleBackColor = false;
            this.UploadImageBTN.Click += new System.EventHandler(this.UploadImageBTN_Click);
            // 
            // ProductImageBox
            // 
            this.ProductImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImageBox.Image = global::PointOFSale_Software.Properties.Resources.image;
            this.ProductImageBox.Location = new System.Drawing.Point(364, 315);
            this.ProductImageBox.Name = "ProductImageBox";
            this.ProductImageBox.Size = new System.Drawing.Size(143, 154);
            this.ProductImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImageBox.TabIndex = 50;
            this.ProductImageBox.TabStop = false;
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CloseBTN.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBTN.Location = new System.Drawing.Point(513, 461);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(166, 46);
            this.CloseBTN.TabIndex = 12;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateBTN.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBTN.Location = new System.Drawing.Point(513, 323);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(166, 46);
            this.UpdateBTN.TabIndex = 9;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteBTN.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBTN.Location = new System.Drawing.Point(513, 369);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(166, 46);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RefreshBTN.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshBTN.Location = new System.Drawing.Point(513, 415);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(166, 46);
            this.RefreshBTN.TabIndex = 11;
            this.RefreshBTN.Text = "Refresh";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Product ID:";
            // 
            // ProductIDTXT
            // 
            this.ProductIDTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTXT.Location = new System.Drawing.Point(104, 284);
            this.ProductIDTXT.Name = "ProductIDTXT";
            this.ProductIDTXT.ReadOnly = true;
            this.ProductIDTXT.Size = new System.Drawing.Size(79, 25);
            this.ProductIDTXT.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Product Date/Time:";
            // 
            // DateANDTimeTXT
            // 
            this.DateANDTimeTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateANDTimeTXT.Location = new System.Drawing.Point(377, 284);
            this.DateANDTimeTXT.Name = "DateANDTimeTXT";
            this.DateANDTimeTXT.ReadOnly = true;
            this.DateANDTimeTXT.Size = new System.Drawing.Size(298, 25);
            this.DateANDTimeTXT.TabIndex = 1;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 519);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.RefreshBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.ProductImageBox);
            this.Controls.Add(this.UploadImageBTN);
            this.Controls.Add(this.DescriptionTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SellingPriceTXT);
            this.Controls.Add(this.PurchasePriceTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoryComboTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BrandNameComboTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateANDTimeTXT);
            this.Controls.Add(this.ProductIDTXT);
            this.Controls.Add(this.ProductNameTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.ProductGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageProduct";
            this.Resizable = false;
            this.Text = "Manage Product";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BrandNameComboTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoryComboTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantityTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SellingPriceTXT;
        private System.Windows.Forms.TextBox PurchasePriceTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescriptionTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UploadImageBTN;
        private System.Windows.Forms.PictureBox ProductImageBox;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductIDTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DateANDTimeTXT;
    }
}