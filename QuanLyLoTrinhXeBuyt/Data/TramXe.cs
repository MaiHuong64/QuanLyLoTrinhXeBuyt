using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TramXe
    {
        [Key]
        public int TramXeID { get; set; }
        public string? TenTramXe { get; set; }
        public virtual ObservableCollection<TuyenXe_ChiTiet> TuyenXe_ChiTiet { get; } = new();
    }
}
