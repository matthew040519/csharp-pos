
namespace POS_SYSTEM
{
    partial class ProductEntry
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQty = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUnitCost = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtPDisct = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(20, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Product";
            // 
            // cboProduct
            // 
            this.cboProduct.AutoResize = false;
            this.cboProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboProduct.Depth = 0;
            this.cboProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboProduct.DropDownHeight = 174;
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.DropDownWidth = 121;
            this.cboProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.IntegralHeight = false;
            this.cboProduct.ItemHeight = 43;
            this.cboProduct.Location = new System.Drawing.Point(133, 110);
            this.cboProduct.MaxDropDownItems = 4;
            this.cboProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(269, 49);
            this.cboProduct.StartIndex = 0;
            this.cboProduct.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(20, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(32, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.AnimateReadOnly = false;
            this.txtQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.Depth = 0;
            this.txtQty.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.HideSelection = true;
            this.txtQty.LeadingIcon = null;
            this.txtQty.Location = new System.Drawing.Point(133, 180);
            this.txtQty.MaxLength = 32767;
            this.txtQty.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PrefixSuffixText = null;
            this.txtQty.ReadOnly = false;
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(269, 48);
            this.txtQty.TabIndex = 3;
            this.txtQty.TabStop = false;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.TrailingIcon = null;
            this.txtQty.UseSystemPasswordChar = false;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.AnimateReadOnly = false;
            this.txtUnitCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUnitCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUnitCost.Depth = 0;
            this.txtUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitCost.HideSelection = true;
            this.txtUnitCost.LeadingIcon = null;
            this.txtUnitCost.Location = new System.Drawing.Point(133, 246);
            this.txtUnitCost.MaxLength = 32767;
            this.txtUnitCost.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.PasswordChar = '\0';
            this.txtUnitCost.PrefixSuffixText = null;
            this.txtUnitCost.ReadOnly = false;
            this.txtUnitCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnitCost.SelectedText = "";
            this.txtUnitCost.SelectionLength = 0;
            this.txtUnitCost.SelectionStart = 0;
            this.txtUnitCost.ShortcutsEnabled = true;
            this.txtUnitCost.Size = new System.Drawing.Size(269, 48);
            this.txtUnitCost.TabIndex = 5;
            this.txtUnitCost.TabStop = false;
            this.txtUnitCost.Text = "0";
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUnitCost.TrailingIcon = null;
            this.txtUnitCost.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(20, 260);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Unit Cost";
            // 
            // btnSave
            // 
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(248, 406);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(130, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPDisct
            // 
            this.txtPDisct.AnimateReadOnly = false;
            this.txtPDisct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPDisct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPDisct.Depth = 0;
            this.txtPDisct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPDisct.HideSelection = true;
            this.txtPDisct.LeadingIcon = null;
            this.txtPDisct.Location = new System.Drawing.Point(133, 313);
            this.txtPDisct.MaxLength = 32767;
            this.txtPDisct.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPDisct.Name = "txtPDisct";
            this.txtPDisct.PasswordChar = '\0';
            this.txtPDisct.PrefixSuffixText = null;
            this.txtPDisct.ReadOnly = false;
            this.txtPDisct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPDisct.SelectedText = "";
            this.txtPDisct.SelectionLength = 0;
            this.txtPDisct.SelectionStart = 0;
            this.txtPDisct.ShortcutsEnabled = true;
            this.txtPDisct.Size = new System.Drawing.Size(269, 48);
            this.txtPDisct.TabIndex = 8;
            this.txtPDisct.TabStop = false;
            this.txtPDisct.Text = "0";
            this.txtPDisct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPDisct.TrailingIcon = null;
            this.txtPDisct.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(20, 328);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Less (Peso)";
            // 
            // ProductEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 477);
            this.Controls.Add(this.txtPDisct);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ProductEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Entry";
            this.Load += new System.EventHandler(this.ProductEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cboProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtQty;
        private MaterialSkin.Controls.MaterialTextBox2 txtUnitCost;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox2 txtPDisct;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}