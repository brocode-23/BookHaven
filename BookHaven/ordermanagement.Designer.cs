namespace BookHaven
{
    partial class ordermanagement
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
            btnback = new Button();
            btnsave = new Button();
            ordergatagrid = new DataGridView();
            label2 = new Label();
            txtsearch = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 61);
            panel2.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(312, 9);
            label7.Name = "label7";
            label7.Size = new Size(390, 46);
            label7.TabIndex = 57;
            label7.Text = "ORDER MANAGEMENT";
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(118, 526);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 89;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Lime;
            btnsave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(737, 526);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(157, 42);
            btnsave.TabIndex = 90;
            btnsave.Text = "ADD ORDER";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // ordergatagrid
            // 
            ordergatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordergatagrid.Location = new Point(118, 152);
            ordergatagrid.Name = "ordergatagrid";
            ordergatagrid.RowHeadersWidth = 51;
            ordergatagrid.Size = new Size(776, 341);
            ordergatagrid.TabIndex = 91;
            ordergatagrid.CellClick += ordergatagrid_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(628, 100);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 92;
            label2.Text = "Search";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(739, 97);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(155, 38);
            txtsearch.TabIndex = 93;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // ordermanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 592);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txtsearch);
            Controls.Add(ordergatagrid);
            Controls.Add(btnsave);
            Controls.Add(btnback);
            Controls.Add(panel2);
            Name = "ordermanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ordermanagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordergatagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private Button btnback;
        private Button btnsave;
        private DataGridView ordergatagrid;
        private Label label2;
        private TextBox txtsearch;
    }
}