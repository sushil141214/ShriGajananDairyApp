using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ShriGajananDairy
{
    public partial class Login : Form
    {

        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ShriGajananDairy.Properties.Settings.GajananDairy1"].ConnectionString.ToString());

        DataSet ds;
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.userid = 1;
           FrmMain Dash = new FrmMain();
            Dash.Show();
            //try
            //{
            //    if (Con.State == ConnectionState.Closed)
            //    {
            //        Con.Open();
            //    }
            //    if (txtUserName.Text == "" && txtPassword.Text == "")
            //    {
            //        MessageBox.Show("Please fill text value..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //        txtUserName.Focus();
            //        return;
            //    }

            //    string query_Login = "[sgdUserLogin]";
            //    List<SqlParameter> Login_Para = new List<SqlParameter>();
            //    Login_Para.Add(new SqlParameter("@UserName", txtUserName.Text.Trim()));
            //    Login_Para.Add(new SqlParameter("@Password", txtPassword.Text.Trim()));
            //    ds = SqlHelper.ExecuteDataset(Con, CommandType.StoredProcedure, query_Login, Login_Para.ToArray());
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        Global.userid = Convert.ToInt32(ds.Tables[0].Rows[0]["RegistrationId"]);
            //        Global.username = ds.Tables[0].Rows[0]["UserName"].ToString();
            //        //string password= ds.Tables[0].Rows[0]["UserPassword"].ToString();
            //        this.Hide();
            //        FrmMain Dash = new FrmMain();
            //        Dash.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("UserName & Password Invalid, Try again..", "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //        txtUserName.Text = "";
            //        txtPassword.Text = "";
            //        txtUserName.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Click Ok", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    return;
            //}

        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();

        }
    }
}
