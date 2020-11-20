using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Application.Services;
using Application.DTOs;

namespace CNPM_MyPham.Controllers
{
    public class LoginController : Controller
    {
        private readonly KhachHangService KHservice;
        private readonly LoaiSanPhamService LSPservice;

        public LoginController(KhachHangService KHservice, LoaiSanPhamService LSPservice){
            this.KHservice = KHservice;
            this.LSPservice = LSPservice;
        }

        [HttpGet]
        public IActionResult Index(){
            View_Chung();
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModelDto lg){
            if(ModelState.IsValid){
                KhachHangDto kh = KHservice.KhachHang_GetByUser(lg.user);
                if(kh == null){
                    return View();
                }
                else if(kh.pass != lg.pass){
                    return View();
                }
                CurrentUserDto U = new CurrentUserDto();
                U.KhachHangDto = kh;
                SessionHelper.SetObjectAsJson(HttpContext.Session, "CurrentUser", U);
                ViewBag.Message_Login = "Đăng nhập thành công!";
                View_Chung();
                return View();
            }
            return View();
        }

        public void View_Chung(){
            // Lấy session User hiện hành
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUserDto>(HttpContext.Session, "CurrentUser");

            // Lấy session Don Hang
            ViewBag.DonHang = SessionHelper.GetObjectFromJson<DonHang>(HttpContext.Session, "DonHang");
            
            // Lấy danh sách loại sản phẩm cho danh mục
            ViewBag.Danhmuc = LSPservice.LoaiSanPham_GetAll();
        }
    }
}