using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShriGajananDairy
{
    public partial class frmCustomerReport : Form
    {
        private bool isFirstSelection = true;
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString.ToString());
        DataSet ds;
        public frmCustomerReport()
        {
            InitializeComponent();
            LoadCustomerDropdown();
            //cbxCustomer.SelectedValue = 0;
        }

       

        private void LoadCustomerDropdown()
        {
            try
            {
                if (Con.State == ConnectionState.Closed) { Con.Open(); }
                
                   
                    SqlCommand cmd = new SqlCommand("sp_GetCustomerMaster", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        cbxCustomer.DataSource = dt;
                        cbxCustomer.DisplayMember = "CustomerName";
                        cbxCustomer.ValueMember = "Id";
                        cbxCustomer.SelectedIndex = 1;
                        cbxCustomer.SelectedText = "Select Customer";
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        public void gvLoadCustomerBill()
        {
            try {
                if (Con.State == ConnectionState.Closed) { Con.Open(); }
                SqlCommand cmd = new SqlCommand("sgd_GetInvoiceDetails", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustID", cbxCustomer.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCustomer.DataSource = dt;
                gvCustomer.Columns[0].HeaderText = "Invoice No.";
                gvCustomer.Columns[1].HeaderText = "Invoice Date";
                gvCustomer.Columns[2].HeaderText = "Customer Name";
                gvCustomer.Columns[3].HeaderText = "Product";
                gvCustomer.Columns[4].HeaderText = "Rate";
                gvCustomer.Columns[5].HeaderText = "Quantity";
                gvCustomer.Columns[6].HeaderText = "Invoice Amt";
                gvCustomer.AutoResizeColumns();
                gvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }

        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstSelection)
            {
                isFirstSelection = false;
                return; // Ignore first selection change
            }

            gvLoadCustomerBill();
        }
    }
}
