
namespace POS_SYSTEM
{
    partial class EntrySupplierAdd
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
            this.txtSupplierName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 136);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Supplier";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AnimateReadOnly = false;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierName.Depth = 0;
            this.txtSupplierName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSupplierName.LeadingIcon = null;
            this.txtSupplierName.Location = new System.Drawing.Point(82, 118);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierName.MaxLength = 50;
            this.txtSupplierName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSupplierName.Multiline = false;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(268, 50);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.Text = "";
            this.txtSupplierName.TrailingIcon = null;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(214, 182);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(136, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Supplier";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EntrySupplierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 251);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntrySupplierAdd";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admindashboard_FormClosing);
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtSupplierName;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}