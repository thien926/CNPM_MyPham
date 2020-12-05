using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly KhachHangService KHservice;
        public CustomerController(KhachHangService KHservice){
            this.KHservice = KHservice;
        }
        public IActionResult Index()
        {
            var ListKH = KHservice.KhachHang_GetAll();
            return View(ListKH);
        }
    }
}
