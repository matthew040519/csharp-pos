
namespace POS_SYSTEM
{
    partial class VoucherPD
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
            this.cboSupplier = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDisct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtReference = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRemarks = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnProductEntry = new MaterialSkin.Controls.MaterialButton();
            this.txtTotalDiscount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocnum
            // 
            this.txtDocnum.AnimateReadOnly = false;
            this.txtDocnum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocnum.Depth = 0;
            this.txtDocnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocnum.HideSelection = true;
            this.txtDocnum.LeadingIcon = null;
            this.txtDocnum.Location = new System.Drawing.Point(971, 67);
            this.txtDocnum.MaxLength = 32767;
            this.txtDocnum.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocnum.Name = "txtDocnum";
            this.txtDocnum.PasswordChar = '\0';
            this.txtDocnum.PrefixSuffixText = null;
            this.txtDocnum.ReadOnly = true;
            this.txtDocnum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocnum.SelectedText = "";
            this.txtDocnum.SelectionLength = 0;
            this.txtDocnum.SelectionStart = 0;
            this.txtDocnum.ShortcutsEnabled = true;
            this.txtDocnum.Size = new System.Drawing.Size(178, 48);
            this.txtDocnum.TabIndex = 0;
            this.txtDocnum.TabStop = false;
            this.txtDocnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDocnum.TrailingIcon = null;
            this.txtDocnum.UseSystemPasswordChar = false;
            // 
            // cboSupplier
            // 
            this.cboSupplier.AutoResize = false;
            this.cboSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSupplier.Depth = 0;
            this.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSupplier.DropDownHeight = 174;
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.DropDownWidth = 121;
            this.cboSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.IntegralHeight = false;
            this.cboSupplier.ItemHeight = 43;
            this.cboSupplier.Location = new System.Drawing.Point(503, 142);
            this.cboSupplier.MaxDropDownItems = 4;
            this.cboSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(263, 49);
            this.cboSupplier.StartIndex = 0;
            this.cboSupplier.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(393, 156);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Supplier";
            // 
            // txtDate
            // 
            this.txtDate.AllowPromptAsInput = true;
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
            this.txtDate.Location = new System.Drawing.Point(122, 143);
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
            this.txtDate.TabIndex = 3;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDate.TrailingIcon = null;
            this.txtDate.UseSystemPasswordChar = false;
            this.txtDate.ValidatingType = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(24, 156);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Date";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.Description,
            this.Qty,
            this.UnitPrice,
            this.PDisct,
            this.Total});
            this.dgv1.Location = new System.Drawing.Point(19, 291);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1130, 434);
            this.dgv1.TabIndex = 5;
            // 
            // ProductCode
            // 
            this.ProductCode.FillWeight = 69.57328F;
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.MinimumWidth = 8;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 110;
            // 
            // Description
            // 
            this.Description.FillWeight = 463.6363F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 400;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.FillWeight = 16.69759F;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.FillWeight = 16.69759F;
            this.UnitPrice.HeaderText = "Unit Cost";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // PDisct
            // 
            this.PDisct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PDisct.FillWeight = 16.69759F;
            this.PDisct.HeaderText = "Peso Less";
            this.PDisct.MinimumWidth = 8;
            this.PDisct.Name = "PDisct";
            this.PDisct.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.FillWeight = 16.69759F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(24, 238);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Reference";
            // 
            // txtReference
            // 
            this.txtReference.AnimateReadOnly = false;
            this.txtReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReference.Depth = 0;
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReference.HideSelection = true;
            this.txtReference.LeadingIcon = null;
            this.txtReference.Location = new System.Drawing.Point(122, 224);
            this.txtReference.MaxLength = 32767;
            this.txtReference.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.PrefixSuffixText = null;
            this.txtReference.ReadOnly = false;
            this.txtReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReference.SelectedText = "";
            this.txtReference.SelectionLength = 0;
            this.txtReference.SelectionStart = 0;
            this.txtReference.ShortcutsEnabled = true;
            this.txtReference.Size = new System.Drawing.Size(250, 48);
            this.txtReference.TabIndex = 7;
            this.txtReference.TabStop = false;
            this.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReference.TrailingIcon = null;
            this.txtReference.UseSystemPasswordChar = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.AnimateReadOnly = false;
            this.txtRemarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemarks.Depth = 0;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRemarks.HideSelection = true;
            this.txtRemarks.LeadingIcon = null;
            this.txtRemarks.Location = new System.Drawing.Point(503, 224);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PrefixSuffixText = null;
            this.txtRemarks.ReadOnly = false;
            this.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(646, 48);
            this.txtRemarks.TabIndex = 9;
            this.txtRemarks.TabStop = false;
            this.txtRemarks.Text = "Purchases";
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemarks.TrailingIcon = null;
            this.txtRemarks.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(393, 238);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Remarks";
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(1083, 751);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(1011, 751);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnProductEntry
            // 
            this.btnProductEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductEntry.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProductEntry.Depth = 0;
            this.btnProductEntry.HighEmphasis = true;
            this.btnProductEntry.Icon = null;
            this.btnProductEntry.Location = new System.Drawing.Point(823, 751);
            this.btnProductEntry.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProductEntry.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductEntry.Name = "btnProductEntry";
            this.btnProductEntry.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProductEntry.Size = new System.Drawing.Size(180, 36);
            this.btnProductEntry.TabIndex = 12;
            this.btnProductEntry.Text = "Open Product Entry";
            this.btnProductEntry.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProductEntry.UseAccentColor = false;
            this.btnProductEntry.UseVisualStyleBackColor = true;
            this.btnProductEntry.Click += new System.EventHandler(this.btnProductEntry_Click);
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.AnimateReadOnly = false;
            this.txtTotalDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalDiscount.Depth = 0;
            this.txtTotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalDiscount.HideSelection = true;
            this.txtTotalDiscount.LeadingIcon = null;
            this.txtTotalDiscount.Location = new System.Drawing.Point(28, 785);
            this.txtTotalDiscount.MaxLength = 32767;
            this.txtTotalDiscount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.PasswordChar = '\0';
            this.txtTotalDiscount.PrefixSuffixText = null;
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalDiscount.SelectedText = "";
            this.txtTotalDiscount.SelectionLength = 0;
            this.txtTotalDiscount.SelectionStart = 0;
            this.txtTotalDiscount.ShortcutsEnabled = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(250, 48);
            this.txtTotalDiscount.TabIndex = 14;
            this.txtTotalDiscount.TabStop = false;
            this.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDiscount.TrailingIcon = null;
            this.txtTotalDiscount.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(24, 754);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(140, 24);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Total Discounts";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(295, 782);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(250, 48);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(291, 751);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 24);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Total";
            // 
            // VoucherPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 839);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtTotalDiscount);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnProductEntry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.txtDocnum);
            this.Name = "VoucherPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Delivery";
            this.Load += new System.EventHandler(this.VoucherPO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VoucherPO_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtDocnum;
        private MaterialSkin.Controls.MaterialComboBox cboSupplier;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgv1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtReference;
        private MaterialSkin.Controls.MaterialTextBox2 txtRemarks;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnProductEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDisct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalDiscount;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}