using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class Xe
    {
        [Key]
        public string? XeID { get; set; }
        public string? BienSo { get; set; }
        public int SoGhe { get; set; }
        public string? LoaiXe { get; set; }
        public string? TrangThai { get; set; }
        
    }
}
