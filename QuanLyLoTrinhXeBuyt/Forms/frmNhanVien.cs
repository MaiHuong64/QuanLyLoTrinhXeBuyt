using ClosedXML.Excel;
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
            if(gridNhanVien.Columns.Count == 0)
            {
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã nhân viên" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ tên" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoDienThoai", DataPropertyName = "SoDienThoai", HeaderText = "Số điện thoại" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa chỉ" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "VaiTro", DataPropertyName = "VaiTro", HeaderText = "Chức vụ" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDangNhap", DataPropertyName = "TenDangNhap", HeaderText = "Tên đăng nhập" });
                gridNhanVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuyenHan", DataPropertyName = "QuyenHan", HeaderText = "Quyền hạn" });
            }
        }
        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            cboChucVu.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = true;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void XoaDuLieu()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            cboChucVu.Text = "";
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
            txtHoVaTen.Focus();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            gridNhanVien.AutoGenerateColumns = false;

            ThemDuLieuVaoGrid();

            BatTatChucNang(false);
            List<NhanVien> nv = context.NhanVien.ToList();

            

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", bindingSource, "VaiTro", false, DataSourceUpdateMode.Never);    

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            gridNhanVien.DataSource = bindingSource;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridNhanVien.CurrentRow.Cells["NhanVienID"].Value.ToString());
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên" + txtHoVaTen.Text + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridNhanVien.CurrentRow.Cells["NhanVienID"].Value.ToString());
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
            else if (string.IsNullOrWhiteSpace(cboChucVu.Text))
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                MessageBox.Show("Vui lòng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.HoTen = txtHoVaTen.Text;
                    nv.SoDienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.VaiTro = cboChucVu.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    nv.QuyenHan = cboQuyenHan.Text;
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
                        nv.VaiTro = cboChucVu.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;

                        nv.QuyenHan = cboQuyenHan.Text;
                        context.Update(nv);

                        if(string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giu nguyen mat khau cu
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

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
            var nv = context.NhanVien.Where(r => r.HoTen!.Contains(txtTimKiem.Text.ToLower())).ToList();
            gridNhanVien.DataSource = nv;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using(XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = wb.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        foreach(IXLRow row in worksheet.RowsUsed())
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

                        if(table.Rows.Count > 0)
                        {
                            foreach(DataRow row in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoTen = row["HoTen"].ToString();
                                nv.SoDienThoai = row["SoDienThoai"].ToString();
                                nv.DiaChi = row["DiaChi"].ToString();
                                nv.VaiTro = row["VaiTro"].ToString();
                                nv.TenDangNhap = row["TenDangNhap"].ToString();
                                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(row["MatKhau"].ToString());
                                nv.QuyenHan = row["QuyenHan"].ToString();
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
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
                            table.Columns.Add("SoDienThoai");
                            table.Columns.Add("DiaChi");
                            table.Columns.Add("VaiTro");
                            table.Columns.Add("TenDangNhap");
                            table.Columns.Add("QuyenHan");
                            var nhanVien = context.NhanVien.Select(nv => new
                            {
                                nv.NhanVienID,
                                nv.HoTen,
                                nv.SoDienThoai,
                                nv.DiaChi,
                                nv.VaiTro,
                                nv.TenDangNhap,
                                nv.QuyenHan
                            }).ToList();

                            foreach(var item in nhanVien)
                            {
                                table.Rows.Add(item.NhanVienID, item.HoTen, item.SoDienThoai, item.DiaChi, item.VaiTro, item.TenDangNhap, item.QuyenHan);
                            }

                            var sheet = wb.Worksheets.Add(table, "NhanVien");
                            sheet.Columns().AdjustToContents();

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

      
    }
}
