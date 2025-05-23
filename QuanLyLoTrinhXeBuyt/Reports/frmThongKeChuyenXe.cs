﻿using Microsoft.Reporting.WinForms;
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
    public partial class frmThongKeChuyenXe : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        QLLTXBDataSet.DanhSachChuyenXeDataTable danhSachChuyenXeDataTable = new QLLTXBDataSet.DanhSachChuyenXeDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeChuyenXe()
        {
            InitializeComponent();
        }
        public void LayTuyenXeVaoComboBox()
        {
            cboTuyenXe.DataSource = context.TuyenXe.ToList();
            cboTuyenXe.DisplayMember = "TenTuyen";
            cboTuyenXe.ValueMember = "TuyenXeID";
        }
        private void frmThongKeChuyenXe_Load(object sender, EventArgs e)
        {
            LayTuyenXeVaoComboBox();

            var danhSachChuyenXe = context.ChuyenXe.Select(x => new
            {
                x.ChuyenXeID,
                x.TenChuyen,
                x.DiemXuatPhat,
                x.ThoiGianDi,
                x.ThoiGianDen,
                x.TuyenXeID,
                x.TuyenXe.TenTuyen,
                x.XeID,
                x.Xe.BienSo
            }).ToList();

            danhSachChuyenXeDataTable.Clear();
            foreach (var row in danhSachChuyenXe)
            {
                danhSachChuyenXeDataTable.AddDanhSachChuyenXeRow(
                    row.ChuyenXeID,
                    row.TenChuyen,
                    row.DiemXuatPhat,
                    row.ThoiGianDi,
                    row.ThoiGianDen,
                    row.TuyenXeID,
                    row.TenTuyen,
                    row.XeID,
                    row.BienSo
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsChuyenXe";
            reportDataSource.Value = danhSachChuyenXeDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeChuyenXe.rdlc");

          

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Tất cả chuyến xe");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int tuyenCanTim = Convert.ToInt32(cboTuyenXe.SelectedValue);
            var danhSachChuyenXe = context.ChuyenXe.Where(x => x.TuyenXeID == tuyenCanTim).Select(x => new
            {
                x.ChuyenXeID,
                x.TenChuyen,
                x.DiemXuatPhat,
                x.ThoiGianDi,
                x.ThoiGianDen,
                x.TuyenXeID,
                x.TuyenXe.TenTuyen,
                x.XeID,
                x.Xe.BienSo
            }).ToList();

            danhSachChuyenXeDataTable.Clear();

            foreach (var row in danhSachChuyenXe)
            {
                danhSachChuyenXeDataTable.AddDanhSachChuyenXeRow(
                    row.ChuyenXeID,
                    row.TenChuyen,
                    row.DiemXuatPhat,
                    row.ThoiGianDi,
                    row.ThoiGianDen,
                    row.TuyenXeID,
                    row.TenTuyen,
                    row.XeID,
                    row.BienSo
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsChuyenXe";
            reportDataSource.Value = danhSachChuyenXeDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeChuyenXe.rdlc");

            string tentuyen = context.TuyenXe.Find(tuyenCanTim).TenTuyen;
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", $"Tuyến xe: {tentuyen}");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmThongKeChuyenXe_Load(sender, e);
        }
    }
}
