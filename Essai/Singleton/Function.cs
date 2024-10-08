﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai.Singleton
{
    class Function
    {
        private static Function _instance;
        private readonly string _connectionString = "data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True";

        private Function()
        {
        }

        public static Function Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Function();
                }

                return _instance;
            }
        }

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            return con;
        }

        public DataSet getData(string query)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public void setData(string query, string msg)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}