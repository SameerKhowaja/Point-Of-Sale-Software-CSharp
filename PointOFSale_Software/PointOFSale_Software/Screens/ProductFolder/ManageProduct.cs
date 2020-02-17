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
    public partial class ManageProduct : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();
        DataTable dt;
        string filename;

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            BrandComboBoxUpdate();
        }

        private void RefreshGridView()
        {
            string Query = "SELECT ProductID, ProductName, BrandName, CategoryName, Quantity, PurchasePrice, SellingPrice, Description, DateANDTime FROM dbo.ProductsDefinition";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(Query, con);
                    dt = new DataTable();
                    sqlData.Fill(dt);

                    ProductGridView.DataSource = dt;
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
                        BrandNameComboTxt.Items.Add(rdr.GetValue(1).ToString());
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

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ProductName like '%{0}%' or BrandName like '%{0}%' or CategoryName like '%{0}%'", SearchTXT.Text);
            ProductGridView.DataSource = dv.ToTable();
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductGridView.Rows[e.RowIndex];

                ProductIDTXT.Text = row.Cells["ProductID"].Value.ToString();

                int ProductIDINT = int.Parse(ProductIDTXT.Text);
                string Query = "SELECT * FROM dbo.ProductsDefinition WHERE ProductID ='" + ProductIDINT + "'";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            ProductNameTXT.Text = rdr["ProductName"].ToString();
                            BrandNameComboTxt.Text = rdr["BrandName"].ToString();
                            CategoryComboTXT.Text = rdr["CategoryName"].ToString();
                            QuantityTXT.Text = rdr["Quantity"].ToString();
                            PurchasePriceTXT.Text = rdr["PurchasePrice"].ToString();
                            SellingPriceTXT.Text = rdr["SellingPrice"].ToString();
                            DescriptionTXT.Text = rdr["Description"].ToString();
                            
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

        private void UploadImageBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    ProductImageBox.Image = Image.FromFile(filename);
                }
            }
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
                        if (rdr.GetValue(1).ToString() == BrandNameComboTxt.Text)
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

        private void BrandNameComboTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Brand_ID = BrandID();
            CategoryComboTXT.Items.Clear();
            CategoryComboTXT.Text = "";

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
                        CategoryComboTXT.Items.Add(rdr.GetValue(2).ToString());
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

        private void ClearTXTBoxes()
        {
            ProductIDTXT.Text = "";
            ProductNameTXT.Text = "";
            BrandNameComboTxt.Text = "";
            CategoryComboTXT.Text = "";
            CategoryComboTXT.Items.Clear();
            BrandNameComboTxt.Items.Clear();
            BrandComboBoxUpdate();
            QuantityTXT.Text = "";
            PurchasePriceTXT.Text = "";
            SellingPriceTXT.Text = "";
            DescriptionTXT.Text = "";
            DateANDTimeTXT.Text = "";
            SearchTXT.Text = "";
            ProductImageBox.Image = Properties.Resources.image;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (ProductIDTXT.Text != null && ProductIDTXT.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Delete Product?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string Query = "DELETE FROM dbo.ProductsDefinition WHERE ProductID='" + int.Parse(ProductIDTXT.Text) + "'";
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(Query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product Deleted");
                            RefreshGridView();
                            ClearTXTBoxes();
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

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            ClearTXTBoxes();
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (ProductIDTXT.Text != null && ProductIDTXT.Text != "")
            {
                string name = ProductNameTXT.Text;
                string Bname = BrandNameComboTxt.Text;
                string Cname = CategoryComboTXT.Text;
                float Quant = float.Parse(QuantityTXT.Text);
                float Pprice = float.Parse(PurchasePriceTXT.Text);
                float Sprice = float.Parse(SellingPriceTXT.Text);
                string Desc = DescriptionTXT.Text;
                string DT = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                byte[] img = imageToByteArray(ProductImageBox.Image);

                
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string Query = "UPDATE dbo.ProductsDefinition SET ProductName = @name, BrandName = @Bname, CategoryName = @Cname, Quantity = @Quant, PurchasePrice = @Pprice, SellingPrice = @Sprice, Description = @Desc, DateANDTime = @DT, ProductImage = @img WHERE ProductID = @id";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);
                        
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@Bname", Bname);
                        cmd.Parameters.AddWithValue("@Cname", Cname);
                        cmd.Parameters.AddWithValue("@Quant", Quant);
                        cmd.Parameters.AddWithValue("@Pprice", Pprice);
                        cmd.Parameters.AddWithValue("@Sprice", Sprice);
                        cmd.Parameters.AddWithValue("@Desc", Desc);
                        cmd.Parameters.AddWithValue("@DT", DT);
                        cmd.Parameters.AddWithValue("@img", img);
                        cmd.Parameters.AddWithValue("@id", int.Parse(ProductIDTXT.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Updated");
                        RefreshGridView();
                        ClearTXTBoxes();
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
