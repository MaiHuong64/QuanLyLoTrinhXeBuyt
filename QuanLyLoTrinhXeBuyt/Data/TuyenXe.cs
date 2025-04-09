using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TuyenXe
    {
        [Key]
        public string? TuyenXeID { get; set; }
        public string? TenTuyen { get; set; } = null!;
        public int SoChuyen { get; set; }
        public virtual ICollection<DiemDung> DiemDung { get; } = new List<DiemDung>();
        public virtual ICollection<ChuyenXe> ChuyenXe { get; } = new List<ChuyenXe>();
    }
}
