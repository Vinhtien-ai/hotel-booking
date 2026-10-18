using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class SignupController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new PersonAndAccount { p = new Person(), a = new TaiKhoan() });
        }

        [HttpPost]
        public IActionResult Index(PersonAndAccount data)
        {
            ViewBag.Message = "Đây là giao diện minh họa, thông tin chưa được lưu.";
            data.p ??= new Person();
            data.a ??= new TaiKhoan();
            return View(data);
        }
    }

    public class PersonAndAccount
    {
        public Person p { get; set; } = new Person();
        public TaiKhoan a { get; set; } = new TaiKhoan();
        public string confirm { get; set; }
    }
}
