using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;
using CNPM_MyPham.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TypeController : Controller
    {
        private readonly LoaiSanPhamService LSPservice;
        private readonly SanPhamService SPservice;
        public TypeController(LoaiSanPhamService LSPservice, SanPhamService SPservice)
        {
            this.LSPservice = LSPservice;
            this.SPservice = SPservice;
        }
        public IActionResult Index()
        {
            var IndexType = new IndexViewTypeModel();
            IndexType.ListLSP = LSPservice.LoaiSanPham_GetAll();
            return View(IndexType);
        }

        [HttpPost]
        public IActionResult EditLSP(int product_type_id)
        {
            var LSP = LSPservice.LoaiSanPham_GetById(product_type_id);
            if(LSP == null)
            {
                return new JsonResult(-1);
            }
            return new JsonResult(LSP);
        }

        [HttpPost]
        public IActionResult SubmitEditLSP(int product_type_id, string name, string description)
        {
            var LSP = new LoaiSanPhamDto(product_type_id, name, description);
            LSPservice.SanPham_Update(LSP);
            return new JsonResult(1);
        }

        [HttpPost]
        public IActionResult RemoveLSP(int product_type_id)
        {
            SPservice.SanPham_RemoveBy_Product_Type_Id(product_type_id);
            LSPservice.LoaiSanPham_Remove(product_type_id);
            return new JsonResult("ok");
        }
    }
}
