namespace SmartFreshHouse
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.productFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalAmountToPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.clearShoppingCartbtn = new System.Windows.Forms.Button();
            this.ManageProductBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewSalesBtn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalSalesTodayLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentMonthSalesLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPricePerKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteAction = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productFlowLayoutPanel
            // 
            this.productFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(236)))), ((int)(((byte)(235)))));
            this.productFlowLayoutPanel.Location = new System.Drawing.Point(13, 61);
            this.productFlowLayoutPanel.Name = "productFlowLayoutPanel";
            this.productFlowLayoutPanel.Size = new System.Drawing.Size(631, 488);
            this.productFlowLayoutPanel.TabIndex = 0;
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToDeleteRows = false;
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.AutoGenerateColumns = false;
            this.CartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.ProductPricePerKg,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DeleteAction});
            this.CartDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartDataGridView.DataSource = this.cartBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(13)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.CartDataGridView.Location = new System.Drawing.Point(650, 61);
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.ReadOnly = true;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(479, 270);
            this.CartDataGridView.TabIndex = 2;
            this.CartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGridView_CellClick);
            // 
            // TotalAmountToPay
            // 
            this.TotalAmountToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountToPay.AutoSize = true;
            this.TotalAmountToPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountToPay.Location = new System.Drawing.Point(697, 349);
            this.TotalAmountToPay.Name = "TotalAmountToPay";
            this.TotalAmountToPay.Size = new System.Drawing.Size(0, 21);
            this.TotalAmountToPay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total: ";
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckOutBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CheckOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutBtn.FlatAppearance.BorderSize = 0;
            this.CheckOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.Azure;
            this.CheckOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckOutBtn.Location = new System.Drawing.Point(1034, 350);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(95, 28);
            this.CheckOutBtn.TabIndex = 4;
            this.CheckOutBtn.Text = "Checkout";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // clearShoppingCartbtn
            // 
            this.clearShoppingCartbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearShoppingCartbtn.BackColor = System.Drawing.Color.DimGray;
            this.clearShoppingCartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearShoppingCartbtn.FlatAppearance.BorderSize = 0;
            this.clearShoppingCartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearShoppingCartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearShoppingCartbtn.ForeColor = System.Drawing.Color.White;
            this.clearShoppingCartbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearShoppingCartbtn.Location = new System.Drawing.Point(909, 350);
            this.clearShoppingCartbtn.Name = "clearShoppingCartbtn";
            this.clearShoppingCartbtn.Size = new System.Drawing.Size(106, 28);
            this.clearShoppingCartbtn.TabIndex = 4;
            this.clearShoppingCartbtn.Text = "Clear Cart";
            this.clearShoppingCartbtn.UseVisualStyleBackColor = false;
            this.clearShoppingCartbtn.Click += new System.EventHandler(this.clearShoppingCartbtn_Click);
            // 
            // ManageProductBtn
            // 
            this.ManageProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(13)))), ((int)(((byte)(10)))));
            this.ManageProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageProductBtn.FlatAppearance.BorderSize = 0;
            this.ManageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProductBtn.ForeColor = System.Drawing.Color.White;
            this.ManageProductBtn.Location = new System.Drawing.Point(13, 25);
            this.ManageProductBtn.Name = "ManageProductBtn";
            this.ManageProductBtn.Size = new System.Drawing.Size(131, 30);
            this.ManageProductBtn.TabIndex = 5;
            this.ManageProductBtn.Text = "Manage Products";
            this.ManageProductBtn.UseVisualStyleBackColor = false;
            this.ManageProductBtn.Click += new System.EventHandler(this.ManageProductBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(1059, 25);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(70, 30);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ViewSalesBtn
            // 
            this.ViewSalesBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewSalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewSalesBtn.FlatAppearance.BorderSize = 0;
            this.ViewSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSalesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSalesBtn.ForeColor = System.Drawing.Color.White;
            this.ViewSalesBtn.Location = new System.Drawing.Point(160, 25);
            this.ViewSalesBtn.Name = "ViewSalesBtn";
            this.ViewSalesBtn.Size = new System.Drawing.Size(106, 30);
            this.ViewSalesBtn.TabIndex = 5;
            this.ViewSalesBtn.Text = "View Sales";
            this.ViewSalesBtn.UseVisualStyleBackColor = false;
            this.ViewSalesBtn.Click += new System.EventHandler(this.ViewSalesBtn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 86.92894F;
            this.dataGridViewImageColumn1.HeaderText = "Remove Item";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 201;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Today\'s Total Sale";
            // 
            // totalSalesTodayLabel
            // 
            this.totalSalesTodayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSalesTodayLabel.AutoSize = true;
            this.totalSalesTodayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesTodayLabel.Location = new System.Drawing.Point(10, 32);
            this.totalSalesTodayLabel.Name = "totalSalesTodayLabel";
            this.totalSalesTodayLabel.Size = new System.Drawing.Size(104, 16);
            this.totalSalesTodayLabel.TabIndex = 7;
            this.totalSalesTodayLabel.Text = "Todays Sales";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalSalesTodayLabel);
            this.panel1.Location = new System.Drawing.Point(653, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 57);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CurrentMonthSalesLbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(909, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 57);
            this.panel2.TabIndex = 9;
            // 
            // CurrentMonthSalesLbl
            // 
            this.CurrentMonthSalesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentMonthSalesLbl.AutoSize = true;
            this.CurrentMonthSalesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMonthSalesLbl.Location = new System.Drawing.Point(7, 32);
            this.CurrentMonthSalesLbl.Name = "CurrentMonthSalesLbl";
            this.CurrentMonthSalesLbl.Size = new System.Drawing.Size(145, 16);
            this.CurrentMonthSalesLbl.TabIndex = 8;
            this.CurrentMonthSalesLbl.Text = "Current Month Sales";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "This Month Total Sales";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.BackColor = System.Drawing.Color.Black;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.Location = new System.Drawing.Point(527, 25);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 30);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataSource = typeof(SmartFreshHouse.Cart);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProductPricePerKg
            // 
            this.ProductPricePerKg.DataPropertyName = "ProductPricePerKg";
            this.ProductPricePerKg.FillWeight = 86.92894F;
            this.ProductPricePerKg.HeaderText = "Price Per Kg";
            this.ProductPricePerKg.Name = "ProductPricePerKg";
            this.ProductPricePerKg.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DeleteAction
            // 
            this.DeleteAction.FillWeight = 86.92894F;
            this.DeleteAction.HeaderText = "";
            this.DeleteAction.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAction.Image")));
            this.DeleteAction.Name = "DeleteAction";
            this.DeleteAction.ReadOnly = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(236)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1141, 561);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ViewSalesBtn);
            this.Controls.Add(this.ManageProductBtn);
            this.Controls.Add(this.clearShoppingCartbtn);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalAmountToPay);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.productFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1157, 600);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productFlowLayoutPanel;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Label TotalAmountToPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button clearShoppingCartbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ManageProductBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewSalesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalSalesTodayLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentMonthSalesLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPricePerKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAction;
        private System.Windows.Forms.BindingSource cartBindingSource1;
    }
}