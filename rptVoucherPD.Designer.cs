
namespace POS_SYSTEM
{
    partial class rptVoucherPD
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
            this.cbortprint = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEndDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBDate = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(19, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Vouchers";
            // 
            // cbortprint
            // 
            this.cbortprint.AutoResize = false;
            this.cbortprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbortprint.Depth = 0;
            this.cbortprint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbortprint.DropDownHeight = 174;
            this.cbortprint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbortprint.DropDownWidth = 121;
            this.cbortprint.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbortprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbortprint.FormattingEnabled = true;
            this.cbortprint.IntegralHeight = false;
            this.cbortprint.ItemHeight = 43;
            this.cbortprint.Location = new System.Drawing.Point(110, 67);
            this.cbortprint.MaxDropDownItems = 4;
            this.cbortprint.MouseState = MaterialSkin.MouseState.OUT;
            this.cbortprint.Name = "cbortprint";
            this.cbortprint.Size = new System.Drawing.Size(206, 49);
            this.cbortprint.StartIndex = 0;
            this.cbortprint.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(716, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Ending Date";
            // 
            // txtEndDate
            // 
            this.txtEndDate.AllowPromptAsInput = true;
            this.txtEndDate.AnimateReadOnly = false;
            this.txtEndDate.AsciiOnly = false;
            this.txtEndDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndDate.BeepOnError = false;
            this.txtEndDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEndDate.Depth = 0;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndDate.HidePromptOnLeave = false;
            this.txtEndDate.HideSelection = true;
            this.txtEndDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEndDate.LeadingIcon = null;
            this.txtEndDate.Location = new System.Drawing.Point(830, 68);
            this.txtEndDate.Mask = "";
            this.txtEndDate.MaxLength = 32767;
            this.txtEndDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.PasswordChar = '\0';
            this.txtEndDate.PrefixSuffixText = null;
            this.txtEndDate.PromptChar = '_';
            this.txtEndDate.ReadOnly = false;
            this.txtEndDate.RejectInputOnFirstFailure = false;
            this.txtEndDate.ResetOnPrompt = true;
            this.txtEndDate.ResetOnSpace = true;
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndDate.SelectedText = "";
            this.txtEndDate.SelectionLength = 0;
            this.txtEndDate.SelectionStart = 0;
            this.txtEndDate.ShortcutsEnabled = true;
            this.txtEndDate.Size = new System.Drawing.Size(250, 48);
            this.txtEndDate.SkipLiterals = true;
            this.txtEndDate.TabIndex = 5;
            this.txtEndDate.TabStop = false;
            this.txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEndDate.TrailingIcon = null;
            this.txtEndDate.UseSystemPasswordChar = false;
            this.txtEndDate.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(335, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Begin Date";
            // 
            // txtBDate
            // 
            this.txtBDate.AllowPromptAsInput = true;
            this.txtBDate.AnimateReadOnly = false;
            this.txtBDate.AsciiOnly = false;
            this.txtBDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBDate.BeepOnError = false;
            this.txtBDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBDate.Depth = 0;
            this.txtBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBDate.HidePromptOnLeave = false;
            this.txtBDate.HideSelection = true;
            this.txtBDate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBDate.LeadingIcon = null;
            this.txtBDate.Location = new System.Drawing.Point(440, 68);
            this.txtBDate.Mask = "";
            this.txtBDate.MaxLength = 32767;
            this.txtBDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.PasswordChar = '\0';
            this.txtBDate.PrefixSuffixText = null;
            this.txtBDate.PromptChar = '_';
            this.txtBDate.ReadOnly = false;
            this.txtBDate.RejectInputOnFirstFailure = false;
            this.txtBDate.ResetOnPrompt = true;
            this.txtBDate.ResetOnSpace = true;
            this.txtBDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBDate.SelectedText = "";
            this.txtBDate.SelectionLength = 0;
            this.txtBDate.SelectionStart = 0;
            this.txtBDate.ShortcutsEnabled = true;
            this.txtBDate.Size = new System.Drawing.Size(250, 48);
            this.txtBDate.SkipLiterals = true;
            this.txtBDate.TabIndex = 7;
            this.txtBDate.TabStop = false;
            this.txtBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBDate.TrailingIcon = null;
            this.txtBDate.UseSystemPasswordChar = false;
            this.txtBDate.ValidatingType = null;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.AutoSize = false;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new System.Drawing.Point(1112, 68);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreview.Size = new System.Drawing.Size(184, 50);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 127);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1273, 562);
            this.crystalReportViewer1.TabIndex = 10;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptVoucherPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 705);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtBDate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.cbortprint);
            this.Controls.Add(this.materialLabel1);
            this.Name = "rptVoucherPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports - Voucher PD";
            this.Load += new System.EventHandler(this.rptVoucherPD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbortprint;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEndDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBDate;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}