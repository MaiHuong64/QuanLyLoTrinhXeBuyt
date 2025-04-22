using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class ChuyenXe
    {
        [Key]
        public int ChuyenXeID { get; set; }
        public string? TenChuyen { get; set; } = null!;
        public string? DiemXuatPhat { get; set; } = null!;
        public DateTime ThoiGianDi { get; set; }
        public int TuyenXeID { get; set; }
        public int XeID { get; set; }
        public virtual TuyenXe TuyenXe { get; set; } = null!;
        public virtual XeBuyt Xe { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachChuyenXe
    {
        public int ChuyenXeID { get; set; }
        public string? TenChuyen { get; set; } = null!;
        public string? DiemXuatPhat { get; set; } = null!;
        public DateTime ThoiGianDi { get; set; }
        public int TuyenXeID { get; set; }
        public string? TenTuyen { get; set; } = null!;
        public int XeID { get; set; }
        public string? BienSo { get; set; } = null!;
    }
}
