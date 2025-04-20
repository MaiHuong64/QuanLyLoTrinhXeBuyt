using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Windows.Forms;
namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmVeXe : Form
    {
        public frmVeXe()
        {
            InitializeComponent();
        }

        QLLTXBContext context = new QLLTXBContext();
        int id;
        bool xuLyThem = false;

        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
           
        }
        public void XoaTrang()
        {
            txtTenVe.Clear();
            nudGiaVe.Value = 0; 
            cboLoaiVe.SelectedIndex = -1;
            cboChuyenXe.SelectedIndex = -1;
          
            txtTenVe.Focus();
        }

        public bool KiemTraHopLe()
        {
            if(string.IsNullOrWhiteSpace(txtTenVe.Text))
            {
                MessageBox.Show("Tên vé không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVe.Focus();
                return false;
            }
            if (nudGiaVe.Value < 0)
            {
                MessageBox.Show("Giá vé phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudGiaVe.Focus();
                return false;
            }
            if (cboLoaiVe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiVe.Focus();
                return false;
            }
            if (cboChuyenXe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chuyến xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenXe.Focus();
                return false;
            }
            return true;
        }
        public void LayChuyenXeVaoComboBox()
        {
            cboChuyenXe.DataSource = context.ChuyenXe.ToList();
            cboChuyenXe.ValueMember = "ChuyenXeID";
            cboChuyenXe.DisplayMember = "TenChuyen";
        }
        private void frmVeXe_Load(object sender, EventArgs e)
        {
            dvgVeXe.AutoGenerateColumns = false;
            
            LayChuyenXeVaoComboBox();

            List<DanhSachVeXe> veXe = new List<DanhSachVeXe>();

            if(dvgVeXe.Columns.Count == 0)
            {
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenVe", DataPropertyName = "TenVe", HeaderText = "Tên vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "LoaiVe", DataPropertyName = "LoaiVe", HeaderText = "Loại vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "GiaVe", DataPropertyName = "TenVe", HeaderText = "Tên vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenChuyen", DataPropertyName = "TenChuyen", HeaderText = "Tên chuyến" });
            }
            veXe = context.VeXe.Select(v => new DanhSachVeXe
            {
                VeID = v.VeXeID,
                TenVe = v.TenVe,
                GiaVe = v.GiaVe,
                LoaiVe = v.LoaiVe,
                ChuyenXeID = v.ChuyenXeID,
                TenChuyen = v.ChuyenXe.TenChuyen
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = veXe;

            txtTenVe.DataBindings.Clear();
            txtTenVe.DataBindings.Add("Text", bindingSource, "TenVe", false, DataSourceUpdateMode.Never);

            nudGiaVe.DataBindings.Clear();
            nudGiaVe.DataBindings.Add("Value", bindingSource, "GiaVe", false, DataSourceUpdateMode.Never);

            cboLoaiVe.DataBindings.Clear();
            cboLoaiVe.DataBindings.Add("SelectedItem", bindingSource, "LoaiVe", false, DataSourceUpdateMode.Never);

            cboChuyenXe.DataBindings.Clear();
            cboChuyenXe.DataBindings.Add("SelectedValue", bindingSource, "ChuyenXeID", false, DataSourceUpdateMode.Never);

            dvgVeXe.DataSource = bindingSource;
        }
    }
}
