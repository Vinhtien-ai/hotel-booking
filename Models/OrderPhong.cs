using System;
using System.Collections.Generic;

namespace HotelManagement.Models
{
    public partial class OrderPhong
    {
        public OrderPhong()
        {
            HoaDons = new HashSet<HoaDon>();
            OrderPhongDichVus = new HashSet<OrderPhongDichVu>();
        }

        public string MaOrderPhong { get; set; } = null!;
        public DateTime? NgayDen { get; set; }
        public DateTime? NgayDi { get; set; }
        public string PersonId { get; set; } = null!;
        public string MaPhong { get; set; } = null!;
        public int TrangThaiThanhToan { get; set; } = 0; // 0: Đặt trước/Chờ nhận phòng, 1: Đang thuê/Nhận phòng, 2: Đã thanh toán, 3: Đã hủy
        public int? SoKhach { get; set; } = 1;
        public float? TongTien { get; set; }
        public string? GhiChu { get; set; }

        public virtual Phong MaPhongNavigation { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<OrderPhongDichVu> OrderPhongDichVus { get; set; }
    }
}