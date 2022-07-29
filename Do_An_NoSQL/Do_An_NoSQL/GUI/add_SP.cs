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
using System.IO;

namespace Do_An_NoSQL.GUI
{
    public partial class add_SP : Form
    {
        string file_path_PT = "";
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        bool check;
        SP sp;
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");
        static IMongoCollection<SP> coll = db.GetCollection<SP>("SanPham");

        static IMongoCollection<LOAISANPHAM> coll2 = db.GetCollection<LOAISANPHAM>("LoaiSanPham");
        public add_SP()
        {
            InitializeComponent();
            cboLoaiSP.DataSource = coll2.AsQueryable<LOAISANPHAM>().ToList();
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        internal add_SP(bool check, SP sp)
        {
            InitializeComponent();
            cboLoaiSP.DataSource = coll2.AsQueryable<LOAISANPHAM>().ToList();
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
            this.check = check;
            this.sp = sp;
            if (sp != null)
            {
                txtMaSP.Text = sp.MaSP;
                txtTenSP.Text = sp.TenSP;
                txtGiaBan.Text = sp.GiaBan.ToString();
                txtSL.Text = sp.SoLuong.ToString();
                txtMota.Text = sp.MoTa;
                if (sp.AnhBia.Length > 10)
                    picAnhBia.Image = Image.FromFile(sp.AnhBia);
                else picAnhBia.Image = Image.FromFile(projectPath + "\\Image\\" + sp.AnhBia);
                file_path_PT = sp.AnhBia;
                cboLoaiSP.SelectedValue = sp.MaLoai;
            }
            if (check)
                txtMaSP.ReadOnly = false;
            else
                txtMaSP.ReadOnly = true;
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            //Thêm mới
            if (check)
            {
                if (MessageBox.Show("Bạn có muốn thêm sản phẩm " + txtTenSP.Text + " không ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                SP sp = new SP();
                if (!file_path_PT.Equals("nocontentyet.jpg") && file_path_PT.Length > 0)
                {
                    sp.MaSP = txtMaSP.Text;
                    sp.TenSP = txtTenSP.Text;
                    sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                    sp.MoTa = txtMota.Text;
                    sp.GiaBan = int.Parse(txtGiaBan.Text);
                    sp.SoLuong = int.Parse(txtSL.Text);
                    sp.AnhBia = file_path_PT;
                }    
                else
                {
                    sp.MaSP = txtMaSP.Text;
                    sp.TenSP = txtTenSP.Text;
                    sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                    sp.MoTa = txtMota.Text;
                    sp.GiaBan = int.Parse(txtGiaBan.Text);
                    sp.SoLuong = int.Parse(txtSL.Text);
                    sp.AnhBia = "nocontentyet.jpg";
                }

                try
                {
                    coll.InsertOne(sp);
                    MessageBox.Show("Thêm sản phẩm thành công ?", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm sản phẩm không thành công ?", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Cập nhật
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa đổi thông tin sản phẩm " + txtTenSP.Text + " không ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;

                try
                {
                    var update = Builders<SP>.Update
                        .Set("TenSP", txtTenSP.Text)
                        .Set("MoTa", txtMota.Text)
                        .Set("SoLuong", txtSL.Text)
                        .Set("AnhBia", file_path_PT)
                        .Set("MaLoai", cboLoaiSP.SelectedValue.ToString())
                        .Set("GiaBan", txtGiaBan.Text);
                    coll.UpdateOne(s => s.Id == sp.Id, update);
                    MessageBox.Show("Sửa đổi thông tin sản phẩm thành công ?", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sửa đổi thông tin sản phẩm không thành công ?", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.Close();
        }

        private void picAnhBia_Click(object sender, EventArgs e)
        {
            openAnh.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openAnh.FilterIndex = 1;
            openAnh.RestoreDirectory = true;
            if (openAnh.ShowDialog() == DialogResult.OK)
            {
                file_path_PT = openAnh.SafeFileName;
                Image img = Image.FromFile(openAnh.FileName);
                picAnhBia.Image = img;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
