using CNPM_MyPham.Models;
using Infrastructure.Persistence;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Infrastructure;

namespace CNPM_MyPham.Controllers
{
    public class ShopController : Controller
    {
        private readonly LoaiSanPhamEFContext LSPcontext;
        private readonly ThuongHieuEFContext THcontext;
        private readonly SanPhamEFContext SPcontext;
        public ShopController(LoaiSanPhamEFContext LSPcontext, ThuongHieuEFContext THcontext, SanPhamEFContext SPcontext){
            this.LSPcontext = LSPcontext;
            this.THcontext = THcontext;
            this.SPcontext = SPcontext;
        }

        public IActionResult Index(string Type, string Brand, string SearchString, string price, int pageIndex = 1)
        {
            View_Chung();
            //var listSP = SPcontext.SanPham_GetAll();

            int pageSize = 9;
            int count;
            decimal pricemax;
            string NameType;
            if(!string.IsNullOrEmpty(Type)){
                NameType = LSPcontext.LoaiSanPham_GetById(int.Parse(Type)).name;
                SearchString = null;
            }
            else{
                NameType = null;
            }
             
            var SanPhams = SPcontext.SanPham_Filter(Type, Brand, SearchString, pageIndex, pageSize, out count, out pricemax, price);
            var indexVSM = new IndexViewShopModel()
            {
                ListSP = new PaginatedList<SanPham>(SanPhams, count, pageIndex, pageSize),
                ListTH = THcontext.ThuongHieu_GetAll(),
                ListLSP = LSPcontext.LoaiSanPham_GetAll(),
                Type = Type,
                NameType = NameType,
                Brand = Brand,
                SearchString = SearchString,
                pricemax = pricemax,
                price = price
            };
            return View(indexVSM);
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