using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Nhom05_NoSQL.Models
{
    public class Model_TK
    {

        [Required(ErrorMessage = "Bạn chưa nhập tài khoản")]
        [Display(Name = "Tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        public string Pass { get; set; }

        [Display(Name = "Ghi nhớ")]
        public bool? GhiNho { get; set; }

        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
    }
}