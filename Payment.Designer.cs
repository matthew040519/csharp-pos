
namespace POS_SYSTEM
{
    partial class Payment
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
            this.txtTotalPayment = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCash = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtChange = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnPay = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.AnimateReadOnly = false;
            this.txtTotalPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalPayment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalPayment.Depth = 0;
            this.txtTotalPayment.Enabled = false;
            this.txtTotalPayment.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPayment.HideSelection = true;
            this.txtTotalPayment.LeadingIcon = null;
            this.txtTotalPayment.Location = new System.Drawing.Point(55, 149);
            this.txtTotalPayment.MaxLength = 32767;
            this.txtTotalPayment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.PasswordChar = '\0';
            this.txtTotalPayment.PrefixSuffixText = null;
            this.txtTotalPayment.ReadOnly = false;
            this.txtTotalPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalPayment.SelectedText = "";
            this.txtTotalPayment.SelectionLength = 0;
            this.txtTotalPayment.SelectionStart = 0;
            this.txtTotalPayment.ShortcutsEnabled = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(250, 48);
            this.txtTotalPayment.TabIndex = 0;
            this.txtTotalPayment.TabStop = false;
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalPayment.TrailingIcon = null;
            this.txtTotalPayment.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(96, 107);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Total Payment";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(145, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 29);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Cash";
            // 
            // txtCash
            // 
            this.txtCash.AnimateReadOnly = false;
            this.txtCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCash.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCash.Depth = 0;
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCash.HideSelection = true;
            this.txtCash.LeadingIcon = null;
            this.txtCash.Location = new System.Drawing.Point(55, 261);
            this.txtCash.MaxLength = 32767;
            this.txtCash.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.PrefixSuffixText = null;
            this.txtCash.ReadOnly = false;
            this.txtCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.Size = new System.Drawing.Size(250, 48);
            this.txtCash.TabIndex = 2;
            this.txtCash.TabStop = false;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCash.TrailingIcon = null;
            this.txtCash.UseSystemPasswordChar = false;
            this.txtCash.Validated += new System.EventHandler(this.txtCash_Validated);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(145, 317);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 29);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.AnimateReadOnly = false;
            this.txtChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtChange.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtChange.Depth = 0;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtChange.HideSelection = true;
            this.txtChange.LeadingIcon = null;
            this.txtChange.Location = new System.Drawing.Point(55, 358);
            this.txtChange.MaxLength = 32767;
            this.txtChange.MouseState = MaterialSkin.MouseState.OUT;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PrefixSuffixText = null;
            this.txtChange.ReadOnly = false;
            this.txtChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(250, 48);
            this.txtChange.TabIndex = 4;
            this.txtChange.TabStop = false;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChange.TrailingIcon = null;
            this.txtChange.UseSystemPasswordChar = false;
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = false;
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPay.Depth = 0;
            this.btnPay.HighEmphasis = false;
            this.btnPay.Icon = null;
            this.btnPay.Location = new System.Drawing.Point(55, 442);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPay.Name = "btnPay";
            this.btnPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPay.Size = new System.Drawing.Size(250, 36);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnPay.UseAccentColor = false;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 528);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTotalPayment);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtTotalPayment;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCash;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtChange;
        private MaterialSkin.Controls.MaterialButton btnPay;
    }
}