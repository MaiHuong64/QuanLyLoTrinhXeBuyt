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
    public partial class frmTramXe : Form
    {

        QLLTXBContext context = new QLLTXBContext();
        int id;
        bool xuLyThem = false;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;

            btnHuy.Enabled = giaTri;

            txtTenTram.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
        }
        public frmTramXe()
        {
            InitializeComponent();
        }
        private void frmTramXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<TramXe> tramXe = new List<TramXe>();
            tramXe = context.TramXe.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tramXe;
            dvgTramXe.DataSource = bindingSource;

            txtTenTram.DataBindings.Clear();
            txtTenTram.DataBindings.Add("Text", bindingSource, "TenTramXe", true, DataSourceUpdateMode.OnPropertyChanged);
            if (dvgTramXe.Columns.Count == 0)
            {
                dvgTramXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TramXeID", DataPropertyName = "TramXeID", HeaderText = "Mã trạm" });
                dvgTramXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTramXe", DataPropertyName = "TenTramXe", HeaderText = "Tên trạm" });

            }

            dvgTramXe.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            id = 0;
            txtTenTram.Clear();
            BatTatChucNang(true);
            txtTenTram.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất " + txtTenTram.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dvgTramXe.CurrentRow.Cells["TramXeID"].Value);
                TramXe tramXe = context.TramXe.Find(id);
                context.TramXe.Remove(tramXe);
                context.SaveChanges();
            }
            frmTramXe_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dvgTramXe.CurrentRow.Cells["TramXeID"].Value);
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                TramXe tramXe = new TramXe();
                tramXe.TenTramXe = txtTenTram.Text;
                context.TramXe.Add(tramXe);
            }
            else
            {
                TramXe tramXe = context.TramXe.Find(id);
                tramXe.TenTramXe = txtTenTram.Text;
                context.TramXe.Update(tramXe);
                
            }
            context.SaveChanges();
            frmTramXe_Load(sender, e);
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmTramXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dung?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tram = context.TramXe.Where(x => x.TenTramXe.Contains(txtTenTram.Text)).ToList();
            dvgTramXe.DataSource = tram;
        }

        private void txtTenTramXe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
