using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChuanDoanBenh
{
    public partial class frmLogin : Form
    {
        private KetNoi kn = new KetNoi();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                string query = string.Format("SELECT * FROM Account WHERE username = '{0}' AND password = '{1}'", username, password);
                DataSet ds = new DataSet();
                ds = kn.LayDuLieu(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    frmTrangChu frm = new frmTrangChu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, kiểm tra lại!");
                }
            }
            else
            {
                MessageBox.Show("Tên người dùng và mật khẩu không được để trống.");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
