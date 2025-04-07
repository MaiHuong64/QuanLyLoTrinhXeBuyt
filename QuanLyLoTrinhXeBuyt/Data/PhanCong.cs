using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class PhanCong
    {
        public int ID { get; set; }
        public string? MaXe { get; set; }
        public string? MaNhanVien { get; set; }
        public DateTime NgayLamViec { get; set; }
        public virtual Xe Xe { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
