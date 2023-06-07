﻿using MaterialSkin.Controls;
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
            EntryProduct frmproduct = new EntryProduct();
            frmproduct.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryCategory entryCategory = new EntryCategory();
            entryCategory.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntrySupplier entrySupplier = new EntrySupplier();
            entrySupplier.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryCustomer entryCustomer = new EntryCustomer();
            entryCustomer.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherPD voucherPO = new VoucherPD();
            voucherPO.Show();
        }
    }
}
