using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookSalesSanager.Model
{
    public class Booksalesmanager
    {
        public string connectStr = ConfigurationManager.ConnectionStrings["BookSalesSanager.Properties.Settings.booksalesmanagerConnectionString"].ConnectionString;

        public void CreateTable()
        {
            string[] tableCreationQueries = new string[]
            {
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'category')
                 BEGIN
                    CREATE TABLE category (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        name NVARCHAR(255) NOT NULL
                 );
                END",
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'book')
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
                 END",
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'invoice')
                     CREATE TABLE invoice (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        invoide_date DATETIME,
                        customer_name NVARCHAR(255) NOT NULL,
                        customer_phone VARCHAR(15)
                );",
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'invoice_details')
                 BEGIN
                     CREATE TABLE invoice_details (
                        book_id INT,
                        invoice_id INT,
                        qty INT,
                        CONSTRAINT FK_invoice_details_book FOREIGN KEY (book_id) REFERENCES book(id),
                        CONSTRAINT FK_invoice_details_invoice FOREIGN KEY (invoice_id) REFERENCES invoice(id) ON DELETE CASCADE
                );
                 END",
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'good_receipt_details')
                 BEGIN
                    CREATE TABLE good_receipt_details (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        book_id INT,
                        qty INT,
                        CONSTRAINT FK_good_receipt_details_book FOREIGN KEY (book_id) REFERENCES book(id)
                );
                END",
                @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'good_receipt')
                 BEGIN
                    CREATE TABLE good_receipt (
                        goods_receipt_details_id INT,
                        date DATETIME,
                        supplier_name NVARCHAR(255),
                        CONSTRAINT FK_good_receipt_good_receipt_details FOREIGN KEY (goods_receipt_details_id) REFERENCES good_receipt_details(id) ON DELETE CASCADE
                );
                END",
            };

            using (SqlConnection con = new SqlConnection(connectStr))
            {
                try
                {
                    con.Open();
                    bool tablesCreated = false;
                    foreach (var query in tableCreationQueries)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0) // Nếu có bảng được tạo
                            {
                                tablesCreated = true;
                            }
                        }
                    }
                    if (tablesCreated)
                    {
                        MessageBox.Show("Tables created successfully where applicable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
