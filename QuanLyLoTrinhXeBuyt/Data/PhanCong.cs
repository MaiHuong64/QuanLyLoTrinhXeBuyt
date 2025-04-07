using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class PhanCong
    {
        public int PhanCongID { get; set; }
        public string? XeID { get; set; }
        public string? NhanVienID { get; set; }
        public DateTime NgayLamViec { get; set; }
        public virtual Xe Xe { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
