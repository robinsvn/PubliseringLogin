using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace PubliseringLogin
{
    public partial class Login : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var GetAllFromLogin = dbl.GetAllFromLogin();
            var password = "";
            foreach (DataRow row in GetAllFromLogin.AsEnumerable())
            {
                password = row["pw"].ToString();
            }
            if (PasswordCheck.Text == password)
            {
                FormsAuthentication.RedirectFromLoginPage(password, false);
                WrongPassword.Visible = false;
            }
            else
            {
                WrongPassword.Visible = true;
            }
        }

        protected void DefaultRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}