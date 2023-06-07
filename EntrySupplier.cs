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
    public partial class EntrySupplier : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        private MySqlDataAdapter da;
        string sql;
        private DataTable dataTable = null;
        BindingSource bindingSource = new BindingSource();
        public static DataGridView glbldgv1;

        public EntrySupplier()
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
            loadData();
            glbldgv1 = dgv1;
        }

        private void admindashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Application.Exit();*/
        }

        private void loadData()
        {
            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            mysqliconnection.Open();

            sql = "SELECT supplier_id, supplier_name FROM tblsupplier";

            da = new MySqlDataAdapter(sql, mysqliconnection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            dataTable = new DataTable();
            da.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            DataGridViewTextBoxColumn ColumnProductCode = new DataGridViewTextBoxColumn();
            ColumnProductCode.HeaderText = "Supplier Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "supplier_id";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = true;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Supplier Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "supplier_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = false;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductName);


            dgv1.DataSource = bindingSource;
            dgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

            /*dgv1.Columns[2].DefaultCellStyle.Format = "N2";*/
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = "supplier_name LIKE '" + txtSearch.Text + "%'";
            dgv1.DataSource = dv;
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            EntrySupplierAdd entrySupplierAdd = new EntrySupplierAdd();
            entrySupplierAdd.Show();
        }

        private void btnSaveDatasheet_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(dataTable);
                MessageBox.Show("Saved", "POS");
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }
    }
}
