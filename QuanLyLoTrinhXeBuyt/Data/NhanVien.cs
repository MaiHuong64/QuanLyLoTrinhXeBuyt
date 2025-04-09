using System;
using System.ComponentModel.DataAnnotations;
namespace QuanLyLoTrinhXeBuyt.Data
{
    public class NhanVien
    {
        [Key]
        public string? NhanVienID { get; set; }
        public string? HoTen { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? ChucVu { get; set; }
        public string? TenDangNhap { get; set; } = null!;
        public string? MatKhau { get; set; } = null!;
        public string? QuyenHan { get; set; } = null!;
        public virtual ICollection<Xe> Xe { get; } = new List<Xe>();
    }
}
