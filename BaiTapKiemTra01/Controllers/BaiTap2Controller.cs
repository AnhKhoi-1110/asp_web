using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class BaiTap2Controller : Controller
    {
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel
            {
                TenSp = " BMW ",

                GiaBan = " 7 tỷ"
            };
            return View(sanpham);
        }
    }
}