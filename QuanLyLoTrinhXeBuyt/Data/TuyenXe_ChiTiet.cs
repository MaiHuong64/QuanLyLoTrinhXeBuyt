using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class TuyenXe_ChiTiet
    {
        [Key]
        public int ID { get; set; }
        public int TuyenXeID { get; set; }
        public int TramXeID { get; set; }   
        public virtual TramXe? TramXe { get; set; }
        public virtual TuyenXe? TuyenXe { get; set; }
    }
    [NotMapped]
    public class DanhSachTuyenXe_ChiTiet
    {
        public int ID { get; set; }
        public int TuyenXeID { get; set; }
        public string? TenTuyen { get; set; }
        public int TramXeID { get; set; }
        public string? TenTramXe { get; set; }
        //public int Thutu { get; set; }
    }
}
