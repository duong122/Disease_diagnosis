namespace ChuanDoanBenh
{
    partial class frmBenhNhan2
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
            lsvDianosis = new ListView();
            groupBox1 = new GroupBox();
            lsvPatient = new ListView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            bntDelete = new Button();
            bntEdit = new Button();
            btnAdd = new Button();
            cmbGioiTinh = new ComboBox();
            dtNgaySinh = new DateTimePicker();
            txtContact = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lsvSymptoms = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lsvDianosis
            // 
            lsvDianosis.Location = new Point(46, 26);
            lsvDianosis.Name = "lsvDianosis";
            lsvDianosis.Size = new Size(330, 323);
            lsvDianosis.TabIndex = 0;
            lsvDianosis.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvPatient);
            groupBox1.Location = new Point(36, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // lsvPatient
            // 
            lsvPatient.Location = new Point(28, 40);
            lsvPatient.Name = "lsvPatient";
            lsvPatient.Size = new Size(507, 323);
            lsvPatient.TabIndex = 1;
            lsvPatient.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(bntDelete);
            groupBox2.Controls.Add(bntEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(cmbGioiTinh);
            groupBox2.Controls.Add(dtNgaySinh);
            groupBox2.Controls.Add(txtContact);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(36, 451);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 384);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(15, 323);
            button5.Name = "button5";
            button5.Size = new Size(186, 41);
            button5.TabIndex = 13;
            button5.Text = "Xem lích sử chẩn đoán";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(221, 323);
            button4.Name = "button4";
            button4.Size = new Size(164, 41);
            button4.TabIndex = 12;
            button4.Text = "Chuẩn đoán";
            button4.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            bntDelete.Location = new Point(291, 265);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(94, 41);
            bntDelete.TabIndex = 11;
            bntDelete.Text = "Xóa";
            bntDelete.UseVisualStyleBackColor = true;
            // 
            // bntEdit
            // 
            bntEdit.Location = new Point(151, 265);
            bntEdit.Name = "bntEdit";
            bntEdit.Size = new Size(94, 41);
            bntEdit.TabIndex = 10;
            bntEdit.Text = "Sửa";
            bntEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Location = new Point(151, 151);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(244, 28);
            cmbGioiTinh.TabIndex = 8;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(151, 102);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(244, 27);
            dtNgaySinh.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(151, 202);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(244, 27);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 99);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày tháng sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 202);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Liên hệ";
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bệnh nhân";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsvDianosis);
            groupBox3.Location = new Point(658, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 380);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách các lần chẩn đoán";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lsvSymptoms);
            groupBox4.Location = new Point(658, 455);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(430, 380);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách các triệu chứng của chuẩn đoán ";
            // 
            // lsvSymptoms
            // 
            lsvSymptoms.Location = new Point(46, 26);
            lsvSymptoms.Name = "lsvSymptoms";
            lsvSymptoms.Size = new Size(330, 323);
            lsvSymptoms.TabIndex = 0;
            lsvSymptoms.UseCompatibleStateImageBehavior = false;
            // 
            // frmBenhNhan2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 907);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBenhNhan2";
            Text = "frmBenhNhan2";
            Load += frmBenhNhan2_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvDianosis;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtName;
        private Label label1;
        private Button btnAdd;
        private ComboBox cmbGioiTinh;
        private DateTimePicker dtNgaySinh;
        private TextBox txtContact;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button bntDelete;
        private Button bntEdit;
        private ListView lsvPatient;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ListView lsvSymptoms;
    }
}