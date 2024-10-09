using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesSanager.Model
{
    public class Booksalesmanager
    {
        public string connectStr = ConfigurationManager.ConnectionStrings["BookSalesSanager.Properties.Settings.booksalesmanagerConnectionString"].ConnectionString;

        public void CreateTable(string query)
        {
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                try
                {
                    // Open connection
                    con.Open();

                    // Create SqlCommand to execute query
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Execute query
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Bamh duoc tao thanh cong.");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
