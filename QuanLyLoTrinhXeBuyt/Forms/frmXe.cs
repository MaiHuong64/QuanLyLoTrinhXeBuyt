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
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        string id ="";
        
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtBienSo.Enabled = giaTri;
            txtMaXe.Enabled = giaTri;
            numSoGhe.Enabled = giaTri;
            cboLoaiXe.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
        }


        private void frmXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<Xe> xe = new List<Xe>();
            xe = context.Xe.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = xe;

            txtMaXe.DataBindings.Clear();
            txtMaXe.DataBindings.Add("Text", bindingSource, "XeID", true, DataSourceUpdateMode.Never);  

            txtBienSo.DataBindings.Clear();
            txtBienSo.DataBindings.Add("Text", bindingSource, "BienSo", true, DataSourceUpdateMode.Never);

            numSoGhe.DataBindings.Clear();
            numSoGhe.DataBindings.Add("Value", bindingSource, "SoGhe", true, DataSourceUpdateMode.Never);

            cboLoaiXe.DataBindings.Clear();
            cboLoaiXe.DataBindings.Add("Text", bindingSource, "LoaiXe", true, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", true, DataSourceUpdateMode.Never);

            gridXe.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            id = "";
            BatTatChucNang(true);
            txtMaXe.Clear();
            txtBienSo.Clear();
            numSoGhe.Value = 0; 
            cboLoaiXe.SelectedIndex = -1;
            cboTrangThai.SelectedValue = -1;

            txtMaXe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận xóa xe " + txtMaXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                id = gridXe.CurrentRow.Cells["XeID"].Value.ToString();
                Xe xe = context.Xe.Find(id);
                if (xe != null)
                {
                    context.Xe.Remove(xe);
                }
                context.SaveChanges();
            }
            frmXe_Load(sender, e);  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = gridXe.CurrentRow.Cells["XeID"].Value.ToString(); 
            txtMaXe.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaXe.Focus();
            }
            else if(string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng nhập biển số xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSo.Focus();
            }
            else if (numSoGhe.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoGhe.Focus();
            }
            else if (cboLoaiXe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiXe.Focus();
            }
            
            else
            {
                if (id == "")
                {
                    Xe xe = new Xe();
                    xe.XeID = txtMaXe.Text;
                    xe.BienSo = txtBienSo.Text;
                    xe.SoGhe = Convert.ToInt32(numSoGhe.Value);
                    xe.LoaiXe = cboLoaiXe.SelectedItem.ToString();
                    xe.TrangThai = cboTrangThai.SelectedItem.ToString();

                    context.Add(xe);

                    context.SaveChanges();
                }
                else
                {
                    Xe xe = context.Xe.Find(id)!;
                    if (xe != null)
                    {
                        xe.XeID = txtMaXe.Text;
                        xe.BienSo = txtBienSo.Text;
                        xe.SoGhe = Convert.ToInt32(numSoGhe.Value);
                        xe.LoaiXe = cboLoaiXe.SelectedItem.ToString();
                        xe.TrangThai = cboTrangThai.SelectedItem.ToString();

                        context.Update(xe);

                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
    }
}
