﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyLoTrinhXeBuyt.Data;

#nullable disable

namespace QuanLyLoTrinhXeBuyt.Migrations
{
    [DbContext(typeof(QLLTXBContext))]
    [Migration("20250407085606_KhoiTaoCSDL")]
    partial class KhoiTaoCSDL
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.ChuyenXe", b =>
                {
                    b.Property<string>("ChuyenXeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiemXuatPhat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianDen")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianDi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TuyenXeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("XeID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ChuyenXeID");

                    b.HasIndex("TuyenXeID");

                    b.HasIndex("XeID");

                    b.ToTable("ChuyenXe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.DiemDung", b =>
                {
                    b.Property<string>("DiemDungID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TuyenXeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tenDiemDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiemDungID");

                    b.HasIndex("TuyenXeID");

                    b.ToTable("DiemDung");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.NhanVien", b =>
                {
                    b.Property<string>("NhanVienID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuyenHan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDangNhap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NhanVienID");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.PhanCong", b =>
                {
                    b.Property<int>("PhanCongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhanCongID"));

                    b.Property<DateTime>("NgayLamViec")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("XeID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PhanCongID");

                    b.HasIndex("NhanVienID");

                    b.HasIndex("XeID");

                    b.ToTable("PhanCong");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.TuyenXe", b =>
                {
                    b.Property<string>("TuyenXeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoChuyen")
                        .HasColumnType("int");

                    b.Property<string>("TenTuyen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TuyenXeID");

                    b.ToTable("TuyenXe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.VeXe", b =>
                {
                    b.Property<string>("VeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChuyenXeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("GiaVe")
                        .HasColumnType("real");

                    b.Property<string>("LoaiVe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenVe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeID");

                    b.HasIndex("ChuyenXeID");

                    b.ToTable("VeXe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.Xe", b =>
                {
                    b.Property<string>("XeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BienSo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiXe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhanVienID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoGhe")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("XeID");

                    b.HasIndex("NhanVienID");

                    b.ToTable("Xe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.ChuyenXe", b =>
                {
                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.TuyenXe", "TuyenXe")
                        .WithMany("ChuyenXe")
                        .HasForeignKey("TuyenXeID");

                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.Xe", "Xe")
                        .WithMany()
                        .HasForeignKey("XeID");

                    b.Navigation("TuyenXe");

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.DiemDung", b =>
                {
                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.TuyenXe", "TuyenXe")
                        .WithMany("DiemDung")
                        .HasForeignKey("TuyenXeID");

                    b.Navigation("TuyenXe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.PhanCong", b =>
                {
                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienID");

                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.Xe", "Xe")
                        .WithMany()
                        .HasForeignKey("XeID");

                    b.Navigation("NhanVien");

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.VeXe", b =>
                {
                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.ChuyenXe", null)
                        .WithMany("VeXe")
                        .HasForeignKey("ChuyenXeID");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.Xe", b =>
                {
                    b.HasOne("QuanLyLoTrinhXeBuyt.Data.NhanVien", null)
                        .WithMany("Xe")
                        .HasForeignKey("NhanVienID");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.ChuyenXe", b =>
                {
                    b.Navigation("VeXe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.NhanVien", b =>
                {
                    b.Navigation("Xe");
                });

            modelBuilder.Entity("QuanLyLoTrinhXeBuyt.Data.TuyenXe", b =>
                {
                    b.Navigation("ChuyenXe");

                    b.Navigation("DiemDung");
                });
#pragma warning restore 612, 618
        }
    }
}
