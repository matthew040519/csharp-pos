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
    public partial class EntryProduct : MaterialForm
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

        public EntryProduct()
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

            sql = "SELECT product_id, product_code, product_name, unit_price, UM, category_id FROM tblproduct";

            da = new MySqlDataAdapter(sql, mysqliconnection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            dataTable = new DataTable();
            da.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            DataGridViewTextBoxColumn ColumnProductid = new DataGridViewTextBoxColumn();
            ColumnProductid.HeaderText = "Product ID";
            //ColumnStockNumber.Width = 80;
            ColumnProductid.DataPropertyName = "product_id";
            ColumnProductid.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductid.Visible = false;
            ColumnProductid.ReadOnly = true;
            ColumnProductid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductid);

            DataGridViewTextBoxColumn ColumnProductCode = new DataGridViewTextBoxColumn();
            ColumnProductCode.HeaderText = "Product Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "product_code";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = true;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Product Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "product_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = false;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductName);


            DataGridViewTextBoxColumn ColumnProductPrice = new DataGridViewTextBoxColumn();
            ColumnProductPrice.HeaderText = "Unit Price";
            //ColumnStockNumber.Width = 80;
            ColumnProductPrice.DataPropertyName = "unit_price";
            ColumnProductPrice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductPrice.Visible = true;
            ColumnProductPrice.ReadOnly = false;
            ColumnProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnProductPrice);

            string selectQueryStringtblCategory = "SELECT category_id, category_name FROM tblCategory ORDER BY category_name";
            MySqlDataAdapter sqlDataAdaptertblCategory = new MySqlDataAdapter(selectQueryStringtblCategory, mysqlconnection.MyConnection2);
            MySqlCommandBuilder sqlCommandBuildertblCategory = new MySqlCommandBuilder(sqlDataAdaptertblCategory);
            DataTable dataTabletblCategory = new DataTable();
            sqlDataAdaptertblCategory.Fill(dataTabletblCategory);
            BindingSource bindingSourcetblCategory = new BindingSource();
            bindingSourcetblCategory.DataSource = dataTabletblCategory;

            DataGridViewComboBoxColumn ColumnCatCode = new DataGridViewComboBoxColumn();
            ColumnCatCode.DataPropertyName = "category_id";
            ColumnCatCode.HeaderText = "Category";
            ColumnCatCode.Width = 100;
            ColumnCatCode.DataSource = bindingSourcetblCategory;
            ColumnCatCode.ValueMember = "category_id";
            ColumnCatCode.DisplayMember = "category_name";
            ColumnCatCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnCatCode);

            DataGridViewTextBoxColumn ColumnUM = new DataGridViewTextBoxColumn();
            ColumnUM.HeaderText = "UM";
            //ColumnStockNumber.Width = 80;
            ColumnUM.DataPropertyName = "UM";
            ColumnUM.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnUM.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnUM.Visible = true;
            ColumnUM.ReadOnly = false;
            ColumnUM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv1.Columns.Add(ColumnUM);



            dgv1.DataSource = bindingSource;
            dgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

            dgv1.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = "product_name LIKE '" + txtSearch.Text + "%' OR product_code LIKE '" + txtSearch.Text + "%'";
            dgv1.DataSource = dv;
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            EntryProductAdd entryProductAdd = new EntryProductAdd();
            entryProductAdd.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
