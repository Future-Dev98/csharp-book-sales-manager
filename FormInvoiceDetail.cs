﻿using System;
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
    public partial class FormInvoiceDetail : Form
    {
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private DataProvider dataProvider = new DataProvider();
        private int invoiceDetailId;
        private int bookId;
        private string editbookName;
        private List<Book> listBook;
        public FormInvoiceDetail(int invoiceId)
        {
            InitializeComponent();
            this.invoiceDetailId = invoiceId;
            loadInvoiceDetails();
            loadBook();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbBook = sender as ComboBox;
            bookId = (int)cbBook.SelectedValue;
        }

        private void loadInvoiceDetails()
        {
            DataTable dt = new DataTable();
            string query = $@"SELECT book.name as [Book name], invoice_details.qty as [Quantity], book.price as [Price], invoice_details.qty * book.price as [Sum]
                             FROM invoice_details
                             INNER JOIN book ON book.id = invoice_details.book_id
                             INNER JOIN invoice ON invoice.id = invoice_details.invoice_id
                             WHERE invoice_details.invoice_id ={invoiceDetailId}";
            dt = dataProvider.execQuery(query);
            invoiceDetailList.DataSource = dt;

            string querySum = $@"SELECT SUM(invoice_details.qty * book.price) as Total
                                 FROM invoice_details
                                 INNER JOIN book ON book.id = invoice_details.book_id
                                 WHERE invoice_id={invoiceDetailId}";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (invoiceDetailList.Rows.Count > 1)
            {
                if (rowId == -1) rowId = 0;
                if (rowId == invoiceDetailList.Rows.Count - 1) rowId = rowId - 1;
                DataGridViewRow row = invoiceDetailList.Rows[rowId];
                cbBook.Text = editbookName = row.Cells[0].Value.ToString();
                nmQty.Value = (int)row.Cells[1].Value;
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            string checkQuery = $"SELECT COUNT(*) FROM invoice_details WHERE invoice_id = {invoiceDetailId} AND book_id = {bookId}";
            DataTable dt = dataProvider.execQuery(checkQuery);

            string query = $"INSERT INTO invoice_details(book_id, invoice_id, qty) VALUES({bookId}, {invoiceDetailId}, {nmQty.Value})";
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                query = $"UPDATE invoice_details SET qty={nmQty.Value} WHERE invoice_id={invoiceDetailId} AND book_id={bookId}";
            }

            int result = dataProvider.execNonQuery(query);

            if (result > 0)
            {
                loadInvoiceDetails();
                MessageBox.Show("Added invoice row successfully!");
            }
            else
            {
                MessageBox.Show("Add invoice row failed!");
            }
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE invoice_details SET book_id={bookId}, qty={nmQty.Value} WHERE invoice_id={invoiceDetailId} AND book_id={bookId}";
            if (editbookName != cbBook.Text)
            {
                try
                {
                    string checkQuery = $"SELECT COUNT(*) FROM invoice_details WHERE invoice_id = {invoiceDetailId} AND book_id = {bookId}";
                    DataTable dt = dataProvider.execQuery(checkQuery);
                    if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                    {
                        int oldBookId = listBook.FirstOrDefault(b => b.Name == editbookName)?.Id ?? 0;
                        string queryDelete = $"DELETE FROM invoice_details WHERE invoice_id={invoiceDetailId} AND book_id={oldBookId}";

                        dataProvider.execNonQuery(queryDelete);
                    }
                    else
                    {
                        query = $"INSERT INTO invoice_details(invoice_id, book_id, qty) VALUES({invoiceDetailId}, {bookId}, {nmQty.Value})";
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show($"An error occurred: {er.Message}");
                }
            }
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadInvoiceDetails();
                MessageBox.Show($"Updated invoice row ({invoiceDetailId}) successfully!");
            }
            else
            {
                MessageBox.Show($"Update invoice row ({invoiceDetailId}) failed!");
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM invoice_details WHERE invoice_id={invoiceDetailId} AND book_id={bookId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadInvoiceDetails();
                MessageBox.Show($"Deleted invoice row ({invoiceDetailId}) successfully!");
            }
            else
            {
                MessageBox.Show($"Delete invoice row ({invoiceDetailId}) failed!");
            }
        }
    }
}
