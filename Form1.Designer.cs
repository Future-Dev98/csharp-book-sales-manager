namespace BookSalesSanager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGoodReceiptSupplierName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.invoiceList = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtInvoiceCustomerPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInvoiceCustomerName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.deleteInvoice = new System.Windows.Forms.Button();
            this.editInvoice = new System.Windows.Forms.Button();
            this.addInvoice = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataCategories = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmQty = new System.Windows.Forms.NumericUpDown();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceList)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1168, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Good Receipt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtGoodReceiptSupplierName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(3, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 103);
            this.panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // txtGoodReceiptSupplierName
            // 
            this.txtGoodReceiptSupplierName.Location = new System.Drawing.Point(623, 12);
            this.txtGoodReceiptSupplierName.Name = "txtGoodReceiptSupplierName";
            this.txtGoodReceiptSupplierName.Size = new System.Drawing.Size(298, 26);
            this.txtGoodReceiptSupplierName.TabIndex = 6;
            this.txtGoodReceiptSupplierName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Supplier name";
            this.label8.UseMnemonic = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1156, 467);
            this.dataGridView2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.invoiceList);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1168, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Invoice";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // invoiceList
            // 
            this.invoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceList.Location = new System.Drawing.Point(6, 3);
            this.invoiceList.Name = "invoiceList";
            this.invoiceList.Size = new System.Drawing.Size(1156, 423);
            this.invoiceList.TabIndex = 3;
            this.invoiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceList_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtInvoiceCustomerPhone);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.dInvoiceDate);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtInvoiceCustomerName);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.deleteInvoice);
            this.panel4.Controls.Add(this.editInvoice);
            this.panel4.Controls.Add(this.addInvoice);
            this.panel4.Location = new System.Drawing.Point(6, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1156, 147);
            this.panel4.TabIndex = 2;
            // 
            // txtInvoiceCustomerPhone
            // 
            this.txtInvoiceCustomerPhone.Location = new System.Drawing.Point(644, 56);
            this.txtInvoiceCustomerPhone.Name = "txtInvoiceCustomerPhone";
            this.txtInvoiceCustomerPhone.Size = new System.Drawing.Size(255, 26);
            this.txtInvoiceCustomerPhone.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Customer phone";
            // 
            // dInvoiceDate
            // 
            this.dInvoiceDate.Location = new System.Drawing.Point(143, 10);
            this.dInvoiceDate.Name = "dInvoiceDate";
            this.dInvoiceDate.Size = new System.Drawing.Size(332, 26);
            this.dInvoiceDate.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Date";
            // 
            // txtInvoiceCustomerName
            // 
            this.txtInvoiceCustomerName.Location = new System.Drawing.Point(143, 59);
            this.txtInvoiceCustomerName.Name = "txtInvoiceCustomerName";
            this.txtInvoiceCustomerName.Size = new System.Drawing.Size(298, 26);
            this.txtInvoiceCustomerName.TabIndex = 6;
            this.txtInvoiceCustomerName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Customer name";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // deleteInvoice
            // 
            this.deleteInvoice.Location = new System.Drawing.Point(504, 104);
            this.deleteInvoice.Name = "deleteInvoice";
            this.deleteInvoice.Size = new System.Drawing.Size(183, 33);
            this.deleteInvoice.TabIndex = 2;
            this.deleteInvoice.Text = "Delete";
            this.deleteInvoice.UseVisualStyleBackColor = true;
            this.deleteInvoice.Click += new System.EventHandler(this.deleteInvoice_Click);
            // 
            // editInvoice
            // 
            this.editInvoice.Location = new System.Drawing.Point(255, 104);
            this.editInvoice.Name = "editInvoice";
            this.editInvoice.Size = new System.Drawing.Size(197, 34);
            this.editInvoice.TabIndex = 1;
            this.editInvoice.Text = "Edit";
            this.editInvoice.UseVisualStyleBackColor = true;
            this.editInvoice.Click += new System.EventHandler(this.editInvoice_Click);
            // 
            // addInvoice
            // 
            this.addInvoice.Location = new System.Drawing.Point(15, 104);
            this.addInvoice.Name = "addInvoice";
            this.addInvoice.Size = new System.Drawing.Size(188, 33);
            this.addInvoice.TabIndex = 0;
            this.addInvoice.Text = "Add";
            this.addInvoice.UseVisualStyleBackColor = true;
            this.addInvoice.Click += new System.EventHandler(this.addInvoice_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataCategories);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Category";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCategoryName);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(3, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 136);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(146, 14);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(700, 26);
            this.txtCategoryName.TabIndex = 6;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Category name";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDeleteCategory);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(247, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnEditCategory);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnAddCategory);
            // 
            // dataCategories
            // 
            this.dataCategories.AllowUserToOrderColumns = true;
            this.dataCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategories.Location = new System.Drawing.Point(3, 3);
            this.dataCategories.Name = "dataCategories";
            this.dataCategories.Size = new System.Drawing.Size(1156, 434);
            this.dataCategories.TabIndex = 1;
            this.dataCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategories_CellClick);
            this.dataCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategories_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.bookList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBookPrice);
            this.panel1.Controls.Add(this.cbBookCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmQty);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBookDelete);
            this.panel1.Controls.Add(this.btnBookEdit);
            this.panel1.Controls.Add(this.btnBookAdd);
            this.panel1.Location = new System.Drawing.Point(6, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 208);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(331, 111);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(194, 26);
            this.txtBookPrice.TabIndex = 13;
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(125, 67);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(274, 28);
            this.cbBookCategory.TabIndex = 12;
            this.cbBookCategory.SelectedIndexChanged += new System.EventHandler(this.cbBookCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qty";
            // 
            // nmQty
            // 
            this.nmQty.Location = new System.Drawing.Point(125, 109);
            this.nmQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmQty.Name = "nmQty";
            this.nmQty.Size = new System.Drawing.Size(70, 26);
            this.nmQty.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(566, 69);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(259, 26);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(125, 16);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(700, 26);
            this.txtBookName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(505, 162);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(183, 33);
            this.btnBookDelete.TabIndex = 2;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Location = new System.Drawing.Point(256, 162);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(197, 34);
            this.btnBookEdit.TabIndex = 1;
            this.btnBookEdit.Text = "Edit";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.btnBookEdit_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(16, 162);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(188, 33);
            this.btnBookAdd.TabIndex = 0;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnAddBook);
            // 
            // bookList
            // 
            this.bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookList.Location = new System.Drawing.Point(8, 6);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(1156, 361);
            this.bookList.TabIndex = 0;
            this.bookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookList_CellClick);
            this.bookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSalesManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategories)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGoodReceiptSupplierName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView invoiceList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtInvoiceCustomerPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dInvoiceDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInvoiceCustomerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button deleteInvoice;
        private System.Windows.Forms.Button editInvoice;
        private System.Windows.Forms.Button addInvoice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataCategories;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DataGridView bookList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown nmQty;
        private System.Windows.Forms.TextBox txtBookPrice;
    }
}

