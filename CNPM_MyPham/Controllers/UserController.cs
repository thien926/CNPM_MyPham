using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Application.Services;
using Application.DTOs;

namespace CNPM_MyPham.Controllers
{
    public class UserController : Controller
    {
        private readonly LoaiSanPhamService LSPservice;

        public UserController(LoaiSanPhamService LSPservice){
            this.LSPservice = LSPservice;
        }
        [HttpGet]
        public IActionResult Index(){
            View_Chung();
            if(ViewBag.CurrentUser == null){
                return Redirect("/Login/Index");
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