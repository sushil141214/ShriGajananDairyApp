namespace ShriGajananDairy
{
    partial class frmSalesInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            lblInvoiceDate = new Label();
            txtInvoiceDate = new TextBox();
            lblCustomer = new Label();
            cbxCustomer = new ComboBox();
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtQty = new TextBox();
            lblQty = new Label();
            txtRate = new TextBox();
            lblRate = new Label();
            cbxProduct = new ComboBox();
            lblProduct = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblTotalDisplay = new Label();
            lblTotal = new Label();
            btnPrint = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblInvoiceNo.Location = new Point(8, 16);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(80, 20);
            lblInvoiceNo.TabIndex = 0;
            lblInvoiceNo.Text = "Invoice No";
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            txtInvoiceNo.Location = new Point(103, 13);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(180, 26);
            txtInvoiceNo.TabIndex = 1;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblInvoiceDate.Location = new Point(325, 16);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(92, 20);
            lblInvoiceDate.TabIndex = 2;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            txtInvoiceDate.Location = new Point(419, 13);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.Size = new Size(180, 26);
            txtInvoiceDate.TabIndex = 3;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblCustomer.Location = new Point(8, 61);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(72, 20);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer";
            // 
            // cbxCustomer
            // 
            cbxCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(103, 58);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(300, 27);
            cbxCustomer.TabIndex = 5;
            cbxCustomer.SelectedIndexChanged += cbxCustomer_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(txtQty);
            panel1.Controls.Add(lblQty);
            panel1.Controls.Add(txtRate);
            panel1.Controls.Add(lblRate);
            panel1.Controls.Add(cbxProduct);
            panel1.Controls.Add(lblProduct);
            panel1.Controls.Add(lblInvoiceNo);
            panel1.Controls.Add(txtInvoiceNo);
            panel1.Controls.Add(txtInvoiceDate);
            panel1.Controls.Add(cbxCustomer);
            panel1.Controls.Add(lblInvoiceDate);
            panel1.Controls.Add(lblCustomer);
            panel1.Location = new Point(4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 156);
            panel1.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            btnClear.Location = new Point(834, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 27);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            btnAdd.Location = new Point(778, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 27);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            txtAmount.Location = new Point(615, 117);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(140, 26);
            txtAmount.TabIndex = 13;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblAmount.Location = new Point(615, 95);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 12;
            lblAmount.Text = "Amount";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            txtQty.Location = new Point(485, 116);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 26);
            txtQty.TabIndex = 11;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblQty.Location = new Point(485, 95);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(32, 20);
            lblQty.TabIndex = 10;
            lblQty.Text = "Qty";
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            txtRate.Location = new Point(325, 117);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(140, 26);
            txtRate.TabIndex = 9;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblRate.Location = new Point(325, 95);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(39, 20);
            lblRate.TabIndex = 8;
            lblRate.Text = "Rate";
            // 
            // cbxProduct
            // 
            cbxProduct.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            cbxProduct.FormattingEnabled = true;
            cbxProduct.Location = new Point(8, 117);
            cbxProduct.Name = "cbxProduct";
            cbxProduct.Size = new Size(300, 27);
            cbxProduct.TabIndex = 7;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.World);
            lblProduct.Location = new Point(8, 95);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Product";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(4, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 268);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, ProductId, Product, Rate, Qty, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(901, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // ProductId
            // 
            ProductId.HeaderText = "ProductId";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.Visible = false;
            ProductId.Width = 125;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.Width = 405;
            // 
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.MinimumWidth = 6;
            Rate.Name = "Rate";
            Rate.Width = 150;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 150;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalDisplay);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(4, 448);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 110);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.AutoSize = true;
            lblTotalDisplay.Location = new Point(825, 11);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(0, 17);
            lblTotalDisplay.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(708, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 17);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(708, 78);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(806, 78);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSalesInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSalesInvoice";
            Text = "Sales Invoice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblInvoiceNo;
        private TextBox txtInvoiceNo;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceDate;
        private Label lblCustomer;
        private ComboBox cbxCustomer;
        private Panel panel1;
        private Panel panel2;
        private Button btnAdd;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtQty;
        private Label lblQty;
        private TextBox txtRate;
        private Label lblRate;
        private ComboBox cbxProduct;
        private Label lblProduct;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label lblTotalDisplay;
        private Label lblTotal;
        private Button btnPrint;
        private Button btnSave;
        private Button btnClear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Amount;
    }
}