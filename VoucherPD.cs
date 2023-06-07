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
            txtDocnum.Text = clsgetsomething1.VoucherAutoNumber("PO");
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
