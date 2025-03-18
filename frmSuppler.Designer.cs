namespace ShriGajananDairy
{
    partial class frmSuppler
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
            txtMobile = new TextBox();
            lblMobileNumber = new Label();
            txtEmailId = new TextBox();
            lblEmailID = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPincode = new TextBox();
            lblPincode = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblRate = new Label();
            txtRate = new TextBox();
            txtOutstanding = new TextBox();
            lblOutstanding = new Label();
            btndelete = new Button();
            btnClear = new Button();
            btnCreate = new Button();
            gvSuppler = new DataGridView();
            cbProduct = new ComboBox();
            lblProduct = new Label();
            lblid = new Label();
            ((System.ComponentModel.ISupportInitialize)gvSuppler).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.UseMnemonic = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 34);
            txtName.TabIndex = 1;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(669, 43);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(221, 34);
            txtMobile.TabIndex = 3;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(465, 43);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(151, 28);
            lblMobileNumber.TabIndex = 2;
            lblMobileNumber.Text = "Mobile Number";
            lblMobileNumber.UseMnemonic = false;
            // 
            // txtEmailId
            // 
            txtEmailId.Location = new Point(130, 108);
            txtEmailId.Name = "txtEmailId";
            txtEmailId.Size = new Size(221, 34);
            txtEmailId.TabIndex = 5;
            // 
            // lblEmailID
            // 
            lblEmailID.AutoSize = true;
            lblEmailID.Location = new Point(24, 108);
            lblEmailID.Name = "lblEmailID";
            lblEmailID.Size = new Size(81, 28);
            lblEmailID.TabIndex = 4;
            lblEmailID.Text = "Email Id";
            lblEmailID.UseMnemonic = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(669, 114);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(379, 74);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(465, 111);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            lblAddress.UseMnemonic = false;
            // 
            // txtPincode
            // 
            txtPincode.Location = new Point(130, 211);
            txtPincode.Name = "txtPincode";
            txtPincode.Size = new Size(221, 34);
            txtPincode.TabIndex = 9;
            // 
            // lblPincode
            // 
            lblPincode.AutoSize = true;
            lblPincode.Location = new Point(24, 214);
            lblPincode.Name = "lblPincode";
            lblPincode.Size = new Size(90, 28);
            lblPincode.TabIndex = 8;
            lblPincode.Text = "Pin Code";
            lblPincode.UseMnemonic = false;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(474, 214);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(88, 28);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            lblQuantity.UseMnemonic = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(669, 214);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(236, 34);
            txtQuantity.TabIndex = 11;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(24, 294);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(51, 28);
            lblRate.TabIndex = 12;
            lblRate.Text = "Rate";
            lblRate.UseMnemonic = false;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(130, 288);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(221, 34);
            txtRate.TabIndex = 13;
            // 
            // txtOutstanding
            // 
            txtOutstanding.Location = new Point(669, 288);
            txtOutstanding.Name = "txtOutstanding";
            txtOutstanding.Size = new Size(236, 34);
            txtOutstanding.TabIndex = 15;
            // 
            // lblOutstanding
            // 
            lblOutstanding.AutoSize = true;
            lblOutstanding.Location = new Point(474, 294);
            lblOutstanding.Name = "lblOutstanding";
            lblOutstanding.Size = new Size(121, 28);
            lblOutstanding.TabIndex = 14;
            lblOutstanding.Text = "Outstanding";
            lblOutstanding.UseMnemonic = false;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(886, 402);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 39);
            btndelete.TabIndex = 19;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(739, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 43);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(600, 402);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 43);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
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
            gvSuppler.EnableHeadersVisualStyles = false;
            gvSuppler.GridColor = SystemColors.InactiveCaption;
            gvSuppler.Location = new Point(0, 475);
            gvSuppler.Name = "gvSuppler";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gvSuppler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gvSuppler.RowHeadersVisible = false;
            gvSuppler.RowHeadersWidth = 51;
            gvSuppler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSuppler.Size = new Size(1096, 304);
            gvSuppler.TabIndex = 20;
            gvSuppler.CellDoubleClick += gvSuppler_CellDoubleClick;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(130, 348);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(221, 36);
            cbProduct.TabIndex = 21;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(24, 356);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(81, 28);
            lblProduct.TabIndex = 22;
            lblProduct.Text = "Product";
            lblProduct.UseMnemonic = false;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(669, 336);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 28);
            lblid.TabIndex = 23;
            lblid.UseMnemonic = false;
            // 
            // frmSuppler
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 779);
            Controls.Add(lblid);
            Controls.Add(lblProduct);
            Controls.Add(cbProduct);
            Controls.Add(gvSuppler);
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
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmSuppler";
            Text = "Suppler";
            ((System.ComponentModel.ISupportInitialize)gvSuppler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtMobile;
        private Label lblMobileNumber;
        private TextBox txtEmailId;
        private Label lblEmailID;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPincode;
        private Label lblPincode;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblRate;
        private TextBox txtRate;
        private TextBox txtOutstanding;
        private Label lblOutstanding;
        private Button btndelete;
        private Button btnClear;
        private Button btnCreate;
        private DataGridView gvSuppler;
        private ComboBox cbProduct;
        private Label lblProduct;
        private Label lblid;
    }
}