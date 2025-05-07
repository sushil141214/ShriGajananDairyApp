namespace ShriGajananDairy
{
    partial class frmCustomerReport
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
            cbxCustomer = new ComboBox();
            lblCustomerName = new Label();
            gvCustomer = new DataGridView();
            lblBillCount = new Label();
            lblBillCount1 = new Label();
            lblTotalAmt = new Label();
            lblTotalAmtTxt = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)gvCustomer).BeginInit();
            SuspendLayout();
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(202, 20);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(267, 28);
            cbxCustomer.TabIndex = 0;
            cbxCustomer.SelectedIndexChanged += cbxCustomer_SelectedIndexChanged;
            cbxCustomer.SelectionChangeCommitted += cbxCustomer_SelectedIndexChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(61, 23);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name";
            // 
            // gvCustomer
            // 
            gvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCustomer.Location = new Point(12, 92);
            gvCustomer.Name = "gvCustomer";
            gvCustomer.RowHeadersWidth = 51;
            gvCustomer.Size = new Size(868, 236);
            gvCustomer.TabIndex = 2;
            // 
            // lblBillCount
            // 
            lblBillCount.AutoSize = true;
            lblBillCount.Location = new Point(247, 367);
            lblBillCount.Name = "lblBillCount";
            lblBillCount.Size = new Size(110, 20);
            lblBillCount.TabIndex = 3;
            lblBillCount.Text = "Total Bill Count";
            // 
            // lblBillCount1
            // 
            lblBillCount1.AutoSize = true;
            lblBillCount1.Location = new Point(395, 367);
            lblBillCount1.Name = "lblBillCount1";
            lblBillCount1.Size = new Size(0, 20);
            lblBillCount1.TabIndex = 4;
            // 
            // lblTotalAmt
            // 
            lblTotalAmt.AutoSize = true;
            lblTotalAmt.Location = new Point(730, 367);
            lblTotalAmt.Name = "lblTotalAmt";
            lblTotalAmt.Size = new Size(0, 20);
            lblTotalAmt.TabIndex = 6;
            // 
            // lblTotalAmtTxt
            // 
            lblTotalAmtTxt.AutoSize = true;
            lblTotalAmtTxt.Location = new Point(582, 367);
            lblTotalAmtTxt.Name = "lblTotalAmtTxt";
            lblTotalAmtTxt.Size = new Size(74, 20);
            lblTotalAmtTxt.TabIndex = 5;
            lblTotalAmtTxt.Text = "Total Amt";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(757, 414);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print ";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmCustomerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 482);
            Controls.Add(btnPrint);
            Controls.Add(lblTotalAmt);
            Controls.Add(lblTotalAmtTxt);
            Controls.Add(lblBillCount1);
            Controls.Add(lblBillCount);
            Controls.Add(gvCustomer);
            Controls.Add(lblCustomerName);
            Controls.Add(cbxCustomer);
            Name = "frmCustomerReport";
            Text = "Customer Report";
            ((System.ComponentModel.ISupportInitialize)gvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxCustomer;
        private Label lblCustomerName;
        private DataGridView gvCustomer;
        private Label lblBillCount;
        private Label lblBillCount1;
        private Label lblTotalAmt;
        private Label lblTotalAmtTxt;
        private Button btnPrint;
    }
}