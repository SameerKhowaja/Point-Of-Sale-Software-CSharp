using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PointOFSale_Software.General;
using System.Data.SqlClient;
using System.IO;

namespace PointOFSale_Software.Screens.ProductFolder
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();
        string filename;

        public DefineProductScreen()
        {
            InitializeComponent();
        }

        private void LoadBrandComboBox()
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

        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            LoadBrandComboBox();
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
                        if(rdr.GetValue(1).ToString() == BrandNameComboTxt.Text)
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

            string Query = "SELECT * FROM dbo.CategoryInformation WHERE BrandID='"+int.Parse(Brand_ID) +"'";
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd= new OpenFileDialog() {Filter="JPEG|*.jpg", ValidateNames=true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    ProductImageBox.Image = Image.FromFile(filename);
                }
            }
        }

        private void ClearAll()
        {
            ProductNameTXT.Text = "";
            BrandNameComboTxt.Text = "";
            CategoryComboTXT.Text = "";
            QuantityTXT.Text = "";
            PurchasePriceTXT.Text = "";
            SellingPriceTXT.Text = "";
            DescriptionTXT.Text = "";
            CategoryComboTXT.Items.Clear();
            BrandNameComboTxt.Items.Clear();
            LoadBrandComboBox();
            ProductImageBox.Image = Properties.Resources.image;
        }

        private void RefreshAllBTN_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private string GetDateTime()
        {
            string DateANDTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            return DateANDTime;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string DateANDTime = GetDateTime();
            byte[] imageArray = imageToByteArray(ProductImageBox.Image);

            string Query1 = "INSERT INTO dbo.ProductsDefinition (ProductName, BrandName, CategoryName, Quantity, PurchasePrice, SellingPrice, Description, DateANDTime, ProductImage) ";
            string Query2 = "VALUES('"+ProductNameTXT.Text+"', '"+BrandNameComboTxt.Text+"', '"+CategoryComboTXT.Text+"', '"+float.Parse(QuantityTXT.Text) +"', '"+ float.Parse(PurchasePriceTXT.Text)+"', '"+ float.Parse(SellingPriceTXT.Text)+"', '"+DescriptionTXT.Text+"', '"+DateANDTime+"', @img)";
            string Query = Query1 + Query2;
            //Query = "INSERT INTO dbo.ProductsDefinition (ProductName) VALUES('" + this.ProductNameTXT.Text + "')";
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@img", imageArray);
                SqlDataReader rdr;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Product Inserted Successfully");
                    ClearAll();
                    while (rdr.Read()) { }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


    }
}
