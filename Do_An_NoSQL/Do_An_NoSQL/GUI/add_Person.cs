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
using System.Text.RegularExpressions;

namespace Do_An_NoSQL.GUI
{
    public partial class add_Person : Form
    {
        bool check, check_KH;
        PERSON ps;
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");

        public add_Person()
        {
            InitializeComponent();
        }

        internal add_Person(bool check, PERSON ps, bool check_KH)
        {
            InitializeComponent();
            this.check = check;
            this.check_KH = check_KH; // true:nv false:kh
            this.ps = ps;
            if (ps != null)
            {
                if (!check)
                {
                    txtTen.Text = ps.HoTen;
                    txtNgay.Value = DateTime.Parse(ps.NgaySinh);
                    txtLH.Text = ps.Sdt;
                    txtDC.Text = ps.DiaChi;
                    if (ps.GioiTinh.Equals("Nam"))
                        radNam.Checked = true;
                    else radNu.Checked = true;
                }
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            //Thêm mới
            if (check)
            {
                if (check_KH)
                {
                    var coll = db.GetCollection<PERSON>("NhanVien");
                    if (MessageBox.Show("Bạn có muốn thêm Thành viên " + txtTen.Text + " không ?", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                    //Tạo tài khoản mật khẩu giống tên của nhân viên
                    string tk, mk;
                    string[] ten = txtTen.Text.Split(' ');
                    if (ten.Length == 1)
                        tk = mk = chuyen_khong_dau(ten[0]);
                    else
                        tk = mk = chuyen_khong_dau((ten[(ten.Length - 1) - 1] + ten[ten.Length - 1]).ToLower());

                    PERSON ps = new PERSON();
                    ps.Username = tk;
                    ps.Pass = mk;
                    ps.HoTen = txtTen.Text;
                    ps.DiaChi = txtDC.Text;
                    ps.Sdt = txtLH.Text;
                    ps.NgaySinh = txtNgay.Text;
                    if (radNam.Checked)
                        ps.GioiTinh = "Nam";
                    else
                        ps.GioiTinh = "Nữ";

                    try
                    {
                        coll.InsertOne(ps);
                        MessageBox.Show("Thêm Thành viên thành công ?", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thành viên không thành công ?", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    var coll = db.GetCollection<PERSON>("KhachHang");
                    if (MessageBox.Show("Bạn có muốn thêm Thành viên " + txtTen.Text + " không ?", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                    //Tạo tài khoản mật khẩu giống tên của nhân viên
                    string tk, mk;
                    string[] ten = txtTen.Text.Split(' ');
                    if (ten.Length == 1)
                        tk = mk = chuyen_khong_dau(ten[0]);
                    else
                        tk = mk = chuyen_khong_dau((ten[(ten.Length - 1) - 1] + ten[ten.Length - 1]).ToLower());

                    PERSON ps = new PERSON();
                    ps.Username = tk;
                    ps.Pass = mk;
                    ps.HoTen = txtTen.Text;
                    ps.DiaChi = txtDC.Text;
                    ps.Sdt = txtLH.Text;
                    ps.NgaySinh = txtNgay.Text;
                    if (radNam.Checked)
                        ps.GioiTinh = "Nam";
                    else
                        ps.GioiTinh = "Nữ";

                    try
                    {
                        coll.InsertOne(ps);
                        MessageBox.Show("Thêm Thành viên thành công ?", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Thành viên không thành công ?", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            //Sửa
            else
            {
                if (check_KH)
                {
                    if (MessageBox.Show("Bạn có muốn sửa đổi thông tin Thành viên " + txtTen.Text + " không ?", "Thông báo",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;

                    try
                    {
                        string gt = "Nam";
                        if (radNu.Checked)
                            gt = "Nữ";
                        var coll = db.GetCollection<PERSON>("NhanVien");
                        var update = Builders<PERSON>.Update
                            .Set("HoTen", txtTen.Text)
                            .Set("NgaySinh", txtNgay.Text)
                            .Set("GioiTinh", gt)
                            .Set("DiaChi", txtDC.Text)
                            .Set("Sdt", txtLH.Text);
                        coll.UpdateOne(s => s.Id == ps.Id, update);
                        MessageBox.Show("Sửa đổi thông tin Thành viên thành công ?", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa đổi thông tin Thành viên không thành công ?", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }   
                else
                {
                    if (MessageBox.Show("Bạn có muốn sửa đổi thông tin Thành viên " + txtTen.Text + " không ?", "Thông báo",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;

                    try
                    {
                        string gt = "Nam";
                        if (radNu.Checked)
                            gt = "Nữ";
                        var coll = db.GetCollection<PERSON>("KhachHang");
                        var update = Builders<PERSON>.Update
                            .Set("HoTen", txtTen.Text)
                            .Set("NgaySinh", txtNgay.Text)
                            .Set("GioiTinh", gt)
                            .Set("DiaChi", txtDC.Text)
                            .Set("Sdt", txtLH.Text);
                        coll.UpdateOne(s => s.Id == ps.Id, update);
                        MessageBox.Show("Sửa đổi thông tin Thành viên thành công ?", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa đổi thông tin Thành viên không thành công ?", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string chuyen_khong_dau(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
