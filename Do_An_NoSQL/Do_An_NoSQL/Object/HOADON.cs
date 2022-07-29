using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Do_An_NoSQL.Object
{
    class HOADON
    {
        ObjectId id;
        string hoTen, diaChiGH;
        int  tongSL, thanhTien;
        DateTime ngayDat;

        public ObjectId Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChiGH { get => diaChiGH; set => diaChiGH = value; }
        public int TongSL { get => tongSL; set => tongSL = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
    }
}
