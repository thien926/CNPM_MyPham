using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using CNPM_MyPham.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PermissionController : Controller
    {
        private readonly QuyenService Qservice;
        public PermissionController(QuyenService Qservice){
            this.Qservice = Qservice;
        }
        public IActionResult Index()
        {
            var IndexQuyen = new IndexViewQuyenModel();
            IndexQuyen.ListQ = Qservice.Quyen_GetAll();
            return View(IndexQuyen);
        }
    }
}
