namespace ChuanDoanBenh
{
    partial class frmSymptom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSymptom));
            panel1 = new Panel();
            txt_TC = new TextBox();
            txt_IdTC = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_ThemTC = new Button();
            btn_SuaTC = new Button();
            btn_XoaTC = new Button();
            dgv_TC = new DataGridView();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            btn_LamMoi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_TC);
            panel1.Controls.Add(txt_IdTC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 163);
            panel1.TabIndex = 0;
            // 
            // txt_TC
            // 
            txt_TC.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TC.Location = new Point(219, 93);
            txt_TC.Name = "txt_TC";
            txt_TC.Size = new Size(409, 39);
            txt_TC.TabIndex = 2;
            // 
            // txt_IdTC
            // 
            txt_IdTC.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IdTC.Location = new Point(219, 34);
            txt_IdTC.Name = "txt_IdTC";
            txt_IdTC.Size = new Size(409, 39);
            txt_IdTC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 96);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 2;
            label2.Text = "Triệu chứng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 1;
            label1.Text = "Id Triệu chứng: ";
            // 
            // btn_ThemTC
            // 
            btn_ThemTC.BackColor = SystemColors.ActiveCaption;
            btn_ThemTC.BackgroundImage = (Image)resources.GetObject("btn_ThemTC.BackgroundImage");
            btn_ThemTC.BackgroundImageLayout = ImageLayout.None;
            btn_ThemTC.Location = new Point(776, 26);
            btn_ThemTC.Name = "btn_ThemTC";
            btn_ThemTC.Size = new Size(73, 91);
            btn_ThemTC.TabIndex = 4;
            btn_ThemTC.Text = "Thêm";
            btn_ThemTC.TextAlign = ContentAlignment.BottomCenter;
            btn_ThemTC.UseVisualStyleBackColor = false;
            btn_ThemTC.Click += btn_ThemTC_Click;
            // 
            // btn_SuaTC
            // 
            btn_SuaTC.BackColor = SystemColors.ActiveCaption;
            btn_SuaTC.BackgroundImage = (Image)resources.GetObject("btn_SuaTC.BackgroundImage");
            btn_SuaTC.BackgroundImageLayout = ImageLayout.None;
            btn_SuaTC.Location = new Point(945, 27);
            btn_SuaTC.Name = "btn_SuaTC";
            btn_SuaTC.Size = new Size(73, 90);
            btn_SuaTC.TabIndex = 5;
            btn_SuaTC.Text = "Sửa";
            btn_SuaTC.TextAlign = ContentAlignment.BottomCenter;
            btn_SuaTC.UseVisualStyleBackColor = false;
            btn_SuaTC.Click += btn_SuaTC_Click;
            // 
            // btn_XoaTC
            // 
            btn_XoaTC.BackColor = SystemColors.ActiveCaption;
            btn_XoaTC.BackgroundImage = (Image)resources.GetObject("btn_XoaTC.BackgroundImage");
            btn_XoaTC.BackgroundImageLayout = ImageLayout.None;
            btn_XoaTC.Location = new Point(945, 143);
            btn_XoaTC.Name = "btn_XoaTC";
            btn_XoaTC.Size = new Size(73, 98);
            btn_XoaTC.TabIndex = 6;
            btn_XoaTC.Text = "Xóa";
            btn_XoaTC.TextAlign = ContentAlignment.BottomCenter;
            btn_XoaTC.UseVisualStyleBackColor = false;
            btn_XoaTC.Click += btn_XoaTC_Click;
            // 
            // dgv_TC
            // 
            dgv_TC.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_TC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TC.Location = new Point(55, 274);
            dgv_TC.Name = "dgv_TC";
            dgv_TC.RowHeadersWidth = 51;
            dgv_TC.RowTemplate.Height = 29;
            dgv_TC.Size = new Size(969, 516);
            dgv_TC.TabIndex = 7;
            dgv_TC.CellClick += dgv_TC_CellClick;
            dgv_TC.CellMouseDown += dgv_TC_CellMouseDown;
            dgv_TC.ColumnHeaderMouseClick += dgv_TC_ColumnHeaderMouseClick;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiem.Location = new Point(55, 208);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(531, 39);
            txt_TimKiem.TabIndex = 3;
            txt_TimKiem.Enter += txt_TimKiem_Enter;
            txt_TimKiem.Leave += txt_TimKiem_Leave;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.ActiveCaption;
            btn_TimKiem.BackgroundImageLayout = ImageLayout.None;
            btn_TimKiem.Location = new Point(592, 208);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(107, 39);
            btn_TimKiem.TabIndex = 8;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.ActiveCaption;
            btn_LamMoi.BackgroundImage = (Image)resources.GetObject("btn_LamMoi.BackgroundImage");
            btn_LamMoi.BackgroundImageLayout = ImageLayout.None;
            btn_LamMoi.Location = new Point(776, 143);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(75, 98);
            btn_LamMoi.TabIndex = 9;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.TextAlign = ContentAlignment.BottomCenter;
            btn_LamMoi.UseVisualStyleBackColor = false;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // frmSymptom
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1114, 820);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimKiem);
            Controls.Add(dgv_TC);
            Controls.Add(btn_XoaTC);
            Controls.Add(btn_SuaTC);
            Controls.Add(btn_ThemTC);
            Controls.Add(panel1);
            Name = "frmSymptom";
            Text = "frmSymptom";
            Load += frmSymptom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_IdTC;
        private TextBox txt_TC;
        private Button btn_ThemTC;
        private Button btn_SuaTC;
        private Button btn_XoaTC;
        private DataGridView dgv_TC;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private Button btn_LamMoi;
    }
}