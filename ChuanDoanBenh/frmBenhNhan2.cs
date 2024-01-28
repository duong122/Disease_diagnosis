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
    public partial class frmBenhNhan2 : Form
    {
        KetNoi kn = new KetNoi();

        private void AddTitleIntoListView()
        {

            //lam tuong tu voi listView patient
            lsvPatient.Columns.Add("Id", (int)(lsvPatient.Width * 0.2));
            lsvPatient.Columns.Add("Tên Triệu Chứng Lựa Chọn", (int)(lsvPatient.Width * 0.2));
            lsvPatient.Columns.Add("Tên bệnh nhân", (int)(lsvPatient.Width * 0.2));
            lsvPatient.Columns.Add("Ngày tháng sinh", (int)(lsvPatient.Width * 0.2));
            lsvPatient.Columns.Add("Liên hệ", (int)(lsvPatient.Width * 0.2));
            lsvPatient.View = View.Details;
            lsvPatient.FullRowSelect = true;
            lsvPatient.GridLines = true;
            lsvPatient.MultiSelect = true;


            // thiet ke listView 
            lsvDianosis.Columns.Add("Id", (int)(lsvDianosis.Width * 0.7));
            lsvDianosis.Columns.Add("Tên bệnh", (int)(lsvDianosis.Width * 0.3));
            lsvDianosis.View = View.Details;
            lsvDianosis.FullRowSelect = true;
            lsvDianosis.GridLines = true;
        }
        public frmBenhNhan2()
        {
            InitializeComponent();
        }

        private void frmBenhNhan2_Load(object sender, EventArgs e)
        {

        }
    }
}
