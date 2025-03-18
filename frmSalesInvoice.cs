using Azure;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShriGajananDairy
{
    public partial class frmSalesInvoice : Form
    {
        string Con = ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString;
        DataTable dt = new DataTable();
        DataSet ds;
        int rowId = 1, selectedID;

        public frmSalesInvoice()
        {
            InitializeComponent();

            LoadInvoceNo();
            LoadCustomerDropdown();
            LoadProductDropdown();

            txtRate.TextChanged += CalculateAmount;
            txtQty.TextChanged += CalculateAmount;
        }

        private void LoadInvoceNo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetSalesInvoiceNo", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtInvoiceNo.Text = dt.Rows[0][0].ToString();
                        txtInvoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        txtInvoiceNo.Enabled = false;
                        txtInvoiceDate.Enabled = false;
                        txtAmount.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
            
        }

        private void LoadCustomerDropdown()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetCustomerMaster", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        cbxCustomer.DataSource = dt;
                        cbxCustomer.DisplayMember = "CustomerName"; 
                        cbxCustomer.ValueMember = "Id"; 
                        cbxCustomer.SelectedIndex = -1;
                        cbxCustomer.SelectedText = "Select Customer";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        private void LoadProductDropdown()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetProductMaster", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        cbxProduct.DataSource = dt;
                        cbxProduct.ValueMember = "Id";
                        cbxProduct.DisplayMember = "ProductName";
                        cbxProduct.SelectedIndex = -1;
                        cbxProduct.SelectedText = "Select Customer";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxProduct.Text == "" || txtRate.Text == "" || txtQty.Text == "")
                {
                    MessageBox.Show("Mandatory data not entered");
                    return;
                }

                int productId = Convert.ToInt32(cbxProduct.SelectedValue);
                string product = cbxProduct.Text;
                decimal rate = Convert.ToDecimal(txtRate.Text);
                int quantity = Convert.ToInt32(txtQty.Text);
                decimal amount = rate * quantity;

                dataGridView1.Rows.Add(rowId++, productId, product, rate, quantity, amount);

                CalculateTotal();

                ClearDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        private void CalculateTotal()
        {
            try
            {
                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Amount"].Value != null) // Check for null value
                    {
                        total += Convert.ToDecimal(row.Cells["Amount"].Value);
                    }
                }

                lblTotalDisplay.Text = total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }   
        }

        private void CalculateAmount(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtRate.Text, out decimal rate) && int.TryParse(txtQty.Text, out int quantity))
                {
                    txtAmount.Text = (rate * quantity).ToString("0.00"); // Show amount in Amount textbox
                }
                else
                {
                    txtAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    selectedID = Convert.ToInt32(row.Cells["Id"].Value);
                    cbxProduct.SelectedValue = Convert.ToInt32(row.Cells["ProductId"].Value);
                    txtRate.Text = row.Cells["Rate"].Value.ToString();
                    txtQty.Text = row.Cells["Qty"].Value.ToString();
                    txtAmount.Text = row.Cells["Amount"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void ClearDetails()
        {
            cbxProduct.SelectedIndex = -1;
            txtRate.Text = "";
            txtQty.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalid = true;

                isvalid = validate();

                if (isvalid)
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        using (SqlConnection conn = new SqlConnection(Con))
                        {
                            conn.Open();

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow) // Skip empty new row
                                {
                                    using (SqlCommand cmd = new SqlCommand("sp_InsertUpdateSALEPURCHASETRANSACTION", conn))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;
                                                                               
                                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(row.Cells["Id"].Value));
                                        cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text);
                                        cmd.Parameters.AddWithValue("@InvoiceDate", txtInvoiceDate.Text);
                                        cmd.Parameters.AddWithValue("@InvoiceType", "Sale");
                                        cmd.Parameters.AddWithValue("@CustomerId", cbxCustomer.SelectedValue);
                                        cmd.Parameters.AddWithValue("@CustomerName", cbxCustomer.Text);
                                        cmd.Parameters.AddWithValue("@ProductId", row.Cells["ProductId"].Value.ToString());
                                        cmd.Parameters.AddWithValue("@Product", row.Cells["Product"].Value.ToString());
                                        cmd.Parameters.AddWithValue("@Quantity", row.Cells["Qty"].Value.ToString());
                                        cmd.Parameters.AddWithValue("@Rate", row.Cells["Rate"].Value.ToString());
                                        cmd.Parameters.AddWithValue("@TotalAmt", row.Cells["Amount"].Value.ToString());
                                        cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Sale Invoice Saved");
                    }

                    // Reload the form
                    this.Hide();    // Hide the current form
                    frmSalesInvoice newForm = new frmSalesInvoice(); // Create a new instance of the form
                    newForm.ShowDialog(); // Show the new form
                    this.Close();  // Close the current form
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        private bool validate()
        {
            bool isvalid = true;

            if (cbxCustomer.SelectedIndex == -1) 
            {
                MessageBox.Show("select Customer");
                isvalid = false; 
            }
            if (dataGridView1.RowCount  == 0)
            {
                MessageBox.Show("Add product");
                isvalid = false;
            }

            return isvalid;
        }

    }
}
