using CNPM_MyPham.Data;
using CNPM_MyPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class LoginController : Controller
    {
        private readonly KhachHangEFContext context;

        public LoginController(KhachHangEFContext context){
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index(){
            LayUserCurrent();
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel lg){
            if(ModelState.IsValid){
                KhachHang kh = context.KhachHang_GetByUser(lg.user);
                if(kh == null){
                    return View(lg);
                }
                else if(kh.pass != lg.pass){
                    return View(lg);
                }
                CurrentUser U = new CurrentUser();
                U.KhachHang = kh;
                //ViewData["script"] = "<script>alert('Đăng nhập thành công');</script>";
                SessionHelper.SetObjectAsJson(HttpContext.Session, "CurrentUser", U);
                //ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUser>(HttpContext.Session, "CurrentUser");
                LayUserCurrent();
                return View();
            }
            return View(lg);
        }

        public void LayUserCurrent(){
            ViewBag.CurrentUser = SessionHelper.GetObjectFromJson<CurrentUser>(HttpContext.Session, "CurrentUser");
            // if(ViewBag.CurrentUser == null){
            //     ViewData["script"] = "";
            // }
        }
    }
}