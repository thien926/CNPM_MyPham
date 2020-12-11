using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CNPM_MyPham.Controllers
{
    public class DetailCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
