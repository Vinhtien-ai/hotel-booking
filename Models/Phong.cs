using System;
using System.Collections.Generic;

namespace HotelManagement.Models
{
    public partial class Phong
    {
        public Phong()
        {
            OrderPhongs = new HashSet<OrderPhong>();
        }

        public string MaPhong { get; set; } = null!;
        public string? TenPhong { get; set; }
        public string? MoTaPhong { get; set; }
        public string MaTrangThai { get; set; } = null!;
        public string MaLoaiPhong { get; set; } = null!;
        public string? HinhAnh { get; set; }
        public int? SoNguoi { get; set; } = 2;
        public int? DienTich { get; set; } = 25;
        public string? TienIch { get; set; }
        public float? GiaPhong { get; set; }

        public virtual LoaiPhong MaLoaiPhongNavigation { get; set; } = null!;
        public virtual TrangThaiPhong MaTrangThaiNavigation { get; set; } = null!;
        public virtual ICollection<OrderPhong> OrderPhongs { get; set; }
    }
}