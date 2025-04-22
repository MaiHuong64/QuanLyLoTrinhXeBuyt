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
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label4 = new Label();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            cboVaiTro = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            dtNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            dvgNhanVien = new DataGridView();
            ChuyenXeID = new DataGridViewTextBoxColumn();
            TenChuyen = new DataGridViewTextBoxColumn();
            DiemXuatPhat = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            TenTuyen = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNhanVien).BeginInit();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(704, 92);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(185, 27);
            txtDiaChi.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 94);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 19;
            label6.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(125, 82);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(185, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 92);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 15;
            label4.Text = "Điện thoại:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(125, 40);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(185, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboVaiTro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1152, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(931, 95);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 29;
            label8.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(995, 91);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(151, 28);
            cboVaiTro.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 53);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 26;
            label5.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 47);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 25;
            label3.Text = "Ngày sinh:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radNu);
            groupBox3.Controls.Add(radNam);
            groupBox3.Location = new Point(704, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 62);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(129, 25);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 0;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(15, 25);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = DateTimePickerFormat.Short;
            dtNgaySinh.Location = new Point(425, 40);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(185, 27);
            dtNgaySinh.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(425, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 94);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 21;
            label2.Text = "Email:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Controls.Add(dvgNhanVien);
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
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, btnTimKiem, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
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
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 27);
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(38, 24);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
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
            btnNhapFileExcel.Click += btnNhapFileExcel_Click;
            // 
            // btnXuatFileExcel
            // 
            btnXuatFileExcel.ImageTransparentColor = Color.Magenta;
            btnXuatFileExcel.Name = "btnXuatFileExcel";
            btnXuatFileExcel.Size = new Size(52, 24);
            btnXuatFileExcel.Text = "Xuất...";
            btnXuatFileExcel.ToolTipText = "Xuất ra tập tin Excel";
            btnXuatFileExcel.Click += btnXuatFileExcel_Click;
            // 
            // dvgNhanVien
            // 
            dvgNhanVien.AllowUserToAddRows = false;
            dvgNhanVien.AllowUserToDeleteRows = false;
            dvgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNhanVien.Columns.AddRange(new DataGridViewColumn[] { ChuyenXeID, TenChuyen, DiemXuatPhat, ThoiGianDi, TenTuyen, BienSo });
            dvgNhanVien.Dock = DockStyle.Fill;
            dvgNhanVien.Location = new Point(4, 24);
            dvgNhanVien.MultiSelect = false;
            dvgNhanVien.Name = "dvgNhanVien";
            dvgNhanVien.ReadOnly = true;
            dvgNhanVien.RowHeadersVisible = false;
            dvgNhanVien.RowHeadersWidth = 51;
            dvgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgNhanVien.Size = new Size(1156, 351);
            dvgNhanVien.TabIndex = 0;
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
            ClientSize = new Size(1176, 609);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtDienThoai;
        private Label label4;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtHoVaTen;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
        private DataGridView dvgNhanVien;
        private DataGridViewTextBoxColumn ChuyenXeID;
        private DataGridViewTextBoxColumn TenChuyen;
        private DataGridViewTextBoxColumn DiemXuatPhat;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn BienSo;
        private Label label3;
        private GroupBox groupBox3;
        private RadioButton radNam;
        private DateTimePicker dtNgaySinh;
        private TextBox txtEmail;
        private Label label2;
        private Label label5;
        private RadioButton radNu;
        private Label label8;
        private ComboBox cboVaiTro;
    }
}