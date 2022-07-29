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
using PagedList;
using System.Globalization;

namespace Nhom05_NoSQL.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        public MongoDBContext dbcontext;
        public IMongoCollection<Sanpham> SPCollection;
        public IMongoCollection<Loai> loaiCollection;
        public SanPhamController()
        {
            dbcontext = new MongoDBContext();
            loaiCollection = dbcontext.database.GetCollection<Loai>("LoaiSanPham");
            SPCollection = dbcontext.database.GetCollection<Sanpham>("SanPham");
        }

        public ActionResult TatCaSanPham(int? page)
        {
            if (page == null) page = 1;
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            List<Sanpham> sp = SPCollection.AsQueryable<Sanpham>().ToList();
            return View(sp.ToPagedList(pageNumber, pageSize));

        }
        public ActionResult ChiTietSanPham(string id)
        {

            var ctsp = SPCollection.AsQueryable<Sanpham>().SingleOrDefault(x => x.MaSP == id);
            var tenloai = loaiCollection.Find(e => e.MaLoai == ctsp.MaLoai).FirstOrDefault();
            ViewBag.tenloai = tenloai.TenLoai;
            return View(ctsp);
        }
        //GET : /SanPham/TimKiem : trang tìm kiếm sp
        [HttpGet]
        public ActionResult SearchResult(int? page, string key)
        {
            ViewBag.Key = key;

            //phân trang
            int pageNumber = (page ?? 1);
            int pageSize = 9;
            var result = SPCollection.AsQueryable<Sanpham>().Where(x => x.TenSP.Contains(key)).ToList().ToPagedList(pageNumber, pageSize);
            if (result.Count == 0 || key == null || key == "")
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View(result);
            }
            ViewBag.ThongBao = "Hiện có " + result.Count + " kết quả ở trang này";

            return View(result);
        }

        //POST : /Home/SearchResult : thực hiện việc tìm kiếm sách
        [HttpPost]
        public ActionResult SearchResult(int? page, FormCollection f)
        {
            //gán từ khóa tìm kiếm được nhập từ client
            string key = f["txtSearch"].ToString();
            ViewBag.Key = key;

            string s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(key);
            //phân trang
            int pageNumber = (page ?? 1);
            int pageSize = 9;

            var result = SPCollection.AsQueryable<Sanpham>().Where(x => x.TenSP.Contains(s)).ToList().ToPagedList(pageNumber, pageSize);

            if (result.Count == 0 || key == null || key == "")
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View(result);
            }
            ViewBag.ThongBao = "Hiện có " + result.Count + " kết quả ở trang này";

            return View(result);
        }


    }
}
