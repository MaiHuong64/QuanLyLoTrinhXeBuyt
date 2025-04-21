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

        #region Hàm cơ bản 
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            txtTenVe.Enabled = giaTri;
            cboChuyenXe.Enabled = giaTri;
            cboLoaiVe.Enabled = giaTri;
            nudGiaVe.Enabled = giaTri;
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
            if (string.IsNullOrWhiteSpace(txtTenVe.Text))
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
        public void LayLoaiVeVaoComboBox()
        {
            cboLoaiVe.DataSource = context.LoaiVe.ToList();
            cboLoaiVe.ValueMember = "LoaiVeID";
            cboLoaiVe.DisplayMember = "TenLoaiVe";
        }
        #endregion
        private void frmVeXe_Load(object sender, EventArgs e)
        {
            dvgVeXe.AutoGenerateColumns = false;

            LayChuyenXeVaoComboBox();
            LayLoaiVeVaoComboBox();

            List<DanhSachVeXe> veXe = new List<DanhSachVeXe>();

            if (dvgVeXe.Columns.Count == 0)
            {
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "VeXeID", DataPropertyName = "VeXeID", HeaderText = "Mã vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenVe", DataPropertyName = "TenVe", HeaderText = "Tên vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoaiVe", DataPropertyName = "TenLoaiVe", HeaderText = "Loại vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "GiaVe", DataPropertyName = "TenVe", HeaderText = "Tên vé" });
                dvgVeXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenChuyen", DataPropertyName = "TenChuyen", HeaderText = "Tên chuyến" });
            }
            veXe = context.VeXe.Select(v => new DanhSachVeXe
            {
                VeXeID = v.VeXeID,
                TenVe = v.TenVe,
                GiaVe = v.GiaVe,
                TenLoaiVe = v.LoaiVe.TenLoaiVe,
                ChuyenXeID = v.ChuyenXeID,
                TenChuyen = v.ChuyenXe.TenChuyen
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = veXe;

            txtTenVe.DataBindings.Clear();
            txtTenVe.DataBindings.Add("Text", bindingSource, "TenVe", false, DataSourceUpdateMode.Never);

            nudGiaVe.DataBindings.Clear();
            nudGiaVe.DataBindings.Add("Value", bindingSource, "GiaVe", false, DataSourceUpdateMode.Never);



            cboChuyenXe.DataBindings.Clear();
            cboChuyenXe.DataBindings.Add("SelectedValue", bindingSource, "ChuyenXeID", false, DataSourceUpdateMode.Never);

            dvgVeXe.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có muốn xóa {txtTenVe.Text}?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                id = Convert.ToInt32(dvgVeXe.CurrentRow.Cells["VeXeID"].Value.ToString());
                VeXe vexe = context.VeXe.Find(id);
                if (vexe !=null)
                    context.Remove(vexe);
                context.SaveChanges();
                frmVeXe_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dvgVeXe.CurrentRow.Cells["VeXeID"].Value.ToString());
            //MessageBox.Show(id.ToString());
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!KiemTraHopLe()) return;
            try
            {
                if (xuLyThem)
                {
                    VeXe vexe = new VeXe
                    {
                        TenVe = txtTenVe.Text,
                        GiaVe = (int)nudGiaVe.Value,
                        LoaiVeID = (int)cboLoaiVe.SelectedValue,
                        ChuyenXeID = (int)cboChuyenXe.SelectedValue
                    };
                    context.Add(vexe);

                }
                else
                {
                    var vexe = context.VeXe.Find(id);
                    if (vexe == null)
                    {
                        MessageBox.Show("Không tìm thấy vé để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    vexe.TenVe = txtTenVe.Text;
                    vexe.GiaVe = (int)nudGiaVe.Value;
                    vexe.LoaiVeID = (int)cboLoaiVe.SelectedValue;
                    vexe.ChuyenXeID = (int)cboChuyenXe.SelectedValue;

                    context.Update(vexe);
                    
                }
                context.SaveChanges();
                frmVeXe_Load(sender, e);
                XoaTrang();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmVeXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}
