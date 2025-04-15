using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TuyenXe_TramXe
    {
        public int ID { get; set; }
        public string? TuyenXeID { get; set; }
        public string? TramXeID { get; set; }
        public int Thutu { get; set; }
        public virtual TramXe? TramXe { get; set; }
        public virtual TuyenXe? TuyenXe { get; set; }
    }
}
