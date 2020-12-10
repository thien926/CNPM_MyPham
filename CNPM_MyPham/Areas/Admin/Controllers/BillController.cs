using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;
using CNPM_MyPham.Areas.Admin.Models;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillController : Controller
    {
        private readonly HoaDonService hdservice;
        private readonly QuyenService Qservice;
        public BillController(HoaDonService hdservice, QuyenService Qservice){
            this.hdservice = hdservice;
            this.Qservice = Qservice;
        }
        public IActionResult Index()
        {
            if(!ViewChung()){
                return Redirect("/Admin/Login/Index");
            }
            var IndexBill = new IndexViewHoaDonModel();
            IndexBill.ListHD = hdservice.HoaDon_GetAll();
            return View(IndexBill);
        }

        public bool ViewChung(){
            ViewBag.CurrentUserAdmin = SessionHelper.GetObjectFromJson<NhanVienDto>(HttpContext.Session, "CurrentUserAdmin");
            
            if(ViewBag.CurrentUserAdmin == null){
                return false;
            }
            ViewBag.QuyenCurrentUserAdmin = Qservice.Quyen_GetById(ViewBag.CurrentUserAdmin.permission_id);
            return true;
        }
    }
}
