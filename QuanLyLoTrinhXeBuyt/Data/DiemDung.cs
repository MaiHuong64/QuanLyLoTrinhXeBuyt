﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLoTrinhXeBuyt.Data
{
    class DiemDung
    {
        [Key]
        public string? maDiemDung { get; set; }
        public string? maTuyen { get; set; }
        public string? tenDiemDung { get; set; }
        public virtual TuyenXe TuyenXe { get; set; } = null!;
    }
}
