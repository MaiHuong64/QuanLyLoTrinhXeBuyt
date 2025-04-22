using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class XeBuyt
    {
        [Key]
        public int XeID { get; set; }
        public string? BienSo { get; set; }
        public string? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
    }
}
