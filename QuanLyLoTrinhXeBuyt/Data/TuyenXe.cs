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
        public string TuyenXeID { get; set; }
        public string? TenTuyen { get; set; }
        public string? Ghichu { get; set; } 
        public virtual ObservableCollection<ChuyenXe> ChuyenXe { get; } = new();
        public virtual ObservableCollectionListSource<TuyenXe_TramXe> TuyenXe_TramXe { get; } = new();
    }
}