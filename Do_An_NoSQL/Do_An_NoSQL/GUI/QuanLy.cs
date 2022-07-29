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
    public partial class QuanLy : UserControl
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");

        public QuanLy()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            var collection = db.GetCollection<PERSON>("NhanVien");
            var query = collection.AsQueryable<PERSON>().ToList();
            datagridDS_NV_KH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridDS_NV_KH.DataSource = query;
        }

        private void btnReload_Data_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add_Person add = new add_Person(true, null, true);
            add.ShowDialog();
            load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rsl = datagridDS_NV_KH.CurrentRow.Index;
            string id_sp = datagridDS_NV_KH.Rows[rsl].Cells[7].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa Thành viên \" " + datagridDS_NV_KH.Rows[rsl].Cells[2].Value.ToString() + " \" không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            try
            {
                var coll = db.GetCollection<PERSON>("NhanVien");
                coll.DeleteOne(sp => sp.Id == ObjectId.Parse(id_sp));
                MessageBox.Show("Xóa Thành viên thành công ?", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            catch
            {
                MessageBox.Show("Xóa Thành viên không thành công ?", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cell 7 is ID
            int rsl = datagridDS_NV_KH.CurrentRow.Index;
            //string i = datagridDS_NV_KH.Rows[rsl].Cells[2].Value.ToString();
            PERSON ps = new PERSON();
            ps.Id = new ObjectId(datagridDS_NV_KH.Rows[rsl].Cells[7].Value.ToString());
            ps.HoTen = datagridDS_NV_KH.Rows[rsl].Cells[2].Value.ToString();
            ps.NgaySinh = datagridDS_NV_KH.Rows[rsl].Cells[6].Value.ToString();
            ps.GioiTinh = datagridDS_NV_KH.Rows[rsl].Cells[3].Value.ToString();
            ps.DiaChi = datagridDS_NV_KH.Rows[rsl].Cells[4].Value.ToString();
            ps.Sdt = datagridDS_NV_KH.Rows[rsl].Cells[5].Value.ToString();

            add_Person add = new add_Person(false, ps, true);
            add.ShowDialog();
            load_data();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            show_dc(txtTK.Text);
        }

        public void show_dc(string dc)
        {
            var collection = db.GetCollection<PERSON>("NhanVien");
            var sp = collection.Find(ps => ps.DiaChi == dc).ToList();

            datagridDS_NV_KH.DataSource = sp;
        }
    }
}
