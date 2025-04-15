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
            btnHuybo.Enabled = giaTri;
            txtTenTramXe.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
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
            gridTramXe.DataSource = bindingSource;

            txtTenTramXe.DataBindings.Clear();
            txtTenTramXe.DataBindings.Add("Text", bindingSource, "TenTramXe", true, DataSourceUpdateMode.OnPropertyChanged);
            if (gridTramXe.Columns.Count == 0)
            {
                gridTramXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TramXeID", DataPropertyName = "TramXeID", HeaderText = "Mã trạm" });
                gridTramXe.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTramXe", DataPropertyName = "TenTramXe", HeaderText = "Tên trạm" });

            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            xuLyThem = true;
            txtTenTramXe.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất " + txtTenTramXe.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridTramXe.CurrentRow.Cells["TramXeID"].Value);
                TramXe tramXe = context.TramXe.Find(id);
                context.TramXe.Remove(tramXe);
                context.SaveChanges();
            }
            frmTramXe_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(gridTramXe.CurrentRow.Cells["TramXeID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                TramXe tramXe = new TramXe();
                tramXe.TenTramXe = txtTenTramXe.Text;
                context.TramXe.Add(tramXe);
                context.SaveChanges();
            }
            else
            {
                TramXe tramXe = context.TramXe.Find(id);
                tramXe.TenTramXe = txtTenTramXe.Text;
                context.TramXe.Update(tramXe);
                context.SaveChanges();
            }
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
            var tram = context.TramXe.Where(x => x.TenTramXe.Contains(txtTenTramXe.Text)).ToList();
            gridTramXe.DataSource = tram;
        }

        private void txtTenTramXe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
