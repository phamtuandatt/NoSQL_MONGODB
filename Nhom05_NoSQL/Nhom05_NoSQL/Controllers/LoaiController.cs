using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using Nhom05_NoSQL.App_Start;
using MongoDB.Driver;
using Nhom05_NoSQL.Models;

namespace Nhom05_NoSQL.Controllers
{
    public class LoaiController : Controller
    {
        //
        // GET: /Loai/
        public MongoDBContext dbcontext;
        public IMongoCollection<Loai> loaiCollection;
        public IMongoCollection<Sanpham> SPCollection;
        public LoaiController()
        {
            dbcontext = new MongoDBContext();
            loaiCollection = dbcontext.database.GetCollection<Loai>("LoaiSanPham");
            SPCollection = dbcontext.database.GetCollection<Sanpham>("SanPham");
        }

        public ActionResult LoaiPartial()
        {
            List<Loai> loai = loaiCollection.AsQueryable<Loai>().ToList();

            return View(loai);

        }
        public ActionResult SanPhamTheoLoai(string maloai)
        {
            //var loaiid = new ObjectId(maloai);
            var tenloai = loaiCollection.Find(e => e.MaLoai == maloai).FirstOrDefault();
            ViewBag.ten = tenloai.TenLoai;

            var listsp = SPCollection.AsQueryable<Sanpham>().Where(x => x.MaLoai == maloai).ToList();
            if (listsp.Count == 0)
            {
                ViewBag.ThongBao = "KHÔNG CÓ SẢN PHẨM NÀO THUỘC LOẠI NÀY!";
            }
            return View(listsp);
        }

       

    }
}
