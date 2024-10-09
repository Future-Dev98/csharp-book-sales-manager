﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesSanager
{
    public class DataProvider
    {
        private string connectStr = ConfigurationManager.ConnectionStrings["BookSalesSanager.Properties.Settings.booksalesmanagerConnectionString"].ConnectionString;

        public DataTable execQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        // Sử dụng cho Insert, Update, Delete
        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        public object execScaler(string query)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
