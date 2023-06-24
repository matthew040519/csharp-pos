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
using CrystalDecisions.CrystalReports.Engine;

namespace POS_SYSTEM
{
    public partial class Payment : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Clsgetsomething clsgetsomething1 = new Clsgetsomething();
        connection MysqlCOnnection = new connection();
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        string sql = "";
        MySqlDataReader MySqlDataReader;
        ReportDocument reportDocument = new ReportDocument();

        public Payment()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtTotalPayment.Text = Order.glbltotalpayment.Text;
        }

        private void txtCash_Validated(object sender, EventArgs e)
        {
            txtChange.Text = (double.Parse(txtCash.Text) - double.Parse(txtTotalPayment.Text)).ToString("n2");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtChange.Text) < 0)
            {
                MessageBox.Show("Insufficient Cash", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCash.Focus();
            }
            else
            {
                mysqliconnection = new MySqlConnection(MysqlCOnnection.MyConnection2);
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
                mycommand.Parameters.Add("_docnum", MySqlDbType.VarChar).Value = "OR" + Order.glbltxtdocnum.Text;
                mycommand.Parameters.Add("_voucher", MySqlDbType.VarChar).Value = "OR";
                mycommand.Parameters.Add("_userid", MySqlDbType.VarChar).Value = login.user_id;
                mycommand.Parameters.Add("_branchid", MySqlDbType.VarChar).Value = login.branch_code;
                mycommand.Parameters.Add("_tdate", MySqlDbType.VarChar).Value = Order.glbltxttdate.Text;
                mycommand.Parameters.Add("_supplierid", MySqlDbType.VarChar).Value = 1;
                mycommand.Parameters.Add("_remarks", MySqlDbType.VarChar).Value = Order.glbltxtdocnum.Text;
                mycommand.Parameters.Add("_reference", MySqlDbType.VarChar).Value = Order.glbltxtdocnum.Text;
                int n1 = mycommand.ExecuteNonQuery();

                DataGridViewRow row1 = null;
                for (int x = 0; x < Order.glbldgv1.Rows.Count - 1; x++)
                {

                    mycommand = new MySqlCommand(sql1, mysqliconnection);
                    mycommand.Parameters.Add("_docnum", MySqlDbType.VarChar).Value = "OR" + Order.glbltxtdocnum.Text;
                    mycommand.Parameters.Add("_voucher", MySqlDbType.VarChar).Value = "OR";
                    mycommand.Parameters.Add("_productcode", MySqlDbType.VarChar).Value = Order.glbldgv1.Rows[x].Cells[0].Value;
                    mycommand.Parameters.Add("_PIn", MySqlDbType.Decimal).Value = 0;
                    mycommand.Parameters.Add("_POut", MySqlDbType.Decimal).Value = Order.glbldgv1.Rows[x].Cells[2].Value;
                    mycommand.Parameters.Add("_discount", MySqlDbType.Decimal).Value = 0;
                    mycommand.Parameters.Add("_percent", MySqlDbType.VarChar).Value = 0;
                    mycommand.Parameters.Add("_UM", MySqlDbType.VarChar).Value = "PIECE";
                    mycommand.Parameters.Add("_UP", MySqlDbType.Decimal).Value = Order.glbldgv1.Rows[x].Cells[3].Value;
                    mycommand.Parameters.Add("_Cost", MySqlDbType.Decimal).Value = Order.glbldgv1.Rows[x].Cells[4].Value;
                    mycommand.Parameters.Add("_Vat", MySqlDbType.Decimal).Value = 0;
                    int n2 = mycommand.ExecuteNonQuery();
                }


                string sqlstatement = "SELECT tblproducttransction.POut as qty, tblproduct.product_name, tblproducttransction.UP, tblproduct.unit_price " +
                    "FROM tblproducttransction INNER JOIN tblproduct ON tblproducttransction.product_code=tblproduct.product_code " +
                    "WHERE voucher = 'OR' AND tblproducttransction.docnum ='" + "OR" + Order.glbltxtdocnum.Text +"'";

               
                mycommand = mysqliconnection.CreateCommand();
                mycommand.CommandText = sqlstatement;
                mycommand.CommandTimeout = 900;
                MySqlDataReader = mycommand.ExecuteReader();
                DataTable DataTable1 = new DataTable();
                DataTable1.Load(MySqlDataReader);

                if (DataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("No data found", "GL");
                    return;
                }
                CROrder objRpt = new CROrder();

                objRpt.SetDataSource(DataTable1);
                System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();
                //  doctoprint.PrinterSettings.PrinterName = "EPSON LX-300+ /II";
                int rawKind = 0;
                for (int i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
                {
                    if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "ZPrinter Paper(58 x 3276mm)")
                    {
                        rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField("kind",
                        System.Reflection.BindingFlags.Instance |
                        System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
                objRpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;

                objRpt.Refresh();
                objRpt.PrintToPrinter(1, false, 0, 0);
                /*reportDocument.Load(MapPath("~/CROrder.rpt"));
                reportDocument.SetDataSource(DataTable1);
                reportDocument.PrintOptions.PrinterName = "POS-58";
                reportDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                reportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
                reportDocument.PrintToPrinter(1, false, 0, 0);*/
                Order.glbltxtdocnum.Text = clsgetsomething1.VoucherAutoNumber("OR");
                Order.glbldgv1.Rows.Clear();
                Order.glbltotalpayment.Text = "0";
                Order.glbltxtNoOfItems.Text = "0";
                mysqliconnection.Close();
                this.Close();
            }
        }
    }
}
