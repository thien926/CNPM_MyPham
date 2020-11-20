using Domain.Entities;
using Infrastructure.Persistence;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Application.Services;
using Application.DTOs;
using System;

namespace CNPM_MyPham.Controllers
{
    public class ProductController : Controller
    {
        private readonly SanPhamService SPservice;
        private readonly ThuongHieuService THservice;

        private readonly LoaiSanPhamService LSPservice;

        public ProductController(SanPhamService SPservice, ThuongHieuService THservice, LoaiSanPhamService LSPservice){
            this.SPservice = SPservice;
            this.THservice = THservice;
            this.LSPservice = LSPservice;
        }

        [HttpGet]
        [Route("Product/Index/{id?}")]
        public IActionResult Index(int id){
            View_Chung();
            SanPhamDto SP = SPservice.SanPham_GetById(id);
            Console.WriteLine(SP.product_id + " " + SP.name);
            ViewBag.TH = THservice.ThuongHieu_GetById(SP.brand_id).name;
            Console.WriteLine(ViewBag.TH);
            ViewBag.LSP = LSPservice.LoaiSanPham_GetById(SP.product_type_id).name;
            Console.WriteLine(ViewBag.LSP);
            return View(SP);
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