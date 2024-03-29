﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Test01
{
    public class db
    {

        static string connstr = System.Configuration.ConfigurationManager.AppSettings["connstr"].ToString();

        public static DataTable getdt(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable t = new DataTable();
                adapter.Fill(t);
                conn.Close();
                return t;
            }
        }

        public static int exeint(string s)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand cmd = new SqlCommand(s, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
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
                if (conn.State != ConnectionState.Open) conn.Open();
                object t = cmd.ExecuteScalar();
                conn.Close();
                return t;
            }
        }
    }
}