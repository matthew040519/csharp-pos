using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class rptVoucherPD : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Clsgetsomething clsgetsomething1 = new Clsgetsomething();
        connection MysqlCOnnection = new connection();
        MySqlConnection mysqliconnection;
        MySqlCommand mycommand;
        MySqlDataReader MySqlDataReader;
        string sqlstatement;

        public rptVoucherPD()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            cbortprint.DisplayMember = "Text";
            cbortprint.ValueMember = "Value";

            var items = new[]
            { 
             
              new { Text = "Purchase Delivery", Value = "PD" },
              new { Text = "Order", Value = "OR" },
            };
            cbortprint.DataSource = items;
        }

        private void rptVoucherPD_Load(object sender, EventArgs e)
        {
            txtBDate.Text = clsgetsomething1.ClsGetDefaultDate();
            txtEndDate.Text = clsgetsomething1.ClsGetDefaultDate();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cbortprint.SelectedValue.ToString() == "PD")
            {
                rptPD(cbortprint.SelectedValue.ToString());
            }
            else if(cbortprint.SelectedValue.ToString() == "OR")
            {
                rptOR(cbortprint.SelectedValue.ToString());
            }
        }

        private void rptPD(string voucher)
        {
            
            sqlstatement = "SELECT * FROM viewdetails WHERE tdate BETWEEN '" + txtBDate.Text + "' AND  '" + txtEndDate.Text + "' AND voucher = '" + voucher +"'";

            mysqliconnection = new MySqlConnection(MysqlCOnnection.MyConnection2);
            mysqliconnection.Open();
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sqlstatement, MysqlCOnnection.MyConnection2);
            DSVoucher dSVoucher = new DSVoucher();
            dscmd.Fill(dSVoucher, "viewdetails");
            mysqliconnection.Close();

          
            CRrptVouchersPD objRpt = new CRrptVouchersPD();
         
            
            TextObject vartxtcompany = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["rpttxtcompany"];
            clsgetsomething1.branchDetails(login.branch_code);
            vartxtcompany.Text = clsgetsomething1.plsBranchName;

            clsgetsomething1.branchDetails(login.branch_code);
            TextObject vartxtaddress = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["rpttxtaddress"];
            vartxtaddress.Text = clsgetsomething1.plsBranchAddress;

            clsgetsomething1.branchDetails(login.branch_code);
            TextObject txtvoucher = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["txtvoucher"];
            txtvoucher.Text = cbortprint.Text;

            TextObject varTextDateRange = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["TextDateRange"];
            varTextDateRange.Text = "From " + txtBDate.Text + " To " + txtEndDate.Text;

            objRpt.SetDataSource(dSVoucher.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        private void rptOR(string voucher)
        {

            sqlstatement = "SELECT * FROM viewdetails WHERE tdate BETWEEN '" + txtBDate.Text + "' AND  '" + txtEndDate.Text + "' AND voucher = '" + voucher + "'";

            mysqliconnection = new MySqlConnection(MysqlCOnnection.MyConnection2);
            mysqliconnection.Open();
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sqlstatement, MysqlCOnnection.MyConnection2);
            DSVoucher dSVoucher = new DSVoucher();
            dscmd.Fill(dSVoucher, "viewdetails");
            mysqliconnection.Close();


            CRrptVouchers objRpt = new CRrptVouchers();

            TextObject vartxtcompany = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["rpttxtcompany"];
            clsgetsomething1.branchDetails(login.branch_code);
            vartxtcompany.Text = clsgetsomething1.plsBranchName;

            clsgetsomething1.branchDetails(login.branch_code);
            TextObject vartxtaddress = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["rpttxtaddress"];
            vartxtaddress.Text = clsgetsomething1.plsBranchAddress;

            clsgetsomething1.branchDetails(login.branch_code);
            TextObject txtvoucher = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["txtvoucher"];
            txtvoucher.Text = cbortprint.Text;

            TextObject varTextDateRange = (TextObject)objRpt.ReportDefinition.Sections["Section1"].ReportObjects["TextDateRange"];
            varTextDateRange.Text = "From " + txtBDate.Text + " To " + txtEndDate.Text;

            objRpt.SetDataSource(dSVoucher.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
