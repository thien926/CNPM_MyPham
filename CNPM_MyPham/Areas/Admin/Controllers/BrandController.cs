using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly ThuongHieuService THservice;
        private readonly QuyenService Qservice;
        public BrandController(ThuongHieuService THservice, QuyenService Qservice){
            this.THservice = THservice;
            this.Qservice = Qservice;
        }
        public IActionResult Index()
        {
            if(!ViewChung()){
                return Redirect("/Admin/Login/Index");
            }
            var ListTH = THservice.ThuongHieu_GetAll();
            return View(ListTH);
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
