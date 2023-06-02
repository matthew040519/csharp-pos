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
    public partial class EntryCategoryAdd : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        private MySqlDataAdapter da;
        string sql;
        private DataTable dataTable = null;
        BindingSource bindingSource = new BindingSource();

        public EntryCategoryAdd()
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

                sql = "INSERT INTO `tblcategory`(`category_id`, `category_name`) VALUES (NULL, @_categoryname)";
                mycommand = new MySqlCommand(sql, mysqliconnection);
                mycommand.Parameters.Add("_categoryname", MySqlDbType.VarChar).Value = txtCategoryName.Text;
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
            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            mysqliconnection.Open();

            sql = "SELECT category_id, category_name FROM tblcategory";

            da = new MySqlDataAdapter(sql, mysqliconnection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            dataTable = new DataTable();
            da.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            DataGridViewTextBoxColumn ColumnProductCode = new DataGridViewTextBoxColumn();
            ColumnProductCode.HeaderText = "Category Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "category_id";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = true;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCategory.glbldgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Category Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "category_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = true;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCategory.glbldgv1.Columns.Add(ColumnProductName);



            EntryCategory.glbldgv1.DataSource = bindingSource;
            EntryCategory.glbldgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

        }
    }
}
