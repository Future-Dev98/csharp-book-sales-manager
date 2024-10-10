using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSalesSanager.Model;

namespace BookSalesSanager
{
    public partial class Form1 : Form
    {
        public DataProvider dataProvider = new DataProvider();
        private int selectedCategory;
        private int bookId;
        private int categoryId;
        private int invoiceId;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO book(name, author, qty, price, category_id)
                            VALUES('{txtBookName.Text}', '{txtAuthor.Text}', {nmQty.Value}, {txtBookPrice.Text}, {selectedCategory})";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadBookList();
                MessageBox.Show("Add book successfully!");
            }
            else
            {
                MessageBox.Show("Add book failed!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteCategory(object sender, EventArgs e)
        {
            string query = $"DELETE FROM category WHERE id={categoryId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadCategories();
                MessageBox.Show("Delete category successfully!");
            }
            else
            {
                MessageBox.Show("Delete category failed!");
            }
        }

        private void btnEditCategory(object sender, EventArgs e)
        {
            string query = $"UPDATE category SET name='{txtCategoryName.Text}' WHERE id={categoryId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadCategories();
                MessageBox.Show("Updated category successfully!");
            }
            else
            {
                MessageBox.Show("Updated category failed!");
            }
        }

        private void btnAddCategory(object sender, EventArgs e)
        {
            string query = $"INSERT INTO category (name) VALUES('{txtCategoryName.Text}')";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadCategories();
                MessageBox.Show("Category added successfully!");
            } else
            {
                MessageBox.Show("Category added failed!");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Booksalesmanager booksalesmanager = new Booksalesmanager();
            booksalesmanager.CreateTable();
        }

        private void init()
        {
            initBook();
            initCategory();
        }

        private void initBook()
        {
            loadBookList();
            loadBookCategories();
            initInvoice();
        }

        private void initCategory()
        {
            loadCategories();
        }

        private void initInvoice()
        {
            loadInvoice();
        }

        private void loadBookList()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT book.id AS [Book id],
                            book.name AS [Book name],
                            category.name AS [Category],
                            book.author AS [Author], 
                            book.qty AS [Quantity],
                            book.price AS [Price]
                             FROM book
                             INNER JOIN category ON book.category_id = category.id;";

            dt = dataProvider.execQuery(query);

            bookList.DataSource = dt;
        }

        private void loadBookCategories()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM category";

            dt = dataProvider.execQuery(query);

            cbBookCategory.DisplayMember = "name";
            cbBookCategory.ValueMember = "id";

            cbBookCategory.DataSource = dt;
        }

        private void loadCategories()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id as [Category ID], name as [Category name] FROM category";

            dt = dataProvider.execQuery(query);
            dataCategories.DataSource = dt;
        }

        private void loadInvoice()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id as [Invoice ID], invoice_date as [Invoice date], customer_name as [Customer name], customer_phone as [Customer phone] FROM invoice";

            dt = dataProvider.execQuery(query);
            invoiceList.DataSource = dt;
        }
        private void cbBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            selectedCategory = (int)comboBox.SelectedValue;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId == -1) rowId = 0;
            if (rowId == bookList.Rows.Count - 1) rowId = rowId - 1;
            DataGridViewRow row = bookList.Rows[rowId];
            bookId = (int)row.Cells[0].Value;
            txtBookName.Text = row.Cells[1].Value.ToString();
            cbBookCategory.Text = row.Cells[2].Value.ToString();
            txtAuthor.Text = row.Cells[3].Value.ToString();
            nmQty.Value = (int)row.Cells[4].Value;
            txtBookPrice.Text = row.Cells[5].Value.ToString();
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE book SET name='{txtBookName.Text}', author='{txtAuthor.Text}', category_id={selectedCategory}, qty={nmQty.Value}, price={txtBookPrice.Text} WHERE id={bookId}";

            int result = dataProvider.execNonQuery(query);

            if (result > 0)
            {
                loadBookList();
                MessageBox.Show("Update successful!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM book WHERE id={bookId}";

            int result = dataProvider.execNonQuery(query);
            if (result > -1)
            {
                loadBookList();
                MessageBox.Show("Delete successful!");
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }

        private void dataCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId == -1) rowId = 0;
            if (rowId == dataCategories.Rows.Count - 1) rowId = rowId - 1;
            DataGridViewRow row = dataCategories.Rows[rowId];
            categoryId = (int)row.Cells[0].Value;
            txtCategoryName.Text = row.Cells[1].Value.ToString();
        }

        private void invoiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId == -1) rowId = 0;
            if (rowId == invoiceList.Rows.Count - 1) rowId = rowId - 1;
            DataGridViewRow row = invoiceList.Rows[rowId];
            invoiceId = (int)row.Cells[0].Value;
            dInvoiceDate.Text = Convert.ToDateTime(row.Cells[1].Value).ToString("yyyy-MM-dd");
            txtInvoiceCustomerName.Text = row.Cells[2].Value.ToString();
            txtInvoiceCustomerPhone.Text = row.Cells[3].Value.ToString();
        }

        private void addInvoice_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO invoice(invoice_date, customer_name, customer_phone)
                            VALUES('{Convert.ToDateTime(dInvoiceDate.Text).ToString("yyyy-MM-dd")}', '{txtInvoiceCustomerName.Text}', '{txtInvoiceCustomerPhone.Text}')";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadInvoice();
                MessageBox.Show("Add invoice successfully!");
            }
            else
            {
                MessageBox.Show("Add book failed!");
            }
        }

        private void editInvoice_Click(object sender, EventArgs e)
        {
            string query = $@"UPDATE invoice SET invoice_date='{Convert.ToDateTime(dInvoiceDate.Text).ToString("yyyy-MM-dd")}', customer_name='{txtInvoiceCustomerName.Text}', customer_phone='{txtInvoiceCustomerPhone.Text}' WHERE id={invoiceId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadInvoice();
                MessageBox.Show("Update invoice successfully!");
            }
            else
            {
                MessageBox.Show("Update book failed!");
            }
        }

        private void deleteInvoice_Click(object sender, EventArgs e)
        {
            string query = $@"DELETE FROM invoice WHERE id={invoiceId}";
            int result = dataProvider.execNonQuery(query);
            if (result > 0)
            {
                loadInvoice();
                MessageBox.Show("Delete invoice successfully!");
            }
            else
            {
                MessageBox.Show("Delete book failed!");
            }
        }
    }
}