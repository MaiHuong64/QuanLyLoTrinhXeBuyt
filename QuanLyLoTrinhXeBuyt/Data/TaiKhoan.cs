using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TaiKhoan
    {
        [Key]
        public int TaiKhoanID { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string QuyenHan { get; set; } = null!;
        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

}
