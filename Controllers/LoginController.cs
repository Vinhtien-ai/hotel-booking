using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new TaiKhoan());

        [HttpPost]
        public IActionResult Index(TaiKhoan account)
        {
        
            return View(account);
        }
    }
}
