using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Do_An_NoSQL.Object;

namespace Do_An_NoSQL.GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnDS_SP_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Dock = System.Windows.Forms.DockStyle.Fill;
            pnUserControl.Controls.Add(sp);
            sp.BringToFront();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Dock = System.Windows.Forms.DockStyle.Fill;
            pnUserControl.Controls.Add(ql);
            ql.BringToFront();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Dock = System.Windows.Forms.DockStyle.Fill;
            pnUserControl.Controls.Add(kh);
            kh.BringToFront();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Dock = System.Windows.Forms.DockStyle.Fill;
            pnUserControl.Controls.Add(hd);
            hd.BringToFront();
        }
    }
}
