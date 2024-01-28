namespace ChuanDoanBenh
{
    partial class frmTapLuat
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
            components = new System.ComponentModel.Container();
            groupBoxDSSK = new GroupBox();
            dgvTrieuChung = new DataGridView();
            groupBoxDSKL = new GroupBox();
            dgvBenh = new DataGridView();
            dgvTapLuat = new DataGridView();
            groupBoxSKTL = new GroupBox();
            txtSuKien = new TextBox();
            txtKetLuan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            contextMenuStripTapLuat = new ContextMenuStrip(components);
            xemChiTietToolStripMenuItem = new ToolStripMenuItem();
            xoaLuatToolStripMenuItem = new ToolStripMenuItem();
            btnTatCa = new Button();
            groupBoxDSSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrieuChung).BeginInit();
            groupBoxDSKL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTapLuat).BeginInit();
            groupBoxSKTL.SuspendLayout();
            contextMenuStripTapLuat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDSSK
            // 
            groupBoxDSSK.Controls.Add(dgvTrieuChung);
            groupBoxDSSK.Location = new Point(29, 68);
            groupBoxDSSK.Name = "groupBoxDSSK";
            groupBoxDSSK.Size = new Size(519, 350);
            groupBoxDSSK.TabIndex = 0;
            groupBoxDSSK.TabStop = false;
            groupBoxDSSK.Text = "Danh sách sự kiện";
            // 
            // dgvTrieuChung
            // 
            dgvTrieuChung.AllowUserToAddRows = false;
            dgvTrieuChung.AllowUserToDeleteRows = false;
            dgvTrieuChung.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTrieuChung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrieuChung.Dock = DockStyle.Fill;
            dgvTrieuChung.Location = new Point(3, 23);
            dgvTrieuChung.MultiSelect = false;
            dgvTrieuChung.Name = "dgvTrieuChung";
            dgvTrieuChung.ReadOnly = true;
            dgvTrieuChung.RowHeadersWidth = 51;
            dgvTrieuChung.RowTemplate.Height = 29;
            dgvTrieuChung.ScrollBars = ScrollBars.Vertical;
            dgvTrieuChung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrieuChung.Size = new Size(513, 324);
            dgvTrieuChung.TabIndex = 1;
            dgvTrieuChung.CellContentClick += dgvTrieuChung_CellContentClick;
            // 
            // groupBoxDSKL
            // 
            groupBoxDSKL.Controls.Add(dgvBenh);
            groupBoxDSKL.Controls.Add(dgvTapLuat);
            groupBoxDSKL.Location = new Point(29, 458);
            groupBoxDSKL.Name = "groupBoxDSKL";
            groupBoxDSKL.Size = new Size(1067, 350);
            groupBoxDSKL.TabIndex = 1;
            groupBoxDSKL.TabStop = false;
            groupBoxDSKL.Text = "Danh sách kết luận";
            // 
            // dgvBenh
            // 
            dgvBenh.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBenh.Dock = DockStyle.Right;
            dgvBenh.Location = new Point(547, 23);
            dgvBenh.MultiSelect = false;
            dgvBenh.Name = "dgvBenh";
            dgvBenh.ReadOnly = true;
            dgvBenh.RowHeadersWidth = 51;
            dgvBenh.RowTemplate.Height = 29;
            dgvBenh.ScrollBars = ScrollBars.Vertical;
            dgvBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenh.Size = new Size(517, 324);
            dgvBenh.TabIndex = 1;
            dgvBenh.CellContentClick += dgvBenh_CellContentClick;
            // 
            // dgvTapLuat
            // 
            dgvTapLuat.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTapLuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTapLuat.Dock = DockStyle.Left;
            dgvTapLuat.Location = new Point(3, 23);
            dgvTapLuat.MultiSelect = false;
            dgvTapLuat.Name = "dgvTapLuat";
            dgvTapLuat.ReadOnly = true;
            dgvTapLuat.RowHeadersWidth = 51;
            dgvTapLuat.RowTemplate.Height = 29;
            dgvTapLuat.ScrollBars = ScrollBars.Vertical;
            dgvTapLuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTapLuat.Size = new Size(516, 324);
            dgvTapLuat.TabIndex = 0;
            dgvTapLuat.CellMouseDown += dgvTapLuat_CellMouseDown;
            // 
            // groupBoxSKTL
            // 
            groupBoxSKTL.Controls.Add(txtSuKien);
            groupBoxSKTL.Controls.Add(txtKetLuan);
            groupBoxSKTL.Controls.Add(label2);
            groupBoxSKTL.Controls.Add(label1);
            groupBoxSKTL.Location = new Point(643, 41);
            groupBoxSKTL.Name = "groupBoxSKTL";
            groupBoxSKTL.Size = new Size(450, 186);
            groupBoxSKTL.TabIndex = 2;
            groupBoxSKTL.TabStop = false;
            groupBoxSKTL.Text = "Sự kiện trong luật";
            // 
            // txtSuKien
            // 
            txtSuKien.Location = new Point(106, 106);
            txtSuKien.Name = "txtSuKien";
            txtSuKien.Size = new Size(265, 27);
            txtSuKien.TabIndex = 3;
            // 
            // txtKetLuan
            // 
            txtKetLuan.Location = new Point(106, 57);
            txtKetLuan.Name = "txtKetLuan";
            txtKetLuan.Size = new Size(265, 27);
            txtKetLuan.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 109);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Sự kiện";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 60);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Kết luận";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyBo.Location = new Point(643, 281);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 48);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(980, 281);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 48);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(818, 281);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 48);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // contextMenuStripTapLuat
            // 
            contextMenuStripTapLuat.ImageScalingSize = new Size(20, 20);
            contextMenuStripTapLuat.Items.AddRange(new ToolStripItem[] { xemChiTietToolStripMenuItem, xoaLuatToolStripMenuItem });
            contextMenuStripTapLuat.Name = "contextMenuStripTapLuat";
            contextMenuStripTapLuat.Size = new Size(158, 52);
            // 
            // xemChiTietToolStripMenuItem
            // 
            xemChiTietToolStripMenuItem.Name = "xemChiTietToolStripMenuItem";
            xemChiTietToolStripMenuItem.Size = new Size(157, 24);
            xemChiTietToolStripMenuItem.Text = "Xem chi tiết";
            xemChiTietToolStripMenuItem.Click += xemChiTietToolStripMenuItem_Click;
            // 
            // xoaLuatToolStripMenuItem
            // 
            xoaLuatToolStripMenuItem.Name = "xoaLuatToolStripMenuItem";
            xoaLuatToolStripMenuItem.Size = new Size(157, 24);
            xoaLuatToolStripMenuItem.Text = "Xóa Luật";
            xoaLuatToolStripMenuItem.Click += xoaLuatToolStripMenuItem_Click;
            // 
            // btnTatCa
            // 
            btnTatCa.Location = new Point(454, 41);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(94, 29);
            btnTatCa.TabIndex = 8;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = true;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // frmTapLuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1114, 820);
            Controls.Add(btnTatCa);
            Controls.Add(btnHuyBo);
            Controls.Add(groupBoxSKTL);
            Controls.Add(btnXoa);
            Controls.Add(groupBoxDSKL);
            Controls.Add(btnThem);
            Controls.Add(groupBoxDSSK);
            Name = "frmTapLuat";
            Text = "frmTapLuat";
            Load += frmTapLuat_Load;
            groupBoxDSSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrieuChung).EndInit();
            groupBoxDSKL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBenh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTapLuat).EndInit();
            groupBoxSKTL.ResumeLayout(false);
            groupBoxSKTL.PerformLayout();
            contextMenuStripTapLuat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDSSK;
        private DataGridView dgvTrieuChung;
        private GroupBox groupBoxDSKL;
        private DataGridView dgvBenh;
        private DataGridView dgvTapLuat;
        private GroupBox groupBoxSKTL;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSuKien;
        private TextBox txtKetLuan;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStripTapLuat;
        private ToolStripMenuItem xemChiTietToolStripMenuItem;
        private ToolStripMenuItem xoaLuatToolStripMenuItem;
        private Button btnTatCa;
    }
}