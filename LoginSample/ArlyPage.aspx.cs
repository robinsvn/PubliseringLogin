using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PubliseringLogin
{
    public partial class ArlyPage : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            TekstHent();
        }
        protected void TekstHent()
        {
            var GetAllFromLogin = dbl.GetAllFromLogin();
            var Text = "";
            foreach (DataRow row in GetAllFromLogin.AsEnumerable())
            {
                Text = row["ArlyText"].ToString();
            }
            ArlyText.Text = Text;
        }
    }
}