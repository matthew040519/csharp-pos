using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class admindashboard : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        public admindashboard()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Amber100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void admindashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(login.level == "1")
            {
                EntryProduct frmproduct = new EntryProduct();
                frmproduct.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.level == "1")
            {
                EntryCategory entryCategory = new EntryCategory();
                entryCategory.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (login.level == "1")
            {
                EntrySupplier entrySupplier = new EntrySupplier();
                entrySupplier.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (login.level == "1")
            {
                EntryCustomer entryCustomer = new EntryCustomer();
                entryCustomer.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (login.level == "1")
            {
                VoucherPD voucherPO = new VoucherPD();
                voucherPO.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (login.level == "1")
            {
                EntryUser entryUser = new EntryUser();
                entryUser.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mainOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void admindashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("A");
            }
        }

        private void voidListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.level == "1")
            {
                EntryUser entryUser = new EntryUser();
                entryUser.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void voucherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (login.level == "1")
            {
                rptVoucherPD rptVoucherPD = new rptVoucherPD();
                rptVoucherPD.Show();
            }
            else
            {
                MessageBox.Show("You do not have necessary permission to open this file", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
