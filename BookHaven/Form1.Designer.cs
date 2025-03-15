namespace BookHaven
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            btnlogin = new Button();
            btnclear = new Button();
            btnexit = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(253, 19);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 0;
            label1.Text = "Book Heaven";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(64, 176);
            label2.Name = "label2";
            label2.Size = new Size(172, 41);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(64, 241);
            label3.Name = "label3";
            label3.Size = new Size(150, 41);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(313, 241);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(260, 38);
            txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(313, 176);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(260, 38);
            txtusername.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(458, 328);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(115, 47);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += loginbtn_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(313, 328);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 47);
            btnclear.TabIndex = 7;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button2_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(546, 476);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(115, 47);
            btnexit.TabIndex = 8;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += exitbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 495);
            label4.Name = "label4";
            label4.Size = new Size(214, 17);
            label4.TabIndex = 9;
            label4.Text = "Developed by Kavindu Mihiranga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            ClientSize = new Size(714, 544);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnlogin);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Button btnlogin;
        private Button btnclear;
        private Button btnexit;
        private Label label4;
    }
}
