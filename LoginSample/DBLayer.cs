using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PubliseringLogin
{
    public class DBLayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        public DataTable GetAllFromLogin()
        {
            DataTable Login = new DataTable();

            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Login", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Login.Load(reader);
            conn.Close();

            return Login;
        }
        public void UpdateArlyText(string ArlyText)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Login SET ArlyText = @ArlyText WHERE id = 1", conn);
            cmd.Parameters.AddWithValue("ArlyText", ArlyText);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateKolonneText(string KolonneText)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Login SET kol1 = @kol1 WHERE id = 1", conn);
            cmd.Parameters.AddWithValue("kol1", KolonneText);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void ChangeLoginAdminPasswordOnButton(string PasswordText)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Login SET pw = @pw WHERE id = 1", conn);
            cmd.Parameters.AddWithValue("pw", PasswordText);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}