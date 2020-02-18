namespace PointOFSale_Software.Screens.ProductFolder
{
    partial class AddNewSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSalesOrder));
            this.CustomerNamesComboTXT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityTXT = new System.Windows.Forms.TextBox();
            this.priceTotalLabel = new System.Windows.Forms.Label();
            this.addProductBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityLeftLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.CartListView = new System.Windows.Forms.ListView();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.AddCustomerBTN = new System.Windows.Forms.Button();
            this.ProductImageBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.distinctProductLabel = new System.Windows.Forms.Label();
            this.quantityTotalLabel = new System.Windows.Forms.Label();
            this.amountTotalLabel = new System.Windows.Forms.Label();
            this.clearCartBTN = new System.Windows.Forms.Button();
            this.deleteProductBTN = new System.Windows.Forms.Button();
            this.proceedBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.CashRecievedTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNamesComboTXT
            // 
            this.CustomerNamesComboTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerNamesComboTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNamesComboTXT.FormattingEnabled = true;
            this.CustomerNamesComboTXT.Location = new System.Drawing.Point(17, 86);
            this.CustomerNamesComboTXT.Name = "CustomerNamesComboTXT";
            this.CustomerNamesComboTXT.Size = new System.Drawing.Size(246, 26);
            this.CustomerNamesComboTXT.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name:";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductDataGridView.Location = new System.Drawing.Point(13, 147);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.Size = new System.Drawing.Size(353, 159);
            this.ProductDataGridView.TabIndex = 2;
            this.ProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick);
            this.ProductDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductDataGridView_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(113, 2);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(18, 20);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "0";
            // 
            // quantityTXT
            // 
            this.quantityTXT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTXT.Location = new System.Drawing.Point(84, 56);
            this.quantityTXT.Name = "quantityTXT";
            this.quantityTXT.Size = new System.Drawing.Size(102, 26);
            this.quantityTXT.TabIndex = 0;
            this.quantityTXT.Text = "0";
            this.quantityTXT.TextChanged += new System.EventHandler(this.quantityTXT_TextChanged);
            // 
            // priceTotalLabel
            // 
            this.priceTotalLabel.AutoSize = true;
            this.priceTotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTotalLabel.Location = new System.Drawing.Point(103, 89);
            this.priceTotalLabel.Name = "priceTotalLabel";
            this.priceTotalLabel.Size = new System.Drawing.Size(20, 22);
            this.priceTotalLabel.TabIndex = 5;
            this.priceTotalLabel.Text = "0";
            // 
            // addProductBTN
            // 
            this.addProductBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.addProductBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProductBTN.Location = new System.Drawing.Point(8, 112);
            this.addProductBTN.Name = "addProductBTN";
            this.addProductBTN.Size = new System.Drawing.Size(215, 41);
            this.addProductBTN.TabIndex = 1;
            this.addProductBTN.Text = "Add Product";
            this.addProductBTN.UseVisualStyleBackColor = false;
            this.addProductBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity Left:";
            // 
            // quantityLeftLabel
            // 
            this.quantityLeftLabel.AutoSize = true;
            this.quantityLeftLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLeftLabel.Location = new System.Drawing.Point(113, 28);
            this.quantityLeftLabel.Name = "quantityLeftLabel";
            this.quantityLeftLabel.Size = new System.Drawing.Size(18, 20);
            this.quantityLeftLabel.TabIndex = 5;
            this.quantityLeftLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addProductBTN);
            this.panel1.Controls.Add(this.quantityTXT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.priceTotalLabel);
            this.panel1.Controls.Add(this.quantityLeftLabel);
            this.panel1.Location = new System.Drawing.Point(13, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 165);
            this.panel1.TabIndex = 7;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(253, 459);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(15, 19);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "..";
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderIDLabel.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.Location = new System.Drawing.Point(261, 23);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(331, 30);
            this.orderIDLabel.TabIndex = 2;
            this.orderIDLabel.Text = "(OrderID#\" + OrderID + \")";
            // 
            // CartListView
            // 
            this.CartListView.Location = new System.Drawing.Point(372, 67);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(438, 239);
            this.CartListView.TabIndex = 52;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(253, 438);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(15, 19);
            this.productIDLabel.TabIndex = 5;
            this.productIDLabel.Text = "..";
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.Color.Transparent;
            this.refreshBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshBTN.Image = global::PointOFSale_Software.Properties.Resources.synchronize_40px;
            this.refreshBTN.Location = new System.Drawing.Point(316, 67);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(50, 47);
            this.refreshBTN.TabIndex = 1;
            this.refreshBTN.UseVisualStyleBackColor = false;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // AddCustomerBTN
            // 
            this.AddCustomerBTN.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCustomerBTN.Image = global::PointOFSale_Software.Properties.Resources.add_user_group_woman_man_40px;
            this.AddCustomerBTN.Location = new System.Drawing.Point(266, 67);
            this.AddCustomerBTN.Name = "AddCustomerBTN";
            this.AddCustomerBTN.Size = new System.Drawing.Size(50, 47);
            this.AddCustomerBTN.TabIndex = 1;
            this.AddCustomerBTN.UseVisualStyleBackColor = false;
            this.AddCustomerBTN.Click += new System.EventHandler(this.AddCustomerBTN_Click);
            // 
            // ProductImageBox
            // 
            this.ProductImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductImageBox.Image = global::PointOFSale_Software.Properties.Resources.image;
            this.ProductImageBox.Location = new System.Drawing.Point(253, 311);
            this.ProductImageBox.Name = "ProductImageBox";
            this.ProductImageBox.Size = new System.Drawing.Size(113, 129);
            this.ProductImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImageBox.TabIndex = 51;
            this.ProductImageBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Distinct Products:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total Amount:";
            // 
            // distinctProductLabel
            // 
            this.distinctProductLabel.AutoSize = true;
            this.distinctProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distinctProductLabel.Location = new System.Drawing.Point(620, 311);
            this.distinctProductLabel.Name = "distinctProductLabel";
            this.distinctProductLabel.Size = new System.Drawing.Size(24, 25);
            this.distinctProductLabel.TabIndex = 5;
            this.distinctProductLabel.Text = "0";
            // 
            // quantityTotalLabel
            // 
            this.quantityTotalLabel.AutoSize = true;
            this.quantityTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTotalLabel.Location = new System.Drawing.Point(620, 338);
            this.quantityTotalLabel.Name = "quantityTotalLabel";
            this.quantityTotalLabel.Size = new System.Drawing.Size(24, 25);
            this.quantityTotalLabel.TabIndex = 5;
            this.quantityTotalLabel.Text = "0";
            // 
            // amountTotalLabel
            // 
            this.amountTotalLabel.AutoSize = true;
            this.amountTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTotalLabel.Location = new System.Drawing.Point(620, 368);
            this.amountTotalLabel.Name = "amountTotalLabel";
            this.amountTotalLabel.Size = new System.Drawing.Size(25, 25);
            this.amountTotalLabel.TabIndex = 5;
            this.amountTotalLabel.Text = "0";
            // 
            // clearCartBTN
            // 
            this.clearCartBTN.Image = global::PointOFSale_Software.Properties.Resources.broom_40px;
            this.clearCartBTN.Location = new System.Drawing.Point(372, 378);
            this.clearCartBTN.Name = "clearCartBTN";
            this.clearCartBTN.Size = new System.Drawing.Size(60, 61);
            this.clearCartBTN.TabIndex = 53;
            this.clearCartBTN.UseVisualStyleBackColor = true;
            this.clearCartBTN.Click += new System.EventHandler(this.clearCartBTN_Click);
            // 
            // deleteProductBTN
            // 
            this.deleteProductBTN.Image = global::PointOFSale_Software.Properties.Resources.delete_40px;
            this.deleteProductBTN.Location = new System.Drawing.Point(372, 311);
            this.deleteProductBTN.Name = "deleteProductBTN";
            this.deleteProductBTN.Size = new System.Drawing.Size(60, 61);
            this.deleteProductBTN.TabIndex = 54;
            this.deleteProductBTN.UseVisualStyleBackColor = true;
            this.deleteProductBTN.Click += new System.EventHandler(this.deleteProductBTN_Click);
            // 
            // proceedBTN
            // 
            this.proceedBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.proceedBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.proceedBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proceedBTN.Image = global::PointOFSale_Software.Properties.Resources.paid_40px;
            this.proceedBTN.Location = new System.Drawing.Point(527, 427);
            this.proceedBTN.Name = "proceedBTN";
            this.proceedBTN.Size = new System.Drawing.Size(283, 50);
            this.proceedBTN.TabIndex = 55;
            this.proceedBTN.Text = "PROCEED";
            this.proceedBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proceedBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proceedBTN.UseVisualStyleBackColor = false;
            this.proceedBTN.Click += new System.EventHandler(this.proceedBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Price:";
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(81, 118);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(285, 27);
            this.SearchTXT.TabIndex = 1;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // CashRecievedTXT
            // 
            this.CashRecievedTXT.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRecievedTXT.Location = new System.Drawing.Point(568, 399);
            this.CashRecievedTXT.Name = "CashRecievedTXT";
            this.CashRecievedTXT.Size = new System.Drawing.Size(163, 28);
            this.CashRecievedTXT.TabIndex = 58;
            this.CashRecievedTXT.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Cash Recieved:";
            // 
            // cashCheck
            // 
            this.cashCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.cashCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashCheck.Location = new System.Drawing.Point(735, 399);
            this.cashCheck.Name = "cashCheck";
            this.cashCheck.Size = new System.Drawing.Size(75, 28);
            this.cashCheck.TabIndex = 59;
            this.cashCheck.Text = "CHECK";
            this.cashCheck.UseVisualStyleBackColor = false;
            this.cashCheck.Click += new System.EventHandler(this.cashCheck_Click);
            // 
            // AddNewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 484);
            this.Controls.Add(this.cashCheck);
            this.Controls.Add(this.CashRecievedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.proceedBTN);
            this.Controls.Add(this.deleteProductBTN);
            this.Controls.Add(this.clearCartBTN);
            this.Controls.Add(this.CartListView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.amountTotalLabel);
            this.Controls.Add(this.quantityTotalLabel);
            this.Controls.Add(this.distinctProductLabel);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.AddCustomerBTN);
            this.Controls.Add(this.ProductImageBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerNamesComboTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewSalesOrder";
            this.Resizable = false;
            this.Text = "Add New Sales Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerNamesComboTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTXT;
        private System.Windows.Forms.Label priceTotalLabel;
        private System.Windows.Forms.Button addProductBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quantityLeftLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ProductImageBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button AddCustomerBTN;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label distinctProductLabel;
        private System.Windows.Forms.Label quantityTotalLabel;
        private System.Windows.Forms.Label amountTotalLabel;
        private System.Windows.Forms.Button clearCartBTN;
        private System.Windows.Forms.Button deleteProductBTN;
        private System.Windows.Forms.Button proceedBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.TextBox CashRecievedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cashCheck;
    }
}