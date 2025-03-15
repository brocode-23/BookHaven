namespace BookHaven
{
    partial class adminbookmanagement
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
            btndelete = new Button();
            btnupdate = new Button();
            btnback = new Button();
            btnclear = new Button();
            btnsave = new Button();
            label7 = new Label();
            bookmanagementgrid = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cmbsupid = new ComboBox();
            label9 = new Label();
            txtstockquantity = new TextBox();
            label8 = new Label();
            txtprice = new TextBox();
            label3 = new Label();
            txtisbn = new TextBox();
            lblbookid = new Label();
            txttitle = new TextBox();
            txtauthor = new TextBox();
            txtgenre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(1009, 606);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(104, 42);
            btndelete.TabIndex = 41;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.HotTrack;
            btnupdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1195, 606);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(111, 42);
            btnupdate.TabIndex = 40;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(12, 606);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 39;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Red;
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(282, 606);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(104, 42);
            btnclear.TabIndex = 38;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Lime;
            btnsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(430, 606);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(157, 42);
            btnsave.TabIndex = 37;
            btnsave.Text = "ADD BOOK";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(460, 9);
            label7.Name = "label7";
            label7.Size = new Size(382, 46);
            label7.TabIndex = 57;
            label7.Text = "BOOK MANAGEMENT ";
            // 
            // bookmanagementgrid
            // 
            bookmanagementgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookmanagementgrid.Location = new Point(629, 84);
            bookmanagementgrid.Name = "bookmanagementgrid";
            bookmanagementgrid.RowHeadersWidth = 51;
            bookmanagementgrid.Size = new Size(697, 504);
            bookmanagementgrid.TabIndex = 65;
            bookmanagementgrid.CellClick += bookmanagementgrid_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 61);
            panel2.TabIndex = 66;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(cmbsupid);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtstockquantity);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtprice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtisbn);
            groupBox1.Controls.Add(lblbookid);
            groupBox1.Controls.Add(txttitle);
            groupBox1.Controls.Add(txtauthor);
            groupBox1.Controls.Add(txtgenre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 504);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Details";
            // 
            // cmbsupid
            // 
            cmbsupid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbsupid.FormattingEnabled = true;
            cmbsupid.Location = new Point(206, 451);
            cmbsupid.Name = "cmbsupid";
            cmbsupid.Size = new Size(200, 36);
            cmbsupid.TabIndex = 80;
            cmbsupid.SelectedIndexChanged += cmbsupid_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 452);
            label9.Name = "label9";
            label9.Size = new Size(134, 31);
            label9.TabIndex = 79;
            label9.Text = "Supplier ID";
            // 
            // txtstockquantity
            // 
            txtstockquantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstockquantity.Location = new Point(206, 376);
            txtstockquantity.Name = "txtstockquantity";
            txtstockquantity.Size = new Size(124, 38);
            txtstockquantity.TabIndex = 78;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 379);
            label8.Name = "label8";
            label8.Size = new Size(173, 31);
            label8.TabIndex = 77;
            label8.Text = "Stock Quantity";
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(206, 306);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(200, 38);
            txtprice.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 309);
            label3.Name = "label3";
            label3.Size = new Size(67, 31);
            label3.TabIndex = 75;
            label3.Text = "Price";
            // 
            // txtisbn
            // 
            txtisbn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtisbn.Location = new Point(206, 242);
            txtisbn.Name = "txtisbn";
            txtisbn.Size = new Size(244, 38);
            txtisbn.TabIndex = 74;
            // 
            // lblbookid
            // 
            lblbookid.AutoSize = true;
            lblbookid.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblbookid.Location = new Point(287, 34);
            lblbookid.Name = "lblbookid";
            lblbookid.Size = new Size(0, 23);
            lblbookid.TabIndex = 73;
            // 
            // txttitle
            // 
            txttitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitle.Location = new Point(206, 76);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(348, 38);
            txttitle.TabIndex = 72;
            // 
            // txtauthor
            // 
            txtauthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtauthor.Location = new Point(206, 135);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(348, 38);
            txtauthor.TabIndex = 71;
            // 
            // txtgenre
            // 
            txtgenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtgenre.Location = new Point(206, 188);
            txtgenre.Name = "txtgenre";
            txtgenre.Size = new Size(244, 38);
            txtgenre.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 245);
            label6.Name = "label6";
            label6.Size = new Size(67, 31);
            label6.TabIndex = 69;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 191);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 68;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 138);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 67;
            label4.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 66;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 65;
            label1.Text = "Book ID";
            // 
            // adminbookmanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 660);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(bookmanagementgrid);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Name = "adminbookmanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminbookmanagement";
            Load += adminbookmanagement_Load;
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btndelete;
        private Button btnupdate;
        private Button btnback;
        private Button btnclear;
        private Button btnsave;
        private Label label7;
        private DataGridView bookmanagementgrid;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox cmbsupid;
        private Label label9;
        private TextBox txtstockquantity;
        private Label label8;
        private TextBox txtprice;
        private Label label3;
        private TextBox txtisbn;
        private Label lblbookid;
        private TextBox txttitle;
        private TextBox txtauthor;
        private TextBox txtgenre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}