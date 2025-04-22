using BCrypt.Net;
using QuanLyLoTrinhXeBuyt.Data;
using System.Data;
using System;

namespace QuanLyLoTrinhXeBuyt.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QLLTXBContext context = new QLLTXBContext();
        private void btnHienThi_CheckedChanged(object sender, EventArgs e)
        {
            var pass = txtMatKhau.Text.Trim();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var user = txtTenDangNhap.Text.Trim();
            var pass = txtMatKhau.Text.Trim();

            if (user == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (pass == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else
            {
                var taikhoan = context.TaiKhoan.Where(t => t.TenDangNhap == user).SingleOrDefault();
                if (taikhoan == null || !BCrypt.Net.BCrypt.Verify(pass, taikhoan.MatKhau))
                {
                    MessageBox.Show("Tên đăng hoặc mật khẩu nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                }
                else
                {
                    MessageBox.Show($"Hash lưu trữ: {taikhoan.MatKhau}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bool isValid = BCrypt.Net.BCrypt.Verify(pass, taikhoan.MatKhau);
                    MessageBox.Show($"Kết quả kiểm tra: {isValid}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string role = taikhoan.QuyenHan == "admin" ? "admin" : "user";
                    var mainForm = new frmMain(role);
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

            private void picHide_Click(object sender, EventArgs e)
            {
                if (txtMatKhau.PasswordChar == '*')
                {
                    picDisplay.BringToFront();
                    txtMatKhau.PasswordChar = '\0';
                }
            }

            private void picDisplay_Click(object sender, EventArgs e)
            {
                if (txtMatKhau.PasswordChar == '\0')
                {
                    picHide.BringToFront();
                    txtMatKhau.PasswordChar = '*';
                }
            }


      
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
          
        }
    }
}
