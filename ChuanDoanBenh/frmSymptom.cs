using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortOrder = System.Windows.Forms.SortOrder;

namespace ChuanDoanBenh
{
    public partial class frmSymptom : Form
    {
        private SortOrder sortOrder = SortOrder.None;
        private DataGridViewColumn sortedColumn = null;
        public frmSymptom()
        {
            InitializeComponent();
            txt_IdTC.Enabled = false;
            btn_SuaTC.Enabled = false;
            btn_XoaTC.Enabled = false;

            txt_TimKiem.ForeColor = Color.LightGray;
            txt_TimKiem.Text = "Nhập tên triệu chứng";
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);

            //dgv_TC.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgv_TC_ColumnHeaderMouseClick);

        }
        KetNoi kn = new KetNoi();
        Base Base = new Base();
        private void getData()
        {
            dgv_TC.AutoGenerateColumns = false;
            string query = "select symptom_id, name from Symptom";
            DataSet ds = kn.LayDuLieu(query);
            dgv_TC.DataSource = ds.Tables[0];
            Base.DefineDataGridViewColumns(dgv_TC, new[] { "Symptom Id", "Name" }, new[] { "symptom_id", "name" }, new[] { 120, 1026 });
        }
        private void frmSymptom_Load(object sender, EventArgs e)
        {
            getData();
        }
        private bool IsDuplicateProductName(string nameTC)
        {
            foreach (DataGridViewRow row in dgv_TC.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(nameTC, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_ThemTC_Click(object sender, EventArgs e)
        {
            string name = txt_TC.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (!IsDuplicateProductName(name))
                {
                    string query = string.Format("insert into Symptom (name) values(N'{0}')", name);
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
                    MessageBox.Show("Tên triệu chứng đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên triệu chứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SuaTC_Click(object sender, EventArgs e)
        {

            string query = string.Format(
                "update Symptom set name = N'{0}' where symptom_id = '{1}'",
                txt_TC.Text,
                txt_IdTC.Text);
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
        private void btn_XoaTC_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from Symptom where symptom_id = '{0}'", txt_IdTC.Text);
            bool ktr = kn.ThucThi(query);
            if (ktr == true)
            {
                MessageBox.Show("Xóa thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        private void dgv_TC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btn_SuaTC.Enabled = true;
                btn_XoaTC.Enabled = true;
                btn_ThemTC.Enabled = false;

                txt_IdTC.Text = dgv_TC.Rows[r].Cells[0].Value.ToString();
                txt_TC.Text = dgv_TC.Rows[r].Cells[1].Value.ToString();
            }
        }
        private void clearText()
        {
            btn_SuaTC.Enabled = false;
            btn_XoaTC.Enabled = false;
            btn_ThemTC.Enabled = true;

            txt_IdTC.Text = "";
            txt_TC.Text = "";
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from Symptom where name like N'%{0}%' ",
                txt_TimKiem.Text);
            DataSet ds = kn.LayDuLieu(query);
            dgv_TC.DataSource = ds.Tables[0];
        }

        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Nhập tên triệu chứng")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
                txt_TimKiem.Text = "Nhập tên triệu chứng";
                txt_TimKiem.ForeColor = Color.Gray;
            }
        }

        private void dgv_TC_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    Point mouseLocation = dgv_TC.PointToClient(Cursor.Position);
            //    contextMenuStripTapLuat.Show(dgv_TC, mouseLocation);
            //}
        }

        private void dgv_TC_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn newSortedColumn = dgv_TC.Columns[e.ColumnIndex];

            //if (newSortedColumn != null && newSortedColumn.SortMode != DataGridViewColumnSortMode.NotSortable)
            //{
            //    if (sortedColumn == newSortedColumn)
            //    {
            //        // Reverse the current sort direction
            //        sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            //    }
            //    else
            //    {
            //        // Set the sort column and default to ascending order
            //        sortedColumn = newSortedColumn;
            //        sortOrder = SortOrder.Ascending;
            //    }

            //    // Apply the sort
            //    ApplySort();
            //}
        }
        //private void ApplySort()
        //{
        //    if (sortedColumn != null)
        //    {
        //        string sortOrderString = (sortOrder == SortOrder.Ascending) ? "ASC" : "DESC";
        //        string query = string.Format("SELECT symptom_id, name FROM Symptom ORDER BY {0} {1}", sortedColumn.DataPropertyName, sortOrderString);

        //        DataSet ds = kn.LayDuLieu(query);
        //        dgv_TC.DataSource = ds.Tables[0];
        //    }
        //}
    }
}
