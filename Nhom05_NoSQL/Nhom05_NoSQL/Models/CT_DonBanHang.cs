using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhom05_NoSQL.Models
{
    public class CT_DonBanHang
    {

        [BsonElement("MaHD")]
        public string MaHD { get; set; }
        [BsonElement("MaSP")]
        public string MaSP { get; set; }
        [BsonElement("TenSP")]
        public string TenSP { get; set; }
        [BsonElement("SoLuong")]
        public int SoLuong { get; set; }
        [BsonElement("GiaBan")]
        public int GiaBan { get; set; }
    }
}