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
            picDisplay = new PictureBox();
            picHide = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            SuspendLayout();
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DodgerBlue;
            btnHuyBo.ForeColor = SystemColors.ButtonHighlight;
            btnHuyBo.Location = new Point(168, 218);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 44);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DodgerBlue;
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(29, 218);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 44);
            btnDangNhap.TabIndex = 13;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 13.8F);
            txtMatKhau.Location = new Point(29, 154);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '•';
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(219, 43);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 13.8F);
            txtTenDangNhap.Location = new Point(29, 103);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.Size = new Size(254, 45);
            txtTenDangNhap.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DodgerBlue;
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
            // picDisplay
            // 
            picDisplay.Image = (Image)resources.GetObject("picDisplay.Image");
            picDisplay.Location = new Point(254, 166);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(29, 22);
            picDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            picDisplay.TabIndex = 18;
            picDisplay.TabStop = false;
            picDisplay.Click += picDisplay_Click;
            // 
            // picHide
            // 
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(254, 163);
            picHide.Name = "picHide";
            picHide.Size = new Size(29, 25);
            picHide.SizeMode = PictureBoxSizeMode.Zoom;
            picHide.TabIndex = 19;
            picHide.TabStop = false;
            picHide.Click += picHide_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 282);
            Controls.Add(picHide);
            Controls.Add(picDisplay);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
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
        private PictureBox picDisplay;
        private PictureBox picHide;
    }
}