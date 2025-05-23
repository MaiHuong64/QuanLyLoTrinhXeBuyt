﻿using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.CustomUI;
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

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        int id;
        bool xuLyThem = false;  // Kiem tra xem co phai la them moi khong
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = true;
            txtTenChuyenXe.Enabled = giaTri;
            cboDiemXuatPhat.Enabled = giaTri;
            cboTuyenXe.Enabled = giaTri;
            cboXe.Enabled = giaTri;
            dtpThoiGianDi.Enabled = giaTri;
            dtpThoiGianDen.Enabled = giaTri;

        }
        public void LayTuyenXeVaoComboBox()
        {
            cboTuyenXe.DataSource = context.TuyenXe.ToList();
            cboTuyenXe.DisplayMember = "TenTuyen";
            cboTuyenXe.ValueMember = "TuyenXeID";
        }

        public void LayXeVaoComboBox()
        {
            cboXe.DataSource = context.XeBuyt.ToList();
            cboXe.DisplayMember = "BienSo";
            cboXe.ValueMember = "XeID";
        }
        public void LayDiemXuatPhat()
        {
            cboDiemXuatPhat.DataSource = context.TramXe.ToList();
            cboDiemXuatPhat.DisplayMember = "TenTramXe";
            cboDiemXuatPhat.ValueMember = "TramXeID";
        }
        private void frmChuyenXe_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            LayTuyenXeVaoComboBox();
            LayXeVaoComboBox();
            LayDiemXuatPhat();

            dvgChuyenXe.AutoGenerateColumns = false;
            if (dvgChuyenXe.Columns.Count == 0)
            {
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "ChuyenXeID", DataPropertyName = "ChuyenXeID", HeaderText = "Mã phân công" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenChuyen", DataPropertyName = "TenChuyen", HeaderText = "HTên chuyến" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiemXuatPhat", DataPropertyName = "DiemXuatPhat", HeaderText = "Điểm xuất phát" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "ThoiGianDi", DataPropertyName = "ThoiGianDi", HeaderText = "Thời gian đi" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "ThoiGianDen", DataPropertyName = "ThoiGianDen", HeaderText = "Thời gian đến" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTuyen", DataPropertyName = "TenTuyen", HeaderText = "Tuyến xe" });
                dvgChuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "BienSo", DataPropertyName = "BienSo", HeaderText = "Biển số" });
            }

            List<DanhSachChuyenXe> chuyenXe = new List<DanhSachChuyenXe>();

            chuyenXe = context.ChuyenXe.Select(r => new DanhSachChuyenXe
            {
                ChuyenXeID = r.ChuyenXeID,
                TenChuyen = r.TenChuyen,
                DiemXuatPhat = r.DiemXuatPhat,
                ThoiGianDi = r.ThoiGianDi,
                ThoiGianDen = r.ThoiGianDen,
                TuyenXeID = r.TuyenXeID,
                TenTuyen = r.TuyenXe.TenTuyen,
                XeID = r.XeID,
                BienSo = r.Xe.BienSo
            }).ToList();


            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = chuyenXe;

            txtTenChuyenXe.DataBindings.Clear();
            txtTenChuyenXe.DataBindings.Add("Text", bindingSource, "TenChuyen", true, DataSourceUpdateMode.Never);

            cboDiemXuatPhat.DataBindings.Clear();
            cboDiemXuatPhat.DataBindings.Add("Text", bindingSource, "DiemXuatPhat", true, DataSourceUpdateMode.Never);

            dtpThoiGianDi.DataBindings.Clear();
            dtpThoiGianDi.DataBindings.Add("Value", bindingSource, "ThoiGianDi", true, DataSourceUpdateMode.Never);

            dtpThoiGianDen.DataBindings.Clear();
            dtpThoiGianDen.DataBindings.Add("Value", bindingSource, "ThoiGianDen", true, DataSourceUpdateMode.Never);

            cboTuyenXe.DataBindings.Clear();
            cboTuyenXe.DataBindings.Add("SelectedValue", bindingSource, "TuyenXeID", true, DataSourceUpdateMode.Never);

            cboXe.DataBindings.Clear();
            cboXe.DataBindings.Add("SelectedValue", bindingSource, "XeID", true, DataSourceUpdateMode.Never);

            dvgChuyenXe.DataSource = bindingSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;
            txtTenChuyenXe.Text = "";
            cboDiemXuatPhat.Text = "";
            dtpThoiGianDi.Value = DateTime.Now;
            cboTuyenXe.Text = "";
            cboXe.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chuyến " + txtTenChuyenXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dvgChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString());
                ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                if (chuyenXe != null)
                {
                    context.Remove(chuyenXe);
                }
                context.SaveChanges();
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dvgChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDiemXuatPhat.Text) || string.IsNullOrWhiteSpace(txtTenChuyenXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboDiemXuatPhat.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboTuyenXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (xuLyThem)
                {
                    ChuyenXe chuyenXe = new ChuyenXe();
                    chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                    chuyenXe.DiemXuatPhat = cboDiemXuatPhat.Text;
                    chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                    chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                    chuyenXe.TuyenXeID = (int)cboTuyenXe.SelectedValue;
                    chuyenXe.XeID = (int)cboXe.SelectedValue;

                    context.ChuyenXe.Add(chuyenXe);

                }
                else
                {
                    ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                    if (chuyenXe != null)
                    {
                        chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                        chuyenXe.DiemXuatPhat = cboDiemXuatPhat.Text;
                        chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                        chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                        chuyenXe.TuyenXeID = (int)cboTuyenXe.SelectedValue;
                        chuyenXe.XeID = (int)cboXe.SelectedValue;

                        context.Update(chuyenXe);
                    }
                }
                context.SaveChanges();
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmChuyenXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnNhapFileExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                ChuyenXe chuyenXe = new ChuyenXe();
                                chuyenXe.TenChuyen = row["TenChuyen"].ToString() ?? "N/A";
                                chuyenXe.DiemXuatPhat = row["DiemXuatPhat"].ToString() ?? "N/A";
                                chuyenXe.ThoiGianDi = Convert.ToDateTime(row["ThoiGianDi"].ToString());
                                chuyenXe.ThoiGianDen = Convert.ToDateTime(row["ThoiGianDen"].ToString());
                                chuyenXe.TuyenXeID = Convert.ToInt32(row["TuyenXeID"].ToString());
                                chuyenXe.XeID = Convert.ToInt32(row["XeID"].ToString());
                                context.ChuyenXe.Add(chuyenXe);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmChuyenXe_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Xuất file excel";
                saveFileDialog.FileName = "ChuyenXe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            DataTable table = new DataTable();
                            table.Columns.Add("ChuyenXeID");
                            table.Columns.Add("TenChuyen");
                            table.Columns.Add("DiemXuatPhat");
                            table.Columns.Add("ThoiGianDi");
                            table.Columns.Add("ThoiGianDen");
                            table.Columns.Add("TuyenXeID");
                            table.Columns.Add("TenTuyen");
                            table.Columns.Add("XeID");
                            table.Columns.Add("BienSo");

                            var chuyenXe = context.ChuyenXe.Select(cx => new DanhSachChuyenXe
                            {
                                ChuyenXeID = cx.ChuyenXeID,
                                TenChuyen = cx.TenChuyen,
                                DiemXuatPhat = cx.DiemXuatPhat,
                                ThoiGianDi = cx.ThoiGianDi,
                                ThoiGianDen = cx.ThoiGianDen,
                                TuyenXeID = cx.TuyenXeID,
                                TenTuyen = cx.TuyenXe.TenTuyen,
                                XeID = cx.XeID,
                                BienSo = cx.Xe.BienSo,

                            }).ToList();

                            foreach (var item in chuyenXe)
                            {
                                table.Rows.Add(item.ChuyenXeID, item.TenChuyen, item.DiemXuatPhat, item.ThoiGianDi,
                                               item.ThoiGianDen, item.TuyenXeID, item.TenTuyen, item.XeID, item.BienSo);
                            }

                            var sheet = wb.Worksheets.Add(table, "ChuyenXe");
                            sheet.Columns().AdjustToContents();

                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower();

            var ketQua = context.ChuyenXe.Where(r => r.TenChuyen!.Contains(tuKhoa)).Select(r => new DanhSachChuyenXe
            {
                ChuyenXeID = r.ChuyenXeID,
                TenChuyen = r.TenChuyen,
                DiemXuatPhat = r.DiemXuatPhat,
                ThoiGianDi = r.ThoiGianDi,
                ThoiGianDen = r.ThoiGianDen,
                TuyenXeID = r.TuyenXeID,
                TenTuyen = r.TuyenXe.TenTuyen,
                XeID = r.XeID,
                BienSo = r.Xe.BienSo
            }).ToList();
            dvgChuyenXe.DataSource = ketQua;
        }
    }
}
