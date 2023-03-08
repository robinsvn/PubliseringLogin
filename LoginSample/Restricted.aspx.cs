using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PubliseringLogin
{
    public partial class Restricted : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) { //knappeklikk er postback
                UpdatePageWithArlyText();//page load cycle
                UpdatePageWithKolonneText();
            }
        }
        protected void UpdatePageWithArlyText()
        {
            var GetAllFromLogin = dbl.GetAllFromLogin();
            var arlyText = "";
            foreach (DataRow row in GetAllFromLogin.AsEnumerable())
            {
                arlyText = row["ArlyText"].ToString();
            }
            ArlyTextbox.Text = arlyText;
        }
        protected void UpdatePageWithKolonneText()
        {
            var GetAllFromLogin = dbl.GetAllFromLogin();
            var kolonneText = "";
            foreach (DataRow row in GetAllFromLogin.AsEnumerable())
            {
                kolonneText = row["kol1"].ToString();
            }
            KolonneTextbox.Text = kolonneText;
        }

        protected void DefaultRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        public void UpdateDB_Click(object sender, EventArgs e)
        {
            dbl.UpdateArlyText(ArlyTextbox.Text);
            UpdatePageWithArlyText();
        }

        protected void UpdateKolonne_Click(object sender, EventArgs e)
        {
            dbl.UpdateKolonneText(KolonneTextbox.Text);
            UpdatePageWithKolonneText();
        }
    }
}