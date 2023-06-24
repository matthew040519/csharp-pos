using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class VoucherPD : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Clsgetsomething clsgetsomething1 = new Clsgetsomething();
        ClsComboBox ClsComboBox1 = new ClsComboBox();
        public static DataGridView glbldgv1;
        public static MaterialTextBox2 glbltxttotal, glbltxttotaldisct;
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        connection mysqlconnection = new connection();
        string sql;

        public VoucherPD()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Amber100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void VoucherPO_Load(object sender, EventArgs e)
        {
            txtDocnum.Text = clsgetsomething1.VoucherAutoNumber("PD");
            buildcboSupplier();
            txtDate.Text = clsgetsomething1.ClsGetDefaultDate();
            glbldgv1 = dgv1;
            glbltxttotal = txtTotal;
            glbltxttotaldisct = txtTotalDiscount;
            txtReference.Text = "PD" + txtDocnum.Text;
        }

        private void buildcboSupplier()
        {
            cboSupplier.DataSource = null;
            ClsComboBox1.ALSupplier.Clear();
            ClsComboBox1.ClsBuildSupplier();
            this.cboSupplier.DataSource = (ClsComboBox1.ALSupplier);
            this.cboSupplier.DisplayMember = "Display";
            this.cboSupplier.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mysqliconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            mysqliconnection.Open();

            string sql1;

            sql = "INSERT INTO `tbltransaction`(`transaction_id`, `docnum`, `voucher`, `user_id`, " +
                "`branch_id`, `tdate`, `supplier_id`, `Remarks`, `reference`) " +
                "VALUES (NULL,@_docnum, @_voucher, @_userid,@_branchid," +
                "@_tdate,@_supplierid,@_remarks,@_reference)";

            sql1 = "INSERT INTO `tblproducttransction`(`transaction_id`, `docnum`, `voucher`, `product_code`, `PIn`," +
                " `POut`, `discount`, `percent_discount`, `UM`, `UP`, `Cost`, `Vat`) " +
                "VALUES (NULL,@_docnum, @_voucher, @_productcode, @_PIn," +
                "@_POut,@_discount,@_percent,@_UM,@_UP,@_Cost,@_Vat)";

            mycommand = new MySqlCommand(sql, mysqliconnection);
            mycommand.Parameters.Add("_docnum", MySqlDbType.VarChar).Value = "PD" + txtDocnum.Text;
            mycommand.Parameters.Add("_voucher", MySqlDbType.VarChar).Value = "PD";
            mycommand.Parameters.Add("_userid", MySqlDbType.VarChar).Value = login.user_id;
            mycommand.Parameters.Add("_branchid", MySqlDbType.VarChar).Value = login.branch_code;
            mycommand.Parameters.Add("_tdate", MySqlDbType.VarChar).Value = txtDate.Text;
            mycommand.Parameters.Add("_supplierid", MySqlDbType.VarChar).Value = cboSupplier.SelectedValue.ToString();
            mycommand.Parameters.Add("_remarks", MySqlDbType.VarChar).Value = txtRemarks.Text;
            mycommand.Parameters.Add("_reference", MySqlDbType.VarChar).Value = txtReference.Text;
            int n1 = mycommand.ExecuteNonQuery();

            DataGridViewRow row1 = null;
            for (int x = 0; x < dgv1.Rows.Count -1; x++)
            {
                row1 = dgv1.Rows[x];

                mycommand = new MySqlCommand(sql1, mysqliconnection);
                mycommand.Parameters.Add("_docnum", MySqlDbType.VarChar).Value = "PD" + txtDocnum.Text;
                mycommand.Parameters.Add("_voucher", MySqlDbType.VarChar).Value = "PD";
                mycommand.Parameters.Add("_productcode", MySqlDbType.VarChar).Value = row1.Cells[0].Value;
                mycommand.Parameters.Add("_PIn", MySqlDbType.Decimal).Value = row1.Cells[2].Value;
                mycommand.Parameters.Add("_POut", MySqlDbType.Decimal).Value = 0;
                mycommand.Parameters.Add("_discount", MySqlDbType.Decimal).Value = row1.Cells[4].Value;
                mycommand.Parameters.Add("_percent", MySqlDbType.VarChar).Value = 0;
                mycommand.Parameters.Add("_UM", MySqlDbType.VarChar).Value = "PIECE";
                mycommand.Parameters.Add("_UP", MySqlDbType.Decimal).Value = row1.Cells[3].Value;
                mycommand.Parameters.Add("_Cost", MySqlDbType.Decimal).Value = row1.Cells[5].Value;
                mycommand.Parameters.Add("_Vat", MySqlDbType.Decimal).Value = 0;
                int n2 = mycommand.ExecuteNonQuery();
            }

            mysqliconnection.Close();

            MessageBox.Show("Data Save!");

            txtDocnum.Text = clsgetsomething1.VoucherAutoNumber("PD");
            dgv1.Rows.Clear();
            txtReference.Text = "PD" + txtDocnum.Text;
            txtTotal.Text = "0.00";
            txtTotalDiscount.Text = "0.00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductEntry_Click(object sender, EventArgs e)
        {
            ProductEntry productEntry = new ProductEntry();
            productEntry.Show();
        }

        private void VoucherPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                /*if ((txtTDate.Text == "  /  /"))
                {
                    MessageBox.Show("Please complete your entry", "GL");
                    txtTDate.Focus();
                }
                else if ((new ClsValidation().emptytxt(cboControlNo.Text)) || (new ClsValidation().emptytxt(txtreference.Text)) ||
                    (new ClsValidation().emptytxt(txtRemarks.Text)))
                {
                    MessageBox.Show("Please complete your entry", "GL");
                    txtTDate.Focus();
                }
                else
                {*/
                    //frmTransactEntryCI.glbltxtD1.Enabled = false;
                    //frmTransactEntryCI.glbltxtD2.Enabled = false;
                    //frmTransactEntryCI.glbltxtD3.Enabled = false;
                    Form NonPoultry = Application.OpenForms["ProductEntry"];
                    if (NonPoultry != null)
                    {
                        //Application.OpenForms["frmTransactEntryPD"].BringToFront();
                        Application.OpenForms["ProductEntry"].Show();
                    }
                    else
                    {
                        MessageBox.Show("Not applicable at this moment", "GL");
                    }
                /*}*/
            }
        }
    }
}
