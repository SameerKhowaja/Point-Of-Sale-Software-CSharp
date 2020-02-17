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
            int length = 10;
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
            if (productNameLabel.Text != "..." && productNameLabel.Text != "" && quantityTXT.Text != null && quantityTXT.Text != "0" && quantityTXT.Text != "")
            {
                string[] row = { productIDLabel.Text, productNameLabel.Text.Trim(), priceLabel.Text.Trim(), quantityTXT.Text.Trim(), priceTotalLabel.Text.Trim() };
                ListViewItem item = new ListViewItem(row);
                CartListView.Items.Add(item);
                quantityTXT.Text = "0";
                //Total Calculating
                Calculation();
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
    }
}
