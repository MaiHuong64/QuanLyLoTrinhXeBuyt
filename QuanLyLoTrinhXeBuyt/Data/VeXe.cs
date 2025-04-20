using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class VeXe
    {
        [Key]
        public int VeXeID { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; }
        public string? LoaiVe { get; set; } = null!;
        public int ChuyenXeID { get; set; }
        public virtual ChuyenXe ChuyenXe { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachVeXe
    {
        public int VeID { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; }
        public string? LoaiVe { get; set; } = null!;
        public int ChuyenXeID { get; set; }
        public string TenChuyen { get; set; } = null!;
    }
}
