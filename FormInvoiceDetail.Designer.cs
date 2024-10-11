namespace BookSalesSanager
{
    partial class FormInvoiceDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceDetailList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.nmQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoce Detail";
            // 
            // invoiceDetailList
            // 
            this.invoiceDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailList.Location = new System.Drawing.Point(1, 55);
            this.invoiceDetailList.Name = "invoiceDetailList";
            this.invoiceDetailList.Size = new System.Drawing.Size(795, 273);
            this.invoiceDetailList.TabIndex = 1;
            this.invoiceDetailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sum);
            this.panel1.Controls.Add(this.btnDeleteInvoice);
            this.panel1.Controls.Add(this.btnEditInvoice);
            this.panel1.Controls.Add(this.btnAddInvoice);
            this.panel1.Controls.Add(this.nmQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 101);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(398, 65);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(120, 26);
            this.btnDeleteInvoice.TabIndex = 9;
            this.btnDeleteInvoice.Text = "Delete";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInvoice.Location = new System.Drawing.Point(202, 65);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(122, 26);
            this.btnEditInvoice.TabIndex = 8;
            this.btnEditInvoice.Text = "Edit";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.Location = new System.Drawing.Point(15, 65);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(111, 26);
            this.btnAddInvoice.TabIndex = 6;
            this.btnAddInvoice.Text = "Add";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // nmQty
            // 
            this.nmQty.Location = new System.Drawing.Point(485, 18);
            this.nmQty.Name = "nmQty";
            this.nmQty.Size = new System.Drawing.Size(278, 20);
            this.nmQty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(108, 17);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(248, 21);
            this.cbBook.TabIndex = 1;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book name";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(558, 65);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(59, 20);
            this.Sum.TabIndex = 10;
            this.Sum.Text = "Sum: 0";
            // 
            // FormInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.invoiceDetailList);
            this.Controls.Add(this.label1);
            this.Name = "FormInvoiceDetail";
            this.Text = "FormInvoiceDetail";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView invoiceDetailList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Label Sum;
    }
}