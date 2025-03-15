namespace BookHaven
{
    partial class SalesClerk
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
            panel1 = new Panel();
            label6 = new Label();
            button7 = new Button();
            btnordermanagement = new Button();
            btnsalestranscation = new Button();
            btncustomermanagement = new Button();
            btnbookmanagement = new Button();
            panel2 = new Panel();
            label3 = new Label();
            custgrid = new DataGridView();
            bookmanagementgrid = new DataGridView();
            ordergatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)custgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(btnordermanagement);
            panel1.Controls.Add(btnsalestranscation);
            panel1.Controls.Add(btncustomermanagement);
            panel1.Controls.Add(btnbookmanagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 710);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 23);
            label6.Name = "label6";
            label6.Size = new Size(282, 38);
            label6.TabIndex = 1;
            label6.Text = "SALES CLERK PANEL";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(66, 618);
            button7.Name = "button7";
            button7.Size = new Size(201, 50);
            button7.TabIndex = 18;
            button7.Text = "LOG OUT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnordermanagement
            // 
            btnordermanagement.BackColor = SystemColors.ActiveCaption;
            btnordermanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnordermanagement.Location = new Point(-3, 338);
            btnordermanagement.Name = "btnordermanagement";
            btnordermanagement.Size = new Size(335, 52);
            btnordermanagement.TabIndex = 15;
            btnordermanagement.Text = "Order Management ";
            btnordermanagement.UseVisualStyleBackColor = false;
            btnordermanagement.Click += btnordermanagement_Click;
            // 
            // btnsalestranscation
            // 
            btnsalestranscation.BackColor = SystemColors.ActiveCaption;
            btnsalestranscation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalestranscation.Location = new Point(0, 264);
            btnsalestranscation.Name = "btnsalestranscation";
            btnsalestranscation.Size = new Size(332, 52);
            btnsalestranscation.TabIndex = 14;
            btnsalestranscation.Text = "Sales Transaction ";
            btnsalestranscation.UseVisualStyleBackColor = false;
            btnsalestranscation.Click += btnsalestranscation_Click;
            // 
            // btncustomermanagement
            // 
            btncustomermanagement.BackColor = SystemColors.ActiveCaption;
            btncustomermanagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncustomermanagement.Location = new Point(-3, 183);
            btncustomermanagement.Name = "btncustomermanagement";
            btncustomermanagement.Size = new Size(335, 52);
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
            btnbookmanagement.Size = new Size(332, 52);
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
            panel2.Size = new Size(957, 61);
            panel2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(104, 7);
            label3.Name = "label3";
            label3.Size = new Size(491, 46);
            label3.TabIndex = 20;
            label3.Text = "BOOK HEAVEN - BOOKSTORE";
            // 
            // custgrid
            // 
            custgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgrid.Location = new Point(361, 120);
            custgrid.Name = "custgrid";
            custgrid.RowHeadersWidth = 51;
            custgrid.Size = new Size(429, 257);
            custgrid.TabIndex = 20;
            // 
            // bookmanagementgrid
            // 
            bookmanagementgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookmanagementgrid.Location = new Point(835, 120);
            bookmanagementgrid.Name = "bookmanagementgrid";
            bookmanagementgrid.RowHeadersWidth = 51;
            bookmanagementgrid.Size = new Size(407, 257);
            bookmanagementgrid.TabIndex = 66;
            // 
            // ordergatagrid
            // 
            ordergatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordergatagrid.Location = new Point(582, 411);
            ordergatagrid.Name = "ordergatagrid";
            ordergatagrid.RowHeadersWidth = 51;
            ordergatagrid.Size = new Size(460, 287);
            ordergatagrid.TabIndex = 93;
            // 
            // SalesClerk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 710);
            ControlBox = false;
            Controls.Add(ordergatagrid);
            Controls.Add(bookmanagementgrid);
            Controls.Add(custgrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SalesClerk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesClerk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)custgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookmanagementgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Button button7;
        private Button btnordermanagement;
        private Button btnsalestranscation;
        private Button btncustomermanagement;
        private Button btnbookmanagement;
        private Panel panel2;
        private Label label3;
        private DataGridView custgrid;
        private DataGridView bookmanagementgrid;
        private DataGridView ordergatagrid;
    }
}