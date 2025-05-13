    using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
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
        public int TaiKhoanID { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        public virtual ObservableCollectionListSource<XeBuyt> XeBuyt { get; } = new ();
    }
    [NotMapped]
    public class DanhSachNhanVien
    {
        public int NhanVienID { get; set; }
        public string? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? VaiTro { get; set; }
        public int TaiKhoanID { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string QuyenHan {  get; set; }
    }
}
