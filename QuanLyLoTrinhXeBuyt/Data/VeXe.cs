using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class VeXe
    {
        [Key]
        public int VeID { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; }
        public string? LoaiVe { get; set; } = null!;
        public int ChuyenXeID { get; set; }

    }
}
