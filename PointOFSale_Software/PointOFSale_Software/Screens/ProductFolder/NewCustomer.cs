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
    public partial class NewCustomer : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();
        private string Cus_name;
        private string Cus_phone;
        private string Cus_email;
        private string Cus_address;

        public NewCustomer()
        {
            InitializeComponent();
        }

        public void CustomerData(string name, string phone, string email, string address)
        {
            this.Cus_name = name;
            this.Cus_phone = phone;
            this.Cus_email = email;
            this.Cus_address = address;
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            Cus_NameTXT.Text = Cus_name;
            Cus_PhoneTXT.Text = Cus_phone;
            Cus_EmailTXT.Text = Cus_email;
            Cus_AddressTXT.Text = Cus_address;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetDateTime()
        {
            string DateANDTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            return DateANDTime;
        }

        private void ClearAll()
        {
            Cus_NameTXT.Text = "";
            Cus_PhoneTXT.Text = "";
            Cus_EmailTXT.Text = "";
            Cus_AddressTXT.Text = "";
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string DateANDTime = GetDateTime();

            string Query = "INSERT INTO dbo.CustomerInformation (Name, Phone, Email, DateANDTime, Address) VALUES('" + Cus_NameTXT.Text + "', '" + Cus_PhoneTXT.Text + "', '" + Cus_EmailTXT.Text + "', '" + DateANDTime + "', '" + Cus_AddressTXT.Text + "')";
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader rdr;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Customer Data Inserted Successfully");
                    ClearAll();
                    while (rdr.Read()) { }
                    con.Close();

                    this.Hide();
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
