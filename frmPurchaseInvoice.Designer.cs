namespace ShriGajananDairy
{
    partial class frmPurchaseInvoice
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
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.0425529F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.95744F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.Size = new Size(914, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // frmPurchaseInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 561);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPurchaseInvoice";
            Text = "Purchase Invoice";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}