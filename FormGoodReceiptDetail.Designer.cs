namespace BookSalesSanager
{
    partial class FormGoodReceiptDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sum = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmQty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodReceiptDetailList = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodReceiptDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sum);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.nmPrice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 101);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(580, 65);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(59, 20);
            this.Sum.TabIndex = 10;
            this.Sum.Text = "Sum: 0";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(398, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(202, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEditClick);
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(647, 17);
            this.nmPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(120, 20);
            this.nmPrice.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // nmQty
            // 
            this.nmQty.Location = new System.Drawing.Point(428, 18);
            this.nmQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmQty.Name = "nmQty";
            this.nmQty.Size = new System.Drawing.Size(120, 20);
            this.nmQty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 17);
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
            this.cbBook.Size = new System.Drawing.Size(200, 21);
            this.cbBook.TabIndex = 1;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
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
            // goodReceiptDetailList
            // 
            this.goodReceiptDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goodReceiptDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodReceiptDetailList.Location = new System.Drawing.Point(3, 46);
            this.goodReceiptDetailList.Name = "goodReceiptDetailList";
            this.goodReceiptDetailList.Size = new System.Drawing.Size(795, 273);
            this.goodReceiptDetailList.TabIndex = 4;
            this.goodReceiptDetailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodReceiptDetailList_CellContentClick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(299, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(177, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Good Receipt Detail";
            // 
            // FormGoodReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goodReceiptDetailList);
            this.Controls.Add(this.title);
            this.Name = "FormGoodReceiptDetail";
            this.Text = "FormGoodReceiptDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodReceiptDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView goodReceiptDetailList;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Sum;
    }
}