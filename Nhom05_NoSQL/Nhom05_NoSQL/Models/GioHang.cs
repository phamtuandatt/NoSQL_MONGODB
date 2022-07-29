using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using System.Web;

namespace Nhom05_NoSQL.Models
{
    public class GioHang
    {
        public Sanpham sp { get; set; }
        public int iSoLuong { get; set; }
        public double? iThanhTien
        {
            get
            {

                return iSoLuong * sp.GiaBan;

            }
        }
    }
}