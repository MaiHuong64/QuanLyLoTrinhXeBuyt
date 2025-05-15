using Microsoft.EntityFrameworkCore;
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

namespace QuanLyLoTrinhXeBuyt.Reports
{
    public partial class InPhanCongNhanVien : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        QLLTXBDataSet.DanhSachPhanCongDataTable danhSachPhanCong = new QLLTXBDataSet.DanhSachPhanCongDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã chuyến
        public InPhanCongNhanVien(int machuyen = 0)
        {
            InitializeComponent();
            id = machuyen;
        }

        private void InPhanCongNhanVien_Load(object sender, EventArgs e)
        {
            var pc = context.PhanCong.Where(x => x.ChuyenXeID == id).SingleOrDefault();
            if (pc != null)
            {
                var phancong = context.PhanCong.Where(x => x.ChuyenXeID == id).Select(r => new DanhSachPhanCong
                {
                    PhanCongID = r.PhanCongID,
                    ChuyenXeID = r.ChuyenXeID,
                    NhanVienID = r.NhanVienID,
                    NgayLamViec = r.NgayLamViec,
                    HoTen = r.NhanVien.HoTen,
                    TenChuyen = r.ChuyenXe.TenChuyen,
                    VaiTro = r.NhanVien.VaiTro,

                }).ToList();

                danhSachPhanCong.Clear();
                foreach (var row in phancong)
                {
                    danhSachPhanCong.AddDanhSachPhanCongRow(row.PhanCongID,
                        row.ChuyenXeID,
                        row.NhanVienID,
                        row.NgayLamViec,
                        row.HoTen,
                        row.TenChuyen,
                        row.VaiTro);
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsPhanCong";
                reportDataSource.Value = danhSachPhanCong;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhanCongNhanVien.rdlc");

                //IList<ReportParameter> parameters = new List<ReportParameter>
                //{
                //    new ReportParameter("NgayLap", string.Format($"Ngày {pc.NgayLamViec.Day} Tháng {pc.NgayLamViec.Month} Năm {pc.NgayLamViec.Year}"),

                //};

            }
            
        }
    }
}
