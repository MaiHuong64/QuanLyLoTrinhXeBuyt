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
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dvgNhanVien = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNhanVien).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(267, 92);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(185, 27);
            txtDiaChi.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 94);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 19;
            label6.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(454, 40);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(185, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 50);
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
            label8.Location = new Point(623, 98);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 29;
            label8.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(687, 94);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(151, 28);
            cboVaiTro.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(781, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 46);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 21;
            label2.Text = "Email:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgNhanVien);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(13, 227);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 379);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dvgNhanVien
            // 
            dvgNhanVien.AllowUserToAddRows = false;
            dvgNhanVien.AllowUserToDeleteRows = false;
            dvgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNhanVien.Dock = DockStyle.Fill;
            dvgNhanVien.Location = new Point(4, 51);
            dvgNhanVien.MultiSelect = false;
            dvgNhanVien.Name = "dvgNhanVien";
            dvgNhanVien.ReadOnly = true;
            dvgNhanVien.RowHeadersWidth = 51;
            dvgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgNhanVien.Size = new Size(1156, 324);
            dvgNhanVien.TabIndex = 4;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNhanVien).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
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
        private TextBox txtEmail;
        private Label label2;
        private DataGridView dvgNhanVien;
        private Label label8;
        private ComboBox cboVaiTro;
    }
}