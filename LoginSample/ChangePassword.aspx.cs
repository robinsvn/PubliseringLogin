using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PubliseringLogin
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            var CurrentPassword = "";
            string EnteredPassword = OldPasswordTextBox.Text;
            var GetAllDataFromText = dbl.GetAllFromLogin();
            foreach (DataRow row in GetAllDataFromText.AsEnumerable())
            {
                CurrentPassword = row["pw"].ToString();
            }
            if (CurrentPassword != EnteredPassword)
            {
                WrongPassword.Visible = true;
                return;
            }
            else
            {
                WrongPassword.Visible = false;
                dbl.ChangeLoginAdminPasswordOnButton(NewPasswordTextBox.Text);
                ChangedPassword.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "redirectScript", "setTimeout(function() { window.location.replace('Restricted.aspx'); }, 1000);", true);
            }
        }
        protected void DefaultRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}