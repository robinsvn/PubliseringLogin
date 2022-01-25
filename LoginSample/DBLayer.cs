using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LoginSample
{
    public class DBLayer
    {
        public int GetUserCountByUserNameAndPassWord(string userName, string passWord)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["xxxx"].ConnectionString;
            SqlParameter param;
            int count = 0;//either 0 or 1. 1 if user exists
            string sqlCmd = "";
            
            sqlCmd = "select count(id)as num from table where username=@un and password=@pw";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCmd, conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = userName;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@pw", SqlDbType.NVarChar);
                param.Value = passWord;
                cmd.Parameters.Add(param);

                count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count;
            }
        }
    }
}