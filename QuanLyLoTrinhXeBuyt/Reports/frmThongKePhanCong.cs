using DocumentFormat.OpenXml.InkML;
using Microsoft.Reporting.WinForms;
using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyLoTrinhXeBuyt.Reports.QLLTXBDataSet;

namespace QuanLyLoTrinhXeBuyt.Reports
{
    public partial class frmThongKePhanCong : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        QLLTXBDataSet.DanhSachPhanCongDataTable danhSachPhanCongDataTable = new QLLTXBDataSet.DanhSachPhanCongDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKePhanCong()
        {
            InitializeComponent();
        }

        private void frmThongKePhanCong_Load(object sender, EventArgs e)
        {
            var danhSachPhanCong = context.PhanCong.Select(r => new
            {
                r.PhanCongID,
                r.NhanVienID,
                r.ChuyenXeID,
                r.NgayLamViec,
                r.NhanVien.HoTen,
                r.ChuyenXe.TenChuyen,
                r.NhanVien.VaiTro
            }).ToList();

            danhSachPhanCongDataTable.Clear();
            foreach (var row in danhSachPhanCong)
            {
                danhSachPhanCongDataTable.AddDanhSachPhanCongRow(
                    row.PhanCongID,
                    row.ChuyenXeID,
                    row.NhanVienID,
                    row.NgayLamViec,
                    row.HoTen,
                    row.TenChuyen,
                    row.VaiTro
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsPhanCong";
            reportDataSource.Value = danhSachPhanCongDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKePhanCong.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", $"Tất cả bảng phân công");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var danhSachPhanCong = context.PhanCong.Select(r => new DanhSachPhanCong
            {
                PhanCongID = r.PhanCongID,
                ChuyenXeID = r.ChuyenXeID,
                NhanVienID = r.NhanVienID,
                NgayLamViec = r.NgayLamViec,
                HoTen = r.NhanVien.HoTen,
                TenChuyen = r.ChuyenXe.TenChuyen,
                VaiTro = r.NhanVien.VaiTro

            });

            danhSachPhanCong = danhSachPhanCong.Where(r => r.NgayLamViec >= dtpTuNgay.Value && r.NgayLamViec <= dtpDenNgay.Value);
            
            danhSachPhanCongDataTable.Clear();
            foreach (var row in danhSachPhanCong)
            {
                danhSachPhanCongDataTable.AddDanhSachPhanCongRow(
                    row.PhanCongID,
                    row.ChuyenXeID,
                    row.NhanVienID,
                    row.NgayLamViec,
                    row.HoTen,
                    row.TenChuyen,
                    row.VaiTro
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsPhanCong";
            reportDataSource.Value = danhSachPhanCongDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKePhanCong.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", $"Từ ngày: {dtpTuNgay.Text} đến ngày: {dtpDenNgay.Text}");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmThongKePhanCong_Load(sender, e);
        }
    }
}
