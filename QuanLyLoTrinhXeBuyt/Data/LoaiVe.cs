using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class LoaiVe
    {
        public int LoaiVeID { get; set; }
        public string TenLoaiVe { get; set; }
        public virtual ObservableCollectionListSource<VeXe> VeXe { get; } = new();
    }
}
