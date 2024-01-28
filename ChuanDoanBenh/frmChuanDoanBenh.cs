using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenh
{
    public partial class frmChuanDoanBenh : Form
    {
        KetNoi kn = new KetNoi();

        public frmChuanDoanBenh()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { }

        private void hienThiDataLenListViewLeft()
        {
            // hiển thị dữ liệu từ dataSet lấy được tu bang trieu chung từ database lên listViewLeft trong form
            DataSet ds = new DataSet();
            ds = kn.LayDuLieu("select symptom_id, name from Symptom");
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = lsvLeft.Items.Add(dr["symptom_id"].ToString());
                    item.SubItems.Add(dr["name"].ToString());
                }
            }
            else
            {
                lsvLeft.Items.Add("No Data Found");
            }
        }
        private void AddTitleIntoListView()
        {
            //lam tuong tu voi listView Right
            lsvRight.Columns.Add("Id", (int)(lsvRight.Width * 0.15));
            lsvRight.Columns.Add("Tên Triệu Chứng Lựa Chọn", (int)(lsvRight.Width * 0.85));
            lsvRight.View = View.Details;
            lsvRight.FullRowSelect = true;
            lsvRight.GridLines = true;
            lsvRight.MultiSelect = true;
        }

        private void frmChuanDoanBenh_Load(object sender, EventArgs e)
        {
            //them 2 cot "id" va "nam" vao cac listView Left 
            lsvLeft.Columns.Add("Id", (int)(lsvLeft.Width * 0.15));
            lsvLeft.Columns.Add("Tên Triệu Chứng", (int)(lsvLeft.Width * 0.85));
            //hien thi listView thanh 2 cot
            lsvLeft.View = View.Details;
            lsvLeft.GridLines = true;
            lsvLeft.FullRowSelect = true;
            lsvLeft.MultiSelect = true;

            // load du lieu vao listView Left
            hienThiDataLenListViewLeft();

            AddTitleIntoListView();
        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lsvLeft.SelectedIndices.Count; i++)
            {
                ListViewItem item = lsvRight.Items.Add(lsvLeft.SelectedItems[i].SubItems[0].Text);
                item.SubItems.Add(lsvLeft.SelectedItems[i].SubItems[1].Text);
            }
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();
            for (int i = 0; i < lsvRight.SelectedIndices.Count; i++)
            {
                itemsToRemove.Add(lsvRight.SelectedItems[i]);
            }

            foreach (ListViewItem item in itemsToRemove)
            {
                lsvRight.Items.Remove(item);
            }
        }

        private string diagnosis_id = "";

        private void btnChuanDoan_Click(object sender, EventArgs e)
        {
            List<int> symptoms_index = new List<int>();

            for (int i = 0; i < lsvRight.Items.Count; i++)
            {
                int symptom_index = Convert.ToInt32(lsvRight.Items[i].SubItems[0].Text);
                symptoms_index.Add(symptom_index);
            }

            // Gọi hàm khởi tạo BackWardChaining truyền vào tham số là danh sách các triệu chứng để tiến hành chuẩn đoán
            BackWardChaining bc = new BackWardChaining(symptoms_index);
            //bc.PrintSymptoms();
            diagnosis_id = bc.MostFrequentTargetRule();
            string query = "SELECT [name] FROM [Disease] WHERE [disease_id] = " + diagnosis_id;
            DataSet ds = kn.LayDuLieu(query);

            string final_diagnosis = ds.Tables[0].Rows[0]["name"].ToString();
            // Kiểm tra xem có dữ liệu trả về từ truy vấn không
            
            Debug.WriteLine(final_diagnosis);
            if (string.Compare("Diagnosis is not possible at this time. Please Try again", final_diagnosis) != 0)
            {
                txtDoTinCay.Text = "100%";
            }
            else
            {
                txtDoTinCay.Text = "0%";
            }
            txtBenhChuanDoan.Text = final_diagnosis;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            lsvRight.Clear();
            txtBenhChuanDoan.Text = "";
            txtDoTinCay.Text = "";
            AddTitleIntoListView();
            foreach (ListViewItem item in lsvLeft.Items)
            {
                if (item.Selected == true)
                {
                    item.Selected = false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuKetQua_Click(object sender, EventArgs e)
        {
            if (diagnosis_id != "")
            {
                string symptoms_index = "";
                for (int i = 0; i < lsvRight.Items.Count; i++)
                {
                    string symptom_index = lsvRight.Items[i].SubItems[0].Text;
                    symptoms_index += symptom_index + ",";
                }
                symptoms_index = symptoms_index.TrimEnd(',');
                int disease_id = Convert.ToInt32(diagnosis_id);
                string patient_name = txtBenhNhan.Text;
                string address = txtDiaChi.Text;

                Debug.WriteLine("Diagnosis_id = " + disease_id);

                string query = $@"INSERT INTO DiagnosticHistory
                 VALUES ({disease_id}, GETDATE(), '{patient_name}', '{address}', '{symptoms_index}')";

                bool isExist = kn.ThucThi(query);
                if (isExist)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chuẩn đoán!");
            }
        }
    }
}