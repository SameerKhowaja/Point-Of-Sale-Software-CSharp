using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PointOFSale_Software.General;
using PointOFSale_Software.Screens;

namespace PointOFSale_Software
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        string conString = ApplicationSetting.ConnectionString();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                //MessageBox.Show(conString);
                using (SqlConnection con = new SqlConnection(conString))
                {
                    /*
                    create PROCEDURE usp_login_VerificationDetails
                    (
	                    @UserName NVARCHAR(50),
	                    @Password NVARCHAR(50)
                    )

                    As
	                    Begin
		                    Select '#' from [dbo].[LoginUser]
		                    Where [userName] = @UserName
		                    and [Password] = @Password

	                    End 
                    */
                    using (SqlCommand cmd = new SqlCommand("usp_login_VerificationDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());

                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            //MessageBox.Show("Welcome");
                            this.Hide();
                            DashboardForm dbf = new DashboardForm();
                            dbf.Show();
                        }
                        else
                        {
                            //Change when done
                            this.Hide();
                            DashboardForm dbf = new DashboardForm();
                            dbf.Show();
                            //MessageBox.Show("UserName or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
