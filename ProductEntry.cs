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
    public partial class ProductEntry : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        ClsComboBox ClsComboBox1 = new ClsComboBox();

        public ProductEntry()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Teal700, MaterialSkin.Primary.Amber100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }

        private void ProductEntry_Load(object sender, EventArgs e)
        {
            buildcboProduct();
        }

        private void buildcboProduct()
        {
            cboProduct.DataSource = null;
            ClsComboBox1.ALProduct.Clear();
            ClsComboBox1.ClsBuildProduct();
            this.cboProduct.DataSource = (ClsComboBox1.ALProduct);
            this.cboProduct.DisplayMember = "Display";
            this.cboProduct.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savetodgv();
            dgvtotal();
            txtUnitCost.Text = "0";
            txtQty.Text = "0";
            txtPDisct.Text = "0";
        }

        private void savetodgv()
        {
            double total = (double.Parse(txtQty.Text) * double.Parse(txtUnitCost.Text)) - double.Parse(txtPDisct.Text);
            
            VoucherPD.glbldgv1.Rows.Add(cboProduct.SelectedValue.ToString(), cboProduct.Text, double.Parse(txtQty.Text).ToString("n2"), double.Parse(txtUnitCost.Text).ToString("n2"), double.Parse(txtPDisct.Text).ToString("n2"), total.ToString("n2"));
        }

        private void dgvtotal()
        {
            double dbltxtTotDisct = 0;
            double dbltxtTotCost = 0;

            for (int x =0; x < VoucherPD.glbldgv1.Rows.Count - 1; x++)
            {
                string vartxtD1 = VoucherPD.glbldgv1.Rows[x].Cells[5].FormattedValue.ToString();
                dbltxtTotCost += double.Parse(vartxtD1);
            }

            for (int x = 0; x < VoucherPD.glbldgv1.Rows.Count - 1; x++)
            {

                string vartxtdiscount = VoucherPD.glbldgv1.Rows[x].Cells[4].FormattedValue.ToString();
                dbltxtTotDisct += double.Parse(vartxtdiscount);
            }

            VoucherPD.glbltxttotal.Text = dbltxtTotCost.ToString("N2");
            VoucherPD.glbltxttotaldisct.Text = dbltxtTotDisct.ToString("N2");
        }
    }
}
