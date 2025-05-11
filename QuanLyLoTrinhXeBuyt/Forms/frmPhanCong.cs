using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyLoTrinhXeBuyt.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
        }

        QLLTXBContext context = new QLLTXBContext();
        int id;
        bool xuLyThem = false;

        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            btnThoat.Enabled = giaTri;
            btnNhapFileExcel.Enabled = true;
            btnXuatFileExcel.Enabled = true;

            btnTimKiem.Enabled = true;
            txtTimKiem.Enabled = true;
            cboNhanVien.Enabled = giaTri;
            cboChuyenXe.Enabled = giaTri;
            dtNgayLam.Enabled = giaTri;
        }
        public void LayDuLieuNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "NhanVienID";
            cboNhanVien.DisplayMember = "HoTen";
        }
        public void LayDuLieuChuyenXeVaoComboBox()
        {
            cboChuyenXe.DataSource = context.ChuyenXe.ToList();
            cboChuyenXe.ValueMember = "ChuyenXeID";
            cboChuyenXe.DisplayMember = "TenChuyen";
        }
        public void ClearField()
        {
            cboChuyenXe.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtNgayLam.Value = DateTime.Now;
        }
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            LayDuLieuNhanVienVaoComboBox();
            LayDuLieuChuyenXeVaoComboBox();

            BatTatChucNang(false);
            dgvPhanCong.AutoGenerateColumns = false;
            if (dgvPhanCong.Columns.Count == 0)
            {
                dgvPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhanCongID", DataPropertyName = "PhanCongID", HeaderText = "Mã phân công" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "XeID", DataPropertyName = "XeID", HeaderText = "Mã xe" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã nhân viên" });
                dgvPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ tên" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã phân công" });
                dgvPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayLamViec", DataPropertyName = "NgayLamViec", HeaderText = "Ngày làm việc" });
                dgvPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenChuyen", DataPropertyName = "TenChuyen", HeaderText = "Chuyến xe" });
                dgvPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "Vaitro", DataPropertyName = "VaiTro", HeaderText = "Vai trò" });
            }


            List<DanhSachPhanCong> phanCong = new List<DanhSachPhanCong>();
            phanCong = context.PhanCong.Select(t => new DanhSachPhanCong
            {
                PhanCongID = t.PhanCongID,
                ChuyenXeID = t.ChuyenXeID,
                TenChuyen = t.ChuyenXe.TenChuyen,
                NhanVienID = t.NhanVienID,
                HoTen = t.NhanVien.HoTen,
                NgayLamViec = t.NgayLamViec,
                VaiTro = t.NhanVien.VaiTro
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = phanCong;

            cboChuyenXe.DataBindings.Clear();
            cboChuyenXe.DataBindings.Add("SelectedValue", bindingSource, "ChuyenXeID", false, DataSourceUpdateMode.Never);

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bindingSource, "NhanVienID", false, DataSourceUpdateMode.Never);

            dtNgayLam.DataBindings.Clear();
            dtNgayLam.DataBindings.Add("value", bindingSource, "NgayLamViec", false, DataSourceUpdateMode.Never);


            dgvPhanCong.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ClearField();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvPhanCong.CurrentRow.Cells["PhanCongID"].Value.ToString());
            PhanCong pc = context.PhanCong.Find(id);
            if (pc != null)
            {
                context.PhanCong.Remove(pc);
                context.SaveChanges();
            }
            frmPhanCong_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvPhanCong.CurrentRow.Cells["PhanCongID"].Value.ToString());
            xuLyThem = false;
            BatTatChucNang(true);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                PhanCong pc = new PhanCong();
                pc.NhanVienID = (int)cboNhanVien.SelectedValue;
                pc.ChuyenXeID = (int)cboChuyenXe.SelectedValue;
                pc.NgayLamViec = dtNgayLam.Value;

                context.PhanCong.Add(pc);
            }
            else
            {
                PhanCong pc = context.PhanCong.Find(id);
                pc.NhanVienID = (int)cboNhanVien.SelectedValue;
                pc.ChuyenXeID = (int)cboChuyenXe.SelectedValue;
                pc.NgayLamViec = dtNgayLam.Value;

                context.PhanCong.Update(pc);
            }
            context.SaveChanges();
            frmPhanCong_Load(sender, e);
        }
        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmPhanCong_Load(sender, e);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tukhoa = txtTimKiem.Text.Trim();
            try
            {
                var phancong = context.PhanCong.Select(r => new DanhSachPhanCong
                {
                    HoTen = r.NhanVien.HoTen,
                    TenChuyen = r.ChuyenXe.TenChuyen,
                    NgayLamViec = r.NgayLamViec,
                    VaiTro = r.NhanVien.VaiTro
                }).Where(r => r.HoTen.Contains(tukhoa) ||r.TenChuyen.Contains(tukhoa)|| r.VaiTro.Contains(tukhoa)).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = phancong;
                dgvPhanCong.DataSource = bindingSource;

                if (dgvPhanCong.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm");
                    frmPhanCong_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapFileExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nhập dữ liệu từ tập tin Excel",
                Filter = "Tập tin Excel|*.xls;*.xlsx",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                        {
                            var sheet = wb.Worksheet(1);
                            bool firstRow = true;
                            string readRange = "1:1";

                            foreach (IXLRow row in sheet.RowsUsed())
                            {
                                if (firstRow)
                                {
                                    readRange = $"1:{row.LastCellUsed().Address.ColumnNumber}";
                                    foreach (IXLCell cell in row.CellsUsed())
                                        dataTable.Columns.Add(cell.Value.ToString().Trim());
                                    firstRow = false;
                                }
                                else
                                {
                                    dataTable.Rows.Add();
                                    int cellIndex = 0;
                                    foreach (IXLCell cell in row.Cells(readRange))
                                        dataTable.Rows[dataTable.Rows.Count - 1][cellIndex++] = cell.Value.ToString().Trim();
                                }
                            }
                        }

                        if (dataTable.Rows.Count > 0)
                        {
                            int soLuongCapNhat = 0, soLuongThemMoi = 0;
                            //var xeList = context.Xe.ToDictionary(x => x.BienSo, x => x, StringComparer.OrdinalIgnoreCase);
                            //var nhanVienList = context.NhanVien.ToDictionary(nv => nv.HoTen, nv => nv, StringComparer.OrdinalIgnoreCase);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string phanCongID = row["PhanCongID"].ToString().Trim();
                                string TenChuyen = row["TenChuyen"].ToString().Trim();
                                string hoTen = row["HoTen"].ToString().Trim();
                                string ngayLamViec = row["NgayLamViec"].ToString().Trim();

                                var nhanVienID = context.NhanVien.Where(n => n.HoTen == hoTen).Select(n => n.NhanVienID).FirstOrDefault();
                                var ChuyenXeID = context.ChuyenXe.Where(x => x.TenChuyen == TenChuyen).Select(x => x.ChuyenXeID).FirstOrDefault();

                                // Kiểm tra bản ghi PhanCong đã tồn tại
                                var existPC = context.PhanCong.FirstOrDefault(pc =>
                                    pc.PhanCongID == Convert.ToInt32(phanCongID) &&
                                    pc.NhanVienID == nhanVienID &&
                                    pc.ChuyenXeID == ChuyenXeID &&
                                    pc.NgayLamViec == dtNgayLam.Value);

                                if (existPC != null)
                                {
                                    // Cập nhật bản ghi
                                    existPC.NhanVienID = nhanVienID;
                                    existPC.ChuyenXeID = ChuyenXeID;
                                    existPC.NgayLamViec = dtNgayLam.Value;
                                    soLuongCapNhat++;
                                }
                                else
                                {
                                    // Thêm bản ghi mới
                                    var newPC = new PhanCong
                                    {
                                        ChuyenXeID = ChuyenXeID,
                                        NhanVienID = nhanVienID,
                                        NgayLamViec = dtNgayLam.Value
                                    };
                                    context.PhanCong.Add(newPC);
                                    soLuongThemMoi++;
                                }
                            }

                            context.SaveChanges();
                            MessageBox.Show($"Cập nhật: {soLuongCapNhat}\nThêm mới: {soLuongThemMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPhanCong_Load(sender, e);
                            dgvPhanCong.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Tập tin Excel không có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi nhập Excel: {ex.Message}\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất File Excel",
                Filter = "File Excel|*.xls;*.xlsx",
                FileName = "PhanCong_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx",
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("PhanCongID");
                        dt.Columns.Add("TenChuyen");
                        dt.Columns.Add("HoTen");
                        dt.Columns.Add("VaiTro");
                        dt.Columns.Add("NgayLamViec");

                        var phanCong = context.PhanCong.Select(pc => new
                        {
                            pc.PhanCongID,
                            pc.ChuyenXe.TenChuyen,
                            pc.NhanVien.HoTen,
                            pc.NgayLamViec
                        }).ToList();
                        foreach (var pc in phanCong)
                            dt.Rows.Add(pc.PhanCongID, pc.TenChuyen, pc.HoTen, pc.NgayLamViec);
                        var sheet = wb.Worksheets.Add(dt, "PhanCong");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click((Control)sender, e);
            }
        }
    }
}
