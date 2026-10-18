namespace HotelManagement.Models
{
    // Dữ liệu phòng viết sẵn để minh họa giao diện, không lưu vào database.
    public static class RoomSamples
    {
        public static List<Phong> GetAll()
        {
            var don = new LoaiPhong { MaLoaiPhong = "LP01", TenLoaiPhong = "Phòng đơn", GiaPhong = 350000 };
            var doi = new LoaiPhong { MaLoaiPhong = "LP02", TenLoaiPhong = "Phòng đôi", GiaPhong = 500000 };
            var giaDinh = new LoaiPhong { MaLoaiPhong = "LP03", TenLoaiPhong = "Phòng gia đình", GiaPhong = 750000 };
            var vip = new LoaiPhong { MaLoaiPhong = "LP04", TenLoaiPhong = "Phòng VIP", GiaPhong = 900000 };

            return new List<Phong>
            {
                new Phong { MaPhong = "P101", TenPhong = "Phòng đơn 101", MoTaPhong = "Phòng sạch sẽ, phù hợp cho một người lưu trú.", MaTrangThai = "TT01", MaLoaiPhong = don.MaLoaiPhong, HinhAnh = "phongdon.png", SoNguoi = 1, DienTich = 20, GiaPhong = 350000, MaLoaiPhongNavigation = don },
                new Phong { MaPhong = "P201", TenPhong = "Phòng đôi 201", MoTaPhong = "Phòng thoải mái dành cho hai người.", MaTrangThai = "TT01", MaLoaiPhong = doi.MaLoaiPhong, HinhAnh = "phongdoi.png", SoNguoi = 2, DienTich = 28, GiaPhong = 500000, MaLoaiPhongNavigation = doi },
                new Phong { MaPhong = "P301", TenPhong = "Phòng gia đình 301", MoTaPhong = "Không gian rộng cho gia đình nhỏ.", MaTrangThai = "TT01", MaLoaiPhong = giaDinh.MaLoaiPhong, HinhAnh = "phonggiadinh.jpg", SoNguoi = 4, DienTich = 35, GiaPhong = 750000, MaLoaiPhongNavigation = giaDinh },
                new Phong { MaPhong = "P401", TenPhong = "Phòng VIP 401", MoTaPhong = "Phòng nghỉ tiện nghi với không gian rộng rãi.", MaTrangThai = "TT01", MaLoaiPhong = vip.MaLoaiPhong, HinhAnh = "phongvip.jpg", SoNguoi = 2, DienTich = 40, GiaPhong = 900000, MaLoaiPhongNavigation = vip }
            };
        }
    }
}
