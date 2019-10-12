using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class db
    {
        static string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["Test2ConnectionString"].ToString();

        public static DataTable getdt(string s)
        {
            using (SqlConnection conn=new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                DataTable r = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(r);

                conn.Close();
                return r; 
            }
        }

        public static int exeint(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                if (conn.State != ConnectionState.Open) conn.Open();

                int r = cmd.ExecuteNonQuery();

                conn.Close();
                return r;
            }
        }

        public static object exeobj(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                if (conn.State != ConnectionState.Open) conn.Open();

                object r = cmd.ExecuteScalar();

                conn.Close();
                return r;
            }
        }
    }
}