using CNPM_MyPham.Data;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class RegisterController : Controller
    {
        private readonly KhachHangEFContext context;

        public RegisterController(KhachHangEFContext context){
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index(){
            LayUserCurrent();
            return View();
        }

        [HttpPost]
        public IActionResult Index(KhachHang U){
            if(ModelState.IsValid){
                KhachHang kh = context.KhachHang_GetByUser(U.user);
                if(kh == null){
                    context.KhachHang_Add(U);
                    CurrentUser currentuser = new CurrentUser();
                    currentuser.KhachHang = U;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "CurrentUser", currentuser);
                    LayUserCurrent();
                    U = null;
                    ViewBag.Message_Register = "Đăng kí thành công!";
                    return View();
                }
                ModelState.AddModelError("", "Tài khoản đã tồn tại!");
            }
            return View(U);
        }

        public void LayUserCurrent(){
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUser>(HttpContext.Session, "CurrentUser");
            // if(ViewBag.CurrentUser == null){
            //     ViewData["script"] = "";
            // }
        }
    }
}