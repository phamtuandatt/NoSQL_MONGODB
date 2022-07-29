using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_NoSQL.Object
{
    class SP
    {
        ObjectId id;
        string maSP;
        string maLoai;
        string tenSP, moTa, anhBia;
        int soLuong, giaBan;
        Image anh;
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public ObjectId Id { get => id; set => id = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string AnhBia { get => anhBia; set => anhBia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public Image Anh
        {
            get
            {
                if (AnhBia.Length > 10)
                    return Image.FromFile(AnhBia);
                return Image.FromFile(projectPath + "\\Image\\" + AnhBia);
            }
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }

        public SP()
        {

        }

        public SP(ObjectId MaLoai, string TenSP, string MoTa, string AnhBia, int SoLuong, int GiaBan)
        {
            //this.MaLoai = MaLoai;
            //this.TenSP = TenSP;
            //this.MoTa = MoTa;
            //this.AnhBia = AnhBia;
            //this.SoLuong = SoLuong;
            //this.GiaBan = GiaBan;
        }
    }
}
