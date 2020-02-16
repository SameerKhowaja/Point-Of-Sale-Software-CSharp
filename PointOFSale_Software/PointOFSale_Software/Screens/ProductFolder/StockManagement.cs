using PointOFSale_Software.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOFSale_Software.Screens.ProductFolder
{
    public partial class StockManagement : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();

        public StockManagement()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string BrandID()
        {
            string Query = "SELECT * FROM dbo.BrandInformation";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetValue(1).ToString() == BrandNamesComboTXT.Text)
                        {
                            return rdr.GetValue(0).ToString();
                        }
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
            return "0";
        }

        private string CategoryID()
        {
            string Query = "SELECT * FROM dbo.CategoryInformation";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetValue(2).ToString() == CategoryNameComboTXT.Text)
                        {
                            return rdr.GetValue(0).ToString();
                        }
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
            return "0";
        }

        private void RefreshCategoryList()
        {
            string Brand_ID = BrandID();
            CategoryNameComboTXT.Items.Clear();
            CategoryNameComboTXT.Text = "";

            string Query = "SELECT * FROM dbo.CategoryInformation WHERE BrandID='" + int.Parse(Brand_ID) + "'";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CategoryNameComboTXT.Items.Add(rdr.GetValue(2).ToString());
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

        private void BrandComboBoxUpdate()
        {
            BrandNamesComboTXT.Items.Clear();

            string Query = "SELECT * FROM dbo.BrandInformation";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        BrandNamesComboTXT.Items.Add(rdr.GetValue(1).ToString());
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

        private void BrandNamesComboTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCategoryList();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            BrandComboBoxUpdate();
        }

        private void FilterData(string query)
        {
            string Query = query;
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);

                    StockDataGridView.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void StocksCount()
        {
            string Total_Stock = StockDataGridView.Rows.Count.ToString();
            totalStockCountLabel.Text = Total_Stock;

            float quantity = 0;
            float purchasePrice = 0;
            float sellingPrice = 0;
            string temp;
            for (int i = 0; i < StockDataGridView.Rows.Count; ++i)
            {
                temp = StockDataGridView.Rows[i].Cells[3].Value.ToString();
                quantity += float.Parse(temp);
                temp = StockDataGridView.Rows[i].Cells[4].Value.ToString();
                purchasePrice += float.Parse(temp);
                temp = StockDataGridView.Rows[i].Cells[5].Value.ToString();
                sellingPrice += float.Parse(temp);
            }
            totalStockQuantityLabel.Text = quantity.ToString();
            totalStockPurchasePriceLabel.Text = purchasePrice.ToString();
            totalStockSellingPriceLabel.Text = sellingPrice.ToString();

        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            if (BrandNamesComboTXT.Text != null && BrandNamesComboTXT.Text != "" && CategoryNameComboTXT.Text != null && CategoryNameComboTXT.Text != "")
            {
                string Query = "SELECT ProductName, BrandName, CategoryName, Quantity, PurchasePrice, SellingPrice, Description, DateANDTime FROM dbo.ProductsDefinition WHERE BrandName = '" + BrandNamesComboTXT.Text + "' AND CategoryName = '" + CategoryNameComboTXT.Text + "'";
                FilterData(Query);
            }
            else if (BrandNamesComboTXT.Text != null && BrandNamesComboTXT.Text != "")
            {
                string Query = "SELECT ProductName, BrandName, CategoryName, Quantity, PurchasePrice, SellingPrice, Description, DateANDTime FROM dbo.ProductsDefinition WHERE BrandName = '" + BrandNamesComboTXT.Text + "'";
                FilterData(Query);
            }
            else
            {
                MessageBox.Show("Please Fill List With Brand/Category to Filter", "Filter Error");
            }

            StocksCount();
        }

        private void RefreshBTN_Click_1(object sender, EventArgs e)
        {
            //Refresh Filtered
            totalStockCountLabel.Text = "0";
            totalStockQuantityLabel.Text = "0";
            totalStockPurchasePriceLabel.Text = "0";
            totalStockSellingPriceLabel.Text = "0";

            StockDataGridView.DataSource = null;
            BrandNamesComboTXT.Items.Clear();
            CategoryNameComboTXT.Items.Clear();

            BrandComboBoxUpdate();
        }


    }
}
