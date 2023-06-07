
namespace POS_SYSTEM
{
    partial class EntryProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.addproduct = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Thistle;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1.Location = new System.Drawing.Point(10, 165);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1192, 484);
            this.dgv1.TabIndex = 0;
            // 
            // addproduct
            // 
            this.addproduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addproduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addproduct.Depth = 0;
            this.addproduct.HighEmphasis = true;
            this.addproduct.Icon = null;
            this.addproduct.Location = new System.Drawing.Point(1081, 96);
            this.addproduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addproduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.addproduct.Name = "addproduct";
            this.addproduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addproduct.Size = new System.Drawing.Size(121, 36);
            this.addproduct.TabIndex = 1;
            this.addproduct.Text = "Add Product";
            this.addproduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addproduct.UseAccentColor = false;
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 107);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 90);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1011, 43);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(1081, 678);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(121, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EntryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1210, 724);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntryProduct";
            this.Padding = new System.Windows.Forms.Padding(4, 96, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admindashboard_FormClosing);
            this.Load += new System.EventHandler(this.admindashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private MaterialSkin.Controls.MaterialButton addproduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}