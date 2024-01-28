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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void showForm(Form form)
        {
            form.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem? clickedItem = e.ClickedItem as ToolStripMenuItem;
            if (clickedItem != null)
            {
                foreach (ToolStripMenuItem item in mnuMain.Items.OfType<ToolStripMenuItem>())
                {
                    item.BackColor = SystemColors.ButtonHighlight;
                    item.Checked = false;
                }
                clickedItem.BackColor = Color.SkyBlue;
                clickedItem.Checked = true;
            }
        }
        private void toolStripMenuItemBenhNhan_Click(object sender, EventArgs e)
        {
            frmTapLuat frm = new frmTapLuat();
            showForm(frm);
        }

        private void toolStripMenuItemGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            showForm(frm);
        }

        private void toolStripMenuItemCoSoTT_Click(object sender, EventArgs e)
        {
            frmCoSoTT frm = new frmCoSoTT();
            showForm(frm);
        }
        private void toolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        private void toolStripMenuItemChuanDoan_Click(object sender, EventArgs e)
        {
            frmTrieuChung frm = new frmTrieuChung();
            showForm(frm);
        }

        private void toolStripMenuItemChuanDoan_Click_1(object sender, EventArgs e)
        {
            frmChuanDoanBenh frm = new frmChuanDoanBenh();
            showForm(frm);
        }

        private void toolStripMenuItemBenhNhan_Click_1(object sender, EventArgs e)
        {
            frmLichSuChuanDoan frm = new frmLichSuChuanDoan();
            showForm(frm);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            frmChuanDoanBenh frm = new frmChuanDoanBenh();
            showForm(frm);
        }
    }
}
