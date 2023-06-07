
namespace POS_SYSTEM
{
    partial class EntryProductAdd
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
            this.txtProductCode = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUM = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUP = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cboCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(8, 125);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.AnimateReadOnly = false;
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductCode.Depth = 0;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.LeadingIcon = null;
            this.txtProductCode.Location = new System.Drawing.Point(171, 103);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductCode.MaxLength = 50;
            this.txtProductCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductCode.Multiline = false;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(366, 50);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.Text = "";
            this.txtProductCode.TrailingIcon = null;
            // 
            // txtProductName
            // 
            this.txtProductName.AnimateReadOnly = false;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Depth = 0;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.LeadingIcon = null;
            this.txtProductName.Location = new System.Drawing.Point(171, 163);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(366, 50);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.Text = "";
            this.txtProductName.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(8, 180);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Product Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(8, 237);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(32, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "UM";
            // 
            // txtUM
            // 
            this.txtUM.AnimateReadOnly = false;
            this.txtUM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUM.Depth = 0;
            this.txtUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUM.LeadingIcon = null;
            this.txtUM.Location = new System.Drawing.Point(171, 223);
            this.txtUM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUM.MaxLength = 50;
            this.txtUM.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUM.Multiline = false;
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(366, 50);
            this.txtUM.TabIndex = 5;
            this.txtUM.Text = "";
            this.txtUM.TrailingIcon = null;
            // 
            // txtUP
            // 
            this.txtUP.AnimateReadOnly = false;
            this.txtUP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUP.Depth = 0;
            this.txtUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUP.LeadingIcon = null;
            this.txtUP.Location = new System.Drawing.Point(171, 283);
            this.txtUP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUP.MaxLength = 50;
            this.txtUP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUP.Multiline = false;
            this.txtUP.Name = "txtUP";
            this.txtUP.Size = new System.Drawing.Size(366, 50);
            this.txtUP.TabIndex = 7;
            this.txtUP.Text = "";
            this.txtUP.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(8, 300);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Unit Price";
            // 
            // btnSave
            // 
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(369, 416);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(168, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Product";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(8, 361);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 24);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.AutoResize = false;
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCategory.Depth = 0;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategory.DropDownHeight = 174;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.DropDownWidth = 121;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IntegralHeight = false;
            this.cboCategory.ItemHeight = 43;
            this.cboCategory.Location = new System.Drawing.Point(171, 343);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategory.MaxDropDownItems = 4;
            this.cboCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(366, 49);
            this.cboCategory.StartIndex = 0;
            this.cboCategory.TabIndex = 10;
            // 
            // EntryProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 487);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUP);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntryProductAdd";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admindashboard_FormClosing);
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtProductCode;
        private MaterialSkin.Controls.MaterialTextBox txtProductName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtUM;
        private MaterialSkin.Controls.MaterialTextBox txtUP;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cboCategory;
    }
}