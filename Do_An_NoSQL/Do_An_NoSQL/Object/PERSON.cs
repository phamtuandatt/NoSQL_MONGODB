using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_NoSQL.Object
{
    class PERSON
    {
        ObjectId id;
        string username, pass, hoTen, gioiTinh, diaChi, sdt, ngaySinh;
        //int quyen;
        

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public ObjectId Id { get => id; set => id = value; }
    }
}
