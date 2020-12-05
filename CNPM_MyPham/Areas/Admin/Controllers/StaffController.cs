using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaffController : Controller
    {
        private readonly NhanVienService NVservice;
        public StaffController(NhanVienService NVservice){
            this.NVservice = NVservice;
        }
        public IActionResult Index()
        {
            var ListNV = NVservice.NhanVien_GetAll();
            return View(ListNV);
        }
    }
}
