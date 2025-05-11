namespace ShriGajananDairy
{
    partial class BulkSalesInvoice
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
            lblCustomer = new Label();
            cbxCustomer = new ComboBox();
            btnCustomerSearch = new Button();
            dataGridView1 = new DataGridView();
            btnCreateBulkSaleInvoice = new Button();
            btnClear = new Button();
            lblSelectedCount = new Label();
            lblCount = new Label();
            SelectCustomer = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            ButtonRemoveColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(25, 33);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(111, 30);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(481, 23);
            cbxCustomer.TabIndex = 1;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(629, 30);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(75, 23);
            btnCustomerSearch.TabIndex = 2;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SelectCustomer, Id, Customer, ButtonRemoveColumn });
            dataGridView1.Location = new Point(25, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(738, 311);
            dataGridView1.TabIndex = 3;
            // 
            // btnCreateBulkSaleInvoice
            // 
            btnCreateBulkSaleInvoice.Location = new Point(615, 415);
            btnCreateBulkSaleInvoice.Name = "btnCreateBulkSaleInvoice";
            btnCreateBulkSaleInvoice.Size = new Size(148, 23);
            btnCreateBulkSaleInvoice.TabIndex = 4;
            btnCreateBulkSaleInvoice.Text = "Create Bulk Sale Invoice";
            btnCreateBulkSaleInvoice.UseVisualStyleBackColor = true;
            btnCreateBulkSaleInvoice.Click += btnCreateBulkSaleInvoice_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(713, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblSelectedCount
            // 
            lblSelectedCount.AutoSize = true;
            lblSelectedCount.Location = new Point(32, 409);
            lblSelectedCount.Name = "lblSelectedCount";
            lblSelectedCount.Size = new Size(90, 15);
            lblSelectedCount.TabIndex = 6;
            lblSelectedCount.Text = "Selected Count:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(129, 409);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 7;
            // 
            // SelectCustomer
            // 
            SelectCustomer.HeaderText = "Select";
            SelectCustomer.Name = "SelectCustomer";
            SelectCustomer.Width = 50;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.True;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Visible = false;
            // 
            // Customer
            // 
            Customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            // 
            // ButtonRemoveColumn
            // 
            ButtonRemoveColumn.HeaderText = "Remove";
            ButtonRemoveColumn.Name = "ButtonRemoveColumn";
            ButtonRemoveColumn.Resizable = DataGridViewTriState.True;
            ButtonRemoveColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            ButtonRemoveColumn.Text = "Remove";
            ButtonRemoveColumn.UseColumnTextForButtonValue = true;
            // 
            // BulkSalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCount);
            Controls.Add(lblSelectedCount);
            Controls.Add(btnClear);
            Controls.Add(btnCreateBulkSaleInvoice);
            Controls.Add(dataGridView1);
            Controls.Add(btnCustomerSearch);
            Controls.Add(cbxCustomer);
            Controls.Add(lblCustomer);
            Name = "BulkSalesInvoice";
            Text = "BulkSalesInvoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private ComboBox cbxCustomer;
        private Button btnCustomerSearch;
        private DataGridView dataGridView1;
        private Button btnCreateBulkSaleInvoice;
        private Button btnClear;
        private Label lblSelectedCount;
        private Label lblCount;
        private DataGridViewCheckBoxColumn SelectCustomer;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewButtonColumn ButtonRemoveColumn;
    }
}