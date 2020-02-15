using PointOFSale_Software.Screens.ProductFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOFSale_Software.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DefineProductBTN_Click(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();
            dps.Show();
        }

        private void ManageProductBTN_Click(object sender, EventArgs e)
        {
            ManageProduct mgp = new ManageProduct();
            mgp.Show();
        }

        private void ManageCategoryBTN_Click(object sender, EventArgs e)
        {
            ManageBrand_Category mbc = new ManageBrand_Category();
            mbc.Show();
        }
    }
}
