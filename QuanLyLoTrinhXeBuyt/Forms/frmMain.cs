using QuanLyLoTrinhXeBuyt.Reports;
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
        frmChuyenXe chuyenXe;
        frmNhanVien nhanVien;
        frmPhanCong phanCong;
        frmTramXe tramXe;
        frmTuyenXe tuyenXe;
        frmXeBuyt xeBuyt;
        frmDangNhap dangNhap;
        frmThongKeChuyenXe thongKeChuyenXe;
        frmThongKePhanCong thongKePhanCong;
        frmBieuDoChuyenXe bieuDoChuyenXe;

        #region Phân Quyền và Đóng form
        public void DongForm()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            chuyenXe = null;
            nhanVien = null;
            phanCong = null;
            tramXe = null;
            nhanVien = null;
            tuyenXe = null;
            dangNhap = null;
            xeBuyt = null;
        }
        public void QuyenAdmin()
        {
            mnNhanVien.Enabled = true;
            mnPhanCong.Enabled = true;
            mnTuyenXe.Enabled = true;
            mnThemTram.Enabled = true;
            mnChuyenXe.Enabled = true;
            mnXeBuyt.Enabled = true;
            //mnChiTiet.Enabled = true;
        }

        public void QuyenUser()
        {
            mnNhanVien.Enabled = false;
            mnPhanCong.Enabled = false;
            mnTuyenXe.Enabled = true;
            mnThemTram.Enabled = false;
            mnChuyenXe.Enabled = true;
            mnXeBuyt.Enabled = true;
            //mnChiTiet.Enabled = true;
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
            DongForm();
            if (tuyenXe == null || tuyenXe.IsDisposed)
            {
                tuyenXe = new frmTuyenXe();
                tuyenXe.MdiParent = this;
                tuyenXe.Show();
            }
            else
                tuyenXe.Activate();
        }

        private void mnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void mnThemTram_Click(object sender, EventArgs e)
        {
            DongForm();
            if (tramXe == null || tramXe.IsDisposed)
            {
                tramXe = new frmTramXe();
                tramXe.MdiParent = this;
                tramXe.Show();
            }
            else
                tramXe.Activate();
        }

        private void mnChuyenXe_Click(object sender, EventArgs e)
        {
            DongForm();
            if (chuyenXe == null || chuyenXe.IsDisposed)
            {
                chuyenXe = new frmChuyenXe();
                chuyenXe.MdiParent = this;
                chuyenXe.Show();
            }
            else
                chuyenXe.Activate();
        }


        private void mnXeBuyt_Click(object sender, EventArgs e)
        {
            DongForm();
            if (xeBuyt == null || xeBuyt.IsDisposed)
            {
                xeBuyt = new frmXeBuyt();
                xeBuyt.MdiParent = this;
                xeBuyt.Show();
            }
            else
                xeBuyt.Activate();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            DongForm();
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnPhanCong_Click(object sender, EventArgs e)
        {
            DongForm();
            if (phanCong == null || phanCong.IsDisposed)
            {
                phanCong = new frmPhanCong();
                phanCong.MdiParent = this;
                phanCong.Show();
            }
            else
                phanCong.Activate();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            DongForm();
            if (dangNhap == null || dangNhap.IsDisposed)
            {
                dangNhap = new frmDangNhap();
                dangNhap.MdiParent = this;
                dangNhap.Show();
            }
            else
                dangNhap.Activate();
        }

        private void mnAccount_Click(object sender, EventArgs e)
        {

        }

        private void mnThongKeChuyenXe_Click(object sender, EventArgs e)
        {
            DongForm();
            if (thongKeChuyenXe == null || thongKeChuyenXe.IsDisposed)
            {
                thongKeChuyenXe = new frmThongKeChuyenXe();
                thongKeChuyenXe.MdiParent = this;
                thongKeChuyenXe.Show();
            }
            else
                thongKeChuyenXe.Activate();
        }

        private void mnThongKePhanCong_Click(object sender, EventArgs e)
        {
            DongForm();
            if (thongKePhanCong == null || thongKePhanCong.IsDisposed)
            {
                thongKePhanCong = new frmThongKePhanCong();
                thongKePhanCong.MdiParent = this;
                thongKePhanCong.Show();
            }
            else
                thongKePhanCong.Activate();
        }

        private void mnDashBoard_Click(object sender, EventArgs e)
        {
            DongForm();
            if (bieuDoChuyenXe == null || bieuDoChuyenXe.IsDisposed)
            {
                bieuDoChuyenXe = new frmBieuDoChuyenXe();
                bieuDoChuyenXe.MdiParent = this;
                bieuDoChuyenXe.Show();
            }
            else
                bieuDoChuyenXe.Activate();
        }
    }
}
    