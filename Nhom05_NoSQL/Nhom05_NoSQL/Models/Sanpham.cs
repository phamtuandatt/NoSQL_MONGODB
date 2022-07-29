using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Nhom05_NoSQL.Models
{
    public class Sanpham
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("TenSP")]
        public string TenSP { get; set; }
        [BsonElement("GiaBan")]
        public int GiaBan { get; set; }
        [BsonElement("MoTa")]
        public string MoTa { get; set; }
        [BsonElement("SoLuong")]
        public int SoLuong { get; set; }
        [BsonElement("AnhBia")]
        public string AnhBia { get; set; }
        [BsonElement("MaLoai")]
        public string MaLoai { get; set; }
        [BsonElement("MaSP")]
        public string MaSP { get; set; }
    }
}