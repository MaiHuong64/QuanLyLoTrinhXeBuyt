using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
   public class VeXe
   {
        [Key]
        public int VeXeID { get; set; }
        public string? TenVe { get; set; } = null!;
        public float GiaVe { get; set; }
        [ForeignKey("LoaiVe")]
        public int LoaiVeID { get; set; }
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
        public float GiaVe { get; set; }
        public int LoaiVeID { get; set; }
        public string? TenLoaiVe { get; set; }
        public int ChuyenXeID { get; set; }
        public string? TenChuyen { get; set; }
    }
}
