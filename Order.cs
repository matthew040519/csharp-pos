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
using System.Threading;

namespace POS_SYSTEM
{
    public partial class Order : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        Clsgetsomething clsgetsomething1 = new Clsgetsomething();
        MySqlConnection mySqlConnection = new MySqlConnection();
        public static Label glbltotalpayment, glbltxtNoOfItems;
        public static MaterialTextBox2 glbltxtdocnum;
        public static MaterialMaskedTextBox glbltxttdate;
        public static ListViewItem glblListViewItem;
        public static DataGridView glbldgv1;
        string stringBarcode = "";
        int i = 0;

        public Order()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            txtDate.Text = clsgetsomething1.ClsGetDefaultDate();
            txtDocnum.Text = clsgetsomething1.VoucherAutoNumber("OR");
            txtProductCode.Focus();
            glbltxtdocnum = txtDocnum;
            glbltxttdate = txtDate;
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            /*stringBarcode = txtProductCode.Text;
            
            MessageBox.Show("" + stringBarcode);*/
            
        }

        private void insert()
        {
            if (clsgetsomething1.isProductCodeExist(txtProductCode.Text))
            {
                clsgetsomething1.getProductDetails(txtProductCode.Text);

                double total = double.Parse(clsgetsomething1.plsGetUnitPrice) * double.Parse(txtQuantity.Text);

                dgv1.Rows.Add(txtProductCode.Text, clsgetsomething1.plsGetProductDesc, txtQuantity.Text, double.Parse(clsgetsomething1.plsGetUnitPrice).ToString("n2"), total.ToString("n2"));


                txtNoOfItems.Text = (dgv1.Rows.Count - 1).ToString();

                double totalpayment = 0.00;

                for (int i = 0; i < dgv1.Rows.Count - 1; i++)
                {
                    totalpayment += double.Parse(dgv1.Rows[i].Cells[4].Value.ToString());
                    txtTotalPayment.Text = totalpayment.ToString("n2");
                }

                glbltotalpayment = txtTotalPayment;
                glbltxtNoOfItems = txtNoOfItems;

                txtProductCode.Focus();
                txtProductCode.Clear();
                btnOpenPayment.Enabled = true;
                glbldgv1 = dgv1;

            }
            else
            {
                if(stringBarcode.Length == 13)
                {
                    insert();
                }
                
                if (txtProductCode.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("Product Code Not Exist", "POS");
                    txtProductCode.Focus();
                    txtProductCode.Clear();
                }
            }
        }

        private void Order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                /*MessageBox.Show("F1");*/
                Form payment = new Payment();
                if (txtNoOfItems.Text != "0" && payment != null)
                {
                    payment.Show();
                }
                else
                {
                    MessageBox.Show("Not applicable at this moment", "GL");
                }

            }
        }

        private void txtProductCode_Validating(object sender, CancelEventArgs e)
        {
            insert();
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                /*MessageBox.Show("F1");*/
                Form payment = new Payment();
                if (txtNoOfItems.Text != "0" && payment != null)
                {
                    payment.Show();
                }
                else
                {
                    MessageBox.Show("Not applicable at this moment", "POS");
                }

            }
        }
    }
}
