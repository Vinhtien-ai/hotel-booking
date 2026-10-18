using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class BookingController : Controller
    {
        [HttpGet]
        public IActionResult Index(string id)
        {
            var room = RoomSamples.GetAll().FirstOrDefault(p => p.MaPhong == id);
            if (room == null) return RedirectToAction("Index", "Room");
            return View(room);
        }
    }
}
