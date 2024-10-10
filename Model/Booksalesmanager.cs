using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookSalesSanager.Model
{
    public class Booksalesmanager
    {
        public string connectStr = ConfigurationManager.ConnectionStrings["BookSalesSanager.Properties.Settings.booksalesmanagerConnectionString"].ConnectionString;

        public Booksalesmanager()
        {
            // Create category table
            CreateTable(categoryQuery);
            // Create book table only if category exists
            CreateTable(bookQuery, new string[] { "category" });
            // Create invoice table
            CreateTable(invoiceQuery);
            // Create good_receipt table
            CreateTable(goodReceiptQuery);
            // Create good_receipt_details table only if both good_receipt and book exist
            CreateTable(goodReceiptDetailsQuery, new string[] { "good_receipt", "book" });
        }

        private string categoryQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'category')
                  BEGIN
                      CREATE TABLE category (
                          id INT IDENTITY(1,1) PRIMARY KEY,
                          name NVARCHAR(255) NOT NULL
                      );
                  END";

        private string bookQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'book')
                  BEGIN
                      CREATE TABLE book (
                          id INT IDENTITY(1,1) PRIMARY KEY,
                          name NVARCHAR(255) NOT NULL,
                          author NVARCHAR(255),
                          qty INT NOT NULL,
                          price DECIMAL(18,2),
                          category_id INT,
                          CONSTRAINT FK_book_category FOREIGN KEY (category_id) REFERENCES category(id) ON DELETE CASCADE
                      );
                  END";

        private string invoiceQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'invoice')
                  BEGIN
                      CREATE TABLE invoice (
                          id INT IDENTITY(1,1) PRIMARY KEY,
                          invoice_date DATETIME,
                          customer_name NVARCHAR(255) NOT NULL,
                          customer_phone VARCHAR(15)
                      );
                  END";

        private string goodReceiptQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'good_receipt')
                  BEGIN
                      CREATE TABLE good_receipt (
                          id INT IDENTITY(1,1) PRIMARY KEY,
                          date DATETIME,
                          supplier_name NVARCHAR(255)
                     );
                  END";

        private string goodReceiptDetailsQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'good_receipt_details')
                  BEGIN
                      CREATE TABLE good_receipt_details (
                          good_receipt_id INT,
                          book_id INT,
                          qty INT,
                          CONSTRAINT FK_good_receipt_details_good_receipt FOREIGN KEY (good_receipt_id) REFERENCES good_receipt(id),
                          CONSTRAINT FK_good_receipt_details_book FOREIGN KEY (book_id) REFERENCES book(id)
                      );
                  END";

        public void CreateTable(string query, string[] tableNames = null)
        {
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                bool allTablesExist = true; // Assume all tables exist unless proven otherwise

                try
                {
                    con.Open();

                    // Check for the existence of specified tables
                    if (tableNames != null)
                    {
                        foreach (var tableName in tableNames)
                        {
                            string checkQuery = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName";
                            using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@tableName", tableName);
                                int tableCount = (int)cmd.ExecuteScalar();
                                if (tableCount == 0)
                                {
                                    allTablesExist = false; // If any table is missing, set to false
                                    break;
                                }
                            }
                        }
                    }

                    // Create the table if all required tables exist
                    if (allTablesExist)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"One or more required tables are missing. Table creation skipped for: {query}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurredssss: " + ex.Message);
                }
            }
        }
    }
}
