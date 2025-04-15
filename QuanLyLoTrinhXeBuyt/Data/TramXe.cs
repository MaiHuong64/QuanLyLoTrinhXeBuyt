using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TramXe
    {
        [Key]
        public string? TramXeID { get; set; }
        public string? TenTramXe { get; set; }
        public virtual ObservableCollection<TuyenXe_TramXe> TuyenXe_DiemDung { get; } = new();
    }
}
