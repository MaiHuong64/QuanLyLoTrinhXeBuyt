﻿using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class frmTuyenXe_ChiTiet : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        int id;
        BindingList<DanhSachTuyenXe_ChiTiet> tuyenXeChiTiet = new BindingList<DanhSachTuyenXe_ChiTiet>();

        frmTuyenXe frmTuyenXe = new frmTuyenXe();


        public frmTuyenXe_ChiTiet(int maTuyenXe)
        {
            InitializeComponent();
            id = maTuyenXe;
            this.frmTuyenXe = frmTuyenXe;
        }
        public bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenTuyen.Text))
            {
                MessageBox.Show("Tên tuyến xe không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTuyen.Focus();
                return false;
            }

            if (tuyenXeChiTiet.Count == 0)
            {
                MessageBox.Show("Tuyến xe phải có ít nhất một trạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public void LayTramXeVaoComboBox()
        {
            cboTramXe.DataSource = context.TramXe.ToList();
            cboTramXe.DisplayMember = "TenTramXe";
            cboTramXe.ValueMember = "TramXeID";
        }
        public void BatTatChucnang()
        {
            if (id == 0 && gridChiTiet.Rows.Count == 0)
            {
                cboTramXe.Text = "";
                txtGhiChu.Text = "";
                txtTenTuyen.Text = "";
                btnLuu.Enabled = gridChiTiet.Rows.Count > 0;
                btnThemTram.Enabled = gridChiTiet.Rows.Count > 0;
                btnXoaTram.Enabled = gridChiTiet.Rows.Count > 0;
            }
        }
        private void frmTuyenXe_TramXe_Load(object sender, EventArgs e)
        {
            LayTramXeVaoComboBox();

            gridChiTiet.AutoGenerateColumns = false;

            if (gridChiTiet.Columns.Count == 0)
            {
                gridChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTuyen", DataPropertyName = "TenTuyen", HeaderText = "Tên tuyến xe" });
                gridChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTramXe", DataPropertyName = "TenTramXe", HeaderText = "Tên trạm xe" });
                //gridChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", DataPropertyName = "MoTa", HeaderText = "Ghi chú" });
            }

            gridChiTiet.DataSource = tuyenXeChiTiet;

            //Thêm dữ liệu để sửa
            if (id != 0)
            {
                var tuyenXe = context.TuyenXe.Where(r => r.TuyenXeID == id).SingleOrDefault();
                txtTenTuyen.Text = tuyenXe.TenTuyen;
                txtGhiChu.Text = tuyenXe.MoTa;

                var ct = context.TuyenXe_ChiTiet.Where(r => r.TuyenXeID == id).Select(r => new DanhSachTuyenXe_ChiTiet
                {
                    TramXeID = r.TramXe.TramXeID,
                    TenTuyen = r.TuyenXe.TenTuyen,
                    TenTramXe = r.TramXe.TenTramXe
                }).ToList();
                tuyenXeChiTiet.Clear();
                foreach (var item in ct)
                {
                    tuyenXeChiTiet.Add(item);
                }
            }
        }

        private void btnThemTuyen_Click(object sender, EventArgs e)
        {
            try
            {
                TuyenXe tuyenXe = new TuyenXe();
                tuyenXe.TenTuyen = txtTenTuyen.Text;
                tuyenXe.MoTa = txtGhiChu.Text;

                context.TuyenXe.Add(tuyenXe);
                context.SaveChanges();

                id = tuyenXe.TuyenXeID;
                frmTuyenXe_TramXe_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            try
            {
                if (id != 0)
                {
                    TuyenXe tuyenXe = context.TuyenXe.Find(id);
                    if (tuyenXe != null)
                    {
                        tuyenXe.TenTuyen = txtTenTuyen.Text;
                        tuyenXe.MoTa = txtGhiChu.Text;
                        
                        //Luu tuyen moi
                        context.SaveChanges();

                        id = tuyenXe.TuyenXeID;

                        // Xoa tram cu
                        var tramCu = context.TuyenXe_ChiTiet.Where(r => r.TuyenXeID == id).ToList();
                        context.TuyenXe_ChiTiet.RemoveRange(tramCu);

                        // Them tram moi
                        foreach (var item in tuyenXeChiTiet)
                        {
                            TuyenXe_ChiTiet tuyenXeChiTiet = new TuyenXe_ChiTiet();
                            tuyenXeChiTiet.TuyenXeID = id;
                            tuyenXeChiTiet.TramXeID = item.TramXeID;
                            context.TuyenXe_ChiTiet.Add(tuyenXeChiTiet);
                        }
                        context.SaveChanges();
                        frmTuyenXe.frmTuyenXe_Load(sender, e);
                    }
                  
                }
                else
                {
                    TuyenXe tuyenXe = new TuyenXe();
                    tuyenXe.TenTuyen = txtTenTuyen.Text;
                    tuyenXe.MoTa = txtGhiChu.Text;
                    context.TuyenXe.Add(tuyenXe);
                    context.SaveChanges(); 

                    foreach (var item in tuyenXeChiTiet)
                    {
                        TuyenXe_ChiTiet tuyenXeChiTiet = new TuyenXe_ChiTiet();
                        tuyenXeChiTiet.TuyenXeID = id;
                        tuyenXeChiTiet.TramXeID = item.TramXeID;
                        context.TuyenXe_ChiTiet.Add(tuyenXeChiTiet);
                    }
                    context.SaveChanges();
                }
              
                btnThoat_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemTram_Click(object sender, EventArgs e)
        {
            try
            {
                int tramxeID = (int)cboTramXe.SelectedValue;
                var tramXe = context.TramXe.Where(r => r.TramXeID == tramxeID).SingleOrDefault();
                if (tramXe == null)
                {
                    MessageBox.Show("Trạm không tồn tại");
                }

                if (tuyenXeChiTiet.Any(r => r.TramXeID == tramxeID))
                {
                    MessageBox.Show("Trạm đã tồn tại trong danh sách");
                    return;
                }

                tuyenXeChiTiet.Add(new DanhSachTuyenXe_ChiTiet
                {
                    TramXeID = tramxeID,
                    TenTuyen = txtTenTuyen.Text,
                    TenTramXe = cboTramXe.Text
                });
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Lỗi cập nhật CSDL: {ex.InnerException?.Message ?? ex.Message}");
            }

        }

        private void btnXoaTram_Click(object sender, EventArgs e)
        {
            int selected = gridChiTiet.CurrentRow.Index;
            tuyenXeChiTiet.RemoveAt(selected);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }
    }
}
