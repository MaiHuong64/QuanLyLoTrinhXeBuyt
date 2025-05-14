
﻿using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.EMMA;
using QuanLyLoTrinhXeBuyt.Data;
using System.Data;
using System.Windows.Forms;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmNhanVien : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        bool xuLyThem = false;
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void ThemDuLieuVaoGrid()
        {
            if (dvgNhanVien.Columns.Count == 0)
            {
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã nhân viên" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ tên" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoDienThoai", DataPropertyName = "SoDienThoai", HeaderText = "Số điện thoại" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "VaiTro", DataPropertyName = "VaiTro", HeaderText = "Vai trò" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDangNhap", DataPropertyName = "TenDangNhap", HeaderText = "Tên đăng nhập" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "MatKhau", DataPropertyName = "MatKhau", HeaderText = "Mật khẩu" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuyenHan", DataPropertyName = "QuyenHan", HeaderText = "Quyền hạn" });
            }
        }
        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            cboVaiTro.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = true;

        }
        public void XoaDuLieu()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cboVaiTro.Text = "";
            txtTenDangNhap.Clear();

            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = 0;


            txtHoVaTen.Focus();
        }
       
        public bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboVaiTro.Text))
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dvgNhanVien.AutoGenerateColumns = false;

            ThemDuLieuVaoGrid();

            BatTatChucNang(false);

            List<DanhSachNhanVien> nv = context.NhanVien.Select(nv => new DanhSachNhanVien
            {
                NhanVienID = nv.NhanVienID,
                HoTen = nv.HoTen,
                SoDienThoai = nv.SoDienThoai,
                Email = nv.Email,
                DiaChi = nv.DiaChi,
                VaiTro = nv.VaiTro,
                TaiKhoanID = nv.TaiKhoanID,
                TenDangNhap = nv.TaiKhoan.TenDangNhap,
                MatKhau = nv.TaiKhoan.MatKhau,
                QuyenHan = nv.TaiKhoan.QuyenHan
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("Text", bindingSource, "VaiTro", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);


            dvgNhanVien.DataSource = bindingSource;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dvgNhanVien.CurrentRow.Cells["NhanVienID"].Value.ToString());
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên" + txtHoVaTen.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dvgNhanVien.CurrentRow.Cells["NhanVienID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.Remove(nv);
                    context.SaveChanges();
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            else
            {
                if (xuLyThem)
                {
                    TaiKhoan taiKhoan = new TaiKhoan();
                    taiKhoan.TenDangNhap = txtTenDangNhap.Text;
                    taiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                    taiKhoan.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "user" : "admin";
                    context.TaiKhoan.Add(taiKhoan);
                    context.SaveChanges();

                    NhanVien nv = new NhanVien();
                    nv.HoTen = txtHoVaTen.Text;
                    nv.SoDienThoai = txtDienThoai.Text;
                    nv.Email = txtEmail.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.VaiTro = cboVaiTro.Text;
                    nv.TaiKhoanID = taiKhoan.TaiKhoanID;

                    context.NhanVien.Add(nv);
                    context.SaveChanges();

                }
                else
                {
                    var nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoTen = txtHoVaTen.Text;
                        nv.SoDienThoai = txtDienThoai.Text;
                        nv.Email = txtEmail.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.Email = txtEmail.Text;
                        nv.VaiTro = cboVaiTro.Text;

                        context.Update(nv);

                        
                        int id = Convert.ToInt32(dvgNhanVien.CurrentRow.Cells["NhanVienID"].Value.ToString());
                        TaiKhoan taiKhoan = context.TaiKhoan.Find(id);
                        if (taiKhoan != null)
                        {
                            taiKhoan.TenDangNhap = txtHoVaTen.Text;
                            taiKhoan.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "user" : "admin";
                            context.Update(taiKhoan);
                            if(string.IsNullOrWhiteSpace(txtMatKhau.Text))
                                context.Entry(taiKhoan).Property(x => x.MatKhau).IsModified = false; //Giữ lại mật khẩu cũ
                            else
                                taiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới
                            context.TaiKhoan.Update(taiKhoan);
                        }
                    }
                    context.SaveChanges();

                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Where(r => r.HoTen!.Contains(txtTimKiem.Text.ToLower()) || r.DiaChi!.Contains(txtTimKiem.Text.ToLower())).ToList();
            dvgNhanVien.DataSource = nv;
        }

        private void btnNhapFileExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = wb.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.CellsUsed())
                                    table.Columns.Add(cell.GetString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.CellsUsed())
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.GetString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            int count = 0;
                            foreach (DataRow row in table.Rows)
                            {
                                TaiKhoan tk = new TaiKhoan
                                {
                                    TenDangNhap = row["TendangNhap"].ToString(),
                                    MatKhau = BCrypt.Net.BCrypt.HashPassword(row["MatKhau"]?.ToString() ?? "123456"),
                                    QuyenHan = row["QuyenHan"]?.ToString() ?? "user"

                                };
                                context.TaiKhoan.Add(tk);
                                context.SaveChanges();

                                NhanVien nv = new NhanVien();
                                nv.HoTen = row["HoTen"].ToString();
                                nv.SoDienThoai = row["SoDienThoai"].ToString();
                                nv.Email = row["Email"].ToString();
                                nv.DiaChi = row["DiaChi"].ToString();
                                nv.VaiTro = row["VaiTro"].ToString();
                                nv.TaiKhoanID = tk.TaiKhoanID;
                                context.NhanVien.Add(nv);
                                count++;
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                            dvgNhanVien.Refresh();
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Xuất file excel";
                saveFileDialog.FileName = "NhanVien" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            // Sheet 1: Nhân viên
                            DataTable tableNhanVien = new DataTable();
                            tableNhanVien.Columns.Add("NhanVienID");
                            tableNhanVien.Columns.Add("HoTen");
                            tableNhanVien.Columns.Add("SoDienThoai");
                            tableNhanVien.Columns.Add("Email");
                            tableNhanVien.Columns.Add("DiaChi");
                            tableNhanVien.Columns.Add("VaiTro");
                            tableNhanVien.Columns.Add("TenDangNhap");
                            tableNhanVien.Columns.Add("MatKhau");
                            tableNhanVien.Columns.Add("QuyenHan");
                            tableNhanVien.Columns.Add("TaiKhoanID");

                            var nhanVien = context.NhanVien.Select(nv => new DanhSachNhanVien
                            {
                                NhanVienID = nv.NhanVienID,
                                HoTen = nv.HoTen,
                                SoDienThoai = nv.SoDienThoai,
                                Email = nv.Email,
                                DiaChi = nv.DiaChi,
                                VaiTro = nv.VaiTro,
                                TaiKhoanID = nv.TaiKhoanID,
                                TenDangNhap = nv.TaiKhoan.TenDangNhap,
                                MatKhau = nv.TaiKhoan.MatKhau,
                                QuyenHan = nv.TaiKhoan.QuyenHan
                            }).ToList();

                            foreach (var item in nhanVien)
                            {
                                tableNhanVien.Rows.Add(item.NhanVienID, item.HoTen, item.SoDienThoai,
                                       item.Email, item.DiaChi, item.VaiTro,
                                       item.TenDangNhap, item.MatKhau, item.QuyenHan);
                            }

                            var sheet = wb.Worksheets.Add(tableNhanVien, "NhanVien");
                            sheet.Columns().AdjustToContents();
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
