using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class ChuyenXe
    {
        [Key]
        public string? ChuyenXeID { get; set; }
        public string? TenChuyen { get; set; } = null!;
        public string? DiemXuatPhat { get; set; } = null!;
        public DateTime ThoiGianDi { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public string? TuyenXeID { get; set; }
        public string? XeID { get; set; }
        public virtual  ICollection<VeXe> VeXe { get; } = new List<VeXe>(); 
        public virtual TuyenXe TuyenXe { get; set; } = null!;
        public virtual Xe Xe { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachChuyenXe
    {
        [Key]
        public string? ChuyenXeID { get; set; }
        public string? TenChuyen { get; set; } = null!;
        public string? DiemXuatPhat { get; set; } = null!;
        public DateTime ThoiGianDi { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public string? TuyenXeID { get; set; }
        public string? TenTuyen { get; set; } = null!;
        public string? XeID { get; set; }
        public string? BienSo { get; set; } = null!;
    }
}
