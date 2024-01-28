namespace ChuanDoanBenh
{
    partial class frmTrangChu
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
            pnlMain = new Panel();
            pnlImage = new Panel();
            pictureBox1 = new PictureBox();
            pnlMenu = new Panel();
            mnuMain = new MenuStrip();
            toolStripMenuItemChuanDoan = new ToolStripMenuItem();
            toolStripMenuItemCoSoTT = new ToolStripMenuItem();
            toolStripMenuItemBenhNhan = new ToolStripMenuItem();
            toolStripMenuItemGioiThieu = new ToolStripMenuItem();
            toolStripMenuItemDangXuat = new ToolStripMenuItem();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ButtonHighlight;
            pnlMain.Dock = DockStyle.Right;
            pnlMain.Location = new Point(228, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1150, 953);
            pnlMain.TabIndex = 0;
            // 
            // pnlImage
            // 
            pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImage.Controls.Add(pictureBox1);
            pnlImage.Dock = DockStyle.Top;
            pnlImage.Location = new Point(4, 0);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(224, 226);
            pnlImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(mnuMain);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(4, 226);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(226, 727);
            pnlMenu.TabIndex = 1;
            // 
            // mnuMain
            // 
            mnuMain.AutoSize = false;
            mnuMain.BackColor = SystemColors.ButtonHighlight;
            mnuMain.Dock = DockStyle.Left;
            mnuMain.ImageScalingSize = new Size(64, 64);
            mnuMain.Items.AddRange(new ToolStripItem[] { toolStripMenuItemChuanDoan, toolStripMenuItemCoSoTT, toolStripMenuItemBenhNhan, toolStripMenuItemGioiThieu, toolStripMenuItemDangXuat });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(2, 18, 0, 2);
            mnuMain.Size = new Size(224, 727);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            mnuMain.ItemClicked += mnuMain_ItemClicked;
            // 
            // toolStripMenuItemChuanDoan
            // 
            toolStripMenuItemChuanDoan.AutoSize = false;
            toolStripMenuItemChuanDoan.Image = Properties.Resources.diagnostic;
            toolStripMenuItemChuanDoan.Margin = new Padding(0, 0, 0, 8);
            toolStripMenuItemChuanDoan.Name = "toolStripMenuItemChuanDoan";
            toolStripMenuItemChuanDoan.Size = new Size(219, 64);
            toolStripMenuItemChuanDoan.Text = "Chuẩn Đoán";
            toolStripMenuItemChuanDoan.Click += toolStripMenuItemChuanDoan_Click_1;
            // 
            // toolStripMenuItemCoSoTT
            // 
            toolStripMenuItemCoSoTT.AutoSize = false;
            toolStripMenuItemCoSoTT.BackColor = SystemColors.ButtonHighlight;
            toolStripMenuItemCoSoTT.Image = Properties.Resources.add_database;
            toolStripMenuItemCoSoTT.Margin = new Padding(0, 0, 0, 8);
            toolStripMenuItemCoSoTT.Name = "toolStripMenuItemCoSoTT";
            toolStripMenuItemCoSoTT.Size = new Size(219, 64);
            toolStripMenuItemCoSoTT.Text = "Cơ Sở TT";
            toolStripMenuItemCoSoTT.Click += toolStripMenuItemCoSoTT_Click;
            // 
            // toolStripMenuItemBenhNhan
            // 
            toolStripMenuItemBenhNhan.AutoSize = false;
            toolStripMenuItemBenhNhan.Image = Properties.Resources.welfare;
            toolStripMenuItemBenhNhan.Margin = new Padding(0, 0, 0, 8);
            toolStripMenuItemBenhNhan.Name = "toolStripMenuItemBenhNhan";
            toolStripMenuItemBenhNhan.Size = new Size(219, 64);
            toolStripMenuItemBenhNhan.Text = "Bệnh Nhân";
            toolStripMenuItemBenhNhan.Click += toolStripMenuItemBenhNhan_Click_1;
            // 
            // toolStripMenuItemGioiThieu
            // 
            toolStripMenuItemGioiThieu.AutoSize = false;
            toolStripMenuItemGioiThieu.Image = Properties.Resources.light_bulb;
            toolStripMenuItemGioiThieu.Margin = new Padding(0, 0, 0, 8);
            toolStripMenuItemGioiThieu.Name = "toolStripMenuItemGioiThieu";
            toolStripMenuItemGioiThieu.Size = new Size(219, 64);
            toolStripMenuItemGioiThieu.Text = "Giới Thiệu";
            toolStripMenuItemGioiThieu.Click += toolStripMenuItemGioiThieu_Click;
            // 
            // toolStripMenuItemDangXuat
            // 
            toolStripMenuItemDangXuat.AutoSize = false;
            toolStripMenuItemDangXuat.BackColor = SystemColors.ButtonHighlight;
            toolStripMenuItemDangXuat.Image = Properties.Resources.shutdown;
            toolStripMenuItemDangXuat.Margin = new Padding(0, 0, 0, 8);
            toolStripMenuItemDangXuat.Name = "toolStripMenuItemDangXuat";
            toolStripMenuItemDangXuat.Size = new Size(219, 64);
            toolStripMenuItemDangXuat.Text = "Đăng Xuất";
            toolStripMenuItemDangXuat.Click += toolStripMenuItemDangXuat_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 953);
            Controls.Add(pnlMenu);
            Controls.Add(pnlImage);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuMain;
            MaximizeBox = false;
            Name = "frmTrangChu";
            Padding = new Padding(4, 0, 4, 0);
            Text = "Trang Chu";
            Load += frmTrangChu_Load;
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMenu.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlImage;
        private Panel pnlMenu;
        private MenuStrip mnuMain;
        private ToolStripMenuItem toolStripMenuItemCoSoTT;
        private PictureBox pictureBox1;
        private ToolStripMenuItem toolStripMenuItemChuanDoan;
        private ToolStripMenuItem toolStripMenuItemBenhNhan;
        private ToolStripMenuItem toolStripMenuItemGioiThieu;
        private ToolStripMenuItem toolStripMenuItemDangXuat;
    }
}