using CNPM_MyPham.Data;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class ProductController : Controller
    {
        private readonly SanPhamEFContext SPcontext;
        private readonly ThuongHieuEFContext THcontext;

        private readonly LoaiSanPhamEFContext LSPcontext;

        public ProductController(SanPhamEFContext SPcontext, ThuongHieuEFContext THcontext, LoaiSanPhamEFContext LSPcontext){
            this.SPcontext = SPcontext;
            this.THcontext = THcontext;
            this.LSPcontext = LSPcontext;
        }

        [HttpGet]
        [Route("Product/Index/{id?}")]
        public IActionResult Index(int id){
            SanPham SP = SPcontext.SanPham_GetById(id);
            ViewBag.TH = THcontext.ThuongHieu_GetById(SP.brand_id).name;
            ViewBag.LSP = LSPcontext.LoaiSanPham_GetById(SP.product_type_id).name;
            return View(SP);
        }
    }
}