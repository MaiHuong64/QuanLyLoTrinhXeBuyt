using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyLoTrinhXeBuyt.Data
{
    public class QLLTXBContext : DbContext
    {
        public DbSet<TuyenXe> TuyenXe { get; set; }
        public DbSet<ChuyenXe> ChuyenXe { get; set; }
        public DbSet<TramXe> TramXe { get; set; }   
        public DbSet<Xe> Xe { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<VeXe> VeXe { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<TuyenXe_TramXe> TuyenXe_TramXe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLLTXBConnection"].ConnectionString);
        }
    }
}
