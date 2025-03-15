namespace BookHaven
{
    partial class OrderRequest
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
            btnback = new Button();
            btnplaceorder = new Button();
            txtsubtotal = new TextBox();
            txtdiscount = new TextBox();
            txttotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgvCart = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qtyleft = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblqty = new Label();
            lblunitprice = new Label();
            lblAuthor = new Label();
            btnadd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtqty = new TextBox();
            cmbcus = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cmbbook = new ComboBox();
            panel2 = new Panel();
            label7 = new Label();
            label11 = new Label();
            cmbDelivery = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(34, 615);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 97;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnplaceorder
            // 
            btnplaceorder.BackColor = Color.Lime;
            btnplaceorder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplaceorder.Location = new Point(875, 615);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(251, 42);
            btnplaceorder.TabIndex = 90;
            btnplaceorder.Text = "PLACE ORDER";
            btnplaceorder.UseVisualStyleBackColor = false;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // txtsubtotal
            // 
            txtsubtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsubtotal.Location = new Point(847, 556);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(155, 38);
            txtsubtotal.TabIndex = 96;
            // 
            // txtdiscount
            // 
            txtdiscount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdiscount.Location = new Point(499, 556);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(165, 38);
            txtdiscount.TabIndex = 95;
            txtdiscount.TextChanged += txtdiscount_TextChanged;
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttotal.Location = new Point(121, 556);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(201, 38);
            txttotal.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(694, 567);
            label10.Name = "label10";
            label10.Size = new Size(132, 31);
            label10.TabIndex = 94;
            label10.Text = "SUB TOTAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(363, 567);
            label9.Name = "label9";
            label9.Size = new Size(130, 31);
            label9.TabIndex = 93;
            label9.Text = "DISCOUNT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 563);
            label8.Name = "label8";
            label8.Size = new Size(81, 31);
            label8.TabIndex = 92;
            label8.Text = "TOTAL";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { ID, Customer, Book, Qty, Author, Price, Qtyleft, TotalPrice });
            dgvCart.Location = new Point(34, 323);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1092, 214);
            dgvCart.TabIndex = 89;
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
            groupBox1.Location = new Point(28, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 202);
            groupBox1.TabIndex = 88;
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
            lblAuthor.Location = new Point(502, 44);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 31);
            lblAuthor.TabIndex = 78;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Lime;
            btnadd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(918, 145);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 70;
            label1.Text = "Customer";
            // 
            // txtqty
            // 
            txtqty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtqty.Location = new Point(135, 151);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(97, 38);
            txtqty.TabIndex = 73;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 151);
            label3.Name = "label3";
            label3.Size = new Size(52, 31);
            label3.TabIndex = 72;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 71;
            label2.Text = "Book";
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 61);
            panel2.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(402, 9);
            label7.Name = "label7";
            label7.Size = new Size(366, 46);
            label7.TabIndex = 57;
            label7.Text = "SALES TRANSACTION";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(348, 621);
            label11.Name = "label11";
            label11.Size = new Size(156, 31);
            label11.TabIndex = 82;
            label11.Text = "Delivery type";
            // 
            // cmbDelivery
            // 
            cmbDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDelivery.FormattingEnabled = true;
            cmbDelivery.Items.AddRange(new object[] { "Delivery", "Pickup", "Complete" });
            cmbDelivery.Location = new Point(521, 620);
            cmbDelivery.Name = "cmbDelivery";
            cmbDelivery.Size = new Size(151, 36);
            cmbDelivery.TabIndex = 81;
            // 
            // OrderRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 673);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(btnback);
            Controls.Add(cmbDelivery);
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
            Name = "OrderRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderRequest";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Button btnplaceorder;
        private TextBox txtsubtotal;
        private TextBox txtdiscount;
        private TextBox txttotal;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qtyleft;
        private DataGridViewTextBoxColumn TotalPrice;
        private GroupBox groupBox1;
        private Label lblqty;
        private Label lblunitprice;
        private Label lblAuthor;
        private Button btnadd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtqty;
        private ComboBox cmbcus;
        private Label label3;
        private Label label2;
        private ComboBox cmbbook;
        private Panel panel2;
        private Label label7;
        private Label label11;
        private ComboBox cmbDelivery;
    }
}