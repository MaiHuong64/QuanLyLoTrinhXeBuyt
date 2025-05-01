using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class PhanCong
    {
        [Key]
        public int PhanCongID { get; set; }
        public int ChuyenXeID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayLamViec { get; set; }
        public virtual ChuyenXe ChuyenXe { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachPhanCong
    {
        public int PhanCongID { get; set; }
        public int ChuyenXeID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayLamViec { get; set; }
        public string? HoTen { get; set; }
        public string? TenChuyen { get; set; }
        public string? VaiTro { get; set; }
    }
}
