namespace BookHaven
{
    partial class CustomerManagement
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtphonenum = new TextBox();
            txtemail = new TextBox();
            txtcustname = new TextBox();
            txtaddress = new TextBox();
            btnsave = new Button();
            btnclear = new Button();
            btnback = new Button();
            btnupdate = new Button();
            custgrid = new DataGridView();
            btndelete = new Button();
            panel2 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            lblcusid = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)custgrid).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(83, 31);
            label4.TabIndex = 4;
            label4.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 222);
            label5.Name = "label5";
            label5.Size = new Size(176, 31);
            label5.TabIndex = 5;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 277);
            label6.Name = "label6";
            label6.Size = new Size(99, 31);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // txtphonenum
            // 
            txtphonenum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphonenum.Location = new Point(252, 219);
            txtphonenum.Name = "txtphonenum";
            txtphonenum.Size = new Size(244, 38);
            txtphonenum.TabIndex = 8;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(252, 160);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(336, 38);
            txtemail.TabIndex = 9;
            // 
            // txtcustname
            // 
            txtcustname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcustname.Location = new Point(252, 104);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(336, 38);
            txtcustname.TabIndex = 10;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaddress.Location = new Point(252, 274);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(287, 166);
            txtaddress.TabIndex = 11;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Lime;
            btnsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(421, 565);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(215, 42);
            btnsave.TabIndex = 14;
            btnsave.Text = "ADD CUSTOMER";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Red;
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(270, 565);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(104, 42);
            btnclear.TabIndex = 15;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(34, 565);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 16;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.MenuHighlight;
            btnupdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1146, 565);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(112, 42);
            btnupdate.TabIndex = 17;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // custgrid
            // 
            custgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgrid.Location = new Point(671, 81);
            custgrid.Name = "custgrid";
            custgrid.RowHeadersWidth = 51;
            custgrid.Size = new Size(614, 467);
            custgrid.TabIndex = 19;
            custgrid.CellClick += custgrid_CellClick;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(998, 565);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(104, 42);
            btndelete.TabIndex = 20;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 61);
            panel2.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(373, 9);
            label7.Name = "label7";
            label7.Size = new Size(469, 46);
            label7.TabIndex = 56;
            label7.Text = "CUSTOMER MANAGEMENT ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblcusid);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtphonenum);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtcustname);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 472);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // lblcusid
            // 
            lblcusid.AutoSize = true;
            lblcusid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcusid.Location = new Point(252, 48);
            lblcusid.Name = "lblcusid";
            lblcusid.Size = new Size(0, 31);
            lblcusid.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1297, 628);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(btndelete);
            Controls.Add(custgrid);
            Controls.Add(btnupdate);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            HelpButton = true;
            Name = "CustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerManagement";
            ((System.ComponentModel.ISupportInitialize)custgrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtphonenum;
        private TextBox txtemail;
        private TextBox txtcustname;
        private TextBox txtaddress;
        private Button btnsave;
        private Button btnclear;
        private Button btnback;
        private Button btnupdate;
        private DataGridView custgrid;
        private Button btndelete;
        private Panel panel2;
        private Label label7;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblcusid;
    }
}