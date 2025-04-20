using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new (); 
        public virtual TuyenXe TuyenXe { get; set; } = null!;
        public virtual Xe Xe { get; set; } = null!;
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
        public int SoLuongVe { get; set; }
        public decimal TongTienVe { get; set; }
    }
}
