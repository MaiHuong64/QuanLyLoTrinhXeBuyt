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
            btnHuybo.Enabled = giaTri;
            btnThoat.Enabled = giaTri;
            btnNhap.Enabled = giaTri;
            btnXuat.Enabled = giaTri;

            btnTimKiem.Enabled = true;
            txtTuKhoa.Enabled = true;
            cboNhanVien.Enabled = giaTri;
            cboXeBuyt.Enabled = giaTri;
            dtNgayLam.Enabled = giaTri;
        }

        public void LayDuLieuNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "NhanVienID";
            cboNhanVien.DisplayMember = "HoTen";
        }
        public void LayDuLieuXeVaoComboBox()
        {
            cboXeBuyt.DataSource = context.Xe.ToList();
            cboXeBuyt.ValueMember = "XeID";
            cboXeBuyt.DisplayMember = "BienSo";
        }

        public void ClearField() 
        { 
            cboXeBuyt.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtNgayLam.Value = DateTime.Now;
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            LayDuLieuNhanVienVaoComboBox();
            LayDuLieuXeVaoComboBox();

            BatTatChucNang(false);
            gridPhanCong.AutoGenerateColumns = false;
            if (gridPhanCong.Columns.Count == 0)
            {
                gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhanCongID", DataPropertyName = "PhanCongID", HeaderText = "Mã phân công" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "XeID", DataPropertyName = "XeID", HeaderText = "Mã xe" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã nhân viên" });
                gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ tên" });
                //gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhanVienID", DataPropertyName = "NhanVienID", HeaderText = "Mã phân công" });
                gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayLamViec", DataPropertyName = "NgayLamViec", HeaderText = "Ngày làm việc" });
                gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "BienSo", DataPropertyName = "BienSo", HeaderText = "Biển số" });
                gridPhanCong.Columns.Add(new DataGridViewTextBoxColumn { Name = "ChucVu", DataPropertyName = "ChucVu", HeaderText = "Vai trò" });
            }

            
            List<DanhSachPhanCong> phanCong = new List<DanhSachPhanCong>();
            phanCong = context.PhanCong.Select(t => new DanhSachPhanCong
            {
                PhanCongID = t.PhanCongID, 
                XeID = t.XeID,
                BienSo = t.Xe.BienSo,
                NhanVienID = t.NhanVienID,
                HoTen = t.NhanVien.HoTen,
                NgayLamViec = t.NgayLamViec,
                ChucVu = t.NhanVien.ChucVu
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource  = phanCong;

            cboXeBuyt.DataBindings.Clear();
            cboXeBuyt.DataBindings.Add("SelectedValue", bindingSource, "XeID", false, DataSourceUpdateMode.Never);

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bindingSource, "NhanVienID", false, DataSourceUpdateMode.Never);

            dtNgayLam.DataBindings.Clear();
            dtNgayLam.DataBindings.Add("value", bindingSource, "NgayLamViec", false, DataSourceUpdateMode.Never);


            gridPhanCong.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ClearField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

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
        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Xuất dữ liệu ra file Excel",
                Filter = "Tập tin Excel|*.xls;*.xlsx",
                Multiselect = false,
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        using (XLWorkbook wb = new XLWorkbook(openFileDialog.FileName))
                        {
                            // Lấy dữ liệu sheet đầu tiên
                            var sheet = wb.Worksheet(1);
                            bool firstRow = false;
                            string readRange = "1:1";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
