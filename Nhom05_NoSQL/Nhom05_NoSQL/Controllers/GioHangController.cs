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
using System.Web.Script.Serialization;


namespace Nhom05_NoSQL.Controllers
{
    public class GioHangController : Controller
    {
        
           public MongoDBContext dbcontext;
            public IMongoCollection<Loai> loaiCollection;
            public IMongoCollection<Sanpham> SPCollection;
            public IMongoCollection<KhachHang> TKCollection;
            public IMongoCollection<DonDatHang> DHCollection;
            public IMongoCollection<CT_DonBanHang> CTDHCollection;
            public GioHangController()
            {
                dbcontext = new MongoDBContext();
                loaiCollection = dbcontext.database.GetCollection<Loai>("LoaiSanPham");
                SPCollection = dbcontext.database.GetCollection<Sanpham>("SanPham");
                TKCollection = dbcontext.database.GetCollection<KhachHang>("KhachHang");
                DHCollection = dbcontext.database.GetCollection<DonDatHang>("HoaDonBan");
                CTDHCollection = dbcontext.database.GetCollection<CT_DonBanHang>("CT_HoaDonBan");
            }
       
            //tạo 1 chuỗi hằng để gán session
            private const string GioHang = "GioHang";

            // GET: GioHang/ : trang giỏ hàng
            [HttpGet]
            public ActionResult Index()
            {
                var cart = Session[GioHang];
                var list = new List<GioHang>();
                var sluong = 0;
                double? thanhtien = 0;
                if (cart != null)
                {
                    list = (List<GioHang>)cart;
                    sluong = list.Sum(x => x.iSoLuong);
                    thanhtien = list.Sum(x => x.iThanhTien);
                }
                ViewBag.Quantity = sluong;
                ViewBag.Total = thanhtien;
                return View(list);
            }
                //GET : /GioHang/CartIcon: đếm sổ sản phẩm trong giỏ hàng
                //PartialView : CartIcon
                public ActionResult CartIcon()
                {
                    var cart = Session[GioHang];
                    var list = new List<GioHang>();
                    if (cart != null)
                    {
                        list = (List<GioHang>)cart;
                    }

                    return PartialView(list);
            }
                //GET : /GioHang/ThemGioHang/?id=?&quantity=1 : thêm sản phẩm vào giỏ hàng
                public ActionResult ThemGioHang(string id, int soluong)
                {
                    //lấy mã sp và gán đối tượng
                    var idsp = new ObjectId(id);
                    var masp = SPCollection.AsQueryable<Sanpham>().SingleOrDefault(x => x._id == idsp);

                    //lấy giỏ hàng từ session
                    var cart = Session[GioHang];

                    //nếu đã có sản phẩm trong giỏ hàng
                    if (cart != null)
                    {
                        var list = (List<GioHang>)cart;
                        //nếu tồn tại 
                        if (list.Exists(x => x.sp._id == idsp))
                        {

                            foreach (var item in list)
                            {
                                if (item.sp._id == idsp)
                                {
                                    item.iSoLuong += soluong;
                                }
                            }
                        }
                        //nếu chưa tồn tại khởi tạo giỏ hàng
                        else
                        {
                            //tạo mới đối tượng cart item
                            var item = new GioHang();
                            item.sp = masp;
                            item.iSoLuong = soluong;
                            list.Add(item);
                        }

                        //Gán vào session
                        Session[GioHang] = list;
                    }
                    //nếu chưa đã có sản phẩm trong giỏ hàng
                    else
                    {
                        //tạo mới giỏ hàng
                        var item = new GioHang();
                        item.sp = masp;
                        item.iSoLuong = soluong;
                        var list = new List<GioHang>();
                        list.Add(item);

                        //gán vào session
                        Session[GioHang] = list;
                    }

                    return RedirectToAction("Index");
                }
        /// <summary>
        /// ///////////////////
     
