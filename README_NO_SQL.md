# HotelManagement MVC - giao diện mẫu không dùng SQL

Project ASP.NET Core MVC dùng các trang Razor `.cshtml` và dữ liệu phòng mẫu viết sẵn trong `Models/RoomSamples.cs`.

## Điểm chính
- Không dùng SQL Server, Entity Framework, DbContext hay database.
- Đã bỏ thư mục `DataAccess` và các interface/repository lưu trữ.
- Danh sách phòng lấy từ dữ liệu mẫu viết trực tiếp trong mã nguồn.
- Nút **Chi tiết** chuyển sang trang chi tiết phòng.
- Nút **Đặt phòng** chuyển sang trang minh họa đặt phòng đã thiết kế sẵn.
- Không lưu thông tin đặt phòng, đăng nhập hoặc đăng ký.

## Chạy project
1. Giải nén file ZIP.
2. Mở `HotelManagement.sln` bằng Visual Studio 2022.
3. Chọn `HotelManagement` làm Startup Project.
4. Nhấn `F5`.

Các trang đặt phòng/đăng nhập/đăng ký chỉ là giao diện minh họa, phù hợp bài tập frontend cơ bản.
