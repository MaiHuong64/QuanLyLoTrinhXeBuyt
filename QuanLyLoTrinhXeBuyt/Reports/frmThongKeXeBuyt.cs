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
    public partial class frmThongKeXeBuyt : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        QLLTXBDataSet.DanhSachXeBuytDataTable danhSachXeBuytDataTable = new QLLTXBDataSet.DanhSachXeBuytDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeXeBuyt()
        {
            InitializeComponent();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void frmThongKeXeBuyt_Load(object sender, EventArgs e)
        {
            var danhSachXeBuyt = context.XeBuyt.Select(r => new
            {
               r.XeID,
               r.BienSo,
               r.TrangThai,
               r.HinhAnh
            }).ToList();

            danhSachXeBuytDataTable.Clear();
            foreach (var row in danhSachXeBuyt)
            {
                danhSachXeBuytDataTable.AddDanhSachXeBuytRow(
                    row.XeID,
                    row.BienSo,
                    row.TrangThai,
                    row.HinhAnh
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsXeBuyt";
            reportDataSource.Value = danhSachXeBuytDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptXeBuyt.rdlc");

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}
