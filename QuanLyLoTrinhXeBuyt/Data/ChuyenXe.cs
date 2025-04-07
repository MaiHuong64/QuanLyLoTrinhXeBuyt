using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class ChuyenXe
    {
        [Key]
        public string? MaChuyen { get; set; }
        public string? TenChuyen { get; set; } = null!;
        public string? DiemXuatPhat { get; set; } = null!;
        public DateTime ThoiGianDi { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public string? MaTuyen { get; set; }
        public string? MaXe { get; set; }
        public virtual  ICollection<VeXe> VeXe { get; } = new List<VeXe>(); 
        public virtual TuyenXe TuyenXe { get; set; } = null!;
        public virtual Xe Xe { get; set; } = null!;
    }
}
