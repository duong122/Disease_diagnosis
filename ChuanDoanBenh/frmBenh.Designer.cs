namespace ChuanDoanBenh
{
    partial class frmTrieuChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrieuChung));
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            dgv_Benh = new DataGridView();
            btn_LamMoi = new Button();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_IdB = new TextBox();
            txt_TenB = new TextBox();
            label3 = new Label();
            txt_MoTa = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Benh).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.ActiveCaption;
            btn_Them.BackgroundImage = (Image)resources.GetObject("btn_Them.BackgroundImage");
            btn_Them.BackgroundImageLayout = ImageLayout.None;
            btn_Them.Location = new Point(643, 26);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(73, 99);
            btn_Them.TabIndex = 3;
            btn_Them.Text = "Thêm";
            btn_Them.TextAlign = ContentAlignment.BottomCenter;
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = SystemColors.ActiveCaption;
            btn_Sua.BackgroundImage = (Image)resources.GetObject("btn_Sua.BackgroundImage");
            btn_Sua.BackgroundImageLayout = ImageLayout.None;
            btn_Sua.Location = new Point(767, 26);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(73, 98);
            btn_Sua.TabIndex = 4;
            btn_Sua.Text = "Sửa";
            btn_Sua.TextAlign = ContentAlignment.BottomCenter;
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = SystemColors.ActiveCaption;
            btn_Xoa.BackgroundImage = (Image)resources.GetObject("btn_Xoa.BackgroundImage");
            btn_Xoa.BackgroundImageLayout = ImageLayout.None;
            btn_Xoa.Location = new Point(885, 26);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(73, 98);
            btn_Xoa.TabIndex = 5;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.TextAlign = ContentAlignment.BottomCenter;
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dgv_Benh
            // 
            dgv_Benh.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Benh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Benh.Location = new Point(55, 260);
            dgv_Benh.Name = "dgv_Benh";
            dgv_Benh.RowHeadersWidth = 20;
            dgv_Benh.RowTemplate.Height = 29;
            dgv_Benh.Size = new Size(1012, 528);
            dgv_Benh.TabIndex = 6;
            dgv_Benh.CellClick += dgv_Benh_CellClick;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.ActiveCaption;
            btn_LamMoi.BackgroundImage = (Image)resources.GetObject("btn_LamMoi.BackgroundImage");
            btn_LamMoi.BackgroundImageLayout = ImageLayout.None;
            btn_LamMoi.Location = new Point(992, 27);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(75, 98);
            btn_LamMoi.TabIndex = 7;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.TextAlign = ContentAlignment.BottomCenter;
            btn_LamMoi.UseVisualStyleBackColor = false;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiem.Location = new Point(643, 173);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(303, 39);
            txt_TimKiem.TabIndex = 5;
            txt_TimKiem.Enter += txt_TimKiem_Enter;
            txt_TimKiem.Leave += txt_TimKiem_Leave;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.InactiveCaption;
            btn_TimKiem.BackgroundImageLayout = ImageLayout.Center;
            btn_TimKiem.Location = new Point(952, 173);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(115, 39);
            btn_TimKiem.TabIndex = 8;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 93);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên bệnh: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 34);
            label2.Name = "label2";
            label2.Size = new Size(46, 32);
            label2.TabIndex = 1;
            label2.Text = "Id: ";
            // 
            // txt_IdB
            // 
            txt_IdB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdB.Location = new Point(178, 27);
            txt_IdB.Name = "txt_IdB";
            txt_IdB.Size = new Size(303, 39);
            txt_IdB.TabIndex = 1;
            // 
            // txt_TenB
            // 
            txt_TenB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenB.Location = new Point(178, 86);
            txt_TenB.Name = "txt_TenB";
            txt_TenB.Size = new Size(303, 39);
            txt_TenB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 3;
            label3.Text = "Mô tả: ";
            // 
            // txt_MoTa
            // 
            txt_MoTa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MoTa.Location = new Point(178, 143);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(303, 39);
            txt_MoTa.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_MoTa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_TenB);
            panel1.Controls.Add(txt_IdB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 206);
            panel1.TabIndex = 0;
            // 
            // frmTrieuChung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1114, 820);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimKiem);
            Controls.Add(btn_LamMoi);
            Controls.Add(dgv_Benh);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(panel1);
            Name = "frmTrieuChung";
            Text = "frmBenh";
            Load += frmBenh_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Benh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dgv_Benh;
        private Button btn_LamMoi;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private Label label1;
        private Label label2;
        private TextBox txt_IdB;
        private TextBox txt_TenB;
        private Label label3;
        private TextBox txt_MoTa;
        private Panel panel1;
    }
}