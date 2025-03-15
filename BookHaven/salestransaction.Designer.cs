namespace BookHaven
{
    partial class salestransaction
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
            panel2 = new Panel();
            label7 = new Label();
            cmbcus = new ComboBox();
            cmbbook = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtqty = new TextBox();
            groupBox1 = new GroupBox();
            lblqty = new Label();
            lblunitprice = new Label();
            lblAuthor = new Label();
            btnadd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvCart = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qtyleft = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txttotal = new TextBox();
            txtdiscount = new TextBox();
            txtsubtotal = new TextBox();
            btnplaceorder = new Button();
            btnback = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 61);
            panel2.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(363, 9);
            label7.Name = "label7";
            label7.Size = new Size(366, 46);
            label7.TabIndex = 57;
            label7.Text = "SALES TRANSACTION";
            // 
            // cmbcus
            // 
            cmbcus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbcus.FormattingEnabled = true;
            cmbcus.Location = new Point(135, 29);
            cmbcus.Name = "cmbcus";
            cmbcus.Size = new Size(151, 36);
            cmbcus.TabIndex = 68;
            cmbcus.SelectedIndexChanged += cmbcus_SelectedIndexChanged;
            // 
            // cmbbook
            // 
            cmbbook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbbook.FormattingEnabled = true;
            cmbbook.Location = new Point(135, 89);
            cmbbook.Name = "cmbbook";
            cmbbook.Size = new Size(151, 36);
            cmbbook.TabIndex = 69;
            cmbbook.SelectedIndexChanged += cmbbook_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 31);
            label1.TabIndex = 70;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 71;
            label2.Text = "Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 151);
            label3.Name = "label3";
            label3.Size = new Size(50, 31);
            label3.TabIndex = 72;
            label3.Text = "Qty";
            // 
            // txtqty
            // 
            txtqty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtqty.Location = new Point(135, 151);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(97, 38);
            txtqty.TabIndex = 73;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lblqty);
            groupBox1.Controls.Add(lblunitprice);
            groupBox1.Controls.Add(lblAuthor);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtqty);
            groupBox1.Controls.Add(cmbcus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbbook);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 202);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // lblqty
            // 
            lblqty.AutoSize = true;
            lblqty.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblqty.Location = new Point(847, 34);
            lblqty.Name = "lblqty";
            lblqty.Size = new Size(0, 31);
            lblqty.TabIndex = 80;
            // 
            // lblunitprice
            // 
            lblunitprice.AutoSize = true;
            lblunitprice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblunitprice.Location = new Point(502, 104);
            lblunitprice.Name = "lblunitprice";
            lblunitprice.Size = new Size(0, 31);
            lblunitprice.TabIndex = 79;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(502, 30);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 31);
            lblAuthor.TabIndex = 78;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Lime;
            btnadd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(900, 140);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(140, 42);
            btnadd.TabIndex = 77;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(698, 34);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 76;
            label6.Text = "QTY LEFT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 104);
            label5.Name = "label5";
            label5.Size = new Size(120, 31);
            label5.TabIndex = 75;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 34);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 74;
            label4.Text = "Author";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { ID, Customer, Book, Qty, Author, Price, Qtyleft, TotalPrice });
            dgvCart.Location = new Point(34, 308);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1092, 214);
            dgvCart.TabIndex = 75;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 125;
            // 
            // Book
            // 
            Book.HeaderText = "Book";
            Book.MinimumWidth = 6;
            Book.Name = "Book";
            Book.Width = 125;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Qtyleft
            // 
            Qtyleft.HeaderText = "Qtyleft";
            Qtyleft.MinimumWidth = 6;
            Qtyleft.Name = "Qtyleft";
            Qtyleft.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 548);
            label8.Name = "label8";
            label8.Size = new Size(81, 31);
            label8.TabIndex = 81;
            label8.Text = "TOTAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(363, 552);
            label9.Name = "label9";
            label9.Size = new Size(130, 31);
            label9.TabIndex = 82;
            label9.Text = "DISCOUNT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(694, 552);
            label10.Name = "label10";
            label10.Size = new Size(132, 31);
            label10.TabIndex = 83;
            label10.Text = "SUB TOTAL";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttotal.Location = new Point(138, 545);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(201, 38);
            txttotal.TabIndex = 81;
            // 
            // txtdiscount
            // 
            txtdiscount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdiscount.Location = new Point(499, 541);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(165, 38);
            txtdiscount.TabIndex = 84;
            txtdiscount.TextChanged += txtdiscount_TextChanged;
            // 
            // txtsubtotal
            // 
            txtsubtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsubtotal.Location = new Point(847, 541);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(155, 38);
            txtsubtotal.TabIndex = 85;
            // 
            // btnplaceorder
            // 
            btnplaceorder.BackColor = Color.Lime;
            btnplaceorder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplaceorder.Location = new Point(875, 600);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(251, 42);
            btnplaceorder.TabIndex = 81;
            btnplaceorder.Text = "PLACE ORDER";
            btnplaceorder.UseVisualStyleBackColor = false;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(42, 600);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 86;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click_1;
            // 
            // salestransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 654);
            ControlBox = false;
            Controls.Add(btnback);
            Controls.Add(btnplaceorder);
            Controls.Add(txtsubtotal);
            Controls.Add(txtdiscount);
            Controls.Add(txttotal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvCart);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "salestransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "salestransaction";
            Load += salestransaction_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private ComboBox cmbcus;
        private ComboBox cmbbook;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtqty;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblqty;
        private Label lblunitprice;
        private Label lblAuthor;
        private Button btnadd;
        private DataGridView dgvCart;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txttotal;
        private TextBox txtdiscount;
        private TextBox txtsubtotal;
        private Button btnplaceorder;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qtyleft;
        private DataGridViewTextBoxColumn TotalPrice;
        private Button btnback;
    }
}