namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmNhanVien
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
            cboQuyenHan = new ComboBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label4 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            cboChucVu = new ComboBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            gridChuyenXe = new DataGridView();
            ChuyenXeID = new DataGridViewTextBoxColumn();
            TenChuyen = new DataGridViewTextBoxColumn();
            DiemXuatPhat = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            TenTuyen = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).BeginInit();
            SuspendLayout();
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(786, 92);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(133, 28);
            cboQuyenHan.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 95);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 21;
            label5.Text = "Quyền hạn (*):";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(413, 11);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(185, 27);
            txtDiaChi.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 14);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 19;
            label6.Text = "Địa chỉ:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(768, 53);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(151, 27);
            txtMatKhau.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 56);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 17;
            label3.Text = "Mật khẩu (*):";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(125, 48);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(185, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 51);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 15;
            label4.Text = "Điện thoại:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(825, 133);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(725, 133);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(313, 95);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(525, 133);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(425, 133);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Huỷ bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(325, 133);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 133);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(125, 133);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 133);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(786, 18);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(151, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 14);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(125, 15);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(185, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(111, 95);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(185, 27);
            txtTimKiem.TabIndex = 25;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboChucVu.Location = new Point(425, 47);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(185, 28);
            cboChucVu.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 53);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 23;
            label7.Text = "Chức vụ (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Controls.Add(gridChuyenXe);
            groupBox2.Location = new Point(13, 227);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 379);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, toolStripButton1, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
            toolStrip.Location = new Point(4, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1156, 27);
            toolStrip.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 24);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(150, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(38, 24);
            toolStripButton1.Text = "Tìm";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnNhapFileExcel
            // 
            btnNhapFileExcel.ImageTransparentColor = Color.Magenta;
            btnNhapFileExcel.Name = "btnNhapFileExcel";
            btnNhapFileExcel.Size = new Size(58, 24);
            btnNhapFileExcel.Text = "Nhập...";
            btnNhapFileExcel.ToolTipText = "Nhập dữ liệu từ Excel";
            // 
            // btnXuatFileExcel
            // 
            btnXuatFileExcel.ImageTransparentColor = Color.Magenta;
            btnXuatFileExcel.Name = "btnXuatFileExcel";
            btnXuatFileExcel.Size = new Size(52, 24);
            btnXuatFileExcel.Text = "Xuất...";
            btnXuatFileExcel.ToolTipText = "Xuất ra tập tin Excel";
            // 
            // gridChuyenXe
            // 
            gridChuyenXe.AllowUserToAddRows = false;
            gridChuyenXe.AllowUserToDeleteRows = false;
            gridChuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridChuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridChuyenXe.Columns.AddRange(new DataGridViewColumn[] { ChuyenXeID, TenChuyen, DiemXuatPhat, ThoiGianDi, TenTuyen, BienSo });
            gridChuyenXe.Dock = DockStyle.Fill;
            gridChuyenXe.Location = new Point(4, 24);
            gridChuyenXe.MultiSelect = false;
            gridChuyenXe.Name = "gridChuyenXe";
            gridChuyenXe.ReadOnly = true;
            gridChuyenXe.RowHeadersVisible = false;
            gridChuyenXe.RowHeadersWidth = 51;
            gridChuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridChuyenXe.Size = new Size(1156, 351);
            gridChuyenXe.TabIndex = 0;
            // 
            // ChuyenXeID
            // 
            ChuyenXeID.DataPropertyName = "ChuyenXeID";
            ChuyenXeID.HeaderText = "Mã chuyến xe";
            ChuyenXeID.MinimumWidth = 6;
            ChuyenXeID.Name = "ChuyenXeID";
            ChuyenXeID.ReadOnly = true;
            // 
            // TenChuyen
            // 
            TenChuyen.DataPropertyName = "TenChuyen";
            TenChuyen.HeaderText = "Tên chuyến";
            TenChuyen.MinimumWidth = 6;
            TenChuyen.Name = "TenChuyen";
            TenChuyen.ReadOnly = true;
            // 
            // DiemXuatPhat
            // 
            DiemXuatPhat.DataPropertyName = "DiemXuatPhat";
            DiemXuatPhat.HeaderText = "Điểm xuất phát";
            DiemXuatPhat.MinimumWidth = 6;
            DiemXuatPhat.Name = "DiemXuatPhat";
            DiemXuatPhat.ReadOnly = true;
            // 
            // ThoiGianDi
            // 
            ThoiGianDi.DataPropertyName = "ThoiGianDi";
            ThoiGianDi.HeaderText = "Thời gian đi";
            ThoiGianDi.MinimumWidth = 6;
            ThoiGianDi.Name = "ThoiGianDi";
            ThoiGianDi.ReadOnly = true;
            // 
            // TenTuyen
            // 
            TenTuyen.DataPropertyName = "TenTuyen";
            TenTuyen.HeaderText = "Tên tuyến";
            TenTuyen.MinimumWidth = 6;
            TenTuyen.Name = "TenTuyen";
            TenTuyen.ReadOnly = true;
            // 
            // BienSo
            // 
            BienSo.DataPropertyName = "BienSo";
            BienSo.HeaderText = "Biến số";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 699);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboQuyenHan;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label4;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private TextBox txtHoVaTen;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox cboChucVu;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
        private DataGridView gridChuyenXe;
        private DataGridViewTextBoxColumn ChuyenXeID;
        private DataGridViewTextBoxColumn TenChuyen;
        private DataGridViewTextBoxColumn DiemXuatPhat;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn BienSo;
    }
}