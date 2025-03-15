namespace BookHaven
{
    partial class reporting
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
            reportingGrid = new DataGridView();
            btnback = new Button();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportingGrid).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 61);
            panel2.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(235, 9);
            label7.Name = "label7";
            label7.Size = new Size(402, 46);
            label7.TabIndex = 57;
            label7.Text = "REPORT AND ANALYSIS";
            // 
            // reportingGrid
            // 
            reportingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportingGrid.Location = new Point(34, 144);
            reportingGrid.Name = "reportingGrid";
            reportingGrid.RowHeadersWidth = 51;
            reportingGrid.Size = new Size(757, 342);
            reportingGrid.TabIndex = 70;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.ActiveBorder;
            btnback.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(34, 510);
            btnback.Name = "btnback";
            btnback.Size = new Size(104, 42);
            btnback.TabIndex = 90;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(515, 94);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 92;
            label1.Text = "Search";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(640, 93);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 36);
            comboBoxFilter.TabIndex = 91;
            comboBoxFilter.SelectedIndexChanged += cmbsearch_SelectedIndexChanged;
            // 
            // reporting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 566);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(comboBoxFilter);
            Controls.Add(btnback);
            Controls.Add(reportingGrid);
            Controls.Add(panel2);
            Name = "reporting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reporting";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportingGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private DataGridView reportingGrid;
        private Button btnback;
        private Label label1;
        private ComboBox comboBoxFilter;
    }
}