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
    public partial class frmMain : Form
    {
        private string role;
        public frmMain(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        frmChuyenXe frmChuyenXe;
        frmNhanVien frmNhanVien;
        frmPhanCong frmPhanCong;
        frmTramXe frmTramXe;
        frmTuyenXe frmTuyenXe;
        frmTuyenXe_ChiTiet frmTuyenXe_ChiTiet;
        frmXeBuyt frmXeBuyt;
        frmDangNhap frmDangNhap;

        #region Phân Quyền và hiển thị form
        public void QuyenAdmin()
        {
            mnNhanVien.Enabled = true;
            mnPhanCong.Enabled = true;
            mnTuyenXe.Enabled = true;
            mnThemTram.Enabled = true;
            mnChuyenXe.Enabled = true;
            mnXeBuyt.Enabled = true;
            mnChiTiet.Enabled = true;
        }

        public void QuyenUser()
        {
            mnNhanVien.Enabled = false;
            mnPhanCong.Enabled = false;
            mnTuyenXe.Enabled = true;
            mnThemTram.Enabled = false;
            mnChuyenXe.Enabled = true;
            mnXeBuyt.Enabled = true;
            mnChiTiet.Enabled = true;
        }
        public void HienThiForm(Form form)
        {
            pnContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnContent.Controls.Add(form);
            form.Show();
        }
        #endregion


        private void frmMain_Load(object sender, EventArgs e)
        {
            if (role == "admin")
                QuyenAdmin();
            else
                QuyenUser();
            lbHienThi.Text += frmDangNhap.tennv;
            lbRole.Text += role;

        }
        private void mnTuyenXe_Click(object sender, EventArgs e)
        {
            frmTuyenXe = new frmTuyenXe();
            HienThiForm(frmTuyenXe);
        }

        private void mnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void mnThemTram_Click(object sender, EventArgs e)
        {
            frmTramXe = new frmTramXe();
            HienThiForm(frmTramXe);
        }

        private void mnChuyenXe_Click(object sender, EventArgs e)
        {
            frmChuyenXe = new frmChuyenXe();
            HienThiForm(frmChuyenXe);
        }


        private void mnXeBuyt_Click(object sender, EventArgs e)
        {
            frmXeBuyt = new frmXeBuyt();
            HienThiForm(frmXeBuyt);
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien = new frmNhanVien();
            HienThiForm(frmNhanVien);
        }

        private void mnPhanCong_Click(object sender, EventArgs e)
        {
            frmPhanCong = new frmPhanCong();
            HienThiForm(frmPhanCong);
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }
    }
}
    