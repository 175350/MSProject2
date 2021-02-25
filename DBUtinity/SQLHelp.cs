using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data; 

namespace DBUtinity
{
    public class SQLHelp
    {
        public static string ServerPort;
        public static string LoginMethod;
        static string connectionstr;
        public static void fangshi()
        {
            if (LoginMethod.Equals("Windows 身份验证"))
            {
                connectionstr = "server=" + ServerPort + ";database=student;integrated security=true";
            }
            else
            {
                connectionstr = "server=" + ServerPort + ";database=student;user id=sa;pwd=123";
            }
        }
        public static bool Sqlexcute(string sqlstr)
        {
            fangshi();
            try
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                SqlCommand com = new SqlCommand(sqlstr, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet Query(string sqlstr)
        {
            fangshi();
            try
            {
                SqlConnection con = new SqlConnection(connectionstr);
                SqlDataAdapter sda = new SqlDataAdapter(sqlstr, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
