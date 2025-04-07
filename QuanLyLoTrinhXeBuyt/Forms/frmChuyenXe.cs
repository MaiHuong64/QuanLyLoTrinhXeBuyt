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
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        string id = "";
        bool xuLyThem = false;  // Kiem tra xem co phai la them moi khong
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtMaChuyenXe.Enabled = giaTri;
            txtTenChuyenXe.Enabled = giaTri;
            txtDiemXuatPhat.Enabled = giaTri;
            cboTuyenXe.Enabled = giaTri;
            cboXe.Enabled = giaTri;
            dtpThoiGianDi.Enabled = giaTri;
            dtpThoiGianDen.Enabled = giaTri;

        }
        public void LayTuyenXeVaoComboBox()
        {
            cboTuyenXe.DataSource = context.TuyenXe.ToList();
            cboTuyenXe.DisplayMember = "TenTuyen";
            cboTuyenXe.ValueMember = "TuyenXeID";
        }

        public void LayXeVaoComboBox()
        {
            cboXe.DataSource = context.Xe.ToList();
            cboXe.DisplayMember = "BienSo";
            cboXe.ValueMember = "XeID";
        }
        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayTuyenXeVaoComboBox();
            LayXeVaoComboBox();

            gridChuyenXe.AutoGenerateColumns = false;

            List<ChuyenXe> chuyenXe = new List<ChuyenXe>();
            chuyenXe = context.ChuyenXe.Select(r => new ChuyenXe
            {
                ChuyenXeID = r.ChuyenXeID,
                TenChuyen = r.TenChuyen,
                DiemXuatPhat = r.DiemXuatPhat,
                ThoiGianDi = r.ThoiGianDi,
                ThoiGianDen = r.ThoiGianDen,
                TuyenXeID = r.TuyenXeID,
                XeID = r.XeID
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = chuyenXe;

            txtMaChuyenXe.DataBindings.Clear();
            txtMaChuyenXe.DataBindings.Add("Text", bindingSource, "ChuyenXeID", true, DataSourceUpdateMode.Never);

            txtTenChuyenXe.DataBindings.Clear();
            txtTenChuyenXe.DataBindings.Add("Text", bindingSource, "TenChuyen", true, DataSourceUpdateMode.Never);

            txtDiemXuatPhat.DataBindings.Clear();
            txtDiemXuatPhat.DataBindings.Add("Text", bindingSource, "DiemXuatPhat", true, DataSourceUpdateMode.Never);

            dtpThoiGianDi.DataBindings.Clear();
            dtpThoiGianDi.DataBindings.Add("Value", bindingSource, "ThoiGianDi", true, DataSourceUpdateMode.Never);

            dtpThoiGianDen.DataBindings.Clear();
            dtpThoiGianDen.DataBindings.Add("Value", bindingSource, "ThoiGianDen", true, DataSourceUpdateMode.Never);

            cboTuyenXe.DataBindings.Clear();
            cboTuyenXe.DataBindings.Add("SelectedValue", bindingSource, "TuyenXeID", true, DataSourceUpdateMode.Never);
            
            cboXe.DataBindings.Clear();
            cboXe.DataBindings.Add("SelectedValue", bindingSource, "XeID", true, DataSourceUpdateMode.Never);

            gridChuyenXe.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;
            txtMaChuyenXe.Text = "";
            txtTenChuyenXe.Text = "";
            txtDiemXuatPhat.Text = "";
            dtpThoiGianDi.Value = DateTime.Now;
            dtpThoiGianDen.Value = DateTime.Now;
            cboTuyenXe.Text = "";
            cboXe.Text = "";
            txtMaChuyenXe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tuyên " + txtTenChuyenXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = gridChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString();
                ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                if (chuyenXe != null)
                {
                    context.Remove(chuyenXe);
                }
                context.SaveChanges();
                frmChuyenXe_Load(sender, e); // Load lại dữ liệu
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = gridChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiemXuatPhat.Text) || string.IsNullOrWhiteSpace(txtTenChuyenXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtDiemXuatPhat.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboTuyenXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboXe.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpThoiGianDi.Value > dtpThoiGianDen.Value)
                MessageBox.Show("Thời gian đi không được lớn hơn thời gian đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (xuLyThem)
                {
                    ChuyenXe chuyenXe = new ChuyenXe();
                    chuyenXe.ChuyenXeID = txtMaChuyenXe.Text;
                    chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                    chuyenXe.DiemXuatPhat = txtDiemXuatPhat.Text;
                    chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                    chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                    chuyenXe.TuyenXeID = cboTuyenXe.SelectedValue.ToString();
                    chuyenXe.XeID = cboXe.SelectedValue.ToString();

                    context.ChuyenXe.Add(chuyenXe);
                    context.SaveChanges();
                }
                else
                {
                    ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                    if (chuyenXe != null)
                    {
                        chuyenXe.ChuyenXeID = txtMaChuyenXe.Text;
                        chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                        chuyenXe.DiemXuatPhat = txtDiemXuatPhat.Text;
                        chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                        chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                        chuyenXe.TuyenXeID = cboTuyenXe.SelectedValue.ToString();
                        chuyenXe.XeID = cboXe.SelectedValue.ToString();

                        context.Update(chuyenXe);
                        context.SaveChanges();
                    }
                }
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmChuyenXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
