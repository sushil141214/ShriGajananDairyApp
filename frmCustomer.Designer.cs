namespace ShriGajananDairy
{
    partial class frmCustomer
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
            lblProduct = new Label();
            cbProduct = new ComboBox();
            btndelete = new Button();
            btnClear = new Button();
            btnCreate = new Button();
            txtOutstanding = new TextBox();
            lblOutstanding = new Label();
            txtRate = new TextBox();
            lblRate = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtPincode = new TextBox();
            lblPincode = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmailId = new TextBox();
            lblEmailID = new Label();
            txtMobile = new TextBox();
            lblMobileNumber = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblid = new Label();
            gvSuppler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvSuppler).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(97, 400);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 43;
            lblProduct.Text = "Product";
            lblProduct.UseMnemonic = false;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(203, 392);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(221, 28);
            cbProduct.TabIndex = 42;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(959, 446);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 39);
            btndelete.TabIndex = 41;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(812, 446);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 43);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(673, 446);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 43);
            btnCreate.TabIndex = 39;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtOutstanding
            // 
            txtOutstanding.Location = new Point(742, 332);
            txtOutstanding.Name = "txtOutstanding";
            txtOutstanding.Size = new Size(236, 27);
            txtOutstanding.TabIndex = 38;
            // 
            // lblOutstanding
            // 
            lblOutstanding.AutoSize = true;
            lblOutstanding.Location = new Point(547, 338);
            lblOutstanding.Name = "lblOutstanding";
            lblOutstanding.Size = new Size(90, 20);
            lblOutstanding.TabIndex = 37;
            lblOutstanding.Text = "Outstanding";
            lblOutstanding.UseMnemonic = false;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(203, 332);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(221, 27);
            txtRate.TabIndex = 36;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(97, 338);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(39, 20);
            lblRate.TabIndex = 35;
            lblRate.Text = "Rate";
            lblRate.UseMnemonic = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(742, 258);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(236, 27);
            txtQuantity.TabIndex = 34;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(547, 258);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 33;
            lblQuantity.Text = "Quantity";
            lblQuantity.UseMnemonic = false;
            // 
            // txtPincode
            // 
            txtPincode.Location = new Point(203, 255);
            txtPincode.Name = "txtPincode";
            txtPincode.Size = new Size(221, 27);
            txtPincode.TabIndex = 32;
            // 
            // lblPincode
            // 
            lblPincode.AutoSize = true;
            lblPincode.Location = new Point(97, 258);
            lblPincode.Name = "lblPincode";
            lblPincode.Size = new Size(68, 20);
            lblPincode.TabIndex = 31;
            lblPincode.Text = "Pin Code";
            lblPincode.UseMnemonic = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(742, 158);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(379, 74);
            txtAddress.TabIndex = 30;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(538, 155);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 29;
            lblAddress.Text = "Address";
            lblAddress.UseMnemonic = false;
            // 
            // txtEmailId
            // 
            txtEmailId.Location = new Point(203, 152);
            txtEmailId.Name = "txtEmailId";
            txtEmailId.Size = new Size(221, 27);
            txtEmailId.TabIndex = 28;
            // 
            // lblEmailID
            // 
            lblEmailID.AutoSize = true;
            lblEmailID.Location = new Point(97, 152);
            lblEmailID.Name = "lblEmailID";
            lblEmailID.Size = new Size(63, 20);
            lblEmailID.TabIndex = 27;
            lblEmailID.Text = "Email Id";
            lblEmailID.UseMnemonic = false;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(742, 87);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(221, 27);
            txtMobile.TabIndex = 26;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(538, 87);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(114, 20);
            lblMobileNumber.TabIndex = 25;
            lblMobileNumber.Text = "Mobile Number";
            lblMobileNumber.UseMnemonic = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 24;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(97, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 23;
            lblName.Text = "Name";
            lblName.UseMnemonic = false;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(756, 392);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 20);
            lblid.TabIndex = 44;
            lblid.UseMnemonic = false;
            // 
            // gvSuppler
            // 
            gvSuppler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gvSuppler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gvSuppler.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvSuppler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvSuppler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gvSuppler.DefaultCellStyle = dataGridViewCellStyle2;
            gvSuppler.EnableHeadersVisualStyles = false;
            gvSuppler.GridColor = SystemColors.InactiveCaption;
            gvSuppler.Location = new Point(12, 508);
            gvSuppler.Name = "gvSuppler";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gvSuppler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gvSuppler.RowHeadersVisible = false;
            gvSuppler.RowHeadersWidth = 51;
            gvSuppler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSuppler.Size = new Size(1096, 241);
            gvSuppler.TabIndex = 45;
            gvSuppler.CellDoubleClick += gvSuppler_CellDoubleClick;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 761);
            Controls.Add(gvSuppler);
            Controls.Add(lblid);
            Controls.Add(lblProduct);
            Controls.Add(cbProduct);
            Controls.Add(btndelete);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(txtOutstanding);
            Controls.Add(lblOutstanding);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPincode);
            Controls.Add(lblPincode);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtEmailId);
            Controls.Add(lblEmailID);
            Controls.Add(txtMobile);
            Controls.Add(lblMobileNumber);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 9F);
            Name = "frmCustomer";
            Text = "Customer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)gvSuppler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cbProduct;
        private Button btndelete;
        private Button btnClear;
        private Button btnCreate;
        private TextBox txtOutstanding;
        private Label lblOutstanding;
        private TextBox txtRate;
        private Label lblRate;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtPincode;
        private Label lblPincode;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmailId;
        private Label lblEmailID;
        private TextBox txtMobile;
        private Label lblMobileNumber;
        private TextBox txtName;
        private Label lblName;
        private Label lblid;
        private DataGridView gvSuppler;
    }
}