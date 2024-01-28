namespace ChuanDoanBenh
{
    partial class frmLogin
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtUserName = new TextBox();
            panel4 = new Panel();
            txtPassword = new TextBox();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 450);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 222);
            label1.Name = "label1";
            label1.Size = new Size(218, 121);
            label1.TabIndex = 1;
            label1.Text = "Welcom to the XXX";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diagnostic;
            pictureBox1.Location = new Point(86, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(384, 86);
            label2.Name = "label2";
            label2.Size = new Size(329, 41);
            label2.TabIndex = 8;
            label2.Text = "Login to Your Account";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 3, 30, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(384, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 46);
            panel2.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ButtonHighlight;
            txtUserName.Dock = DockStyle.Right;
            txtUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(49, 0);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Tài khoản";
            txtUserName.Size = new Size(266, 47);
            txtUserName.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(384, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 46);
            panel4.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Right;
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(49, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.Size = new Size(266, 47);
            txtPassword.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(32, -54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 40);
            textBox3.TabIndex = 4;
            textBox3.WordWrap = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(570, 326);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 60);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.Highlight;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(384, 326);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(144, 60);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnThoat;
        private Button btnDangNhap;
    }
}