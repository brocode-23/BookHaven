namespace BookHaven
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button7 = new Button();
            btnsuppliermanagement = new Button();
            btnreportanalysis = new Button();
            btnordermanagement = new Button();
            btnsalestranscation = new Button();
            btncustomermanagement = new Button();
            btnbookmanagement = new Button();
            panel2 = new Panel();
            label3 = new Label();
            suppliergrid = new DataGridView();
            custgrid = new DataGridView();
            bookmanagementgrid = new DataGridView();
            ordergatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliergrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(915, 264);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 15);
            label2.Name = "label2";
            label2.Size = new Size(309, 46);
            label2.TabIndex = 1;
            label2.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(btnsuppliermanagement);
            panel1.Controls.Add(btnreportanalysis);
            panel1.Controls.Add(btnordermanagement);
            panel1.Controls.Add(btnsalestranscation);
            panel1.Controls.Add(btncustomermanagement);
            panel1.Controls.Add(btnbookmanagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 705);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 516);
            button1.Name = "button1";
            button1.Size = new Size(329, 52);
            button1.TabIndex = 19;
            button1.Text = "Clerk Management";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(66, 618);
            button7.Name = "button7";
            button7.Size = new Size(201, 50);
            button7.TabIndex = 18;
            button7.Text = "LOG OUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // btnsuppliermanagement
            // 
            btnsuppliermanagement.BackColor = SystemColors.ActiveCaption;
            btnsuppliermanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsuppliermanagement.Location = new Point(0, 381);
            btnsuppliermanagement.Name = "btnsuppliermanagement";
            btnsuppliermanagement.Size = new Size(329, 52);
            btnsuppliermanagement.TabIndex = 17;
            btnsuppliermanagement.Text = "Supplier Management ";
            btnsuppliermanagement.UseVisualStyleBackColor = false;
            btnsuppliermanagement.Click += btnsuppliermanagement_Click;
            // 
            // btnreportanalysis
            // 
            btnreportanalysis.BackColor = SystemColors.ActiveCaption;
            btnreportanalysis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreportanalysis.Location = new Point(3, 449);
            btnreportanalysis.Name = "btnreportanalysis";
            btnreportanalysis.Size = new Size(329, 52);
            btnreportanalysis.TabIndex = 16;
            btnreportanalysis.Text = "Reporting and Analytics ";
            btnreportanalysis.UseVisualStyleBackColor = false;
            btnreportanalysis.Click += btnreportanalysis_Click;
            // 
            // btnordermanagement
            // 
            btnordermanagement.BackColor = SystemColors.ActiveCaption;
            btnordermanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnordermanagement.Location = new Point(0, 313);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Size = new Size(329, 52);
            btnordermanagement.TabIndex = 15;
            btnordermanagement.Text = "Order Management ";
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnsalestranscation
            // 
            btnsalestranscation.BackColor = SystemColors.ActiveCaption;
            btnsalestranscation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalestranscation.Location = new Point(3, 242);
            btnsalestranscation.Name = "btnsalestranscation";
            btnsalestranscation.Size = new Size(329, 52);
            btnsalestranscation.TabIndex = 14;
            btnsalestranscation.Text = "Sales Transaction ";
            btnsalestranscation.UseVisualStyleBackColor = false;
            btnsalestranscation.Click += btnsalestranscation_Click;
            // 
            // btncustomermanagement
            // 
            btncustomermanagement.BackColor = SystemColors.ActiveCaption;
            btncustomermanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncustomermanagement.Location = new Point(0, 174);
            btncustomermanagement.Name = "btncustomermanagement";
            btncustomermanagement.Size = new Size(329, 52);
            btncustomermanagement.TabIndex = 13;
            btncustomermanagement.Text = "Customer Management ";
            btncustomermanagement.UseVisualStyleBackColor = false;
            btncustomermanagement.Click += btncustomermanagement_Click;
            // 
            // btnbookmanagement
            // 
            btnbookmanagement.BackColor = SystemColors.ActiveCaption;
            btnbookmanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbookmanagement.Location = new Point(0, 106);
            btnbookmanagement.Name = "btnbookmanagement";
            btnbookmanagement.Size = new Size(329, 52);
            btnbookmanagement.TabIndex = 12;
            btnbookmanagement.Text = "Book Management ";
            btnbookmanagement.UseVisualStyleBackColor = false;
            btnbookmanagement.Click += btnbookmanagement_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(329, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 61);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(158, 9);
            label3.Name = "label3";
            label3.Size = new Size(491, 46);
            label3.TabIndex = 19;
            label3.Text = "BOOK HEAVEN - BOOKSTORE";
            // 
            // suppliergrid
            // 
            suppliergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliergrid.Location = new Point(361, 106);
            suppliergrid.Name = "suppliergrid";
            suppliergrid.RowHeadersWidth = 51;
            suppliergrid.Size = new Size(460, 244);
            suppliergrid.TabIndex = 52;
            // 
            // custgrid
            // 
            custgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgrid.Location = new Point(848, 106);
            custgrid.Name = "custgrid";
            custgrid.RowHeadersWidth = 51;
            custgrid.Size = new Size(460, 244);
            custgrid.TabIndex = 53;
            // 
            // bookmanagementgrid
            // 
            bookmanagementgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookmanagementgrid.Location = new Point(361, 381);
            bookmanagementgrid.Name = "bookmanagementgrid";
            bookmanagementgrid.RowHeadersWidth = 51;
            bookmanagementgrid.Size = new Size(460, 287);
            bookmanagementgrid.TabIndex = 66;
            // 
            // ordergatagrid
            // 
            ordergatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordergatagrid.Location = new Point(848, 381);
            ordergatagrid.Name = "ordergatagrid";
            ordergatagrid.RowHeadersWidth = 51;
            ordergatagrid.Size = new Size(460, 287);
            ordergatagrid.TabIndex = 92;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 705);
            ControlBox = false;
            Controls.Add(ordergatagrid);
            Controls.Add(bookmanagementgrid);
            Controls.Add(custgrid);
            Controls.Add(suppliergrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)suppliergrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)custgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button btnordermanagement;
        private Button btnsalestranscation;
        private Button btncustomermanagement;
        private Button btnbookmanagement;
        private Button button7;
        private Button btnsuppliermanagement;
        private Button btnreportanalysis;
        private Label label3;
        private Button button1;
        private DataGridView suppliergrid;
        private DataGridView custgrid;
        private DataGridView bookmanagementgrid;
        private DataGridView ordergatagrid;
    }
}