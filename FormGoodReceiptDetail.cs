using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesSanager
{
    public partial class FormGoodReceiptDetail : Form
    {
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private DataProvider dataProvider = new DataProvider();

        private int goodReceiptID;

        private int bookId;

        private string editbookName;

        private List<Book> listBook;
        public FormGoodReceiptDetail(int goodReceiptId)
        {
            InitializeComponent();
            loadBook();
            title.Text = $"Good Receipt Detail {goodReceiptId}";
            goodReceiptID = goodReceiptId;
            loadGoodReceipt();
        }

        private void goodReceiptDetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (goodReceiptDetailList.Rows.Count > 1)
            {
                if (rowId == -1) rowId = 0;
                if (rowId == goodReceiptDetailList.Rows.Count - 1) rowId = rowId - 1;
                DataGridViewRow row = goodReceiptDetailList.Rows[rowId];
                cbBook.Text = editbookName =  row.Cells[0].Value.ToString();
                nmQty.Value = (int)row.Cells[1].Value;
                nmPrice.Value = (decimal)row.Cells[2].Value;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadGoodReceipt()
        {
            DataTable dt = new DataTable();
            string query = $@"SELECT book.name as [Book name], good_receipt_details.qty as [Quantity], good_receipt_details.price as [Price], good_receipt_details.qty * good_receipt_details.price as [Sum]
                             FROM good_receipt_details
                             INNER JOIN book ON book.id = good_receipt_details.book_id
                             INNER JOIN good_receipt ON good_receipt.id = good_receipt_details.good_receipt_id
                             WHERE good_receipt_details.good_receipt_id ={goodReceiptID}";
            dt = dataProvider.execQuery(query);
            goodReceiptDetailList.DataSource = dt;

            string querySum = $"SELECT SUM(qty * price) as Total FROM good_receipt_details WHERE good_receipt_id={goodReceiptID}";
            dt = dataProvider.execQuery(querySum);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Total"] != DBNull.Value)
            {
                decimal totalSum = dt.Rows[0].Field<decimal>("Total");
                Sum.Text = "Sum: " + totalSum.ToString();
            }
            else
            {
                Sum.Text = "Sum: 0";
            }
        }
        private void loadBook()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM book";
            dt = dataProvider.execQuery(query);
            cbBook.DisplayMember = "name";
            cbBook.ValueMember = "id";
            cbBook.DataSource = dt;
            listBook = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                listBook.Add(new Book
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["name"].ToString()
                });
            }
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            string checkQuery = $"SELECT COUNT(*) FROM good_receipt_details WHERE good_receipt_id = {goodReceiptID} AND book_id = {bookId}";
            DataTable dt = dataProvider.execQuery(checkQuery);

            string query = $"INSERT INTO good_receipt_details(good_receipt_id, book_id, qty, price) VALUES({goodReceiptID}, {bookId}, {nmQty.Value}, {nmPrice.Value})";
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                query = $"UPDATE good_receipt_details SET qty={nmQty.Value}, price={nmPrice.Value} WHERE good_receipt_id={goodReceiptID} AND book_id={bookId}";
            }
            
            int result = dataProvider.execNonQuery(query);

            if (result > 0)
            {
                loadGoodReceipt();
                MessageBox.Show("Added good receipt successfully!");
            }
            else
            {
                MessageBox.Show("Add good receipt failed!");
            }
        }

        private void btnEditClick(object sender, EventArgs e)
        {
            string query = $"UPDATE good_receipt_details SET book_id={bookId}, qty={nmQty.Value}, price={nmPrice.Value} WHERE good_receipt_id={goodReceiptID} AND book_id={bookId}";
            if (editbookName != cbBook.Text)
            {
                try
                {
                    string checkQuery = $"SELECT COUNT(*) FROM good_receipt_details WHERE good_receipt_id = {goodReceiptID} AND book_id = {bookId}";
                    DataTable dt = dataProvider.execQuery(checkQuery);
                    if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                    {
                        int oldBookId = listBook.FirstOrDefault(b => b.Name == editbookName)?.Id ?? 0;
                        string queryDelete = $"DELETE FROM good_receipt_details WHERE good_receipt_id={goodReceiptID} AND book_id={oldBookId}";
                        dataProvider.execNonQuery(queryDelete);
                    }
                    else
                    {
                        query = $"INSERT INTO good_receipt_details(good_receipt_id, book_id, qty, price) VALUES({goodReceiptID}, {bookId}, {nmQty.Value}, {nmPrice.Value})";
                    }

                } catch(Exception er) {
                    MessageBox.Show($"An error occurred: {er.Message}");
                }
            }
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadGoodReceipt();
                MessageBox.Show($"Updated good receipt ({goodReceiptID}) successfully!");
            }
            else
            {
                MessageBox.Show($"Update good receipt ({goodReceiptID}) failed!");
            }
        }
        private void btnDeleteClick(object sender, EventArgs e)
        {
            string query = $"DELETE FROM good_receipt_details WHERE good_receipt_id={goodReceiptID} AND book_id={bookId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadGoodReceipt();
                MessageBox.Show($"Deleted good receipt ({goodReceiptID}) successfully!");
            }
            else
            {
                MessageBox.Show($"Delete good receipt ({goodReceiptID}) failed!");
            }
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbBook = sender as ComboBox;
            bookId = (int)cbBook.SelectedValue;
        }

        private void FormGoodReceiptDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
