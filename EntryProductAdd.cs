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
    public partial class EntryProductAdd : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        private MySqlDataAdapter da;
        string sql;
        private DataTable dataTable = null;
        BindingSource bindingSource = new BindingSource();
        ClsComboBox ClsComboBox1 = new ClsComboBox();

        public EntryProductAdd()
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
            buildcboCustCode();
        }

        private void buildcboCustCode()
        {
            cboCategory.DataSource = null;
            ClsComboBox1.ALCategory.Clear();
            ClsComboBox1.ClsBuildCategory();
            this.cboCategory.DataSource = (ClsComboBox1.ALCategory);
            this.cboCategory.DisplayMember = "Display";
            this.cboCategory.ValueMember = "Value";
        }

        private void admindashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Application.Exit();*/
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                mysqliconnection.Open();

                sql = "INSERT INTO `tblproduct`(`product_id`, `product_code`, `product_name`, `unit_price`, `category_id`, `UM`)" +
                    " VALUES (NULL,@_productcode,@_productname,@_unitprice,@_categoryid,@_um)";
                mycommand = new MySqlCommand(sql, mysqliconnection);
                mycommand.Parameters.Add("_productcode", MySqlDbType.VarChar).Value = txtProductCode.Text;
                mycommand.Parameters.Add("_productname", MySqlDbType.VarChar).Value = txtProductName.Text;
                mycommand.Parameters.Add("_unitprice", MySqlDbType.VarChar).Value = txtUP.Text;
                mycommand.Parameters.Add("_categoryid", MySqlDbType.VarChar).Value = cboCategory.SelectedValue.ToString();
                mycommand.Parameters.Add("_um", MySqlDbType.VarChar).Value = txtUM.Text;
                int n1 = mycommand.ExecuteNonQuery();
                mysqliconnection.Close();

                MessageBox.Show("Data Save!");
                loadData();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //dr.Close();
                mysqliconnection.Close();
            }
            
        }

        private void loadData()
        {
            EntryProduct.glbldgv1.DataSource = null;
            EntryProduct.glbldgv1.Rows.Clear();
            EntryProduct.glbldgv1.Columns.Clear();

            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            mysqliconnection.Open();

            sql = "SELECT product_code, product_name, unit_price, UM FROM tblproduct";

            da = new MySqlDataAdapter(sql, mysqliconnection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            dataTable = new DataTable();
            da.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            DataGridViewTextBoxColumn ColumnProductCode = new DataGridViewTextBoxColumn();
            ColumnProductCode.HeaderText = "Product Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "product_code";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = true;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryProduct.glbldgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Product Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "product_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = true;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryProduct.glbldgv1.Columns.Add(ColumnProductName);


            DataGridViewTextBoxColumn ColumnProductPrice = new DataGridViewTextBoxColumn();
            ColumnProductPrice.HeaderText = "Unit Price";
            //ColumnStockNumber.Width = 80;
            ColumnProductPrice.DataPropertyName = "unit_price";
            ColumnProductPrice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductPrice.Visible = true;
            ColumnProductPrice.ReadOnly = true;
            ColumnProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryProduct.glbldgv1.Columns.Add(ColumnProductPrice);

            DataGridViewTextBoxColumn ColumnUM = new DataGridViewTextBoxColumn();
            ColumnUM.HeaderText = "UM";
            //ColumnStockNumber.Width = 80;
            ColumnUM.DataPropertyName = "UM";
            ColumnUM.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnUM.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnUM.Visible = true;
            ColumnUM.ReadOnly = true;
            ColumnUM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryProduct.glbldgv1.Columns.Add(ColumnUM);



            EntryProduct.glbldgv1.DataSource = bindingSource;
            EntryProduct.glbldgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

            EntryProduct.glbldgv1.Columns[2].DefaultCellStyle.Format = "N2";
        }
    }
}
