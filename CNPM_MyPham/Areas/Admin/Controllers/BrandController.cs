using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly ThuongHieuService THservice;
        public BrandController(ThuongHieuService THservice){
            this.THservice = THservice;
        }
        public IActionResult Index()
        {
            var ListTH = THservice.ThuongHieu_GetAll();
            return View(ListTH);
        }
    }
}
