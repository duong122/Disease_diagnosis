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
    public partial class frmCoSoTT : Form
    {
        public frmCoSoTT()
        {
            InitializeComponent();
        }

        private void tabPageBenh_Click(object sender, EventArgs e)
        {

        }

        private void showForm(Form form)
        {
            form.TopLevel = false;
            pnlCSTT.Controls.Clear();
            pnlCSTT.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void benhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrieuChung frm = new frmTrieuChung();
            showForm(frm);
        }

        private void trieuChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSymptom frm = new frmSymptom();
            showForm(frm);
        }

        private void tapLuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTapLuat frm = new frmTapLuat();
            showForm(frm);
        }

        private void mnuCSTT_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem? clickedItem = e.ClickedItem as ToolStripMenuItem;
            if (clickedItem != null)
            {
                foreach (ToolStripMenuItem item in mnuCSTT.Items.OfType<ToolStripMenuItem>())
                {
                    item.BackColor = SystemColors.ButtonHighlight;
                    item.Checked = false;
                }
                clickedItem.BackColor = Color.SkyBlue;
                clickedItem.Checked = true;
            }
        }

        private void frmCoSoTT_Load(object sender, EventArgs e)
        {
            benhToolStripMenuItem.BackColor = Color.SkyBlue;
            benhToolStripMenuItem_Click(this, e);
        }
    }
}
