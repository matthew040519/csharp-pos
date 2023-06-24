
namespace POS_SYSTEM
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDocnum = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoOfItems = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalPayment = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenPayment = new System.Windows.Forms.Button();
            this.txtDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocnum
            // 
            this.txtDocnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocnum.AnimateReadOnly = false;
            this.txtDocnum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocnum.Depth = 0;
            this.txtDocnum.Enabled = false;
            this.txtDocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocnum.HideSelection = true;
            this.txtDocnum.LeadingIcon = null;
            this.txtDocnum.Location = new System.Drawing.Point(1035, 107);
            this.txtDocnum.MaxLength = 32767;
            this.txtDocnum.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocnum.Name = "txtDocnum";
            this.txtDocnum.PasswordChar = '\0';
            this.txtDocnum.PrefixSuffixText = null;
            this.txtDocnum.ReadOnly = false;
            this.txtDocnum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocnum.SelectedText = "";
            this.txtDocnum.SelectionLength = 0;
            this.txtDocnum.SelectionStart = 0;
            this.txtDocnum.ShortcutsEnabled = true;
            this.txtDocnum.Size = new System.Drawing.Size(250, 48);
            this.txtDocnum.TabIndex = 1;
            this.txtDocnum.TabStop = false;
            this.txtDocnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocnum.TrailingIcon = null;
            this.txtDocnum.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.HideSelection = true;
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(631, 107);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PrefixSuffixText = null;
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(210, 48);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.TrailingIcon = null;
            this.txtQuantity.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(535, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 29);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Quantity";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel1.Location = new System.Drawing.Point(6, 645);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(324, 72);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "No of Items:";
            // 
            // txtNoOfItems
            // 
            this.txtNoOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoOfItems.AutoSize = true;
            this.txtNoOfItems.Depth = 0;
            this.txtNoOfItems.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoOfItems.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.txtNoOfItems.Location = new System.Drawing.Point(346, 645);
            this.txtNoOfItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNoOfItems.Name = "txtNoOfItems";
            this.txtNoOfItems.Size = new System.Drawing.Size(34, 72);
            this.txtNoOfItems.TabIndex = 7;
            this.txtNoOfItems.Text = "0";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel3.Location = new System.Drawing.Point(395, 645);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(412, 72);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Total Payment :";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPayment.AutoSize = true;
            this.txtTotalPayment.Depth = 0;
            this.txtTotalPayment.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPayment.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.txtTotalPayment.Location = new System.Drawing.Point(813, 645);
            this.txtTotalPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(34, 72);
            this.txtTotalPayment.TabIndex = 9;
            this.txtTotalPayment.Text = "0";
            // 
            // btnOpenPayment
            // 
            this.btnOpenPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPayment.Enabled = false;
            this.btnOpenPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPayment.Location = new System.Drawing.Point(1035, 161);
            this.btnOpenPayment.Name = "btnOpenPayment";
            this.btnOpenPayment.Size = new System.Drawing.Size(252, 88);
            this.btnOpenPayment.TabIndex = 11;
            this.btnOpenPayment.Text = "F1-Open Payment Form";
            this.btnOpenPayment.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.AllowPromptAsInput = true;
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AnimateReadOnly = false;
            this.txtDate.AsciiOnly = false;
            this.txtDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDate.BeepOnError = false;
            this.txtDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDate.Depth = 0;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDate.HidePromptOnLeave = false;
            this.txtDate.HideSelection = true;
            this.txtDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDate.LeadingIcon = null;
            this.txtDate.Location = new System.Drawing.Point(1037, 685);
            this.txtDate.Mask = "";
            this.txtDate.MaxLength = 32767;
            this.txtDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.PrefixSuffixText = null;
            this.txtDate.PromptChar = '_';
            this.txtDate.ReadOnly = false;
            this.txtDate.RejectInputOnFirstFailure = false;
            this.txtDate.ResetOnPrompt = true;
            this.txtDate.ResetOnSpace = true;
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(250, 48);
            this.txtDate.SkipLiterals = true;
            this.txtDate.TabIndex = 12;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDate.TrailingIcon = null;
            this.txtDate.UseSystemPasswordChar = false;
            this.txtDate.ValidatingType = null;
            this.txtDate.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Quantity,
            this.UnitPrice,
            this.totalPayment});
            this.dgv1.Location = new System.Drawing.Point(6, 161);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1023, 481);
            this.dgv1.TabIndex = 13;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductCode";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product Description";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            // 
            // totalPayment
            // 
            this.totalPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPayment.HeaderText = "Total";
            this.totalPayment.MinimumWidth = 8;
            this.totalPayment.Name = "totalPayment";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(6, 111);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(504, 44);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            this.txtProductCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductCode_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(393, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 44);
            this.textBox1.TabIndex = 14;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 739);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnOpenPayment);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNoOfItems);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDocnum);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtDocnum;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel txtNoOfItems;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel txtTotalPayment;
        private System.Windows.Forms.Button btnOpenPayment;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDate;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayment;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox textBox1;
    }
}