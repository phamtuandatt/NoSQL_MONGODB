using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Do_An_NoSQL.Object;

namespace Do_An_NoSQL.GUI
{
    public partial class frmCT_HD : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("QL_SANPHAM");
        public frmCT_HD()
        { 
            InitializeComponent();
            
        }

        public frmCT_HD(string id_hd, string tenKH, string diaChi)
        {
            InitializeComponent();
            show_ct_hd(id_hd);
            txtTenKH.Text = tenKH;
            txtDC.Text = diaChi;
        }

        public void show_ct_hd(string id_hd)
        {
            var collection = db.GetCollection<CT_HOADON>("CT_HoaDonBan");
            
            var hd = collection.Find(h => h.MaHD == id_hd).ToList();

            dataGridCT_HD.DataSource = hd;
        }
    }
}
