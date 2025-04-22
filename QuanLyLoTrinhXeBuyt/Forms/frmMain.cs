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
        #region Phân Quyền
        public void QuyenAdmin()
        {
            
        }

        public void QuyenUser()
        {

        }
        #endregion


        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
