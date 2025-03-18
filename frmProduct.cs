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
    public partial class frmProduct : Form
    {

        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString.ToString());
        DataSet ds;
        public frmProduct()
        {
            InitializeComponent();

            LoadGrid();
        }

        public void LoadGrid()
        {
            try
            {
                if (Con.State == ConnectionState.Closed) { Con.Open(); }
                SqlCommand cmd = new SqlCommand("sgdProduct", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", "");
                cmd.Parameters.AddWithValue("@Type", "S");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProductData.DataSource = dt;
                gvProductData.Columns[0].HeaderText = "Product Id";
                gvProductData.Columns[1].HeaderText = "Product Name";
                gvProductData.Columns[2].HeaderText = "Product Description";
                gvProductData.Columns[3].HeaderText = "Purchase Rate";
                gvProductData.Columns[4].HeaderText = "Sale Rate";
                gvProductData.Columns[5].HeaderText = "Discount";

                gvProductData.AutoResizeColumns();
                gvProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //dataGridView1.Columns[5].Visible = false;
                //dataGridView1.ColumnCount = 0;


                //gvProductData.Columns["ProductID"].Visible = true;
                //gvProductData.Columns["ProductName"].Visible = true;
                //gvProductData.Columns["ProductDesc"].Visible = false;
                //gvProductData.Columns["PucrchaseRate"].Visible = false;
                //gvProductData.Columns["SaleRate"].Visible = false;
                //gvProductData.Columns["Discount"].Visible = false;


                //gvProductData.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;

            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        public void SaveData()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                if (txtName.Text == "" || txtProductDesc.Text == "" || txtPurchaseRate.Text == "" || txtSalesRate.Text == "" || txtdiscount.Text == "")
                {
                    MessageBox.Show("Please fill text value..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtName.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("sgdProduct", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductDesc", txtProductDesc.Text.Trim());
                cmd.Parameters.AddWithValue("@SaleRate", txtSalesRate.Text);
                cmd.Parameters.AddWithValue("@PurchaseRate", txtPurchaseRate.Text);
                cmd.Parameters.AddWithValue("@Discount", txtdiscount.Text);
                cmd.Parameters.AddWithValue("@UserId", Global.userid);
                cmd.Parameters.Add("@Result", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                if (lblid.Text == "")
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = 'I';
                    cmd.ExecuteNonQuery();
                    string s = cmd.Parameters["@Result"].Value.ToString();
                    MessageBox.Show(s, "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = lblid.Text;
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


        public void Clear()
        {
            txtName.Text = "";
            txtProductDesc.Text = "";
            lblid.Text = "";
            txtSalesRate.Text = "";
            txtPurchaseRate.Text = "";
            txtdiscount.Text = "";
            btnCreate.Text = "Save";
            txtName.Focus();

        }

        private void gvProductData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = gvProductData.CurrentRow.Cells["ProductId"].Value.ToString().Trim();
            txtName.Text = gvProductData.CurrentRow.Cells["ProductName"].Value.ToString().Trim();
            txtProductDesc.Text = gvProductData.CurrentRow.Cells["ProductDesc"].Value.ToString().Trim();
            txtPurchaseRate.Text = gvProductData.CurrentRow.Cells["PurchaseRate"].Value.ToString().Trim();
            txtSalesRate.Text = gvProductData.CurrentRow.Cells["SaleRate"].Value.ToString().Trim();
            txtdiscount.Text = gvProductData.CurrentRow.Cells["Discount"].Value.ToString().Trim();
            btnCreate.Text = "Update";
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

                if (txtName.Text == "" || txtProductDesc.Text == "" || txtPurchaseRate.Text == "" || txtSalesRate.Text == "" || txtdiscount.Text == "")
                {
                    MessageBox.Show("Please delete records by double-clicking a row in a Gridview ..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtName.Focus();
                    return;
                }



                SqlCommand cmd = new SqlCommand("sgdProduct", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(lblid.Text);
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



        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtSalesRate_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtPurchaseRate_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
