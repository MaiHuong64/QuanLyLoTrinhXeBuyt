namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            btnHuyBo = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHienThi = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(181, 233);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(29, 233);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 13;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(29, 143);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(254, 36);
            txtMatKhau.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(29, 103);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.Size = new Size(254, 34);
            txtTenDangNhap.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(246, 50);
            label1.TabIndex = 8;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnHienThi
            // 
            btnHienThi.AutoSize = true;
            btnHienThi.Location = new Point(29, 194);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(148, 24);
            btnHienThi.TabIndex = 17;
            btnHienThi.Text = "Hiển thị mật khẩu";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.CheckedChanged += btnHienThi_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 282);
            Controls.Add(btnHienThi);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHuyBo;
        private Button btnDangNhap;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox btnHienThi;
    }
}