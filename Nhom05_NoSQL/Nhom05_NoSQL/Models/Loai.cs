using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace Nhom05_NoSQL.Models
{
    public class Loai
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public String MaLoai { get; set; }
        [BsonElement("TenLoai")]
        public string TenLoai { get; set; }
    }
}