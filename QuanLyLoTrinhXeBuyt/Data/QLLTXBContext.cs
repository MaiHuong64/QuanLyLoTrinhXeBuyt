﻿using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class QLLTXBContext : DbContext
    {
        public DbSet<TuyenXe> TuyenXe { get; set; }
        public DbSet<ChuyenXe> ChuyenXe { get; set; }
        public DbSet<TramXe> TramXe { get; set; }   
        public DbSet<XeBuyt> XeBuyt { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<TuyenXe_ChiTiet> TuyenXe_ChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLLTXBConnection"].ConnectionString);
        }
    }
}
