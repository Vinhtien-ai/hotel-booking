using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class RoomController : Controller
    {
        [HttpGet]
        public IActionResult Index(string loaiphong = null, DateTime? ngayden = null, DateTime? ngaydi = null)
        {
       
            var rooms = RoomSamples.GetAll();
            if (!string.IsNullOrWhiteSpace(loaiphong))
                rooms = rooms.Where(p => p.MaLoaiPhong == loaiphong).ToList();

            var model = new LoaiPhongPhongTrangThaiPhong
            {
                phongs = rooms,
                loaiphongs = RoomSamples.GetAll().Select(r => r.MaLoaiPhongNavigation).GroupBy(x => x.MaLoaiPhong).Select(g => g.First()).ToList(),
                selectedLoaiPhong = loaiphong,
                NgayDen = ngayden,
                NgayDi = ngaydi
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var phong = RoomSamples.GetAll().FirstOrDefault(p => p.MaPhong == id);
            if (phong == null) return RedirectToAction(nameof(Index));
            return View(phong);
        }
    }

    public class LoaiPhongPhongTrangThaiPhong
    {
        public IEnumerable<LoaiPhong> loaiphongs { get; set; } = new List<LoaiPhong>();
        public IEnumerable<Phong> phongs { get; set; } = new List<Phong>();
        public string selectedLoaiPhong { get; set; }
        public DateTime? NgayDen { get; set; }
        public DateTime? NgayDi { get; set; }
    }
}
