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

namespace ChuanDoanBenh
{
    public partial class frmTapLuat : Form
    {
        private KetNoi kn = new KetNoi();
        Base Base = new Base();
        public frmTapLuat()
        {
            InitializeComponent();
        }

        private void frmTapLuat_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            dgvBenh.AutoGenerateColumns = false;
            dgvTrieuChung.AutoGenerateColumns = false;
            dgvTapLuat.AutoGenerateColumns = false;
            // Disease
            string diseaseQuery = "select disease_id, name from Disease";
            DataSet diseaseDS = kn.LayDuLieu(diseaseQuery);
            dgvBenh.DataSource = diseaseDS.Tables[0];
            Base.DefineDataGridViewColumns(dgvBenh, new[] { "Disease Id", "Name" }, new[] { "disease_id", "name" }, new[] { 50, 420 });
            // Symptom
            string symptomQuery = "select symptom_id, name from Symptom";
            DataSet symptomDS = kn.LayDuLieu(symptomQuery);
            dgvTrieuChung.DataSource = symptomDS.Tables[0];
            Base.DefineDataGridViewColumns(dgvTrieuChung, new[] { "Symptom Id", "Name" }, new[] { "symptom_id", "name" }, new[] { 50, 420 });
            // InferenceRule
            string ruleQuery = "SELECT rule_id, antecedent, disease_id FROM InferenceRule";
            DataSet ruleDS = kn.LayDuLieu(ruleQuery);
            DataTable formattedRuleTable = new DataTable();
            formattedRuleTable.Columns.Add("rule_id");
            formattedRuleTable.Columns.Add("antecedentFormatted");
            foreach (DataRow row in ruleDS.Tables[0].Rows)
            {
                string antecedent = row["antecedent"].ToString();
                string disease_id = row["disease_id"].ToString();
                //Format the "antecedent" column
                string formattedAntecedent = FormatAntecedent(antecedent, disease_id);
                formattedRuleTable.Rows.Add(row["rule_id"], formattedAntecedent);
            }
            dgvTapLuat.DataSource = formattedRuleTable;
            Base.DefineDataGridViewColumns(dgvTapLuat, new[] { "Rule Id", "Antecedent" }, new[] { "rule_id", "antecedentFormatted" }, new[] { 50, 420 });
        }

