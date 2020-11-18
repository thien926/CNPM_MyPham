using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;

namespace CNPM_MyPham.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoaiSanPhamEFContext LSPcontext;

        public HomeController(LoaiSanPhamEFContext LSPcontext)
        {
            this.LSPcontext = LSPcontext;
        }

        public IActionResult Index()
        {
            View_Chung();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
