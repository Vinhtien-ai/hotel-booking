using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var rooms = RoomSamples.GetAll();
            var model = new HomeViewModel
            {
                LoaiPhongs = rooms.Select(r => r.MaLoaiPhongNavigation).GroupBy(x => x.MaLoaiPhong).Select(g => g.First()).ToList(),
                FeaturedPhongs = rooms.Take(4).ToList()
            };
            return View(model);
        }
    }

    public class HomeViewModel
    {
        public List<LoaiPhong> LoaiPhongs { get; set; } = new List<LoaiPhong>();
        public List<Phong> FeaturedPhongs { get; set; } = new List<Phong>();
    }
}
