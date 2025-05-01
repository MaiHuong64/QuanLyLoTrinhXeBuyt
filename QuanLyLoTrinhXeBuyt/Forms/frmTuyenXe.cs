using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Data;
using ClosedXML.Excel;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
        {
            InitializeComponent();
        }

        QLLTXBContext context = new QLLTXBContext();
        int id;

        void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnTimKiem.Enabled = true;
            btnXuatFileExcel.Enabled = true;
            btnNhapFileExcel.Enabled = true;
        }

        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dvgTuyenXe.AutoGenerateColumns = false;

            if (dvgTuyenXe.Columns.Count == 0)
            {
                dvgTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TuyenXeID", DataPropertyName = "TuyenXeID", HeaderText = "Mã tuyến xe" });
                dvgTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTuyen", DataPropertyName = "TenTuyen", HeaderText = "Tên tuyến xe" });
                dvgTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", DataPropertyName = "MoTa", HeaderText = "Mô tả" });
                dvgTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "XemChiTiet", DataPropertyName = "XemChiTiet", HeaderText = "Xem chi tiết" });
            }

            List<DanhSachTuyenXe> tuyenXe = new List<DanhSachTuyenXe>();

            tuyenXe = context.TuyenXe.Select(t => new DanhSachTuyenXe
            {
                TuyenXeID = t.TuyenXeID,
                TenTuyen = t.TenTuyen,
                MoTa = t.MoTa,
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dvgTuyenXe.DataSource = tuyenXe;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmTuyenXe_ChiTiet frm = new frmTuyenXe_ChiTiet(id))
            {
                frm.ShowDialog();
                frmTuyenXe_Load(sender, e);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dvgTuyenXe.CurrentRow.Cells["TuyenXeID"].Value.ToString());
            using (var frm = new frmTuyenXe_ChiTiet(id))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frmTuyenXe_Load(sender, e);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Xuất file excel";
                saveFileDialog.FileName = "TuyenXe_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            DataTable tableTuyenXe = new DataTable();
                            tableTuyenXe.Columns.Add("Mã tuyến xe");
                            tableTuyenXe.Columns.Add("Tên tuyến xe");
                            tableTuyenXe.Columns.Add("Ghi chú");

                            var tuyenXe = context.TuyenXe.Select(t => new
                            {
                                t.TuyenXeID,
                                t.TenTuyen,
                                t.MoTa
                            }).ToList();

                            foreach (var item in tuyenXe)
                            {
                                tableTuyenXe.Rows.Add(item.TuyenXeID, item.TenTuyen, item.MoTa);
                            }

                            var sheet = wb.Worksheets.Add(tableTuyenXe, "TuyenXe");
                            sheet.Columns().AdjustToContents();

                            // Chi tiet tuyen xe 
                            DataTable tableChiTietTuyenXe = new DataTable();
                            tableChiTietTuyenXe.Columns.Add("TuyenXe");
                            tableChiTietTuyenXe.Columns.Add("Tram");
                            var chiTietTuyenXe = context.TuyenXe_ChiTiet.Select(ct => new
                            {
                                TramXe = ct.TramXe.TenTramXe,
                                TuyenXe = ct.TuyenXe.TenTuyen,
                            }).ToList();

                            foreach (var ct in chiTietTuyenXe)
                            {
                                tableChiTietTuyenXe.Rows.Add(ct.TuyenXe, ct.TramXe);
                            }

                            var wsChiTiet = wb.Worksheets.Add(tableChiTietTuyenXe, "TuyenXe_TramXe");
                            wsChiTiet.Columns().AdjustToContents();

                            // Luu file
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dvgTuyenXe.CurrentRow.Index;
            var ten = dvgTuyenXe.Rows[index].Cells["TenTuyen"].Value.ToString();
            if (MessageBox.Show("Xác nhận xóa chuyến " + ten + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dvgTuyenXe.Rows[index].Cells["TuyenXeID"].Value.ToString());
                TuyenXe tuyenxe = context.TuyenXe.Find(id);
                context.Remove(tuyenxe);

                context.SaveChanges();
                frmTuyenXe_Load(sender, e);
            }

        }

        private void dvgTuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgTuyenXe.Columns["XemChiTiet"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dvgTuyenXe.Rows[e.RowIndex].Cells["TuyenXeID"].Value);
                using (var frm = new frmTuyenXe_ChiTiet(id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frmTuyenXe_Load(sender, e);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tuKhoa = context.TuyenXe.Where(r => r.TenTuyen.Contains(txtTimKiem.Text)).Select(t => new DanhSachTuyenXe
            {
                TuyenXeID = t.TuyenXeID,
                TenTuyen = t.TenTuyen,
                MoTa = t.MoTa,
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dvgTuyenXe.DataSource = tuKhoa;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTuyenXe_Load(sender, e);
        }
    }
}
