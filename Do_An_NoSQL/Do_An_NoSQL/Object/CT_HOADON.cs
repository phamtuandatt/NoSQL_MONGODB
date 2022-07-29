using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Do_An_NoSQL.Object
{
    class CT_HOADON
    {
        ObjectId id;
        string maHD, maSP, tenSP;
        int  soLuong, giaBan;

        public ObjectId Id { get => id; set => id = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
    }
}
