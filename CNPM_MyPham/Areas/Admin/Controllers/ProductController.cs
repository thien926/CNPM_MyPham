using Application.Services;
using CNPM_MyPham.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly SanPhamService SPservice;
        private readonly ThuongHieuService THservice;
        private readonly LoaiSanPhamService LSPservice;
        public ProductController(SanPhamService SPservice, ThuongHieuService THservice, LoaiSanPhamService LSPservice)
        {
            this.SPservice = SPservice;
            this.THservice = THservice;
            this.LSPservice = LSPservice;
        }

        public IActionResult Index()
        {
            var IndexProduct = new IndexViewProductModel();
            IndexProduct.ListSP = SPservice.SanPham_GetAll();
            IndexProduct.ListTH = THservice.ThuongHieu_GetAll();
            IndexProduct.ListLSP = LSPservice.LoaiSanPham_GetAll();
            return View(IndexProduct);
        }

        [HttpPost]
        public IActionResult RemoveSP(int product_id)
        {
            //SPservice.SanPham_Remove(product_id);
            var SP = SPservice.SanPham_GetById(product_id);
            SP.status = 0;
            SPservice.SanPham_Update(SP);
            return new JsonResult("ok");
        }

        [HttpPost]
        public IActionResult BackSP(int product_id)
        {
            //SPservice.SanPham_Remove(product_id);
            var SP = SPservice.SanPham_GetById(product_id);
            SP.status = 1;
            SPservice.SanPham_Update(SP);
            return new JsonResult("ok");
        }
        [HttpPost]
        public IActionResult EditSP(int product_id)
        {
            var SP = SPservice.SanPham_GetById(product_id);
            if(SP == null){
                return new JsonResult(-1);
            }
            return new JsonResult(SP);
        }
    }
}