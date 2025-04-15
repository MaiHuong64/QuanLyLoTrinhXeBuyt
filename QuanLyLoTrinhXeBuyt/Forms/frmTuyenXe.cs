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
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        bool xuLyThem = false;
        string id = "";
        void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtMaTuyenXe.Enabled = giaTri;
            txtTenTuyenXe.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;
        }
        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            gridTuyenXe.AutoGenerateColumns = false;

            List<TuyenXe> tuyenXe = context.TuyenXe.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tuyenXe;

            txtTenTuyenXe.DataBindings.Clear();
            txtTenTuyenXe.DataBindings.Add("Text", bindingSource, "TenTuyen", true, DataSourceUpdateMode.Never);

            txtMaTuyenXe.DataBindings.Clear();
            txtMaTuyenXe.DataBindings.Add("Text", bindingSource, "TuyenXeID", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", true, DataSourceUpdateMode.Never);

            gridTuyenXe.DataSource = bindingSource;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            id = "";
            //xuLyThem = true;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                TuyenXe tuyenXe = new TuyenXe();
                tuyenXe.TuyenXeID = txtTenTuyenXe.Text;
                tuyenXe.TenTuyen = txtMaTuyenXe.Text;

                //tuyenXe.GhiChu = txtGhiChu.Text;
                context.Add(tuyenXe);
                context.SaveChanges();
            }
            else
            {
                TuyenXe tuyenXe = context.TuyenXe.Find(id);
                if (tuyenXe != null)
                {
                    tuyenXe.TenTuyen = txtTenTuyenXe.Text;
                    //tuyenXe.GhiChu = txtGhiChu.Text;
                    context.Update(tuyenXe);
                    context.SaveChanges();
                }
            }
            frmTuyenXe_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = gridTuyenXe.CurrentRow.Cells["TuyenXeID"].Value.ToString();
            BatTatChucNang(true);
        }

        private void btnLap_Click(object sender, EventArgs e)
        {

        }
    }
}
