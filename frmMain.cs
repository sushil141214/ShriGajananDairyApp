using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShriGajananDairy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCustomer Customers = new frmCustomer();
            Customers.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseInvoice PurchaseInvoice = new frmPurchaseInvoice();
            PurchaseInvoice.Show();

        }

        private void supplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSuppler Suppler = new frmSuppler();
            Suppler.Show();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmProduct Product = new frmProduct();
            Product.Show();
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSalesInvoice Invoice = new frmSalesInvoice();
            Invoice.Show();
        }

        private void salesMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSalesMemo SalesMemo = new frmSalesMemo();
            SalesMemo.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCustomerReport CustomerReport = new frmCustomerReport();
            CustomerReport.Show();
        }

        private void deliveryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDeliveryReport DeliveryReport = new frmDeliveryReport();
            DeliveryReport.Show();


        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmStockReport StockReport = new frmStockReport();
            StockReport.Show();

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSalesReport SalesReport = new frmSalesReport();
            SalesReport.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmPurchaseReport PurchaseReport = new frmPurchaseReport();
            PurchaseReport.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.Show();
        }
    }
}
