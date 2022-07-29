using MongoDB.Driver;
using Nhom05_NoSQL.App_Start;
using Nhom05_NoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhom05_NoSQL.Controllers
{
    public class TaiKhoanController : Controller
    {
        //Khởi tạo biến dữ liệu : db
        public MongoDBContext dbcontext;
        public IMongoCollection<KhachHang> TKCollection;
        public TaiKhoanController()
        {
            dbcontext = new MongoDBContext();
            TKCollection = dbcontext.database.GetCollection<KhachHang>("KhachHang");
        }
        public static KhachHang tkstatic;
        // GET: /TaiKhoan/

        //GET : /User/Login : đăng nhập tài khoản
        //Parital View : Login


        public ActionResult Login()
        {
            return PartialView();
        }
        //POST : /User/Login : thực hiện đăng nhập
        [HttpPost]
        [ChildActionOnly]
        public ActionResult Login(Model_TK model)
        {
            //kiểm tra hợp lệ dữ liệu
            if (ModelState.IsValid)
            {
                //gọi hàm đăng nhập trong UserProcess và gán dữ liệu trong biến model
                var result = TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == model.Username && x.Pass == model.Pass);
                if (result != null)
                {
                    //gán Session["LoginAdmin"] bằng dữ liệu đã đăng nhập
                    Session["User"] = model.Username;
                    var t1 = TKCollection.AsQueryable<KhachHang>().Where(x => x.Username == model.Username).FirstOrDefault();
                    tkstatic = t1;
                    //trả về trang chủ

                    return RedirectToAction("TatCaSanPham", "SanPham");

                }
                else
                {
                    Response.Write("<script>alert('Tài Khoản hoặc mật khẩu không đúng !!!')</script>");
                }

            }

            return PartialView();
        }
        //GET : /User/LoginPage : trang đăng nhập

        public ActionResult PageDangNhap()
        {
            return View();
        }

        //POST : /User/LoginPage : thực hiện đăng nhập
        [HttpPost]
        public ActionResult PageDangNhap(Model_TK model)
        {
            //kiểm tra hợp lệ dữ liệu
            if (ModelState.IsValid)
            {
                //gọi hàm đăng nhập trong UserProcess và gán dữ liệu trong biến model
                var result = TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == model.Username && x.Pass == model.Pass);
                if (result != null)
                {
                    //gán Session["LoginAdmin"] bằng dữ liệu đã đăng nhập
                    Session["User"] = model.Username;
                    var t1 = TKCollection.AsQueryable<KhachHang>().Where(x => x.Username == model.Username).FirstOrDefault();
                    tkstatic = t1;
                    //trả về trang chủ

                    return RedirectToAction("TatCaSanPham", "SanPham");

                }

                else
                {
                    Response.Write("<script>alert('Tài Khoản hoặc mật khẩu không đúng !!!')</script>");
                }
            }

            return View();
        }


        //GET : /User/Logout : đăng xuất tài khoản khách hàng
        [HttpGet]
        public ActionResult DangXuat()
        {
            Session["User"] = null;
            tkstatic = null;
            return RedirectToAction("Index", "Home");
        }

        //GET : /User/ThongTinUser : cập nhật thông tin khách hàng
        [HttpGet]
        public ActionResult ThongTinUser()
        {
            //lấy dữ liệu từ session
            var model = Session["User"];

            if (ModelState.IsValid)
            {
                //tìm tên tài khoản
                var result = TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == model);
                //trả về dữ liệu tương ứng
                return View(result);
            }

            return View();
        }

        //POST : /User/UpdateUser : thực hiện việc cập nhật thông tin khách hàng
        [HttpPost]
        public ActionResult ThongTinUser(KhachHang model)
        {
            var use = Session["User"];
            var re = TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == use);
            var filter = Builders<KhachHang>.Filter.Eq("_id", (re._id));
            var update = Builders<KhachHang>.Update
                    .Set("Username", model.Username)
                    .Set("Pass", model.Pass)
                    .Set("HoTen", model.HoTen)
                    .Set("NgaySinh", model.NgaySinh)
                    .Set("GioiTinh", model.GioiTinh)
                    .Set("DiaChi", model.DiaChi)
                    .Set("Sdt", model.Sdt);
            var result = TKCollection.UpdateOne(filter, update);
            //thực hiện kiểm tra
            if (result != null)
            {

                return RedirectToAction("ThongTinUser");

            }
            else
            {
                ModelState.AddModelError("", "Cập nhật không thành công.");
            }

            return View();


        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(KhachHang model)
        {
            if (ModelState.IsValid)
            {
                if (TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == model.Username) != null)
                {
                    Response.Write("<script>alert('Tên đăng nhập đã tồn tại!!!')</script>");
                }
                else
                {
                    TKCollection.InsertOne(model);
                    return RedirectToAction("PageDangNhap", "TaiKhoan");
                }
            }

            return View();
        }
            
            

    }
}
