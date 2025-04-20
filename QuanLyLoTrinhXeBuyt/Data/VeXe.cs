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
         [ForeignKey("LoaiVe")]
        public int MaLoaiVe { get; set; }
        [ForeignKey("ChuyenXe")]
        public int ChuyenXeID { get; set; }
        public virtual LoaiVe LoaiVe { get; set; } = null!;
        public virtual ChuyenXe ChuyenXe { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachVeXe
    {
        public int VeXeID { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; } = null!
        public int MaLoaiVe { get; set; } = null!
        public string TenLoaiVe {get; set;} = null!
        public int ChuyenXeID { get; set; } = null!
        public string TenChuyen { get; set; } = null!
    }
}
