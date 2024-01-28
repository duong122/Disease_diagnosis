namespace ChuanDoanBenh
{
    partial class frmChuanDoanBenh
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
            groupBox1 = new GroupBox();
            btnMoveToLeft = new Button();
            lsvRight = new ListView();
            btnMoveToRight = new Button();
            lsvLeft = new ListView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            txtDoTinCay = new TextBox();
            groupBox8 = new GroupBox();
            label5 = new Label();
            txtBenhChuanDoan = new TextBox();
            groupBox7 = new GroupBox();
            label4 = new Label();
            groupBox6 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            grbButton = new GroupBox();
            btnThoat = new Button();
            btnLuuKetQua = new Button();
            btnTiepTuc = new Button();
            btnChuanDoan = new Button();
            label1 = new Label();
            txtBenhNhan = new TextBox();
            txtDiaChi = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            grbButton.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-2, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 423);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMoveToLeft);
            groupBox1.Controls.Add(lsvRight);
            groupBox1.Controls.Add(btnMoveToRight);
            groupBox1.Controls.Add(lsvLeft);
            groupBox1.Location = new Point(62, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(986, 365);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnMoveToLeft
            // 
            btnMoveToLeft.Location = new Point(462, 179);
            btnMoveToLeft.Margin = new Padding(3, 4, 3, 4);
            btnMoveToLeft.Name = "btnMoveToLeft";
            btnMoveToLeft.Size = new Size(66, 80);
            btnMoveToLeft.TabIndex = 2;
            btnMoveToLeft.Text = "<<";
            btnMoveToLeft.UseVisualStyleBackColor = true;
            btnMoveToLeft.Click += btnMoveToLeft_Click;
            // 
            // lsvRight
            // 
            lsvRight.Location = new Point(571, 27);
            lsvRight.Name = "lsvRight";
            lsvRight.Size = new Size(378, 305);
            lsvRight.TabIndex = 4;
            lsvRight.UseCompatibleStateImageBehavior = false;
            // 
            // btnMoveToRight
            // 
            btnMoveToRight.Location = new Point(462, 69);
            btnMoveToRight.Margin = new Padding(3, 4, 3, 4);
            btnMoveToRight.Name = "btnMoveToRight";
            btnMoveToRight.Size = new Size(66, 80);
            btnMoveToRight.TabIndex = 1;
            btnMoveToRight.Text = ">>";
            btnMoveToRight.UseVisualStyleBackColor = true;
            btnMoveToRight.Click += btnMoveToRight_Click;
            // 
            // lsvLeft
            // 
            lsvLeft.Location = new Point(27, 27);
            lsvLeft.Name = "lsvLeft";
            lsvLeft.Size = new Size(378, 305);
            lsvLeft.TabIndex = 3;
            lsvLeft.UseCompatibleStateImageBehavior = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(grbButton);
            panel2.Location = new Point(-2, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 499);
            panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDoTinCay);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(txtBenhChuanDoan);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(613, 107);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(435, 391);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // txtDoTinCay
            // 
            txtDoTinCay.BackColor = SystemColors.HighlightText;
            txtDoTinCay.Enabled = false;
            txtDoTinCay.Location = new Point(163, 227);
            txtDoTinCay.Name = "txtDoTinCay";
            txtDoTinCay.Size = new Size(167, 27);
            txtDoTinCay.TabIndex = 3;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label5);
            groupBox8.Location = new Point(43, 217);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(98, 40);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 13);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 0;
            label5.Text = "Độ tin cậy";
            // 
            // txtBenhChuanDoan
            // 
            txtBenhChuanDoan.BackColor = SystemColors.HighlightText;
            txtBenhChuanDoan.Enabled = false;
            txtBenhChuanDoan.Location = new Point(49, 163);
            txtBenhChuanDoan.Name = "txtBenhChuanDoan";
            txtBenhChuanDoan.Size = new Size(366, 27);
            txtBenhChuanDoan.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label4);
            groupBox7.Location = new Point(43, 100);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(373, 48);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 13);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 0;
            label4.Text = "Bệnh nhân bị mắc bệnh";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label2);
            groupBox6.Location = new Point(43, 36);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(373, 48);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Kết Luận";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBenhNhan);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(62, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 388);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // grbButton
            // 
            grbButton.Controls.Add(btnThoat);
            grbButton.Controls.Add(btnLuuKetQua);
            grbButton.Controls.Add(btnTiepTuc);
            grbButton.Controls.Add(btnChuanDoan);
            grbButton.Location = new Point(62, 0);
            grbButton.Name = "grbButton";
            grbButton.Size = new Size(986, 101);
            grbButton.TabIndex = 0;
            grbButton.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(835, 27);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 43);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuuKetQua
            // 
            btnLuuKetQua.Location = new Point(291, 27);
            btnLuuKetQua.Name = "btnLuuKetQua";
            btnLuuKetQua.Size = new Size(114, 43);
            btnLuuKetQua.TabIndex = 3;
            btnLuuKetQua.Text = "Lưu Kết Quả";
            btnLuuKetQua.UseVisualStyleBackColor = true;
            btnLuuKetQua.Click += btnLuuKetQua_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(143, 27);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(114, 43);
            btnTiepTuc.TabIndex = 1;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnChuanDoan
            // 
            btnChuanDoan.Location = new Point(6, 27);
            btnChuanDoan.Name = "btnChuanDoan";
            btnChuanDoan.Size = new Size(114, 43);
            btnChuanDoan.TabIndex = 0;
            btnChuanDoan.Text = "Chuẩn Đoán";
            btnChuanDoan.UseVisualStyleBackColor = true;
            btnChuanDoan.Click += btnChuanDoan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 85);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bệnh nhân";
            // 
            // txtBenhNhan
            // 
            txtBenhNhan.Location = new Point(36, 121);
            txtBenhNhan.Name = "txtBenhNhan";
            txtBenhNhan.Size = new Size(368, 27);
            txtBenhNhan.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(36, 227);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(368, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 190);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // frmChuanDoanBenh
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 907);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmChuanDoanBenh";
            Text = "frmChuanDoanBenh";
            Load += frmChuanDoanBenh_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grbButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMoveToLeft;
        private Button btnMoveToRight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView lsvRight;
        private ListView lsvLeft;
        private Panel panel2;
        private GroupBox grbButton;
        private Button btnChuanDoan;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnLuuKetQua;
        private Button btnTiepTuc;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private TextBox txtDoTinCay;
        private GroupBox groupBox8;
        private Label label5;
        private TextBox txtBenhChuanDoan;
        private GroupBox groupBox7;
        private Label label4;
        private GroupBox groupBox6;
        private Label label2;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtBenhNhan;
        private Label label1;
    }
}