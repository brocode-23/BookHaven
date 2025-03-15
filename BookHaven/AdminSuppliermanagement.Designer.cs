namespace BookHaven
{
    partial class AdminSuppliermanagement
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
            suppliergrid = new DataGridView();
            lblsupid = new Label();
            btnupdate = new Button();
            btnback = new Button();
            btnclear = new Button();
            btnsave = new Button();
            txtaddress = new TextBox();
            txtsuppliername = new TextBox();
            txtcontactperson = new TextBox();
            txtpnum = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtemail = new TextBox();
            label3 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)suppliergrid).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(1025, 581);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(104, 42);
            btndelete.TabIndex = 52;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // suppliergrid
            // 
            suppliergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliergrid.Location = new Point(639, 96);
            suppliergrid.Name = "suppliergrid";
            suppliergrid.RowHeadersWidth = 51;
            suppliergrid.Size = new Size(649, 453);
            suppliergrid.TabIndex = 51;
            suppliergrid.CellClick += suppliergrid_CellClick;
            // 
            // lblsupid
            // 
            lblsupid.AutoSize = true;
            lblsupid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsupid.Location = new Point(235, 40);
            lblsupid.Name = "lblsupid";
            lblsupid.Size = new Size(0, 31);
            lblsupid.TabIndex = 50;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.MenuHighlight;
            btnupdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1179, 581);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(109, 42);
            btnupdate.TabIndex = 49;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.DarkGray;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(25, 581);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 48;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Red;
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(258, 581);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(104, 42);
            btnclear.TabIndex = 47;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Lime;
            btnsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(390, 581);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(215, 42);
            btnsave.TabIndex = 46;
            btnsave.Text = "ADD SUPPLIER";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaddress.Location = new Point(235, 312);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(286, 129);
            txtaddress.TabIndex = 45;
            // 
            // txtsuppliername
            // 
            txtsuppliername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsuppliername.Location = new Point(235, 87);
            txtsuppliername.Name = "txtsuppliername";
            txtsuppliername.Size = new Size(347, 38);
            txtsuppliername.TabIndex = 44;
            // 
            // txtcontactperson
            // 
            txtcontactperson.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontactperson.Location = new Point(235, 143);
            txtcontactperson.Name = "txtcontactperson";
            txtcontactperson.Size = new Size(338, 38);
            txtcontactperson.TabIndex = 43;
            // 
            // txtpnum
            // 
            txtpnum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpnum.Location = new Point(235, 199);
            txtpnum.Name = "txtpnum";
            txtpnum.Size = new Size(244, 38);
            txtpnum.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 257);
            label6.Name = "label6";
            label6.Size = new Size(73, 31);
            label6.TabIndex = 41;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 202);
            label5.Name = "label5";
            label5.Size = new Size(176, 31);
            label5.TabIndex = 40;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 150);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 39;
            label4.Text = "Contact Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 94);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 38;
            label2.Text = "Supplier Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 37;
            label1.Text = "Supplier ID";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(235, 254);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(338, 38);
            txtemail.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 312);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 54;
            label3.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(407, 9);
            label7.Name = "label7";
            label7.Size = new Size(440, 46);
            label7.TabIndex = 55;
            label7.Text = "SUPPLIER MANAGEMENT ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1316, 61);
            panel2.TabIndex = 58;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblsupid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtpnum);
            groupBox1.Controls.Add(txtcontactperson);
            groupBox1.Controls.Add(txtsuppliername);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 453);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier Details";
            // 
            // AdminSuppliermanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 668);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(btndelete);
            Controls.Add(suppliergrid);
            Controls.Add(btnupdate);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Name = "AdminSuppliermanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSuppliermanagement";
            ((System.ComponentModel.ISupportInitialize)suppliergrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btndelete;
        private DataGridView suppliergrid;
        private Label lblsupid;
        private Button btnupdate;
        private Button btnback;
        private Button btnclear;
        private Button btnsave;
        private TextBox txtaddress;
        private TextBox txtsuppliername;
        private TextBox txtcontactperson;
        private TextBox txtpnum;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtemail;
        private Label label3;
        private Label label7;
        private Panel panel2;
        private GroupBox groupBox1;
    }
}