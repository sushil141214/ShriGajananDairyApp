using Microsoft.Data.SqlClient;
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
    public partial class frmCustomer : Form
    {
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString.ToString());
        DataSet ds;
        public frmCustomer()
        {
            InitializeComponent();
            LoadGrid();
            FillSiteCode();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        public void LoadGrid()
        {
            try
            {
                if (Con.State == ConnectionState.Closed) { Con.Open(); }
                SqlCommand cmd = new SqlCommand("sgdCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", "");
                cmd.Parameters.AddWithValue("@Type", "S");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvSuppler.DataSource = dt;
                gvSuppler.Columns[0].HeaderText = "Customer Id";
                gvSuppler.Columns[1].HeaderText = "Customer Name";
                gvSuppler.Columns[2].HeaderText = "Mobile Number";
                gvSuppler.Columns[3].HeaderText = "Email";
                gvSuppler.Columns[4].HeaderText = "Pin Code";
                gvSuppler.Columns[5].HeaderText = "Product Name";
                gvSuppler.Columns[6].HeaderText = "Quantity";
                gvSuppler.Columns[7].HeaderText = "Rate";
                gvSuppler.Columns[8].HeaderText = "Outstanding";
                gvSuppler.Columns[9].HeaderText = "Address";
                gvSuppler.AutoResizeColumns();
                gvSuppler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;

            }

        }

        private void FillSiteCode()
        {
            try
            {
                string query_GetGate = "sgdCustomer";
                List<SqlParameter> GetGate_Para = new List<SqlParameter>();
                GetGate_Para.Add(new SqlParameter("@CustomerID", ""));
                GetGate_Para.Add(new SqlParameter("@Type", "CB".ToString()));
                ds = SqlHelper.ExecuteDataset(Con, CommandType.StoredProcedure, query_GetGate, GetGate_Para.ToArray());
                cbProduct.DisplayMember = "ProductName";
                cbProduct.ValueMember = "ProductID";
                cbProduct.DataSource = ds.Tables[0];
                cbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        public void Clear()
        {
            txtName.Text = "";
            txtMobile.Text = "";
            txtEmailId.Text = "";
            txtAddress.Text = "";
            txtPincode.Text = "";
            txtQuantity.Text = "";
            txtRate.Text = "";
            txtOutstanding.Text = "";
            cbProduct.SelectedIndex = -1;
            lblid.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                if (txtName.Text == "" || txtMobile.Text == "" || txtEmailId.Text == "" || txtAddress.Text == "" || txtPincode.Text == "" || txtQuantity.Text == "" || txtRate.Text == "" || txtOutstanding.Text == "" || lblid.Text == "")
                {
                    MessageBox.Show("Please delete records by double-clicking a row in a Gridview ..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtName.Focus();
                    return;
                }



                SqlCommand cmd = new SqlCommand("sgdCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = Convert.ToInt32(lblid.Text);
                cmd.Parameters.AddWithValue("@UserId", Global.userid);
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 10).Value = 'D';
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                string s = cmd.Parameters["@Result"].Value.ToString();
                MessageBox.Show(s, "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                LoadGrid();
                Clear();
                Con.Close();
                txtName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        public void SaveData()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                if (txtName.Text == "" || txtMobile.Text == "" || txtEmailId.Text == "" || txtAddress.Text == "" || txtPincode.Text == "" || txtQuantity.Text == "" || txtRate.Text == "")
                {
                    MessageBox.Show("Please fill text value..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtName.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("sgdCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@MobileNumber", txtMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@EmailId", txtEmailId.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PinCode", txtPincode.Text);
                cmd.Parameters.AddWithValue("@ProductId", cbProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductName", cbProduct.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@Rate", txtRate.Text);
                cmd.Parameters.AddWithValue("@Outstanding", txtOutstanding.Text);
                cmd.Parameters.AddWithValue("@UserId", Global.userid);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                if (lblid.Text == "")
                {
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = 'I';
                    cmd.ExecuteNonQuery();
                    string s = cmd.Parameters["@Result"].Value.ToString();
                    MessageBox.Show(s, "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = lblid.Text;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 10).Value = 'U';
                    cmd.ExecuteNonQuery();
                    string s = cmd.Parameters["@Result"].Value.ToString();
                    MessageBox.Show(s, "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                Clear();
                Con.Close();
                LoadGrid();
                btnCreate.Text = "Save";
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void gvSuppler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lblid.Text = gvSuppler.CurrentRow.Cells["CustomerID"].Value.ToString().Trim();
            txtName.Text = gvSuppler.CurrentRow.Cells["CustomerName"].Value.ToString().Trim();
            txtMobile.Text = gvSuppler.CurrentRow.Cells["MobileNumber"].Value.ToString().Trim();
            txtEmailId.Text = gvSuppler.CurrentRow.Cells["EmailId"].Value.ToString().Trim();
            txtAddress.Text = gvSuppler.CurrentRow.Cells["Address"].Value.ToString().Trim();
            txtPincode.Text = gvSuppler.CurrentRow.Cells["PinCode"].Value.ToString().Trim();
            txtQuantity.Text = gvSuppler.CurrentRow.Cells["Quantity"].Value.ToString().Trim();
            txtRate.Text = gvSuppler.CurrentRow.Cells["Rate"].Value.ToString().Trim();
            txtOutstanding.Text = gvSuppler.CurrentRow.Cells["Outstanding"].Value.ToString().Trim();
            cbProduct.SelectedText = gvSuppler.CurrentRow.Cells["ProductName"].Value.ToString().Trim();

            btnCreate.Text = "Update";

        }
    }
}
