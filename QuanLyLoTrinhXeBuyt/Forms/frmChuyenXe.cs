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
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        int id;
        bool xuLyThem = false;  // Kiem tra xem co phai la them moi khong
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenChuyenXe.Enabled = giaTri;
            txtDiemXuatPhat.Enabled = giaTri;
            cboTuyenXe.Enabled = giaTri;
            cboXe.Enabled = giaTri;
            dtpThoiGianDi.Enabled = giaTri;
            //dtpThoiGianDen.Enabled = giaTri;

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

            List<DanhSachChuyenXe> chuyenXe = new List<DanhSachChuyenXe>();

            chuyenXe = context.ChuyenXe.Select(r => new DanhSachChuyenXe
            {
                ChuyenXeID = r.ChuyenXeID,
                TenChuyen = r.TenChuyen,
                DiemXuatPhat = r.DiemXuatPhat,
                ThoiGianDi = r.ThoiGianDi,
                TuyenXeID = r.TuyenXeID,
                TenTuyen = r.TuyenXe.TenTuyen,
                XeID = r.XeID,
                BienSo = r.Xe.BienSo
            }).ToList();


            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = chuyenXe;

            txtTenChuyenXe.DataBindings.Clear();
            txtTenChuyenXe.DataBindings.Add("Text", bindingSource, "TenChuyen", true, DataSourceUpdateMode.Never);

            txtDiemXuatPhat.DataBindings.Clear();
            txtDiemXuatPhat.DataBindings.Add("Text", bindingSource, "DiemXuatPhat", true, DataSourceUpdateMode.Never);

            dtpThoiGianDi.DataBindings.Clear();
            dtpThoiGianDi.DataBindings.Add("Value", bindingSource, "ThoiGianDi", true, DataSourceUpdateMode.Never);

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
            txtTenChuyenXe.Text = "";
            txtDiemXuatPhat.Text = "";
            dtpThoiGianDi.Value = DateTime.Now;
            cboTuyenXe.Text = "";
            cboXe.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chuyến " + txtTenChuyenXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString());
                ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                if (chuyenXe != null)
                {
                    context.Remove(chuyenXe);
                }
                context.SaveChanges();
                frmChuyenXe_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(gridChuyenXe.CurrentRow.Cells["ChuyenXeID"].Value.ToString());
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
            else
            {
                if (xuLyThem)
                {
                    ChuyenXe chuyenXe = new ChuyenXe();
                    chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                    chuyenXe.DiemXuatPhat = txtDiemXuatPhat.Text;
                    chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                    //chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                    chuyenXe.TuyenXeID = (int)cboTuyenXe.SelectedValue;
                    chuyenXe.XeID = (int)cboXe.SelectedValue;

                    context.ChuyenXe.Add(chuyenXe);
                    context.SaveChanges();
                }
                else
                {
                    ChuyenXe chuyenXe = context.ChuyenXe.Find(id);
                    if (chuyenXe != null)
                    {
                        chuyenXe.TenChuyen = txtTenChuyenXe.Text;
                        chuyenXe.DiemXuatPhat = txtDiemXuatPhat.Text;
                        chuyenXe.ThoiGianDi = dtpThoiGianDi.Value;
                        //chuyenXe.ThoiGianDen = dtpThoiGianDen.Value;
                        chuyenXe.TuyenXeID = (int)cboTuyenXe.SelectedValue;
                        chuyenXe.XeID = (int)cboXe.SelectedValue;

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

        private void gridChuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                            table.Columns.Add("ChuyenXeID");
                            table.Columns.Add("TenChuyen");
                            table.Columns.Add("DiemXuatPhat");
                            table.Columns.Add("ThoiGianDi");
                            table.Columns.Add("TuyenXeID");
                            table.Columns.Add("TenTuyen");
                            table.Columns.Add("XeID");


                            var chuyenXe = context.ChuyenXe.Select(cx => new
                            {
                                cx.ChuyenXeID,
                                cx.TenChuyen,
                                cx.DiemXuatPhat,
                                cx.ThoiGianDi,
                                cx.TuyenXeID,
                                cx.TuyenXe.TenTuyen,
                                cx.XeID
                            }).ToList();

                            foreach (var item in chuyenXe)
                            {
                                table.Rows.Add(item.ChuyenXeID, item.TenChuyen, item.DiemXuatPhat, item.DiemXuatPhat, item.ThoiGianDi, item.TuyenXeID, item.TenChuyen, item.XeID);    
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

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
