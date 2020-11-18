using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class LoginController : Controller
    {
        private readonly KhachHangEFContext KHcontext;
        private readonly LoaiSanPhamEFContext LSPcontext;

        public LoginController(KhachHangEFContext KHcontext, LoaiSanPhamEFContext LSPcontext){
            this.KHcontext = KHcontext;
            this.LSPcontext = LSPcontext;
        }

        [HttpGet]
        public IActionResult Index(){
            View_Chung();
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel lg){
            if(ModelState.IsValid){
                KhachHang kh = KHcontext.KhachHang_GetByUser(lg.user);
                if(kh == null){
                    return View(lg);
                }
                else if(kh.pass != lg.pass){
                    return View(lg);
                }
                CurrentUser U = new CurrentUser();
                U.KhachHang = kh;
                SessionHelper.SetObjectAsJson(HttpContext.Session, "CurrentUser", U);
                ViewBag.Message_Login = "Đăng nhập thành công!";
                View_Chung();
                return View();
            }
            return View(lg);
        }

        public void View_Chung(){
            // Lấy session User hiện hành
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUser>(HttpContext.Session, "CurrentUser");

            // Lấy session Don Hang
            ViewBag.DonHang = SessionHelper.GetObjectFromJson<DonHang>(HttpContext.Session, "DonHang");
            
            // Lấy danh sách loại sản phẩm cho danh mục
            ViewBag.Danhmuc = LSPcontext.LoaiSanPham_GetAll();
        }
    }
}