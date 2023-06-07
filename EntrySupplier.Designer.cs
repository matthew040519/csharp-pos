
namespace POS_SYSTEM
{
    partial class EntrySupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnaddcategory = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSaveDatasheet = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.Location = new System.Drawing.Point(10, 169);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(1049, 497);
            this.dgv1.TabIndex = 0;
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnaddcategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnaddcategory.Depth = 0;
            this.btnaddcategory.HighEmphasis = true;
            this.btnaddcategory.Icon = null;
            this.btnaddcategory.Location = new System.Drawing.Point(930, 87);
            this.btnaddcategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnaddcategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnaddcategory.Size = new System.Drawing.Size(121, 36);
            this.btnaddcategory.TabIndex = 1;
            this.btnaddcategory.Text = "Add Supplier";
            this.btnaddcategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnaddcategory.UseAccentColor = false;
            this.btnaddcategory.UseVisualStyleBackColor = true;
            this.btnaddcategory.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(22, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 83);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(834, 44);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSaveDatasheet
            // 
            this.btnSaveDatasheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDatasheet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveDatasheet.Depth = 0;
            this.btnSaveDatasheet.HighEmphasis = true;
            this.btnSaveDatasheet.Icon = null;
            this.btnSaveDatasheet.Location = new System.Drawing.Point(914, 675);
            this.btnSaveDatasheet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDatasheet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDatasheet.Name = "btnSaveDatasheet";
            this.btnSaveDatasheet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveDatasheet.Size = new System.Drawing.Size(145, 36);
            this.btnSaveDatasheet.TabIndex = 4;
            this.btnSaveDatasheet.Text = "Save Datasheet";
            this.btnSaveDatasheet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveDatasheet.UseAccentColor = false;
            this.btnSaveDatasheet.UseVisualStyleBackColor = true;
            this.btnSaveDatasheet.Click += new System.EventHandler(this.btnSaveDatasheet_Click);
            // 
            // EntrySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 719);
            this.Controls.Add(this.btnSaveDatasheet);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntrySupplier";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admindashboard_FormClosing);
            this.Load += new System.EventHandler(this.admindashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private MaterialSkin.Controls.MaterialButton btnaddcategory;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSaveDatasheet;
    }
}