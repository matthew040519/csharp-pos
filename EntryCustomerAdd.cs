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
    public partial class EntryCustomerAdd : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        private MySqlDataAdapter da;
        string sql;
        private DataTable dataTable = null;
        BindingSource bindingSource = new BindingSource();

        public EntryCustomerAdd()
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

                sql = "INSERT INTO `tblcustomer`(`customer_id`, `costumer_name`, `address`, `contact_number`) " +
                    "VALUES (NULL, @_costumername, @_address, @_contactnumber)";
                mycommand = new MySqlCommand(sql, mysqliconnection);
                mycommand.Parameters.Add("_costumername", MySqlDbType.VarChar).Value = txtCustomerName.Text;
                mycommand.Parameters.Add("_address", MySqlDbType.VarChar).Value = txtAddress.Text;
                mycommand.Parameters.Add("_contactnumber", MySqlDbType.VarChar).Value = txtContactNumber.Text;
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
            EntryCustomer.glbldgv1.DataSource = null;
            EntryCustomer.glbldgv1.Rows.Clear();
            EntryCustomer.glbldgv1.Columns.Clear();

            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            mysqliconnection.Open();

            sql = "SELECT customer_id, costumer_name, address, contact_number FROM tblcustomer";

            da = new MySqlDataAdapter(sql, mysqliconnection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            dataTable = new DataTable();
            da.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            DataGridViewTextBoxColumn ColumnProductCode = new DataGridViewTextBoxColumn();
            ColumnProductCode.HeaderText = "Customer Code";
            //ColumnStockNumber.Width = 80;
            ColumnProductCode.DataPropertyName = "customer_id";
            ColumnProductCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductCode.Visible = true;
            ColumnProductCode.ReadOnly = true;
            ColumnProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCustomer.glbldgv1.Columns.Add(ColumnProductCode);

            DataGridViewTextBoxColumn ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductName.HeaderText = "Customer Name";
            //ColumnStockNumber.Width = 80;
            ColumnProductName.DataPropertyName = "costumer_name";
            ColumnProductName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnProductName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnProductName.Visible = true;
            ColumnProductName.ReadOnly = true;
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCustomer.glbldgv1.Columns.Add(ColumnProductName);

            DataGridViewTextBoxColumn ColumnAddressName = new DataGridViewTextBoxColumn();
            ColumnAddressName.HeaderText = "Address";
            //ColumnStockNumber.Width = 80;
            ColumnAddressName.DataPropertyName = "address";
            ColumnAddressName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnAddressName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnAddressName.Visible = true;
            ColumnAddressName.ReadOnly = true;
            ColumnAddressName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCustomer.glbldgv1.Columns.Add(ColumnAddressName);

            DataGridViewTextBoxColumn ColumnContact = new DataGridViewTextBoxColumn();
            ColumnContact.HeaderText = "Contact Number";
            //ColumnStockNumber.Width = 80;
            ColumnContact.DataPropertyName = "contact_number";
            ColumnContact.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnContact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnContact.Visible = true;
            ColumnContact.ReadOnly = true;
            ColumnContact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntryCustomer.glbldgv1.Columns.Add(ColumnContact);



            EntryCustomer.glbldgv1.DataSource = bindingSource;
            EntryCustomer.glbldgv1.AllowUserToAddRows = false;
            mysqliconnection.Close();

        }
    }
}
