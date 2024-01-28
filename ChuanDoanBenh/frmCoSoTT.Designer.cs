namespace ChuanDoanBenh
{
    partial class frmCoSoTT
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
            mnuCSTT = new MenuStrip();
            benhToolStripMenuItem = new ToolStripMenuItem();
            trieuChungToolStripMenuItem = new ToolStripMenuItem();
            tapLuatToolStripMenuItem = new ToolStripMenuItem();
            pnlCSTT = new Panel();
            mnuCSTT.SuspendLayout();
            SuspendLayout();
            // 
            // mnuCSTT
            // 
            mnuCSTT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            mnuCSTT.ImageScalingSize = new Size(20, 20);
            mnuCSTT.Items.AddRange(new ToolStripItem[] { benhToolStripMenuItem, trieuChungToolStripMenuItem, tapLuatToolStripMenuItem });
            mnuCSTT.Location = new Point(0, 0);
            mnuCSTT.Name = "mnuCSTT";
            mnuCSTT.Size = new Size(1132, 39);
            mnuCSTT.TabIndex = 0;
            mnuCSTT.Text = "menuStrip1";
            mnuCSTT.ItemClicked += mnuCSTT_ItemClicked;
            // 
            // benhToolStripMenuItem
            // 
            benhToolStripMenuItem.Name = "benhToolStripMenuItem";
            benhToolStripMenuItem.Size = new Size(80, 35);
            benhToolStripMenuItem.Text = "Bệnh";
            benhToolStripMenuItem.Click += benhToolStripMenuItem_Click;
            // 
            // trieuChungToolStripMenuItem
            // 
            trieuChungToolStripMenuItem.Name = "trieuChungToolStripMenuItem";
            trieuChungToolStripMenuItem.Size = new Size(150, 35);
            trieuChungToolStripMenuItem.Text = "Triệu chứng";
            trieuChungToolStripMenuItem.Click += trieuChungToolStripMenuItem_Click;
            // 
            // tapLuatToolStripMenuItem
            // 
            tapLuatToolStripMenuItem.Name = "tapLuatToolStripMenuItem";
            tapLuatToolStripMenuItem.Size = new Size(112, 35);
            tapLuatToolStripMenuItem.Text = "Tập luật";
            tapLuatToolStripMenuItem.Click += tapLuatToolStripMenuItem_Click;
            // 
            // pnlCSTT
            // 
            pnlCSTT.BackColor = SystemColors.ButtonHighlight;
            pnlCSTT.Dock = DockStyle.Fill;
            pnlCSTT.Location = new Point(0, 39);
            pnlCSTT.Name = "pnlCSTT";
            pnlCSTT.Size = new Size(1132, 867);
            pnlCSTT.TabIndex = 1;
            // 
            // frmCoSoTT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 906);
            Controls.Add(pnlCSTT);
            Controls.Add(mnuCSTT);
            MainMenuStrip = mnuCSTT;
            Name = "frmCoSoTT";
            Text = "frmCoSoTT";
            Load += frmCoSoTT_Load;
            mnuCSTT.ResumeLayout(false);
            mnuCSTT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuCSTT;
        private ToolStripMenuItem benhToolStripMenuItem;
        private ToolStripMenuItem trieuChungToolStripMenuItem;
        private ToolStripMenuItem tapLuatToolStripMenuItem;
        private Panel pnlCSTT;
    }
}