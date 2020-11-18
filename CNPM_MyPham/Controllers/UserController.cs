using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class UserController : Controller
    {
        private readonly LoaiSanPhamEFContext LSPcontext;

        public UserController(LoaiSanPhamEFContext LSPcontext){
            this.LSPcontext = LSPcontext;
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
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUser>(HttpContext.Session, "CurrentUser");

            // Lấy session Don Hang
            ViewBag.DonHang = SessionHelper.GetObjectFromJson<DonHang>(HttpContext.Session, "DonHang");
            
            // Lấy danh sách loại sản phẩm cho danh mục
            ViewBag.Danhmuc = LSPcontext.LoaiSanPham_GetAll();
        }
    }
}