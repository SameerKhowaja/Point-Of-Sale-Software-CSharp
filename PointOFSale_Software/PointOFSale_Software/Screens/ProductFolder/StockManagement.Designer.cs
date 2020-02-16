namespace PointOFSale_Software.Screens.ProductFolder
{
    partial class StockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBTN = new System.Windows.Forms.Button();
            this.findBTN = new System.Windows.Forms.Button();
            this.CategoryNameComboTXT = new System.Windows.Forms.ComboBox();
            this.BrandNamesComboTXT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.totalStockSellingPriceLabel = new System.Windows.Forms.Label();
            this.totalStockPurchasePriceLabel = new System.Windows.Forms.Label();
            this.totalStockQuantityLabel = new System.Windows.Forms.Label();
            this.totalStockCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Names List";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.closeBTN);
            this.panel1.Controls.Add(this.findBTN);
            this.panel1.Controls.Add(this.CategoryNameComboTXT);
            this.panel1.Controls.Add(this.BrandNamesComboTXT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 129);
            this.panel1.TabIndex = 2;
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeBTN.Location = new System.Drawing.Point(211, 68);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(139, 45);
            this.closeBTN.TabIndex = 3;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // findBTN
            // 
            this.findBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.findBTN.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findBTN.Location = new System.Drawing.Point(211, 21);
            this.findBTN.Name = "findBTN";
            this.findBTN.Size = new System.Drawing.Size(139, 45);
            this.findBTN.TabIndex = 2;
            this.findBTN.Text = "Find";
            this.findBTN.UseVisualStyleBackColor = false;
            this.findBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // CategoryNameComboTXT
            // 
            this.CategoryNameComboTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryNameComboTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameComboTXT.FormattingEnabled = true;
            this.CategoryNameComboTXT.Location = new System.Drawing.Point(13, 87);
            this.CategoryNameComboTXT.Name = "CategoryNameComboTXT";
            this.CategoryNameComboTXT.Size = new System.Drawing.Size(192, 26);
            this.CategoryNameComboTXT.TabIndex = 1;
            // 
            // BrandNamesComboTXT
            // 
            this.BrandNamesComboTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandNamesComboTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNamesComboTXT.FormattingEnabled = true;
            this.BrandNamesComboTXT.Location = new System.Drawing.Point(13, 34);
            this.BrandNamesComboTXT.Name = "BrandNamesComboTXT";
            this.BrandNamesComboTXT.Size = new System.Drawing.Size(192, 26);
            this.BrandNamesComboTXT.TabIndex = 0;
            this.BrandNamesComboTXT.SelectedIndexChanged += new System.EventHandler(this.BrandNamesComboTXT_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brand List:";
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.StockDataGridView.Location = new System.Drawing.Point(11, 207);
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.Size = new System.Drawing.Size(602, 213);
            this.StockDataGridView.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.RefreshBTN);
            this.panel2.Controls.Add(this.totalStockSellingPriceLabel);
            this.panel2.Controls.Add(this.totalStockPurchasePriceLabel);
            this.panel2.Controls.Add(this.totalStockQuantityLabel);
            this.panel2.Controls.Add(this.totalStockCountLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(374, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 167);
            this.panel2.TabIndex = 2;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.RefreshBTN.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshBTN.Location = new System.Drawing.Point(39, 119);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(143, 36);
            this.RefreshBTN.TabIndex = 0;
            this.RefreshBTN.Text = "Clear All";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click_1);
            // 
            // totalStockSellingPriceLabel
            // 
            this.totalStockSellingPriceLabel.AutoSize = true;
            this.totalStockSellingPriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalStockSellingPriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockSellingPriceLabel.Location = new System.Drawing.Point(109, 91);
            this.totalStockSellingPriceLabel.Name = "totalStockSellingPriceLabel";
            this.totalStockSellingPriceLabel.Size = new System.Drawing.Size(19, 21);
            this.totalStockSellingPriceLabel.TabIndex = 0;
            this.totalStockSellingPriceLabel.Text = "0";
            // 
            // totalStockPurchasePriceLabel
            // 
            this.totalStockPurchasePriceLabel.AutoSize = true;
            this.totalStockPurchasePriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalStockPurchasePriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockPurchasePriceLabel.Location = new System.Drawing.Point(109, 70);
            this.totalStockPurchasePriceLabel.Name = "totalStockPurchasePriceLabel";
            this.totalStockPurchasePriceLabel.Size = new System.Drawing.Size(19, 21);
            this.totalStockPurchasePriceLabel.TabIndex = 0;
            this.totalStockPurchasePriceLabel.Text = "0";
            // 
            // totalStockQuantityLabel
            // 
            this.totalStockQuantityLabel.AutoSize = true;
            this.totalStockQuantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalStockQuantityLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockQuantityLabel.Location = new System.Drawing.Point(109, 49);
            this.totalStockQuantityLabel.Name = "totalStockQuantityLabel";
            this.totalStockQuantityLabel.Size = new System.Drawing.Size(19, 21);
            this.totalStockQuantityLabel.TabIndex = 0;
            this.totalStockQuantityLabel.Text = "0";
            // 
            // totalStockCountLabel
            // 
            this.totalStockCountLabel.AutoSize = true;
            this.totalStockCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalStockCountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockCountLabel.Location = new System.Drawing.Point(106, 17);
            this.totalStockCountLabel.Name = "totalStockCountLabel";
            this.totalStockCountLabel.Size = new System.Drawing.Size(23, 26);
            this.totalStockCountLabel.TabIndex = 0;
            this.totalStockCountLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Selling Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purchase Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtered Result";
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 435);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockManagement";
            this.Resizable = false;
            this.Text = "Stock Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CategoryNameComboTXT;
        private System.Windows.Forms.ComboBox BrandNamesComboTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.Label totalStockCountLabel;
        private System.Windows.Forms.Label totalStockQuantityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalStockSellingPriceLabel;
        private System.Windows.Forms.Label totalStockPurchasePriceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}