namespace PointOFSale_Software.Screens.ProductFolder
{
    partial class DefineProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineProductScreen));
            this.CloseBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.RefreshAllBTN = new System.Windows.Forms.Button();
            this.UploadImageBTN = new System.Windows.Forms.Button();
            this.ProductImageBox = new System.Windows.Forms.PictureBox();
            this.BrandNameComboTxt = new System.Windows.Forms.ComboBox();
            this.SellingPriceTXT = new System.Windows.Forms.TextBox();
            this.PurchasePriceTXT = new System.Windows.Forms.TextBox();
            this.DescriptionTXT = new System.Windows.Forms.TextBox();
            this.QuantityTXT = new System.Windows.Forms.TextBox();
            this.ProductNameTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryComboTXT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CloseBTN.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBTN.Location = new System.Drawing.Point(388, 299);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(144, 45);
            this.CloseBTN.TabIndex = 9;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveBTN.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBTN.Location = new System.Drawing.Point(388, 253);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(144, 45);
            this.SaveBTN.TabIndex = 8;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // RefreshAllBTN
            // 
            this.RefreshAllBTN.BackColor = System.Drawing.Color.Transparent;
            this.RefreshAllBTN.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshAllBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshAllBTN.Image = global::PointOFSale_Software.Properties.Resources.synchronize_40px;
            this.RefreshAllBTN.Location = new System.Drawing.Point(309, 200);
            this.RefreshAllBTN.Name = "RefreshAllBTN";
            this.RefreshAllBTN.Size = new System.Drawing.Size(50, 50);
            this.RefreshAllBTN.TabIndex = 10;
            this.RefreshAllBTN.UseVisualStyleBackColor = false;
            this.RefreshAllBTN.Click += new System.EventHandler(this.RefreshAllBTN_Click);
            // 
            // UploadImageBTN
            // 
            this.UploadImageBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.UploadImageBTN.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadImageBTN.Location = new System.Drawing.Point(389, 211);
            this.UploadImageBTN.Name = "UploadImageBTN";
            this.UploadImageBTN.Size = new System.Drawing.Size(143, 36);
            this.UploadImageBTN.TabIndex = 7;
            this.UploadImageBTN.Text = "Upload";
            this.UploadImageBTN.UseVisualStyleBackColor = false;
            this.UploadImageBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductImageBox
            // 
            this.ProductImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImageBox.Image = global::PointOFSale_Software.Properties.Resources.image;
            this.ProductImageBox.Location = new System.Drawing.Point(389, 53);
            this.ProductImageBox.Name = "ProductImageBox";
            this.ProductImageBox.Size = new System.Drawing.Size(143, 154);
            this.ProductImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImageBox.TabIndex = 36;
            this.ProductImageBox.TabStop = false;
            // 
            // BrandNameComboTxt
            // 
            this.BrandNameComboTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BrandNameComboTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BrandNameComboTxt.DisplayMember = "None";
            this.BrandNameComboTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandNameComboTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameComboTxt.FormattingEnabled = true;
            this.BrandNameComboTxt.Location = new System.Drawing.Point(140, 95);
            this.BrandNameComboTxt.Name = "BrandNameComboTxt";
            this.BrandNameComboTxt.Size = new System.Drawing.Size(219, 27);
            this.BrandNameComboTxt.TabIndex = 1;
            this.BrandNameComboTxt.SelectedIndexChanged += new System.EventHandler(this.BrandNameComboTxt_SelectedIndexChanged);
            // 
            // SellingPriceTXT
            // 
            this.SellingPriceTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPriceTXT.Location = new System.Drawing.Point(140, 225);
            this.SellingPriceTXT.Name = "SellingPriceTXT";
            this.SellingPriceTXT.Size = new System.Drawing.Size(160, 25);
            this.SellingPriceTXT.TabIndex = 5;
            // 
            // PurchasePriceTXT
            // 
            this.PurchasePriceTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceTXT.Location = new System.Drawing.Point(140, 193);
            this.PurchasePriceTXT.Name = "PurchasePriceTXT";
            this.PurchasePriceTXT.Size = new System.Drawing.Size(160, 25);
            this.PurchasePriceTXT.TabIndex = 4;
            // 
            // DescriptionTXT
            // 
            this.DescriptionTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTXT.Location = new System.Drawing.Point(140, 257);
            this.DescriptionTXT.Multiline = true;
            this.DescriptionTXT.Name = "DescriptionTXT";
            this.DescriptionTXT.Size = new System.Drawing.Size(219, 87);
            this.DescriptionTXT.TabIndex = 6;
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTXT.Location = new System.Drawing.Point(140, 161);
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(160, 25);
            this.QuantityTXT.TabIndex = 3;
            // 
            // ProductNameTXT
            // 
            this.ProductNameTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTXT.Location = new System.Drawing.Point(140, 63);
            this.ProductNameTXT.Name = "ProductNameTXT";
            this.ProductNameTXT.Size = new System.Drawing.Size(219, 25);
            this.ProductNameTXT.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Product Picture (IF ANY)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Selling Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Purchase Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Brand Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Product Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Category:";
            // 
            // CategoryComboTXT
            // 
            this.CategoryComboTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CategoryComboTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryComboTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboTXT.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboTXT.FormattingEnabled = true;
            this.CategoryComboTXT.Location = new System.Drawing.Point(140, 128);
            this.CategoryComboTXT.Name = "CategoryComboTXT";
            this.CategoryComboTXT.Size = new System.Drawing.Size(219, 27);
            this.CategoryComboTXT.TabIndex = 2;
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.RefreshAllBTN);
            this.Controls.Add(this.UploadImageBTN);
            this.Controls.Add(this.ProductImageBox);
            this.Controls.Add(this.CategoryComboTXT);
            this.Controls.Add(this.BrandNameComboTxt);
            this.Controls.Add(this.SellingPriceTXT);
            this.Controls.Add(this.PurchasePriceTXT);
            this.Controls.Add(this.DescriptionTXT);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.ProductNameTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineProductScreen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Product Definition";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button RefreshAllBTN;
        private System.Windows.Forms.Button UploadImageBTN;
        private System.Windows.Forms.PictureBox ProductImageBox;
        private System.Windows.Forms.ComboBox BrandNameComboTxt;
        private System.Windows.Forms.TextBox SellingPriceTXT;
        private System.Windows.Forms.TextBox PurchasePriceTXT;
        private System.Windows.Forms.TextBox DescriptionTXT;
        private System.Windows.Forms.TextBox ProductNameTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CategoryComboTXT;
    }
}