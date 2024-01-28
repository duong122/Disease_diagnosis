namespace ChuanDoanBenh
{
    partial class frmLichSuChuanDoan
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
            dgvDsTrieuChung = new DataGridView();
            panel1 = new Panel();
            txtDate = new TextBox();
            txtBenh = new TextBox();
            txtBenhNhan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            dgvDsChuanDoan = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDsTrieuChung).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChuanDoan).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(56, 456);
            label2.Name = "label2";
            label2.Size = new Size(220, 31);
            label2.TabIndex = 1;
            label2.Text = "Kết quả chuẩn đoán";
            // 
            // dgvDsTrieuChung
            // 
            dgvDsTrieuChung.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDsTrieuChung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsTrieuChung.Location = new Point(535, 50);
            dgvDsTrieuChung.Name = "dgvDsTrieuChung";
            dgvDsTrieuChung.RowHeadersWidth = 51;
            dgvDsTrieuChung.RowTemplate.Height = 29;
            dgvDsTrieuChung.Size = new Size(434, 331);
            dgvDsTrieuChung.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(txtBenh);
            panel1.Controls.Add(txtBenhNhan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvDsTrieuChung);
            panel1.Location = new Point(56, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 404);
            panel1.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(152, 289);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(295, 38);
            txtDate.TabIndex = 11;
            // 
            // txtBenh
            // 
            txtBenh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBenh.Location = new Point(166, 120);
            txtBenh.Name = "txtBenh";
            txtBenh.Size = new Size(301, 38);
            txtBenh.TabIndex = 10;
            // 
            // txtBenhNhan
            // 
            txtBenhNhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBenhNhan.Location = new Point(238, 45);
            txtBenhNhan.Name = "txtBenhNhan";
            txtBenhNhan.Size = new Size(229, 38);
            txtBenhNhan.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 231);
            label6.Name = "label6";
            label6.Size = new Size(193, 31);
            label6.TabIndex = 7;
            label6.Text = "Ngày khám bệnh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(535, 16);
            label5.Name = "label5";
            label5.Size = new Size(253, 31);
            label5.TabIndex = 6;
            label5.Text = "Do các triệu chứng sau:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 127);
            label4.Name = "label4";
            label4.Size = new Size(65, 31);
            label4.TabIndex = 5;
            label4.Text = "Bệnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 45);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 4;
            label3.Text = "Tên bệnh nhân:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDsChuanDoan);
            panel2.Location = new Point(56, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 321);
            panel2.TabIndex = 5;
            // 
            // dgvDsChuanDoan
            // 
            dgvDsChuanDoan.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDsChuanDoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChuanDoan.Dock = DockStyle.Fill;
            dgvDsChuanDoan.Location = new Point(0, 0);
            dgvDsChuanDoan.Name = "dgvDsChuanDoan";
            dgvDsChuanDoan.RowHeadersWidth = 51;
            dgvDsChuanDoan.RowTemplate.Height = 29;
            dgvDsChuanDoan.Size = new Size(1014, 321);
            dgvDsChuanDoan.TabIndex = 7;
            dgvDsChuanDoan.CellContentClick += dgvDsChuanDoan_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(52, 38);
            label1.Name = "label1";
            label1.Size = new Size(248, 31);
            label1.TabIndex = 6;
            label1.Text = "Danh sách chuẩn đoán";
            // 
            // frmLichSuChuanDoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1132, 906);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLichSuChuanDoan";
            Text = "frmBenhNhan";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDsTrieuChung).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDsChuanDoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dgvDsTrieuChung;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private DataGridView dgvDsChuanDoan;
        private Label label1;
        private TextBox txtBenh;
        private TextBox txtBenhNhan;
        private TextBox txtDate;
    }
}