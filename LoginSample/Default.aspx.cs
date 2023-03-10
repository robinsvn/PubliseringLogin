using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace PubliseringLogin
{
    public partial class Default : System.Web.UI.Page
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
            var Kol1 = "";
            foreach (DataRow row in GetAllFromLogin.AsEnumerable())
            {
                Kol1 = row["kol1"].ToString();
            }
            Kolonne1.Text = Kol1;
        }
    }
}