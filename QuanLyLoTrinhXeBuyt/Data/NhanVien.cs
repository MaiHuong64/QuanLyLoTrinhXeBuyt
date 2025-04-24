    using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations;
namespace QuanLyLoTrinhXeBuyt.Data
{
    public class NhanVien
    {
        [Key]
        public int NhanVienID { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? VaiTro { get; set; }
        public virtual ObservableCollectionListSource<XeBuyt> XeBuyt { get; } = new ();
    }
}