        private void dgvTrieuChung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTrieuChung.Rows[e.RowIndex];
                DataGridViewCell cell = selectedRow.Cells[0];
                string suKienValue = cell?.Value?.ToString() ?? string.Empty;
                txtSuKien.Text = suKienValue;
            }
        }

        private void dgvBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBenh.Rows[e.RowIndex];
                DataGridViewCell cell = selectedRow.Cells[0];
                string ketLuanValue = cell?.Value?.ToString() ?? string.Empty;
                txtKetLuan.Text = ketLuanValue;
            }
        }
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            string symptomQuery = "select symptom_id, name from Symptom";
            DataSet symptomDS = kn.LayDuLieu(symptomQuery);
            dgvTrieuChung.DataSource = symptomDS.Tables[0];
            Base.DefineDataGridViewColumns(dgvTrieuChung, new[] { "Symptom Id", "Name" }, new[] { "symptom_id", "name" }, new[] { 50, 420 });
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ketLuanValue = txtKetLuan.Text;
            string suKienValue = txtSuKien.Text;
            if (string.IsNullOrEmpty(ketLuanValue) || string.IsNullOrEmpty(suKienValue))
            {
                MessageBox.Show("Thiếu dữ liệu, xin kiểm tra lại!");
                return;
            }
            if (!ExistsInDatabase("Disease", "disease_id", ketLuanValue))
            {
                MessageBox.Show("Không tồn tại kết luận này. Kiểm tra lại");
                return;
            }
            if (!ExistsInDatabase("Symptom", "symptom_id", suKienValue))
            {
                MessageBox.Show("Không tồn tại sự kiện này. Kiểm tra lại");
                return;
            }

            //Thực thi
            string query = $"SELECT COUNT(*) FROM InferenceRule WHERE disease_id = {ketLuanValue}";
            bool isExist = kn.ThucThiDuyNhat(query);
            bool kt = false;
            if (isExist)
            {
                string selectQuery = $"SELECT antecedent FROM InferenceRule WHERE disease_id = {ketLuanValue}";
                DataSet ds = kn.LayDuLieu(selectQuery);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string currentAntecedent = ds.Tables[0].Rows[0]["antecedent"].ToString();

                    if (currentAntecedent.Contains(suKienValue))
                    {
                        MessageBox.Show("Thêm thất bại! Đã có triệu chứng này trong tập luật.");
                        return;
                    }
                    else
                    {
                        string updateQuery = $"Update InferenceRule SET antecedent = '{currentAntecedent + "," + suKienValue}' WHERE disease_id = {ketLuanValue}";
                        kt = kn.ThucThi(updateQuery);
                    }
                }
            }
            else
            {
                string insertQuery = string.Format("insert into InferenceRule(antecedent,disease_id) values('{0}' , '{1}')", suKienValue, ketLuanValue);
                kt = kn.ThucThi(insertQuery);
            }
            // Thông báo
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                btnHuyBo.PerformClick();
                getData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtKetLuan.Text = null;
            txtSuKien.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ketLuanValue = txtKetLuan.Text;
            string suKienValue = txtSuKien.Text;
            if (string.IsNullOrEmpty(ketLuanValue) || string.IsNullOrEmpty(suKienValue))
            {
                MessageBox.Show("Thiếu dữ liệu, xin kiểm tra lại!");
                return;
            }
            if (!ExistsInDatabase("Disease", "disease_id", ketLuanValue))
            {
                MessageBox.Show("Không tồn tại kết luận này. Kiểm tra lại");
                return;
            }

            //Thực thi
            string query = $"SELECT COUNT(*) FROM InferenceRule WHERE disease_id = {ketLuanValue}";
            bool isExist = kn.ThucThiDuyNhat(query);
            bool kt = false;
            if (isExist)
            {
                string selectQuery = $"SELECT antecedent FROM InferenceRule WHERE disease_id = {ketLuanValue}";
                DataSet ds = kn.LayDuLieu(selectQuery);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string currentAntecedent = ds.Tables[0].Rows[0]["antecedent"].ToString();

                    if (!currentAntecedent.Contains(suKienValue))
                    {
                        MessageBox.Show("Xóa thất bại! Không có sự kiện này trong tập luật.");
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Sự kiện này khỏi Luật?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string[] values = currentAntecedent.Split(',');
                            List<string> updatedValues = values.Where(v => v != suKienValue).ToList();
                            string updatedAntecedent = string.Join(",", updatedValues);
                            string updateQuery = $"Update InferenceRule SET antecedent = '{updatedAntecedent}' WHERE disease_id = {ketLuanValue}";
                            kt = kn.ThucThi(updateQuery);

                            // Thông báo
                            if (kt)
                            {
                                MessageBox.Show("Xóa thành công");
                                btnHuyBo.PerformClick();
                                getData();
                            }
                            else
                                MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tập luật có kết luận này!");
            }
        }

        private void dgvTapLuat_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Point mouseLocation = dgvTapLuat.PointToClient(Cursor.Position);
                contextMenuStripTapLuat.Show(dgvTapLuat, mouseLocation);
            }
        }

        private void xemChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvTapLuat.CurrentRow;
            if (selectedRow != null)
            {
                string cellValue = selectedRow.Cells[0].Value.ToString();
                string syss = $"select antecedent from InferenceRule where rule_id = {cellValue}";
                DataSet ds = kn.LayDuLieu(syss);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string result = ds.Tables[0].Rows[0][0].ToString();
                    string symptomQuery = $"SELECT * FROM Symptom WHERE symptom_id IN ({result})";
                    DataSet symptomDS = kn.LayDuLieu(symptomQuery);
                    dgvTrieuChung.DataSource = symptomDS.Tables[0];
                }
            }
        }
        private void xoaLuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvTapLuat.CurrentRow;
            if (selectedRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Luật này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string cellValue = selectedRow.Cells[0].Value.ToString();
                    string query = $"DELETE  FROM InferenceRule WHERE rule_id = {cellValue}";
                    bool kt = kn.ThucThi(query);
                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công");
                        btnHuyBo.PerformClick();
                        getData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private string FormatAntecedent(string antecedent, string benhId)
        {
            // Dinh dang chuoi antecedent
            if (string.IsNullOrWhiteSpace(antecedent)) return string.Empty;
            string[] parts = antecedent.Split(',');
            string formattedParts = string.Join(" + ", parts) + " -> " + benhId;
            return formattedParts;
        }
        private bool ExistsInDatabase(string tableName, string columnName, string value)
        {
            // Kiem tra xem gia tri co ton tai khong
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = {value}";
            return kn.ThucThiDuyNhat(query);
        }
    }
}
