using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class PhanCong
    {
        [Key]
        public int PhanCongID { get; set; }
        public int XeID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayLamViec { get; set; }
        public virtual Xe Xe { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
