namespace BookHaven
{
    partial class clearkcreatemanagement
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
            panel2 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtuserid = new TextBox();
            label3 = new Label();
            txtclearkusername = new TextBox();
            label2 = new Label();
            txtpassword = new TextBox();
            clearkgrid = new DataGridView();
            btndelete = new Button();
            btnupdate = new Button();
            btnclear = new Button();
            btnsave = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clearkgrid).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(21, 535);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 90;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 61);
            panel2.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(436, 9);
            label7.Name = "label7";
            label7.Size = new Size(379, 46);
            label7.TabIndex = 57;
            label7.Text = "CLEAK MANAGEMENT";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtuserid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtclearkusername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 413);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clerk Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtuserid
            // 
            txtuserid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuserid.Location = new Point(211, 236);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(273, 38);
            txtuserid.TabIndex = 56;
            txtuserid.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 98);
            label3.Name = "label3";
            label3.Size = new Size(194, 31);
            label3.TabIndex = 55;
            label3.Text = "Cleark Username";
            // 
            // txtclearkusername
            // 
            txtclearkusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtclearkusername.Location = new Point(211, 95);
            txtclearkusername.Name = "txtclearkusername";
            txtclearkusername.Size = new Size(347, 38);
            txtclearkusername.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 167);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 38;
            label2.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(211, 167);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(273, 38);
            txtpassword.TabIndex = 44;
            // 
            // clearkgrid
            // 
            clearkgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clearkgrid.Location = new Point(636, 96);
            clearkgrid.Name = "clearkgrid";
            clearkgrid.RowHeadersWidth = 51;
            clearkgrid.Size = new Size(557, 413);
            clearkgrid.TabIndex = 93;
            clearkgrid.CellClick += clearkgrid_CellClick;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(930, 535);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(104, 42);
            btndelete.TabIndex = 97;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click_1;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.MenuHighlight;
            btnupdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1084, 535);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(109, 42);
            btnupdate.TabIndex = 96;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Red;
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(149, 535);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(104, 42);
            btnclear.TabIndex = 95;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Lime;
            btnsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(408, 535);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(202, 42);
            btnsave.TabIndex = 94;
            btnsave.Text = "ADD CLERK";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // clearkcreatemanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 589);
            ControlBox = false;
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Controls.Add(clearkgrid);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(btnback);
            Name = "clearkcreatemanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clearkcreatemanagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clearkgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnback;
        private Panel panel2;
        private Label label7;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtclearkusername;
        private DataGridView clearkgrid;
        private Button btndelete;
        private Button btnupdate;
        private Button btnclear;
        private Button btnsave;
        private TextBox txtuserid;
    }
}