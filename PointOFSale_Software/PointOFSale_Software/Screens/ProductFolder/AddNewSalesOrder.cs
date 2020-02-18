using PointOFSale_Software.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PointOFSale_Software.Screens.ProductFolder
{
    public partial class AddNewSalesOrder : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();
        DataTable dt;
        string OrderID;

        public AddNewSalesOrder()
        {
            InitializeComponent();
        }

        //Random ID Generator
        private static Random random = new Random();
        public string RandomString()
        {
            int length = 14;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //

        private void CustomerComboBox_Refresh()
        {
            CustomerNamesComboTXT.Items.Clear();
            string name, id;

            string Query = "SELECT CustomerID, Name FROM dbo.CustomerInformation";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        id = rdr["CustomerID"].ToString();
                        name = rdr["Name"].ToString();
                        CustomerNamesComboTXT.Items.Add(name.Trim() + "  ID:"+id);
                    }
                    cmd.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void RefreshGridView()
        {
            string Query = "SELECT ProductID, ProductName, BrandName, CategoryName FROM dbo.ProductsDefinition";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(Query, con);
                    dt = new DataTable();
                    sqlData.Fill(dt);

                    ProductDataGridView.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void AddNewSalesOrder_Load(object sender, EventArgs e)
        {
            OrderID = RandomString();
            orderIDLabel.Text = "(OrderID#" + OrderID + ")";
            SetupListView();

            CustomerComboBox_Refresh();
            RefreshGridView();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ProductName like '%{0}%' or BrandName like '%{0}%' or CategoryName like '%{0}%'", SearchTXT.Text);
            ProductDataGridView.DataSource = dv.ToTable();
        }

        private void quantityTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float quant = float.Parse(quantityTXT.Text);
                float price = float.Parse(priceLabel.Text);
                float TPrice = quant * price;
                priceTotalLabel.Text = TPrice.ToString();

                float quant_Left = float.Parse(quantityLeftLabel.Text);
                if (quant > quant_Left)
                {
                    MessageBox.Show("Quantity Limit Exceeds");
                    quantityTXT.Text = quant_Left.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Valid Number");
                if(quantityTXT.Text != null)
                {
                    quantityTXT.Text = "0";
                }
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ProductLoadFromDataBase_OnClick(DataGridViewCellEventArgs e)
        {
            string ID;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDataGridView.Rows[e.RowIndex];

                ID = row.Cells["ProductID"].Value.ToString();
                productIDLabel.Text = ID;
                productNameLabel.Text = row.Cells["ProductName"].Value.ToString();

                int ProductIDINT = int.Parse(ID);
                string Query = "SELECT Quantity, SellingPrice, ProductImage FROM dbo.ProductsDefinition WHERE ProductID ='" + ProductIDINT + "'";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            quantityLeftLabel.Text = rdr["Quantity"].ToString();
                            priceLabel.Text = rdr["SellingPrice"].ToString();
                            ProductImageBox.Image = byteArrayToImage((byte[])rdr["ProductImage"]);
                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                        con.Close();
                    }
                }
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductLoadFromDataBase_OnClick(e);
        }

        private void ProductLoadFromDataBase_OnKeyEvent()
        {
            string ID = ProductDataGridView.CurrentRow.Cells[0].Value.ToString();
            productIDLabel.Text = ID;
            productNameLabel.Text = ProductDataGridView.CurrentRow.Cells[1].Value.ToString();

            int ProductIDINT = int.Parse(ID);
            string Query = "SELECT Quantity, SellingPrice, ProductImage FROM dbo.ProductsDefinition WHERE ProductID ='" + ProductIDINT + "'";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        quantityLeftLabel.Text = rdr["Quantity"].ToString();
                        priceLabel.Text = rdr["SellingPrice"].ToString();
                        ProductImageBox.Image = byteArrayToImage((byte[])rdr["ProductImage"]);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void ProductDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            ProductLoadFromDataBase_OnKeyEvent();
        }

        private void AddCustomerBTN_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.Show();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            CustomerComboBox_Refresh();
        }

        private void SetupListView()
        {
            CartListView.View = View.Details;
            CartListView.FullRowSelect = true;
            //Col
            CartListView.Columns.Add("ID", 40);
            CartListView.Columns.Add("Product Name", 160);
            CartListView.Columns.Add("Price", 70);
            CartListView.Columns.Add("Quantity", 70);
            CartListView.Columns.Add("Total Price", 90);
        }

        private void AddTOList()
        {
            bool allowToAdd = true;
            if (productNameLabel.Text != "..." && productNameLabel.Text != "" && quantityTXT.Text != null && quantityTXT.Text != "0" && quantityTXT.Text != "")
            {
                string idTemp;
                for (int i = 0; i < CartListView.Items.Count; i++)
                {
                    idTemp = CartListView.Items[i].SubItems[0].Text;

                    if (productIDLabel.Text == idTemp.ToString())
                    {
                        float addQuantity = float.Parse(quantityTXT.Text);
                        addQuantity += float.Parse(CartListView.Items[i].SubItems[3].Text);
                        if(addQuantity <= float.Parse(quantityLeftLabel.Text))
                        {
                            CartListView.Items[i].SubItems[3].Text = addQuantity.ToString();
                        }
                        else
                        {
                            float Quan_Limit = float.Parse(quantityLeftLabel.Text) - float.Parse(CartListView.Items[i].SubItems[3].Text);
                            MessageBox.Show("Quantity Limit (less than or equal to) : " + Quan_Limit, "You are Exceeding Limits");
                        }

                        float addPrice = float.Parse(priceTotalLabel.Text);
                        addPrice += float.Parse(CartListView.Items[i].SubItems[4].Text);
                        CartListView.Items[i].SubItems[4].Text = addPrice.ToString();

                        quantityTXT.Text = "0";
                        //Total Calculating
                        Calculation();
                        allowToAdd = false;
                        break;
                    }
                }

                if (CartListView.Items.Count == 0 || allowToAdd == true)
                {
                    string[] row = { productIDLabel.Text, productNameLabel.Text.Trim(), priceLabel.Text.Trim(), quantityTXT.Text.Trim(), priceTotalLabel.Text.Trim() };
                    ListViewItem item = new ListViewItem(row);
                    CartListView.Items.Add(item);
                    quantityTXT.Text = "0";
                    //Total Calculating
                    Calculation();
                }
                
            }
            else
            {
                MessageBox.Show("Some Fields are Missing");
            }
        }

        private void Calculation()
        {
            string distinctProduct = CartListView.Items.Count.ToString();
            distinctProductLabel.Text = distinctProduct;

            float quantity = 0;
            float Tprice = 0;
            for (int i = 0; i < CartListView.Items.Count; i++)
            {
                quantity += float.Parse(CartListView.Items[i].SubItems[3].Text);
                Tprice += float.Parse(CartListView.Items[i].SubItems[4].Text);
            }
            quantityTotalLabel.Text = quantity.ToString();
            amountTotalLabel.Text = Tprice.ToString();
        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
            AddTOList();
        }

        private void clearCartBTN_Click(object sender, EventArgs e)
        {
            CartListView.Items.Clear();
            distinctProductLabel.Text = "0";
            quantityTotalLabel.Text = "0";
            amountTotalLabel.Text = "0";
        }

        private void deleteProductBTN_Click(object sender, EventArgs e)
        {
            CartListView.Items.RemoveAt(CartListView.SelectedIndices[0]);
            Calculation();
        }

        private void cashCheck_Click(object sender, EventArgs e)
        {
            if (CashRecievedTXT.Text != "0" && CashRecievedTXT.Text != null && amountTotalLabel.Text != "0" && float.Parse(CashRecievedTXT.Text) > float.Parse(amountTotalLabel.Text))
            {
                try
                {
                    float CashRecieved = float.Parse(CashRecievedTXT.Text);
                    float TotalAmount = float.Parse(amountTotalLabel.Text);
                    float returnCash = CashRecieved - TotalAmount;
                    MessageBox.Show("Cash Return Amount : "+returnCash);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid Cash Amount");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Recieved Cash Amount OR Add a Product OR Less Cash Recieved");
            }

        }

        private string GetDateTime()
        {
            string DateANDTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            return DateANDTime;
        }

        private string getCustomerID()
        {
            string Cust_ID = CustomerNamesComboTXT.Text;
            string newString = Regex.Replace(Cust_ID, "[a-z]", "");
            newString = Regex.Replace(newString, "[A-Z]", "");
            newString = Regex.Replace(newString, "[:]", "");
            return newString;
        }

        private void AddOrderDetailsTo_Database()
        {
            string DateANDTime = GetDateTime();
            string CustomerID_ = getCustomerID();

            string Query = "INSERT INTO dbo.InvoiceDetails (InvoiceNumber, CustomerID, DistinctProducts, TotalQuantity, TotalAmount, CashRecieved, DateANDTime) VALUES('" + OrderID + "', '" + int.Parse(CustomerID_) + "', '" + int.Parse(distinctProductLabel.Text) + "', '" + float.Parse(quantityTotalLabel.Text) + "', '" + amountTotalLabel.Text + "', '" + CashRecievedTXT.Text + "', '" + DateANDTime + "')";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr;

                    con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read()) { }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void AddOrderProductDetailsTo_Database()
        {
            int arraySize = CartListView.Items.Count;
            int[] product_ID = new int[arraySize];
            float[] product_quantity = new float[arraySize];
            float[] product_sellingPrice = new float[arraySize];

            //Get From Cart ListView
            for (int i=0; i<arraySize;i++)
            {
                product_ID[i] = int.Parse(CartListView.Items[i].SubItems[0].Text); //ID 0
                product_sellingPrice[i] = float.Parse(CartListView.Items[i].SubItems[2].Text); //price 2
                product_quantity[i] = float.Parse(CartListView.Items[i].SubItems[3].Text); //quantity 3
            }

            //Adding to DB
            for (int i=0; i<arraySize;i++){
                string Query = "INSERT INTO dbo.InvoiceProductDetails (InvoiceNumber, ProductID, Quantity, SellingPrice) VALUES('" + OrderID + "', '" + product_ID[i] + "', '" + product_quantity[i] + "', '" + product_sellingPrice[i] + "')";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(Query, con);
                        SqlDataReader rdr;

                        con.Open();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read()) { }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                        con.Close();
                    }
                }
            }
        }

        private void proceedBTN_Click(object sender, EventArgs e)
        {
            //Order to DB
            if (CustomerNamesComboTXT.Text != "" && amountTotalLabel.Text != "0" && amountTotalLabel.Text != null && CashRecievedTXT.Text != "0" && CashRecievedTXT.Text != null && float.Parse(CashRecievedTXT.Text) > float.Parse(amountTotalLabel.Text))
            {
                AddOrderDetailsTo_Database();
                AddOrderProductDetailsTo_Database();
            }
            else
            {
                MessageBox.Show("Something is Missing");
            }
        }

        
    }
}
