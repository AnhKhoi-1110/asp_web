using Microsoft.AspNetCore.Mvc;

namespace baitapvenha9_9.Controllers
{
    public class Tuan02Controller : Controller
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
