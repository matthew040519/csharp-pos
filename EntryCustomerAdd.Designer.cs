
namespace POS_SYSTEM
{
    partial class EntryCustomerAdd
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
            this.txtCustomerName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
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
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AnimateReadOnly = false;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.LeadingIcon = null;
            this.txtCustomerName.Location = new System.Drawing.Point(13, 160);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(337, 50);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "";
            this.txtCustomerName.TrailingIcon = null;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(214, 399);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(136, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Customer";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.AnimateReadOnly = false;
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContactNumber.LeadingIcon = null;
            this.txtContactNumber.Location = new System.Drawing.Point(13, 246);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactNumber.MaxLength = 50;
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContactNumber.Multiline = false;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(337, 50);
            this.txtContactNumber.TabIndex = 10;
            this.txtContactNumber.Text = "";
            this.txtContactNumber.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 222);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(116, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(13, 335);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 50);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "";
            this.txtAddress.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(10, 311);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Address";
            // 
            // EntryCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 465);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntryCustomerAdd";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admindashboard_FormClosing);
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCustomerName;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox txtContactNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}