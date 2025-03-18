namespace ShriGajananDairy
{
    partial class frmProduct
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
            lblName = new Label();
            txtName = new TextBox();
            txtProductDesc = new TextBox();
            lblProductDesc = new Label();
            txtPurchaseRate = new TextBox();
            lblPurchaseRate = new Label();
            txtSalesRate = new TextBox();
            lblSaleRate = new Label();
            txtdiscount = new TextBox();
            lbldiscount = new Label();
            btnCreate = new Button();
            btnClear = new Button();
            lblid = new Label();
            gvProductData = new DataGridView();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gvProductData).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 34);
            txtName.TabIndex = 1;
            // 
            // txtProductDesc
            // 
            txtProductDesc.Location = new Point(752, 52);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(247, 34);
            txtProductDesc.TabIndex = 3;
            // 
            // lblProductDesc
            // 
            lblProductDesc.AutoSize = true;
            lblProductDesc.Location = new Point(541, 58);
            lblProductDesc.Name = "lblProductDesc";
            lblProductDesc.Size = new Size(186, 28);
            lblProductDesc.TabIndex = 2;
            lblProductDesc.Text = "Product Description";
            // 
            // txtPurchaseRate
            // 
            txtPurchaseRate.Location = new Point(752, 138);
            txtPurchaseRate.Name = "txtPurchaseRate";
            txtPurchaseRate.Size = new Size(247, 34);
            txtPurchaseRate.TabIndex = 7;
            txtPurchaseRate.KeyPress += txtPurchaseRate_KeyPress;
            // 
            // lblPurchaseRate
            // 
            lblPurchaseRate.AutoSize = true;
            lblPurchaseRate.Location = new Point(541, 141);
            lblPurchaseRate.Name = "lblPurchaseRate";
            lblPurchaseRate.Size = new Size(133, 28);
            lblPurchaseRate.TabIndex = 6;
            lblPurchaseRate.Text = "Purchase Rate";
            // 
            // txtSalesRate
            // 
            txtSalesRate.Location = new Point(185, 144);
            txtSalesRate.Name = "txtSalesRate";
            txtSalesRate.Size = new Size(247, 34);
            txtSalesRate.TabIndex = 5;
            txtSalesRate.KeyPress += txtSalesRate_KeyPress;
            // 
            // lblSaleRate
            // 
            lblSaleRate.AutoSize = true;
            lblSaleRate.Location = new Point(55, 144);
            lblSaleRate.Name = "lblSaleRate";
            lblSaleRate.Size = new Size(100, 28);
            lblSaleRate.TabIndex = 4;
            lblSaleRate.Text = "Sales Rate";
            // 
            // txtdiscount
            // 
            txtdiscount.Location = new Point(185, 228);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(247, 34);
            txtdiscount.TabIndex = 9;
            txtdiscount.KeyPress += txtdiscount_KeyPress;
            // 
            // lbldiscount
            // 
            lbldiscount.AutoSize = true;
            lbldiscount.Location = new Point(63, 234);
            lbldiscount.Name = "lbldiscount";
            lbldiscount.Size = new Size(89, 28);
            lbldiscount.TabIndex = 8;
            lbldiscount.Text = "Discount";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(521, 283);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 43);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(658, 283);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 43);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(752, 209);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 28);
            lblid.TabIndex = 14;
            // 
            // gvProductData
            // 
            gvProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gvProductData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gvProductData.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvProductData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvProductData.EnableHeadersVisualStyles = false;
            gvProductData.GridColor = SystemColors.InactiveCaption;
            gvProductData.Location = new Point(63, 374);
            gvProductData.Name = "gvProductData";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gvProductData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gvProductData.RowHeadersVisible = false;
            gvProductData.RowHeadersWidth = 51;
            gvProductData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvProductData.Size = new Size(920, 312);
            gvProductData.TabIndex = 15;
            gvProductData.CellDoubleClick += gvProductData_CellDoubleClick;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(809, 287);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 39);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 698);
            Controls.Add(btndelete);
            Controls.Add(gvProductData);
            Controls.Add(lblid);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(txtdiscount);
            Controls.Add(lbldiscount);
            Controls.Add(txtPurchaseRate);
            Controls.Add(lblPurchaseRate);
            Controls.Add(txtSalesRate);
            Controls.Add(lblSaleRate);
            Controls.Add(txtProductDesc);
            Controls.Add(lblProductDesc);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmProduct";
            Text = "Product";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gvProductData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtProductDesc;
        private Label lblProductDesc;
        private TextBox txtPurchaseRate;
        private Label lblPurchaseRate;
        private TextBox txtSalesRate;
        private Label lblSaleRate;
        private TextBox txtdiscount;
        private Label lbldiscount;
        private Button btnCreate;
        private Button btnClear;
        private Label lblid;
        private DataGridView gvProductData;
        private Button btndelete;
    }
}