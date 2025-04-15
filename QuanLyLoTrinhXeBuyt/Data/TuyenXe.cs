    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace QuanLyLoTrinhXeBuyt.Data
    {
        public class TuyenXe
        {
            [Key]
            public int TuyenXeID { get; set; }
            public string? TenTuyen { get; set; }
            public string? MoTa { get; set; }
            public virtual ObservableCollection<TuyenXe_ChiTiet> TuyenXe_DiemDung { get; } = new(); // 1 - n
            public virtual ObservableCollection<ChuyenXe> ChuyenXe { get; } = new();
        }
        [NotMapped]
        public class DanhSachTuyenXe
        {
            public int TuyenXeID { get; set; }
            public string? TenTuyen { get; set; }
            public int TramXeID { get; set; }
            public string? TenTram { get; set; }
            public string? MoTa { get; set; }
            public string? XemChiTiet { get; set; }
        }
    }