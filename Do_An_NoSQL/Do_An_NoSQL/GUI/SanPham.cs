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
    public partial class SanPham : UserControl
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");
        public SanPham()
        {
            InitializeComponent();
             
            load_data();
        }
        public void load_data()
        {
            var collection = db.GetCollection<SP>("SanPham");
            var query = collection.AsQueryable<SP>().ToList();
            datagridDS_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridDS_SP.DataSource = query;


            var col = db.GetCollection<LOAISANPHAM>("LoaiSanPham");
            var query2 = col.AsQueryable<LOAISANPHAM>().ToList();
            cboTheLoai.DataSource = query2;
            cboTheLoai.DisplayMember = "TenLoai";
            cboTheLoai.ValueMember = "MaLoai";
        }
        public void show_loai_sp(string ma)
        {
            var collection = db.GetCollection<SP>("SanPham");
            
            var sp = collection.Find(b => b.MaLoai == ma).ToList();

            datagridDS_SP.DataSource = sp;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add_SP add = new add_SP(true, null);
            add.ShowDialog(this);
            load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rsl = datagridDS_SP.CurrentRow.Index;
            string id_sp = datagridDS_SP.Rows[rsl].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm \" " + datagridDS_SP.Rows[rsl].Cells[2].Value.ToString() + " \" không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            try
            {
                var coll = db.GetCollection<SP>("SanPham");
                coll.DeleteOne(sp => sp.Id == ObjectId.Parse(id_sp));
                MessageBox.Show("Xóa sản phẩm thành công ?", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            catch
            {
                MessageBox.Show("Xóa sản phẩm không thành công ?", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rsl = datagridDS_SP.CurrentRow.Index;
            string id_sp = datagridDS_SP.Rows[rsl].Cells[0].Value.ToString();
            SP sp = new SP();
            sp.Id = new ObjectId(datagridDS_SP.Rows[rsl].Cells[0].Value.ToString());
            sp.TenSP = datagridDS_SP.Rows[rsl].Cells[1].Value.ToString();
            sp.MaLoai = datagridDS_SP.Rows[rsl].Cells[8].Value.ToString();
            sp.GiaBan = int.Parse(datagridDS_SP.Rows[rsl].Cells[5].Value.ToString());
            sp.SoLuong = int.Parse(datagridDS_SP.Rows[rsl].Cells[4].Value.ToString());
            sp.MoTa = datagridDS_SP.Rows[rsl].Cells[2].Value.ToString();
            sp.AnhBia = datagridDS_SP.Rows[rsl].Cells[3].Value.ToString();
            sp.MaSP = datagridDS_SP.Rows[rsl].Cells[7].Value.ToString();

            add_SP add = new add_SP(false, sp);
            add.ShowDialog(this);
            load_data();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            show_loai_sp(cboTheLoai.SelectedValue.ToString());
        }

        private void btnReload_Data_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
