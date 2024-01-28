using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenh
{
    public partial class frmLichSuChuanDoan : Form
    {
        private KetNoi kn = new KetNoi();
        public frmLichSuChuanDoan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            string query = "select * from DiagnosticHistory";
            DataSet diseaseDS = kn.LayDuLieu(query);
            dgvDsChuanDoan.DataSource = diseaseDS.Tables[0];
        }

        private void dgvDsChuanDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDsChuanDoan.Rows[e.RowIndex];
                DataGridViewCell selectedCell = selectedRow.Cells[e.ColumnIndex];

                if (selectedCell.Value != null)
                {
                    // Lay du lieu từ các cột của hàng được chọn
                    string name = selectedRow.Cells["patient_name"].Value?.ToString();
                    txtBenhNhan.Text = name;

                    int disease_id = 0;
                    int.TryParse(selectedRow.Cells["disease_id"].Value?.ToString(), out disease_id);

                    if (disease_id != 0)
                    {
                        string query = $"SELECT name FROM Disease WHERE disease_id = {disease_id}";
                        DataSet ds = kn.LayDuLieu(query);

                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            string final_diagnosis = ds.Tables[0].Rows[0]["name"].ToString();
                            txtBenh.Text = final_diagnosis;
                        }
                    }

                    string timestamp = selectedRow.Cells["timestamp"].Value?.ToString();
                    txtDate.Text = timestamp;

                    string preds = selectedRow.Cells["preds"].Value?.ToString();
                    if (!string.IsNullOrEmpty(preds))
                    {
                        string symptomQuery = $"SELECT * FROM Symptom WHERE symptom_id IN ({preds})";
                        DataSet symptomDS = kn.LayDuLieu(symptomQuery);

                        if (symptomDS != null && symptomDS.Tables.Count > 0)
                        {
                            dgvDsTrieuChung.DataSource = symptomDS.Tables[0];
                        }
                    }
                }
            }
        }

    }
}