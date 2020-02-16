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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void CheckOldPassword()
        {
            string oldPassword = null;
            string Query = "SELECT Password FROM dbo.LoginUser WHERE userName = @name";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@name", "Admin");
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        oldPassword = rdr["Password"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }

            if(oldPassword != null)
            {
                ChangePasswordFunc(oldPassword);
                //MessageBox.Show(oldPassword);
            }
        }

        private void ChangePasswordFunc(string oldpass)
        {
            string newPassword = newPassword1TXT.Text.Trim();
            string oldPassword = oldPasswordTXT.Text.Trim();

            if (oldPassword == oldpass.Trim())
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string Query = "UPDATE dbo.LoginUser SET Password = @password WHERE userName = @name";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(Query, con);

                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@name", "Admin");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (newPassword1TXT.Text.Trim() != newPassword2TXT.Text.Trim())
            {
                MessageBox.Show("New Password not Matched", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (oldPasswordTXT.Text != null && oldPasswordTXT.Text != "" && newPassword1TXT.Text != null && newPassword1TXT.Text != "" && newPassword2TXT.Text != null && newPassword2TXT.Text != "")
            {
                CheckOldPassword();
            }
            else
            {
                MessageBox.Show("Password Matched Error", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Encrypt_checkBox.Checked == false)
            {
                oldPasswordTXT.UseSystemPasswordChar = false;
                newPassword1TXT.UseSystemPasswordChar = false;
                newPassword2TXT.UseSystemPasswordChar = false;
            }
            else
            {
                oldPasswordTXT.UseSystemPasswordChar = true;
                newPassword1TXT.UseSystemPasswordChar = true;
                newPassword2TXT.UseSystemPasswordChar = true;
            }
        }
    }
}
