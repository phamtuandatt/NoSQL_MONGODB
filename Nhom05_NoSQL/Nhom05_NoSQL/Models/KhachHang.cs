using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace Nhom05_NoSQL.Models
{
    public class KhachHang
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [Required(ErrorMessage = "Tài khoản không được để trống")]
        [BsonElement("Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [BsonElement("Pass")]
        public string Pass { get; set; }
        [BsonElement("HoTen")]
        [Required(ErrorMessage = "Không được để trống tên")]
        public string HoTen { get; set; }

        [BsonElement("NgaySinh")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddThh:mm:ss}")]
        [Display(Name = "NgaySinh")]
        public String NgaySinh { get; set; }

        [BsonElement("GioiTinh")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [BsonElement("DiaChi")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "SDT không được để trống")]
        [BsonElement("Sdt")]
        public string Sdt { get; set; }
    }
}