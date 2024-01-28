using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChuanDoanBenh
{
    public partial class frmTrieuChung : Form
    {
        KetNoi kn = new KetNoi();
        Base Base = new Base();
        public frmTrieuChung()
        {
            InitializeComponent();
            txt_IdB.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

            txt_TimKiem.ForeColor = Color.LightGray;
            txt_TimKiem.Text = "Nhập tên bệnh";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
        }
        private void getData()
        {
            string query = "select * from Disease";
            DataSet ds = kn.LayDuLieu(query);
            dgv_Benh.DataSource = ds.Tables[0];
            Base.DefineDataGridViewColumns(dgv_Benh, new[] { "Disease Id", "Name", "Description" }, new[] { "disease_id", "name", "description" }, new[] { 120, 200, 1012 });
        }
        private void frmBenh_Load(object sender, EventArgs e)
        {
            getData();
        }
        private bool IsDuplicateProductName(string nameB)
        {
            foreach (DataGridViewRow row in dgv_Benh.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(nameB, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenBenh = txt_TenB.Text;
            string moTa = txt_MoTa.Text;

            if (!string.IsNullOrEmpty(tenBenh))
            {
                if (!IsDuplicateProductName(tenBenh))
                {
                    string query = string.Format("insert into Disease values(N'{0}', N'{1}')", tenBenh, moTa);
                    bool ktr = kn.ThucThi(query);

                    if (ktr)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        btn_LamMoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên bệnh đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên bệnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string Id = txt_IdB.Text;
            string tenBenh = txt_TenB.Text;
            string moTa = txt_MoTa.Text;

            string query = string.Format(
                        "update Disease set name = N'{0}', description = N'{1}' where disease_id = '{2}'",
                        tenBenh,
                        moTa,
                        Id);
            bool ktr = kn.ThucThi(query);

            if (ktr)
            {
                MessageBox.Show("Sửa thành công!");
                btn_LamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from Disease where disease_id = '{0}'", txt_IdB.Text);
            bool ktr = kn.ThucThi(query);
            if (ktr == true)
            {
                MessageBox.Show("Xóa thành công!");
                btn_LamMoi.PerformClick();
                //getData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        private void dgv_Benh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Them.Enabled = false;

                txt_IdB.Text = dgv_Benh.Rows[r].Cells[0].Value.ToString();
                txt_TenB.Text = dgv_Benh.Rows[r].Cells[1].Value.ToString();
                txt_MoTa.Text = dgv_Benh.Rows[r].Cells[2].Value.ToString();
            }
        }
        private void clearText()
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = true;

            txt_IdB.Text = "";
            txt_MoTa.Text = "";
            txt_TenB.Text = "";

        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from Disease where name like N'%{0}%' ",
                txt_TimKiem.Text);
            DataSet ds = kn.LayDuLieu(query);
            dgv_Benh.DataSource = ds.Tables[0];
        }
        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
                txt_TimKiem.Text = "Nhập tên bệnh";
                txt_TimKiem.ForeColor = Color.Gray;
            }
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên bệnh")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = Color.Black;
            }
        }
    }
}
