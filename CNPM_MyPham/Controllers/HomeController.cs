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
using Domain.Interfaces;
using Application.Services;
using Application.DTOs;
using Application.DTOs.CurrentUserDTO;

namespace CNPM_MyPham.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoaiSanPhamService LSPservice;

        public HomeController(LoaiSanPhamService LSPservice)
        {
            this.LSPservice = LSPservice;
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

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
        [HttpPost]
        public IActionResult LoadCartForLayOut(){
            var currentuser = SessionHelper.GetObjectFromJson<CurrentUserDto>(HttpContext.Session, "CurrentUser");
            if(currentuser != null){
                return new JsonResult(currentuser.DonHangDto.ListSP);
            }
            var donhang = SessionHelper.GetObjectFromJson<DonHangDto>(HttpContext.Session, "DonHang");
            if(donhang != null){
                return new JsonResult(donhang.ListSP);
            }
            return new JsonResult(null);
        }

        public void View_Chung(){
            // Lấy session User hiện hành
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUserDto>(HttpContext.Session, "CurrentUser");

            // Lấy session Don Hang
            ViewBag.DonHang = SessionHelper.GetObjectFromJson<DonHangDto>(HttpContext.Session, "DonHang");

            // Lấy danh sách loại sản phẩm cho danh mục
            ViewBag.Danhmuc = LSPservice.LoaiSanPham_GetAll();
        }
    }
}
