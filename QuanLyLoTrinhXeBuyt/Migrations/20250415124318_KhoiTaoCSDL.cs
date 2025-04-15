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
                    NhanVienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_NhanVien", x => x.NhanVienID);
                });

            migrationBuilder.CreateTable(
                name: "TramXe",
                columns: table => new
                {
                    TramXeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTramXe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramXe", x => x.TramXeID);
                });

            migrationBuilder.CreateTable(
                name: "TuyenXe",
                columns: table => new
                {
                    TuyenXeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuyenXe", x => x.TuyenXeID);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    XeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BienSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGhe = table.Column<int>(type: "int", nullable: false),
                    LoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.XeID);
                    table.ForeignKey(
                        name: "FK_Xe_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "NhanVienID");
                });

            migrationBuilder.CreateTable(
                name: "TuyenXe_ChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuyenXeID = table.Column<int>(type: "int", nullable: false),
                    TramXeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuyenXe_ChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TuyenXe_ChiTiet_TramXe_TramXeID",
                        column: x => x.TramXeID,
                        principalTable: "TramXe",
                        principalColumn: "TramXeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuyenXe_ChiTiet_TuyenXe_TuyenXeID",
                        column: x => x.TuyenXeID,
                        principalTable: "TuyenXe",
                        principalColumn: "TuyenXeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenXe",
                columns: table => new
                {
                    ChuyenXeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemXuatPhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianDi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TuyenXeID = table.Column<int>(type: "int", nullable: false),
                    XeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenXe", x => x.ChuyenXeID);
                    table.ForeignKey(
                        name: "FK_ChuyenXe_TuyenXe_TuyenXeID",
                        column: x => x.TuyenXeID,
                        principalTable: "TuyenXe",
                        principalColumn: "TuyenXeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuyenXe_Xe_XeID",
                        column: x => x.XeID,
                        principalTable: "Xe",
                        principalColumn: "XeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    PhanCongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XeID = table.Column<int>(type: "int", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    NgayLamViec = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => x.PhanCongID);
                    table.ForeignKey(
                        name: "FK_PhanCong_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "NhanVienID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCong_Xe_XeID",
                        column: x => x.XeID,
                        principalTable: "Xe",
                        principalColumn: "XeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeXe",
                columns: table => new
                {
                    VeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaVe = table.Column<float>(type: "real", nullable: false),
                    LoaiVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenXeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeXe", x => x.VeID);
                    table.ForeignKey(
                        name: "FK_VeXe_ChuyenXe_ChuyenXeID",
                        column: x => x.ChuyenXeID,
                        principalTable: "ChuyenXe",
                        principalColumn: "ChuyenXeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenXe_TuyenXeID",
                table: "ChuyenXe",
                column: "TuyenXeID");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenXe_XeID",
                table: "ChuyenXe",
                column: "XeID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_NhanVienID",
                table: "PhanCong",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_XeID",
                table: "PhanCong",
                column: "XeID");

            migrationBuilder.CreateIndex(
                name: "IX_TuyenXe_ChiTiet_TramXeID",
                table: "TuyenXe_ChiTiet",
                column: "TramXeID");

            migrationBuilder.CreateIndex(
                name: "IX_TuyenXe_ChiTiet_TuyenXeID",
                table: "TuyenXe_ChiTiet",
                column: "TuyenXeID");

            migrationBuilder.CreateIndex(
                name: "IX_VeXe_ChuyenXeID",
                table: "VeXe",
                column: "ChuyenXeID");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_NhanVienID",
                table: "Xe",
                column: "NhanVienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "TuyenXe_ChiTiet");

            migrationBuilder.DropTable(
                name: "VeXe");

            migrationBuilder.DropTable(
                name: "TramXe");

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