                [HttpPost]
                public JsonResult Delete(string id)
                {
                    var idsp = new ObjectId(id);
                    var sessionCart = (List<GioHang>)Session[GioHang];
                    //xóa những giá trị mà có mã sách giống với id
                    sessionCart.RemoveAll(x => x.sp._id == idsp);
                    //gán lại giá trị cho session
                    Session[GioHang] = sessionCart;

                    return Json(new
                    {
                        status = true
                    });
                }
                //Xóa tất cả các sản phẩm trong giỏ hàng
                public JsonResult DeleteAll()
                {
                    Session[GioHang] = null;
                    return Json(new
                    {
                        status = true
                    });
                }
                //Cập nhật giỏ hàng
                public JsonResult Update(string cartModel)
                {

                  
                    var jsonCart = new JavaScriptSerializer().Deserialize<List<GioHang>>(cartModel);

                    //ép kiểu từ session
                    var sessionCart = (List<GioHang>)Session[GioHang];

                    foreach (var item in sessionCart)
                    {
                        var jsonItem = jsonCart.Single(x => x.sp.MaSP== item.sp.MaSP);
                        if (jsonItem != null)
                        {
                            item.iSoLuong = jsonItem.iSoLuong;
                        }
                    }
                    //cập nhật lại session
                    Session[GioHang] = sessionCart;

                    return Json(new
                    {
                        status = true
                    });
                }


                //Thông tin khách hàng
                [HttpGet]
                [ChildActionOnly]
                public PartialViewResult ThongTinKhachHang()
                {
                    //lấy dữ liệu từ session
                    var model = Session["User"];

                    if (ModelState.IsValid)
                    {
                        //tìm tên tài khoản
                        var result = TKCollection.AsQueryable<KhachHang>().SingleOrDefault(x => x.Username == model);

                        //trả về dữ liệu tương ứng
                        return PartialView(result);
                    }

                    return PartialView();
                }
                [HttpGet]
                public ActionResult ThanhToan()
                {
                    //kiểm tra đăng nhập
                    if (Session["User"] == null || Session["User"].ToString() == "")
                    {
                        return RedirectToAction("PageDangNhap", "TaiKhoan");
                    }
                    else
                    {

                        var cart = Session[GioHang];
                        var list = new List<GioHang>();
                        var sl = 0;
                        double? total = 0;
                        if (cart != null)
                        {
                            list = (List<GioHang>)cart;
                            sl = list.Sum(x => x.iSoLuong);
                            total = list.Sum(x => x.iThanhTien);
                        }
                        ViewBag.Quantity = sl;
                        ViewBag.Total = total;
                        return View(list);
                    }
                }

                [HttpPost]
                public ActionResult ThanhToan(string TenKH,string DiaChi, FormCollection f)
                {
                   
                    if (ModelState.IsValid)
                    {
                        var order = new DonDatHang();
                        var cart = (List<GioHang>)Session["GioHang"];
                  
                        var list = new List<GioHang>();
                        var sl = 0;
                        double? total = 0;
                        if (cart != null)
                        {
                            list = (List<GioHang>)cart;
                            sl = list.Sum(x => x.iSoLuong);
                            total = list.Sum(x => x.iThanhTien);
                        }
                       
                        
                       ViewBag.Quantity = sl;
                        ViewBag.Total = total;
                        order.NgayDat = DateTime.Now;
                       
                        order.HoTen= TenKH;
                        order.DiaChiGH = DiaChi;
                        order.TongSL= ViewBag.Quantity;
                        order.ThanhTien = ViewBag.Total;
                        DHCollection.InsertOne(order);
                        //thêm dữ liệu vào đơn đặt hàng
                        //List<DonDatHang.SanPhamHD> listabc = new List<DonDatHang.SanPhamHD>();
                        foreach (var item in cart)
                        {
                  
                           
                                //DonDatHang.SanPhamHD abl = new DonDatHang.SanPhamHD();
                                //abl.MaSP = item.sp.MaSP;
                                //abl.TenSP = item.sp.TenSP;
                                //abl.SoLuong = Convert.ToInt32(item.iSoLuong);
                                //abl.GiaBan = item.sp.GiaBan;
                                //listabc.Add(abl);
                                    var orderDetail = new CT_DonBanHang();
                                    
                                    orderDetail.MaHD = order._id.ToString();
                                    orderDetail.MaSP = item.sp.MaSP;
                                    orderDetail.TenSP = item.sp.TenSP;
                                    orderDetail.SoLuong = item.iSoLuong;
                                    orderDetail.GiaBan = item.sp.GiaBan;

                                    CTDHCollection.InsertOne(orderDetail);
                                
                        }
                                    //order.SP.AddRange(listabc);
                                  
                            
                             ModelState.Clear();
                             Session[GioHang] = null;
                        return RedirectToAction("KiemTraThongBaoKichHoat", "GioHang");
                        }
                    return View();
                }
                public ActionResult KiemTraThongBaoKichHoat()
                {
                    return View();
                }
        }
    }

