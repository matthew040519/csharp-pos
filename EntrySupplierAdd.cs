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
    public partial class EntrySupplierAdd : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        private MySqlDataAdapter da;
        string sql;
        private DataTable dataTable = null;
        BindingSource bindingSource = new BindingSource();

        public EntrySupplierAdd()
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
            /*Application.Exit();*/
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                mysqliconnection.Open();

                sql = "INSERT INTO `tblsupplier`(`supplier_id`, `supplier_name`) VALUES (NULL, @_suppliername)";
                mycommand = new MySqlCommand(sql, mysqliconnection);
                mycommand.Parameters.Add("_suppliername", MySqlDbType.VarChar).Value = txtSupplierName.Text;
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
            EntrySupplier.glbldgv1.DataSource = null;
            EntrySupplier.glbldgv1.Rows.Clear();
            EntrySupplier.glbldgv1.Columns.Clear();

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
            ColumnProductCode.HeaderText = "Category Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "supplier_id";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = false;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntrySupplier.glbldgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Supplier Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "supplier_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = true;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntrySupplier.glbldgv1.Columns.Add(ColumnProductName);



            EntrySupplier.glbldgv1.DataSource = bindingSource;
            EntrySupplier.glbldgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

        }
    }
}
