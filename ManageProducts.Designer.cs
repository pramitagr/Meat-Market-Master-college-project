namespace SmartFreshHouse
{
    partial class ManageProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.ProductPriceText = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectPhotoBtn = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerKgDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartFreshHouseDataSet = new SmartFreshHouse.SmartFreshHouseDataSet();
            this.productsTableAdapter = new SmartFreshHouse.SmartFreshHouseDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFreshHouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(22, 54);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(181, 20);
            this.ProductNameText.TabIndex = 1;
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.Location = new System.Drawing.Point(22, 103);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(181, 20);
            this.ProductPriceText.TabIndex = 2;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductBtn.FlatAppearance.BorderSize = 0;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddProductBtn.Location = new System.Drawing.Point(22, 308);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(181, 23);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectPhotoBtn
            // 
            this.SelectPhotoBtn.BackColor = System.Drawing.Color.SlateGray;
            this.SelectPhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectPhotoBtn.FlatAppearance.BorderSize = 0;
            this.SelectPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPhotoBtn.ForeColor = System.Drawing.Color.Snow;
            this.SelectPhotoBtn.Location = new System.Drawing.Point(22, 142);
            this.SelectPhotoBtn.Name = "SelectPhotoBtn";
            this.SelectPhotoBtn.Size = new System.Drawing.Size(181, 23);
            this.SelectPhotoBtn.TabIndex = 3;
            this.SelectPhotoBtn.Text = "Select Photo";
            this.SelectPhotoBtn.UseVisualStyleBackColor = false;
            this.SelectPhotoBtn.Click += new System.EventHandler(this.SelectPhotoBtn_Click);
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.pricePerKgDataGridViewTextBoxColumn1,
            this.updatedAtDataGridViewTextBoxColumn1,
            this.productImageUrlDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn});
            this.ProductGridView.DataSource = this.productBindingSource;
            this.ProductGridView.Location = new System.Drawing.Point(265, 29);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(496, 360);
            this.ProductGridView.TabIndex = 7;
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pricePerKgDataGridViewTextBoxColumn
            // 
            this.pricePerKgDataGridViewTextBoxColumn.DataPropertyName = "PricePerKg";
            this.pricePerKgDataGridViewTextBoxColumn.HeaderText = "Price Per Kg";
            this.pricePerKgDataGridViewTextBoxColumn.Name = "pricePerKgDataGridViewTextBoxColumn";
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "Date";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price per kg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductPriceText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectPhotoBtn);
            this.groupBox1.Controls.Add(this.AddProductBtn);
            this.groupBox1.Controls.Add(this.ProductPhoto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductNameText);
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ProductPhoto.Image")));
            this.ProductPhoto.Location = new System.Drawing.Point(22, 171);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(181, 120);
            this.ProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPhoto.TabIndex = 6;
            this.ProductPhoto.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pricePerKgDataGridViewTextBoxColumn1
            // 
            this.pricePerKgDataGridViewTextBoxColumn1.DataPropertyName = "PricePerKg";
            this.pricePerKgDataGridViewTextBoxColumn1.HeaderText = "PricePerKg";
            this.pricePerKgDataGridViewTextBoxColumn1.Name = "pricePerKgDataGridViewTextBoxColumn1";
            this.pricePerKgDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn1
            // 
            this.updatedAtDataGridViewTextBoxColumn1.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn1.Name = "updatedAtDataGridViewTextBoxColumn1";
            this.updatedAtDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productImageUrlDataGridViewTextBoxColumn
            // 
            this.productImageUrlDataGridViewTextBoxColumn.DataPropertyName = "ProductImageUrl";
            this.productImageUrlDataGridViewTextBoxColumn.HeaderText = "ProductImageUrl";
            this.productImageUrlDataGridViewTextBoxColumn.Name = "productImageUrlDataGridViewTextBoxColumn";
            this.productImageUrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.productImageUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            this.salesDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesDataGridViewTextBoxColumn.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SmartFreshHouse.Product);
            // 
            // smartFreshHouseDataSet
            // 
            this.smartFreshHouseDataSet.DataSetName = "SmartFreshHouseDataSet";
            this.smartFreshHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(236)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(773, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageProducts_FormClosing);
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartFreshHouseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ProductPhoto;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.TextBox ProductPriceText;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectPhotoBtn;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private SmartFreshHouseDataSet smartFreshHouseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SmartFreshHouseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerKgDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
    }
}