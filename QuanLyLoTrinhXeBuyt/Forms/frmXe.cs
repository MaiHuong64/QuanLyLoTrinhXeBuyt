using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        string imagesPath = Application.StartupPath.Replace("\\bin\\Debug\\net 8.0-winddows", "Images");
        private string tempImage = null;


        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnDoiAnh.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtBienSo.Enabled = giaTri;
            txtMaXe.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
        }
        private void XoaAnhCu(string old)
        {
            if (picHinhAnh.Image != null)
            {
                string oldImagePath = Path.Combine(imagesPath, old);
                if (File.Exists(oldImagePath))
                {
                    try
                    {
                        picHinhAnh.Image.Dispose(); // Giải phóng tài nguyên hình ảnh
                        picHinhAnh.Image = null; // Đặt hình ảnh thành null
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa ảnh cũ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void XoaTrang()
        {
            txtMaXe.Clear();
            txtBienSo.Clear();
            cboTrangThai.SelectedValue = -1;
            picHinhAnh.Image = null;
            tempImage = null;
        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
          
            dvgXeBuyt.AutoGenerateColumns = false;  
            if(dvgXeBuyt.Columns.Count == 0)
            {
                dvgXeBuyt.Columns.Add(new DataGridViewTextBoxColumn { Name = "XeID", DataPropertyName = "XeID", HeaderText = "Mã xe buýt" });
                dvgXeBuyt.Columns.Add(new DataGridViewTextBoxColumn { Name = "BienSo", DataPropertyName = "BienSo", HeaderText = "Biển số" });
                dvgXeBuyt.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", DataPropertyName = "TrangThai", HeaderText = "Trạng thái" });

                dvgXeBuyt.Columns.Add(new DataGridViewImageColumn()
                {
                    Name = "HinhAnh",
                    HeaderText = "Hình Ảnh",
                    DataPropertyName = "HinhAnh",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 100
                });
            }

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
                //Ten anh
                string img = e.Value.ToString();
                if(string.IsNullOrEmpty(img))
                {
                    e.Value = Path.Combine(imagesPath, "no-image.png");
                }
                else
                {
                    e.Value = Path.Combine(Path.GetFileName(imagesPath), e.Value.ToString());
                }
              
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dvgXeBuyt.DataSource = bindingSource;
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            XoaTrang();
            txtMaXe.Focus();
        }
        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtMaXe.Text))
            {
                MessageBox.Show("Mã xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaXe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Biển số không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSo.Focus();
                return false;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return false;
            }

            return true;
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
            if (!KiemTraHopLe()) return;
            if (id == 0)
            {
                XeBuyt xe = new XeBuyt();
                //xe.XeID = txtMaXe.Text;
                xe.BienSo = txtBienSo.Text;

                xe.TrangThai = cboTrangThai.SelectedItem.ToString();
                xe.HinhAnh = string.IsNullOrEmpty(tempImage) ? "no-image.png" : tempImage.ToString();

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
                    // Kiểm tra nếu không có ảnh mới, dùng ảnh cũ hoặc ảnh mặc định
                    xe.HinhAnh = string.IsNullOrEmpty(picHinhAnh.Tag?.ToString()) ? xe.HinhAnh ?? "no-image.png" : picHinhAnh.Tag.ToString();

                    context.Update(xe);

                    context.SaveChanges();
                }
            }
            frmXe_Load(sender, e);
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
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string oldFileName = picHinhAnh.Tag?.ToString();

                // Chuẩn hóa tên file: chuyển về chữ thường, thay khoảng trắng bằng dấu '-'
                string normalizedFileName = Regex.Replace(fileName.ToLower(), @"[^a-z0-9]+", "-") + ext;
                string destPath = Path.Combine(imagesPath, normalizedFileName);

                // Kiểm tra trùng lặp và tạo tên mới nếu cần
                int counter = 1;
                while (File.Exists(destPath))
                {
                    normalizedFileName = Regex.Replace(fileName.ToLower(), @"[^a-z0-9]+", "-") + $"-{counter}" + ext;
                    destPath = Path.Combine(imagesPath, normalizedFileName);
                    counter++;
                }

                // Xóa file ảnh cũ nếu không phải ảnh mặc định
                if (!string.IsNullOrEmpty(oldFileName) && oldFileName != "no-image.png")
                {
                    XoaAnhCu(oldFileName);
                }
                // Sao chép file mới vào thư mục
                File.Copy(openFileDialog.FileName, destPath, true);

                // Hiển thị ảnh mới
                picHinhAnh.Image = Image.FromFile(destPath);
                picHinhAnh.Tag = normalizedFileName;
            }
        }

        private void dvgXeBuyt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dvgXeBuyt.Columns[e.ColumnIndex].Name == "HinhAnh")
                {
                    string path = Path.Combine(imagesPath, e.Value.ToString());
                    if (File.Exists(path))
                    {
                        using (var anhGoc = Image.FromFile(path))
                        {
                            e.Value = new Bitmap(anhGoc, 24, 24);
                        }
                    }
                    else
                    {
                        string defaultImagePath = Path.Combine(imagesPath, "no-image.png");
                        if (File.Exists(defaultImagePath))
                        {
                            using (var defaultImage = Image.FromFile(defaultImagePath))
                            {
                                e.Value = new Bitmap(defaultImage, 24, 24);
                            }
                        }
                        else
                        {
                            e.Value = null; // Nếu không tìm thấy ảnh mặc định, đặt giá trị là null
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi định dạng ô: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
