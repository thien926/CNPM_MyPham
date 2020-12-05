using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public LoginController()
        {
            ViewBag.controller = "Login";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
