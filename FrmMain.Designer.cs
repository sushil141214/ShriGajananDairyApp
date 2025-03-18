namespace ShriGajananDairy
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            masterToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            supplerToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            saToolStripMenuItem = new ToolStripMenuItem();
            salesInvoiceToolStripMenuItem = new ToolStripMenuItem();
            salesMemoToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            customerReportToolStripMenuItem = new ToolStripMenuItem();
            deliveryReportToolStripMenuItem = new ToolStripMenuItem();
            stockReportToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            purchaseReportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterToolStripMenuItem, saToolStripMenuItem, reportToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 4, 0, 4);
            menuStrip1.Size = new Size(1924, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerToolStripMenuItem, supplerToolStripMenuItem, productToolStripMenuItem });
            masterToolStripMenuItem.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(121, 41);
            masterToolStripMenuItem.Text = "Master";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(232, 42);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // supplerToolStripMenuItem
            // 
            supplerToolStripMenuItem.Name = "supplerToolStripMenuItem";
            supplerToolStripMenuItem.Size = new Size(232, 42);
            supplerToolStripMenuItem.Text = "Suppler";
            supplerToolStripMenuItem.Click += supplerToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(232, 42);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // saToolStripMenuItem
            // 
            saToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salesInvoiceToolStripMenuItem, salesMemoToolStripMenuItem, purchaseToolStripMenuItem });
            saToolStripMenuItem.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            saToolStripMenuItem.Name = "saToolStripMenuItem";
            saToolStripMenuItem.Size = new Size(164, 41);
            saToolStripMenuItem.Text = "Inventory ";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            salesInvoiceToolStripMenuItem.Size = new Size(323, 42);
            salesInvoiceToolStripMenuItem.Text = "Sales Invoice";
            salesInvoiceToolStripMenuItem.Click += salesInvoiceToolStripMenuItem_Click;
            // 
            // salesMemoToolStripMenuItem
            // 
            salesMemoToolStripMenuItem.Name = "salesMemoToolStripMenuItem";
            salesMemoToolStripMenuItem.Size = new Size(323, 42);
            salesMemoToolStripMenuItem.Text = "Sales Memo";
            salesMemoToolStripMenuItem.Click += salesMemoToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(323, 42);
            purchaseToolStripMenuItem.Text = "Purchase Invoice";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerReportToolStripMenuItem, deliveryReportToolStripMenuItem, stockReportToolStripMenuItem, salesReportToolStripMenuItem, purchaseReportToolStripMenuItem });
            reportToolStripMenuItem.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(120, 41);
            reportToolStripMenuItem.Text = "Report";
            // 
            // customerReportToolStripMenuItem
            // 
            customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            customerReportToolStripMenuItem.Size = new Size(328, 42);
            customerReportToolStripMenuItem.Text = "Customer Report";
            customerReportToolStripMenuItem.Click += customerReportToolStripMenuItem_Click;
            // 
            // deliveryReportToolStripMenuItem
            // 
            deliveryReportToolStripMenuItem.Name = "deliveryReportToolStripMenuItem";
            deliveryReportToolStripMenuItem.Size = new Size(328, 42);
            deliveryReportToolStripMenuItem.Text = "Delivery Report";
            deliveryReportToolStripMenuItem.Click += deliveryReportToolStripMenuItem_Click;
            // 
            // stockReportToolStripMenuItem
            // 
            stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            stockReportToolStripMenuItem.Size = new Size(328, 42);
            stockReportToolStripMenuItem.Text = "Stock Report ";
            stockReportToolStripMenuItem.Click += stockReportToolStripMenuItem_Click;
            // 
            // salesReportToolStripMenuItem
            // 
            salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            salesReportToolStripMenuItem.Size = new Size(328, 42);
            salesReportToolStripMenuItem.Text = "Sales Report ";
            salesReportToolStripMenuItem.Click += salesReportToolStripMenuItem_Click;
            // 
            // purchaseReportToolStripMenuItem
            // 
            purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            purchaseReportToolStripMenuItem.Size = new Size(328, 42);
            purchaseReportToolStripMenuItem.Text = "Purchase Report ";
            purchaseReportToolStripMenuItem.Click += purchaseReportToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(92, 41);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "Dashbord";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem supplerToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem saToolStripMenuItem;
        private ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private ToolStripMenuItem salesMemoToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem customerReportToolStripMenuItem;
        private ToolStripMenuItem deliveryReportToolStripMenuItem;
        private ToolStripMenuItem stockReportToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private ToolStripMenuItem purchaseReportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}