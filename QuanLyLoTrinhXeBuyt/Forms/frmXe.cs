using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmXeBuyt : Form
    {
        public frmXeBuyt()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtBienSo.Enabled = giaTri;
            txtMaXe.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<XeBuyt> xe = new List<XeBuyt>();
            xe = context.XeBuyt.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = xe;

            txtMaXe.DataBindings.Clear();
            txtMaXe.DataBindings.Add("Text", bindingSource, "XeID", true, DataSourceUpdateMode.Never);

            txtBienSo.DataBindings.Clear();
            txtBienSo.DataBindings.Add("Text", bindingSource, "BienSo", true, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", true, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dvgXeBuyt.DataSource = bindingSource;
        }
        private string GenerateSlug(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            // Chuyển thành chữ thường
            string slug = input.ToLower();

            // Loại bỏ ký tự không hợp lệ (giữ lại chữ cái, số và dấu '-')
            slug = Regex.Replace(slug, @"[^a-z0-9\s-]", "");

            // Thay khoảng trắng bằng dấu '-'
            slug = Regex.Replace(slug, @"\s+", "-").Trim('-');

            return slug;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtMaXe.Clear();
            txtBienSo.Clear();
            cboTrangThai.SelectedValue = -1;

            txtMaXe.Focus();
        }
        private void gridXe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvgXeBuyt.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    string imagePath = Path.Combine(imagesFolder, e.Value.ToString());

                    if (File.Exists(imagePath)) // Kiểm tra xem file có tồn tại không
                    {
                        try
                        {
                            using (Image image = Image.FromFile(imagePath)) // Đọc ảnh từ file
                            {
                                e.Value = new Bitmap(image, 24, 24); // Resize ảnh
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Value = new Bitmap(24, 24); // Ảnh trống nếu lỗi
                        }
                    }
                    else
                    {
                        e.Value = new Bitmap(24, 24); // Ảnh trống nếu file không tồn tại
                    }
                }
                else
                {
                    e.Value = new Bitmap(24, 24); // Ảnh trống nếu không có đường dẫn
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dvgXeBuyt.CurrentRow != null)
            {
                id = Convert.ToInt32(dvgXeBuyt.CurrentRow.Cells["XeID"].Value.ToString());
                XeBuyt xe = context.XeBuyt.Find(id);
                if (xe != null)
                {
                    context.XeBuyt.Remove(xe);
                    context.SaveChanges();
                }
                frmXe_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dvgXeBuyt.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dvgXeBuyt.CurrentRow.Cells["XeID"].Value.ToString());
                txtMaXe.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtMaXe.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaXe.Focus();
            //}
            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng nhập biển số xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSo.Focus();
            }
          

            else
            {
                if (id == 0)
                {
                    XeBuyt xe = new XeBuyt();
                    //xe.XeID = txtMaXe.Text;
                    xe.BienSo = txtBienSo.Text;
                 
                    xe.TrangThai = cboTrangThai.SelectedItem.ToString();
                    xe.HinhAnh = string.IsNullOrEmpty(picHinhAnh.ImageLocation) ? "" : Path.GetFileName(picHinhAnh.ImageLocation);

                    context.Add(xe);

                    context.SaveChanges();
                }
                else
                {
                    XeBuyt xe = context.XeBuyt.Find(id)!;
                    if (xe != null)
                    {
                        //xe.XeID = txtMaXe.Text;
                        xe.BienSo = txtBienSo.Text;
                     
                        xe.TrangThai = cboTrangThai.SelectedItem.ToString();
                        xe.HinhAnh = string.IsNullOrEmpty(picHinhAnh.ImageLocation) ? "" : Path.GetFileName(picHinhAnh.ImageLocation);

                        context.Update(xe);

                        context.SaveChanges();
                    }
                }
                frmXe_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, GenerateSlug(fileName) + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                id = Convert.ToInt32(dvgXeBuyt.CurrentRow.Cells["XeID"].Value.ToString());
                XeBuyt sp = context.XeBuyt.Find(id);
                sp.HinhAnh = GenerateSlug(fileName) + ext;

                context.XeBuyt.Update(sp); 
                context.SaveChanges();
                frmXe_Load(sender, e);

            }
        }
    }
}
