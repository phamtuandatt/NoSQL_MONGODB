using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_NoSQL.Object;
using MongoDB.Driver;

namespace Do_An_NoSQL.GUI
{
    public partial class HoaDon : UserControl
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");
        public HoaDon()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            var collection = db.GetCollection<HOADON>("HoaDonBan");
            var query = collection.AsQueryable<HOADON>().ToList();
            dataGridHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHD.DataSource = query;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            tim_kiem_dc(txtTK.Text);
            if (dataGridHD.RowCount <= 0)
            {
                tim_kiem_tenkh(txtTK.Text);
                if (dataGridHD.RowCount <= 0)
                {
                    MessageBox.Show(this, "KHÔNG TÌM THẤY ĐƠN HÀNG NÀO PHÙ HỢP", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                }
            }
        }

        public void tim_kiem_dc(string dia_c)
        {
            var collection = db.GetCollection<HOADON>("HoaDonBan");

            var hd = collection.Find(h => h.DiaChiGH == dia_c).ToList();

            dataGridHD.DataSource = hd;
        }

        public void tim_kiem_tenkh(string tenkh)
        {
            var collection = db.GetCollection<HOADON>("HoaDonBan");

            var hd = collection.Find(h => h.HoTen == tenkh).ToList();

            dataGridHD.DataSource = hd;
        }

        private void btnReload_Data_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnCT_HD_Click(object sender, EventArgs e)
        {
            int rsl = dataGridHD.CurrentRow.Index;
            string ma_hd = dataGridHD.Rows[rsl].Cells[0].Value.ToString();
            string tenkh = dataGridHD.Rows[rsl].Cells[1].Value.ToString();
            string dc = dataGridHD.Rows[rsl].Cells[2].Value.ToString();
            frmCT_HD ct_hd = new frmCT_HD(ma_hd, tenkh, dc);
            ct_hd.ShowDialog();
        }

        private void dataGridHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridHD.CurrentRow.Index;
            string ma_hd = dataGridHD.Rows[rsl].Cells[0].Value.ToString();
            string tenkh = dataGridHD.Rows[rsl].Cells[1].Value.ToString();
            string dc = dataGridHD.Rows[rsl].Cells[2].Value.ToString();
            frmCT_HD ct_hd = new frmCT_HD(ma_hd, tenkh, dc);
            ct_hd.ShowDialog();
        }
    }
}
