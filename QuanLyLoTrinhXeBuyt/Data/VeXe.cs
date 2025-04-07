using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class VeXe
    {
        [Key]
        public string? MaVe { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; }
        public string? LoaiVe { get; set; } = null!;

    }
}
