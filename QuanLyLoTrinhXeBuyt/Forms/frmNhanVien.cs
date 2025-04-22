using ClosedXML.Excel;
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
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgaySinh", DataPropertyName = "NgaySinh", HeaderText = "Ngày sinh" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "GioiTinh", DataPropertyName = "GioiTinh", HeaderText = "Giới tính" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoDienThoai", DataPropertyName = "SoDienThoai", HeaderText = "Số điện thoại" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
                dvgNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "VaiTro", DataPropertyName = "VaiTro", HeaderText = "Vai trò" });
            }
        }
        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            cboVaiTro.Enabled = giaTri;
            //txtTenDangNhap.Enabled = giaTri;
            //txtMatKhau.Enabled = giaTri;
            //cboQuyenHan.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = true;

        }
        public void XoaDuLieu()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            cboVaiTro.Text = "";
            //txtTenDangNhap.Clear();
            //txtMatKhau.Clear();
            //cboQuyenHan.Text = "";
            txtHoVaTen.Focus();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dvgNhanVien.AutoGenerateColumns = false;

            ThemDuLieuVaoGrid();

            BatTatChucNang(false);
            List<NhanVien> nv = context.NhanVien.ToList();



            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);
            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", true, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            radNam.DataBindings.Clear();
            radNu.DataBindings.Clear();

            Binding bindingNam = new Binding("Checked", bindingSource, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingNam.Format += (sender, e) => { e.Value = (bool)e.Value == true; };
            bindingNam.Parse += (sender, e) => { e.Value = (bool)e.Value ? 1 : 0; };
            radNam.DataBindings.Add(bindingNam);

            Binding bindingNu = new Binding("Checked", bindingSource, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingNu.Format += (sender, e) => { e.Value = (bool)e.Value == false; };
            bindingNu.Parse += (sender, e) => { e.Value = (bool)e.Value ? 0 : 1; };
            radNu.DataBindings.Add(bindingNu);

            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("Text", bindingSource, "VaiTro", false, DataSourceUpdateMode.Never);



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
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboVaiTro.Text))
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.HoTen = txtHoVaTen.Text;
                    nv.SoDienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.VaiTro = cboVaiTro.Text;
                    //nv.TenDangNhap = txtTenDangNhap.Text;
                    //nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    //nv.QuyenHan = cboQuyenHan.Text;
                    context.NhanVien.Add(nv);

                    context.SaveChanges();
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoTen = txtHoVaTen.Text;
                        nv.SoDienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.VaiTro = cboVaiTro.Text;
                        //nv.TenDangNhap = txtTenDangNhap.Text;

                        //nv.QuyenHan = cboQuyenHan.Text;
                        context.Update(nv);

                        //if (string.IsNullOrEmpty(txtMatKhau.Text))
                        //    context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giu nguyen mat khau cu
                        //else
                        //    nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                        context.SaveChanges();
                    }
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
                                readRange = string.Format("{0}:{1}", row.LastCellUsed().Address.ColumnNumber);
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
                            foreach (DataRow row in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoTen = row["HoTen"].ToString();
                                nv.SoDienThoai = row["SoDienThoai"].ToString();
                                nv.DiaChi = row["DiaChi"].ToString();
                                nv.VaiTro = row["VaiTro"].ToString();
                                //nv.TenDangNhap = row["TenDangNhap"].ToString();
                                //nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(row["MatKhau"].ToString());
                                //nv.QuyenHan = row["QuyenHan"].ToString();
                                context.NhanVien.Add(nv);

                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
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
                            DataTable table = new DataTable();
                            table.Columns.Add("NhanVienID");
                            table.Columns.Add("HoTen");
                            table.Columns.Add("NgaySinh");
                            table.Columns.Add("GioiTinh");
                            table.Columns.Add("SoDienThoai");
                            table.Columns.Add("DiaChi");
                            table.Columns.Add("VaiTro");

                            var nhanVien = context.NhanVien.Select(nv => new
                            {
                                nv.NhanVienID,
                                nv.HoTen,
                                nv.NgaySinh,
                                nv.GioiTinh,
                                nv.SoDienThoai,
                                nv.DiaChi,
                                nv.VaiTro
                            }).ToList();

                            foreach (var item in nhanVien)
                            {
                                table.Rows.Add(item.NhanVienID, item.HoTen, item.NgaySinh, item.GioiTinh,
                                    item.SoDienThoai, item.DiaChi, item.VaiTro);
                            }

                            var sheet = wb.Worksheets.Add(table, "NhanVien");
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
