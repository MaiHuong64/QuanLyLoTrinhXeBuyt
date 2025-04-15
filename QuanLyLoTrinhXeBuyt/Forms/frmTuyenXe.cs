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
     
        }
        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            gridTuyenXe.AutoGenerateColumns = false;

            if(gridTuyenXe.Columns.Count == 0)
            {
                gridTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TuyenXeID", DataPropertyName = "TuyenXeID", HeaderText = "Mã tuyến xe" });
                gridTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTuyen", DataPropertyName = "TenTuyen", HeaderText = "Tên tuyến xe" });
                gridTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", DataPropertyName = "MoTa", HeaderText = "Mô tả" });
                gridTuyenXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "XemChiTiet", DataPropertyName = "XemChiTiet", HeaderText = "Xem chi tiết" });
            }

            List<DanhSachTuyenXe> tuyenXe = new List<DanhSachTuyenXe>();

            tuyenXe = context.TuyenXe.Select(t => new DanhSachTuyenXe
            {
                TuyenXeID = t.TuyenXeID,
                TenTuyen = t.TenTuyen,
                MoTa = t.MoTa,
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            gridTuyenXe.DataSource = tuyenXe;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmTuyenXe_ChiTiet frm = new frmTuyenXe_ChiTiet(id))
            {
                Console.WriteLine(id);
                frm.ShowDialog();
                this.Close();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridTuyenXe.CurrentRow.Cells["TuyenXeID"].Value.ToString());
            using(frmTuyenXe_ChiTiet frm = new frmTuyenXe_ChiTiet(id))
            {
                frm.ShowDialog();
                this.Close();
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
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
                        using(XLWorkbook wb = new XLWorkbook())
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

                            var sheet  = wb.Worksheets.Add(tableTuyenXe, "TuyenXe");
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = gridTuyenXe.CurrentRow.Index;
            var ten = gridTuyenXe.Rows[index].Cells["TenTuyen"].Value.ToString();
            if (MessageBox.Show("Xác nhận xóa chuyến " + ten + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridTuyenXe.Rows[index].Cells["TuyenXeID"].Value.ToString());
                TuyenXe tuyenxe = context.TuyenXe.Find(id);
                context.Remove(tuyenxe);

                context.SaveChanges();
                frmTuyenXe_Load(sender, e);
            }

        }
    }
}
