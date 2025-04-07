using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyLoTrinhXeBuyt.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyenHan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "TuyenXe",
                columns: table => new
                {
                    MaTuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoChuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuyenXe", x => x.MaTuyen);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    MaXe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BienSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGhe = table.Column<int>(type: "int", nullable: false),
                    LoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNV = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.MaXe);
                    table.ForeignKey(
                        name: "FK_Xe_NhanVien_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "DiemDung",
                columns: table => new
                {
                    maDiemDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maTuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenDiemDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuyenXeMaTuyen = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDung", x => x.maDiemDung);
                    table.ForeignKey(
                        name: "FK_DiemDung_TuyenXe_TuyenXeMaTuyen",
                        column: x => x.TuyenXeMaTuyen,
                        principalTable: "TuyenXe",
                        principalColumn: "MaTuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenXe",
                columns: table => new
                {
                    MaChuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemXuatPhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianDi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianDen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaTuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaXe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuyenXeMaTuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    XeMaXe = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenXe", x => x.MaChuyen);
                    table.ForeignKey(
                        name: "FK_ChuyenXe_TuyenXe_TuyenXeMaTuyen",
                        column: x => x.TuyenXeMaTuyen,
                        principalTable: "TuyenXe",
                        principalColumn: "MaTuyen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuyenXe_Xe_XeMaXe",
                        column: x => x.XeMaXe,
                        principalTable: "Xe",
                        principalColumn: "MaXe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaXe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayLamViec = table.Column<DateTime>(type: "datetime2", nullable: false),
                    XeMaXe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhanVienMaNV = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhanCong_NhanVien_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                    table.ForeignKey(
                        name: "FK_PhanCong_Xe_XeMaXe",
                        column: x => x.XeMaXe,
                        principalTable: "Xe",
                        principalColumn: "MaXe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeXe",
                columns: table => new
                {
                    MaVe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaVe = table.Column<float>(type: "real", nullable: false),
                    LoaiVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenXeMaChuyen = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeXe", x => x.MaVe);
                    table.ForeignKey(
                        name: "FK_VeXe_ChuyenXe_ChuyenXeMaChuyen",
                        column: x => x.ChuyenXeMaChuyen,
                        principalTable: "ChuyenXe",
                        principalColumn: "MaChuyen");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenXe_TuyenXeMaTuyen",
                table: "ChuyenXe",
                column: "TuyenXeMaTuyen");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenXe_XeMaXe",
                table: "ChuyenXe",
                column: "XeMaXe");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDung_TuyenXeMaTuyen",
                table: "DiemDung",
                column: "TuyenXeMaTuyen");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_NhanVienMaNV",
                table: "PhanCong",
                column: "NhanVienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_XeMaXe",
                table: "PhanCong",
                column: "XeMaXe");

            migrationBuilder.CreateIndex(
                name: "IX_VeXe_ChuyenXeMaChuyen",
                table: "VeXe",
                column: "ChuyenXeMaChuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_NhanVienMaNV",
                table: "Xe",
                column: "NhanVienMaNV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiemDung");

            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "VeXe");

            migrationBuilder.DropTable(
                name: "ChuyenXe");

            migrationBuilder.DropTable(
                name: "TuyenXe");

            migrationBuilder.DropTable(
                name: "Xe");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
