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
    public partial class ManageBrand_Category : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();

        public ManageBrand_Category()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddNewBrand()
        {
            if (BrandNameTXT.Text != null && BrandNameTXT.Text != "")
            {
                string Query = "INSERT INTO dbo.BrandInformation (BrandName) VALUES ('" + BrandNameTXT.Text + "')";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr;
                    try
                    {
                        con.Open();
                        rdr = cmd.ExecuteReader();
                        MessageBox.Show("Brand Inserted Successfully");
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

        private void ManageBrand_Category_Load(object sender, EventArgs e)
        {
            BrandComboBoxUpdate();
        }

        private void addBrandBTN_Click(object sender, EventArgs e)
        {
            AddNewBrand();
            BrandComboBoxUpdate();
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

        private void BrandNamesComboTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCategoryList();
        }

        private void AddNewCategory()
        {
            if (CategoryNameTXT.Text != null && CategoryNameTXT.Text != "" && BrandNamesComboTXT.Text != null && BrandNamesComboTXT.Text != "")
            {
                string BrandIDINT = BrandID();
                string Query = "INSERT INTO dbo.CategoryInformation (BrandID, CategoryName) VALUES ('"+int.Parse(BrandIDINT) +"', '" + CategoryNameTXT.Text + "')";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader rdr;
                    try
                    {
                        con.Open();
                        rdr = cmd.ExecuteReader();
                        MessageBox.Show("Category Inserted Successfully");
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

        private void addCategoryBTN_Click(object sender, EventArgs e)
        {
            AddNewCategory();
            RefreshCategoryList();
        }

        private void RefreshTXTBoxes()
        {
            BrandNameTXT.Text = "";
            CategoryNameTXT.Text = "";
            UpdateBrandNameTXT.Text = "";
            updateCategoryBTN.Text = "";
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            RefreshTXTBoxes();
        }

        private void updateBrandBTN_Click(object sender, EventArgs e)
        {
            if (UpdateBrandNameTXT.Text != null && UpdateBrandNameTXT.Text != "" && BrandNamesComboTXT.Text != null && BrandNamesComboTXT.Text != "")
            {
                string BrandIDINT = BrandID();
                string name = UpdateBrandNameTXT.Text;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string Query = "UPDATE dbo.BrandInformation SET BrandName = @name WHERE BrandID = @id";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", int.Parse(BrandIDINT));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Brand Updated");
                        BrandComboBoxUpdate();
                        RefreshTXTBoxes();
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

        private void updateCategoryBTN_Click(object sender, EventArgs e)
        {
            if (UpdateCategoryNameTXT.Text != null && UpdateCategoryNameTXT.Text != "" && CategoryNameComboTXT.Text != null && CategoryNameComboTXT.Text != "")
            {
                string CategoryIDINT = CategoryID();
                string name = UpdateCategoryNameTXT.Text;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string Query = "UPDATE dbo.CategoryInformation SET CategoryName = @name WHERE CategoryID = @id";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", int.Parse(CategoryIDINT));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Updated");
                        RefreshCategoryList();
                        RefreshTXTBoxes();
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


    }
}
