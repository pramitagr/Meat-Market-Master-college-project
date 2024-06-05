namespace SmartFreshHouse
{
    partial class UpdateDeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeleteProduct));
            this.ProductId = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.BrowsePhoto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(55, 78);
            this.ProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Size = new System.Drawing.Size(232, 24);
            this.ProductId.TabIndex = 0;
            this.ProductId.TabStop = false;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(55, 151);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(232, 24);
            this.ProductName.TabIndex = 1;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(55, 224);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(232, 24);
            this.ProductPrice.TabIndex = 2;
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateProductBtn.Location = new System.Drawing.Point(55, 277);
            this.UpdateProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(112, 32);
            this.UpdateProductBtn.TabIndex = 3;
            this.UpdateProductBtn.Text = "Update";
            this.UpdateProductBtn.UseVisualStyleBackColor = false;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteProductBtn.Location = new System.Drawing.Point(177, 277);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(112, 32);
            this.DeleteProductBtn.TabIndex = 4;
            this.DeleteProductBtn.Text = "Delete";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UpdateProductBtn);
            this.groupBox1.Controls.Add(this.DeleteProductBtn);
            this.groupBox1.Location = new System.Drawing.Point(40, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(348, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Or Update Product";
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Location = new System.Drawing.Point(414, 42);
            this.ProductPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(243, 166);
            this.ProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPhoto.TabIndex = 4;
            this.ProductPhoto.TabStop = false;
            // 
            // BrowsePhoto
            // 
            this.BrowsePhoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BrowsePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowsePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowsePhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowsePhoto.Location = new System.Drawing.Point(414, 224);
            this.BrowsePhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowsePhoto.Name = "BrowsePhoto";
            this.BrowsePhoto.Size = new System.Drawing.Size(243, 32);
            this.BrowsePhoto.TabIndex = 3;
            this.BrowsePhoto.Text = "Change Picture";
            this.BrowsePhoto.UseVisualStyleBackColor = false;
            this.BrowsePhoto.Click += new System.EventHandler(this.BrowsePhoto_Click);
            // 
            // UpdateDeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 426);
            this.Controls.Add(this.ProductPhoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BrowsePhoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateDeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ProductPhoto;
        private System.Windows.Forms.Button BrowsePhoto;
    }
}