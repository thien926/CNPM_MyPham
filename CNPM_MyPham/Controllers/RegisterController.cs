using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class RegisterController : Controller
    {
        private readonly KhachHangEFContext KHcontext;

        private readonly LoaiSanPhamEFContext LSPcontext;

        public RegisterController(KhachHangEFContext KHcontext, LoaiSanPhamEFContext LSPcontext){
            this.KHcontext = KHcontext;
            this.LSPcontext = LSPcontext;
        }

        [HttpGet]
        public IActionResult Index(){
            View_Chung();
            return View();
        }

        [HttpPost]
        public IActionResult Index(KhachHang U){
            if(ModelState.IsValid){
                KhachHang kh = KHcontext.KhachHang_GetByUser(U.user);
                if(kh == null){
                    KHcontext.KhachHang_Add(U);
                    CurrentUser currentuser = new CurrentUser();
                    currentuser.KhachHang = U;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "CurrentUser", currentuser);
                    View_Chung();
                    U = null;
                    ViewBag.Message_Register = "Đăng kí thành công!";
                    return View();
                }
                ModelState.AddModelError("", "Tài khoản đã tồn tại!");
            }
            return View(U);
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