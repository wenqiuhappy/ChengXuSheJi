using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Test01
{
    public class db
    {
        static string connstr = System.Configuration.ConfigurationManager.AppSettings["connstr"].ToString();

        public static DataTable getdt(string s)
        {
            using (SqlConnection conn=new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                sda.Fill(t);
                conn.Close();
                return t;

            }
        }

        public static int exeint(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                int t = cmd.ExecuteNonQuery();
                conn.Close();
                return t;

            }
        }

        public static object exeobj(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                object t = cmd.ExecuteScalar();
                conn.Close();
                return t;

            }
        }

    }
}