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
    public partial class CustomerManagement : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();
        DataTable dt;

        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            string Query = "SELECT * FROM dbo.CustomerInformation";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(Query, con);
                    dt = new DataTable();
                    sqlData.Fill(dt);

                    CustomeDataGridView.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.CustomerData(Cus_NameTXT.Text, Cus_NumberTXT.Text, Cus_EmailTXT.Text, Cus_AddressTXT.Text);
            nc.Show();
            this.Close();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' or Phone like '%{0}%'", SearchTXT.Text);
            CustomeDataGridView.DataSource = dv.ToTable();
        }

        private void CustomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomeDataGridView.Rows[e.RowIndex];

                CustomerIDTXT.Text = row.Cells["CustomerID"].Value.ToString();
                DateANDTimeTXT.Text = row.Cells["DateANDTime"].Value.ToString();

                int CustomerIDINT = int.Parse(CustomerIDTXT.Text);
                string Query = "SELECT * FROM dbo.CustomerInformation WHERE CustomerID ='" + CustomerIDINT + "'";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Cus_NameTXT.Text = rdr["Name"].ToString();
                            Cus_NumberTXT.Text = rdr["Phone"].ToString();
                            Cus_EmailTXT.Text = rdr["Email"].ToString();
                            Cus_AddressTXT.Text = rdr["Address"].ToString();
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

        private void RefreshALL()
        {
            Cus_NameTXT.Text = "";
            Cus_NumberTXT.Text = "";
            Cus_EmailTXT.Text = "";
            Cus_AddressTXT.Text = "";
            CustomerIDTXT.Text = "";
            DateANDTimeTXT.Text = "";
            SearchTXT.Text = "";
            RefreshGridView();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            RefreshALL();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (CustomerIDTXT.Text != null && CustomerIDTXT.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Delete Customer Data?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string Query = "DELETE FROM dbo.CustomerInformation WHERE CustomerID='" + int.Parse(CustomerIDTXT.Text) + "'";
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(Query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer Data Deleted");
                            RefreshALL();
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

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (CustomerIDTXT.Text != null && CustomerIDTXT.Text != "")
            {
                string name = Cus_NameTXT.Text;
                string phone = Cus_NumberTXT.Text;
                string email = Cus_EmailTXT.Text;
                string address = Cus_AddressTXT.Text;
                string DT = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                using (SqlConnection con = new SqlConnection(conString))
                {
                    string Query = "UPDATE dbo.CustomerInformation SET Name = @name, Phone = @phone, Email = @email, Address = @address, DateANDTime = @DT WHERE CustomerID = @id";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@DT", DT);
                        cmd.Parameters.AddWithValue("@id", int.Parse(CustomerIDTXT.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Data Updated");
                        RefreshALL();
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
