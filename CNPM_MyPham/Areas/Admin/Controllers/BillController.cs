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
        private readonly ChiTietHoaDonService cthdservice;
        public BillController(HoaDonService hdservice, QuyenService Qservice, ChiTietHoaDonService cthdservice){
            this.hdservice = hdservice;
            this.Qservice = Qservice;
            this.cthdservice = cthdservice;
        }

        [HttpPost]
        public IActionResult EditHD(int bill_id){
            var hd = hdservice.HoaDon_GetById(bill_id);
            if(hd == null)
            {
                return new JsonResult(-1);
            }
            return new JsonResult(hd);
        }

        [HttpPost]
        public IActionResult SubmitEditHD(int bill_id, int status)
        {
            var bill = hdservice.HoaDon_GetById(bill_id);
            if(bill.status > status){
                return new JsonResult(-1);
            }
            bill.status = status;
            if(bill.status == 3 || bill.status == 4){
                var usercurrent = SessionHelper.GetObjectFromJson<NhanVienDto>(HttpContext.Session, "CurrentUserAdmin");
                bill.user_nv = usercurrent.user;
                DateTime now = DateTime.Now;
                bill.date_receice = now;
            }
            hdservice.HoaDon_Update(bill);
            return new JsonResult(1);
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
