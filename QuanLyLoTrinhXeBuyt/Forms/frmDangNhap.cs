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
        public static string tennv = "";

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
                    string role = taikhoan.QuyenHan == "admin" ? "admin" : "user";
                    tennv = context.NhanVien.Where(t => t.NhanVienID == t.TaiKhoanID).Select(t => t.HoTen).SingleOrDefault();

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
            if (txtMatKhau.PasswordChar == '•')
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
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
