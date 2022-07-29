using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Do_An_NoSQL.Object
{
    class LOAISANPHAM
    {
        ObjectId id;
        string maLoai;
        string tenLoai;

        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public ObjectId Id { get => id; set => id = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
    }
}
