using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Nhom05_NoSQL.Models
{
    public class DonDatHang
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("HoTen")]
        public string HoTen { get; set; }
        [BsonElement("NgayDat")]
        public DateTime NgayDat { get; set; }
        [BsonElement("TongSL")]
        public int TongSL { get; set; }
        [BsonElement("DiaChiGH")]
        public string DiaChiGH { get; set; }
        [BsonElement("ThanhTien")]
        public Double ThanhTien { get; set; }
        //[BsonElement("SanPham")]
        //public List<SanPhamHD> SP { get; set; }

        //public DonDatHang()
        //{
        //    this.SP = new List<SanPhamHD>();
        //}

        //public class SanPhamHD
        //{
        //    [BsonElement("MaSP")]
        //    public string MaSP { get; set; }
        //    [BsonElement("TenSP")]
        //    public string TenSP { get; set; }
        //    [BsonElement("SoLuong")]
        //    public int SoLuong { get; set; }
        //    [BsonElement("GiaBan")]
        //    public int GiaBan { get; set; }

        //}
    }
}