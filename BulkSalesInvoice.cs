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
    public partial class BulkSalesInvoice : Form
    {
        string Con = ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString;

        public BulkSalesInvoice()
        {
            InitializeComponent();

            LoadComboBoxItems();            
            // Enable autocomplete (search) in ComboBox
            cbxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadComboBoxItems()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sgdGetCustomerMasterForBulk", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Add items to the dropdown
                        cbxCustomer.DataSource = dt;
                        cbxCustomer.DisplayMember = "CustomerName";
                        cbxCustomer.ValueMember = "Id";
                        cbxCustomer.SelectedIndex = -1;
                        //cbxCustomer.SelectedText = "Select Customer";                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }
        }

        private void ClearDetails()
        {
            cbxCustomer.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }
        
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SelectCustomer"].Index) // Adjust "Select" to your checkbox column name
            {
                int count = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["SelectCustomer"].Value) == true)
                    {
                        count++;
                    }
                }

                lblCount.Text = count.ToString(); // You can update a label, or use MessageBox
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ButtonRemoveColumn")
            {
                var confirm = MessageBox.Show("Do you want to remove this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    cbxCustomer.SelectedIndex = -1;
                }
            }
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (cbxCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer from the dropdown.");
                return;
            }

            string selected = cbxCustomer.Text;

            if (selected == "Select All")
            {
                using (SqlConnection con = new SqlConnection(Con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetCustomerMaster", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtg = new DataTable();

                    da.Fill(dtg);

                    if (dtg.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtg.Rows.Count; i++)
                        {
                            AddCustomerToGrid(Convert.ToInt64(dtg.Rows[i][0]), dtg.Rows[i][1].ToString());
                        }
                    }
                }
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    AddCustomerToGrid(Convert.ToInt64(cbxCustomer.SelectedValue), cbxCustomer.Text);                
                }
                else
                {
                    AddCustomerToGrid(Convert.ToInt64(cbxCustomer.SelectedValue), cbxCustomer.Text);
                }
            }
        }

        private void AddCustomerToGrid(Int64 customerId,string customerName)
        {
            // Prevent duplicate entries
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Customer"].Value?.ToString() == customerName)
                    return;
            }
                        
            dataGridView1.Rows.Add(false, customerId, customerName);
        }

        private void btnCreateBulkSaleInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                bool anyChecked = dataGridView1.Rows
                                  .Cast<DataGridViewRow>()
                                  .Any(row => Convert.ToBoolean(row.Cells["SelectCustomer"].Value) == true);

                if (!anyChecked)
                {
                    MessageBox.Show("Please select at least one record.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method early
                }

                List<string> duplicates = new List<string>();
                int insertCount = 0;

                using (SqlConnection conn = new SqlConnection(Con))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["SelectCustomer"].Value) == true)
                        {
                            string customerName = row.Cells["Customer"].Value.ToString();
                            Int64 customerId = Convert.ToInt64(row.Cells["Id"].Value);

                            SqlCommand cmd = new SqlCommand("sgd_InsertCustomerIfNotExists", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            cmd.Parameters.AddWithValue("@CustomerName", customerName);
                            cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                            // Get return value from stored procedure
                            SqlParameter returnValue = new SqlParameter();
                            returnValue.Direction = ParameterDirection.ReturnValue;
                            cmd.Parameters.Add(returnValue);

                            cmd.ExecuteNonQuery();

                            int result = (int)returnValue.Value;
                            if (result == 1)
                            {
                                insertCount++; // Inserted
                            }
                            else
                            {
                                duplicates.Add(customerName); // Duplicate
                            }
                        }
                    }
                }

                // Show result
                string message = $" Inserted: {insertCount} record(s).";
                if (duplicates.Count > 0)
                {
                    message += "\n Skipped (already exists):\n" + string.Join("\n", duplicates);
                }

                MessageBox.Show(message, "Insert Summary");
                ClearDetails();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Try again later");
                return;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

    }
}
