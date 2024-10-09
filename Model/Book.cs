using System;
using System.Data.SqlClient;
using System.Configuration;

namespace BookSalesSanager.Model
{
    public class Book
    {
        public string connectStr { get; set; }

        public Book()
        {
            string bookTableQuery = @"
                CREATE TABLE book
                id INT IDENTINY(1,1) PRIMARY KEY,
                name NVARCHAR(255) NOT NULL,
                author NVARCHAR(255),
                qty INT NOT NULL,
                price MONEY NOT NULL,
                category_id int
            ";
        }
    }
}


