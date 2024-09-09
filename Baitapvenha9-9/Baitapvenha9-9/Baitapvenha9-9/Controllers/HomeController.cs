using Baitapvenha9_9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baitapvenha9_9.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Hoàng Anh Khôi";
            ViewBag.MSSV = "1822040937";
            ViewData["Nam"] = "Năm 2004";
            return View();
        }


    }

}