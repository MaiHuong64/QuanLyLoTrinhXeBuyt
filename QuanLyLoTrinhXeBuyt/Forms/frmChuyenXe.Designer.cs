namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmChuyenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenXe));
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cboTuyenXe = new ComboBox();
            label5 = new Label();
            txtTenChuyenXe = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cboDiemXuatPhat = new ComboBox();
            label1 = new Label();
            dtpThoiGianDen = new DateTimePicker();
            label4 = new Label();
            cboXe = new ComboBox();
            label7 = new Label();
            dtpThoiGianDi = new DateTimePicker();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dvgChuyenXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgChuyenXe).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(265, 198);
            btnThoat.Margin = new Padding(6, 4, 6, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 40);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Image = (Image)resources.GetObject("btnHuyBo.Image");
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(135, 198);
            btnHuyBo.Margin = new Padding(6, 4, 6, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(118, 40);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.BottomLeft;
            btnLuu.Location = new Point(14, 198);
            btnLuu.Margin = new Padding(6, 4, 6, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(109, 40);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(265, 150);
            btnSua.Margin = new Padding(6, 4, 6, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(135, 150);
            btnXoa.Margin = new Padding(6, 4, 6, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 40);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboTuyenXe
            // 
            cboTuyenXe.FormattingEnabled = true;
            cboTuyenXe.Items.AddRange(new object[] { "Đang hoạt động", "Đang bảo trì" });
            cboTuyenXe.Location = new Point(1185, 83);
            cboTuyenXe.Margin = new Padding(6, 4, 6, 4);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(228, 30);
            cboTuyenXe.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1038, 91);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 9;
            label5.Text = "Tuyến xe";
            // 
            // txtTenChuyenXe
            // 
            txtTenChuyenXe.Location = new Point(164, 41);
            txtTenChuyenXe.Margin = new Padding(6, 4, 6, 4);
            txtTenChuyenXe.Name = "txtTenChuyenXe";
            txtTenChuyenXe.Size = new Size(283, 30);
            txtTenChuyenXe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 4;
            label2.Text = "Tên chuyến xe";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(14, 150);
            btnThem.Margin = new Padding(6, 4, 6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboDiemXuatPhat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpThoiGianDen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboXe);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpThoiGianDi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(cboTuyenXe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenChuyenXe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(4, 16);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(1600, 243);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // cboDiemXuatPhat
            // 
            cboDiemXuatPhat.FormattingEnabled = true;
            cboDiemXuatPhat.Location = new Point(678, 84);
            cboDiemXuatPhat.Margin = new Padding(4, 3, 4, 3);
            cboDiemXuatPhat.Name = "cboDiemXuatPhat";
            cboDiemXuatPhat.Size = new Size(240, 30);
            cboDiemXuatPhat.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1038, 38);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 22);
            label1.TabIndex = 25;
            label1.Text = "Thời gian đến";
            // 
            // dtpThoiGianDen
            // 
            dtpThoiGianDen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiGianDen.Format = DateTimePickerFormat.Custom;
            dtpThoiGianDen.Location = new Point(1185, 36);
            dtpThoiGianDen.Margin = new Padding(4, 3, 4, 3);
            dtpThoiGianDen.Name = "dtpThoiGianDen";
            dtpThoiGianDen.Size = new Size(228, 30);
            dtpThoiGianDen.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 91);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 23;
            label4.Text = "Xe buýt";
            // 
            // cboXe
            // 
            cboXe.FormattingEnabled = true;
            cboXe.Location = new Point(169, 84);
            cboXe.Margin = new Padding(4, 3, 4, 3);
            cboXe.Name = "cboXe";
            cboXe.Size = new Size(278, 30);
            cboXe.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 44);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 22);
            label7.TabIndex = 19;
            label7.Text = "Thời gian đi";
            // 
            // dtpThoiGianDi
            // 
            dtpThoiGianDi.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiGianDi.Format = DateTimePickerFormat.Custom;
            dtpThoiGianDi.Location = new Point(678, 41);
            dtpThoiGianDi.Margin = new Padding(4, 3, 4, 3);
            dtpThoiGianDi.Name = "dtpThoiGianDi";
            dtpThoiGianDi.Size = new Size(240, 30);
            dtpThoiGianDi.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 98);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 22);
            label6.TabIndex = 16;
            label6.Text = "Điểm xuất phát";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgChuyenXe);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(4, 268);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(1594, 383);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dvgChuyenXe
            // 
            dvgChuyenXe.AllowUserToAddRows = false;
            dvgChuyenXe.AllowUserToDeleteRows = false;
            dvgChuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgChuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgChuyenXe.Dock = DockStyle.Fill;
            dvgChuyenXe.Location = new Point(6, 56);
            dvgChuyenXe.Margin = new Padding(4, 3, 4, 3);
            dvgChuyenXe.MultiSelect = false;
            dvgChuyenXe.Name = "dvgChuyenXe";
            dvgChuyenXe.ReadOnly = true;
            dvgChuyenXe.RowHeadersWidth = 51;
            dvgChuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgChuyenXe.Size = new Size(1582, 323);
            dvgChuyenXe.TabIndex = 4;
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, btnTimKiem, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
            toolStrip.Location = new Point(6, 27);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1582, 29);
            toolStrip.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(91, 26);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(206, 29);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(66, 26);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // btnNhapFileExcel
            // 
            btnNhapFileExcel.Image = (Image)resources.GetObject("btnNhapFileExcel.Image");
            btnNhapFileExcel.ImageTransparentColor = Color.Magenta;
            btnNhapFileExcel.Name = "btnNhapFileExcel";
            btnNhapFileExcel.Size = new Size(91, 26);
            btnNhapFileExcel.Text = "Nhập...";
            btnNhapFileExcel.ToolTipText = "Nhập dữ liệu từ Excel";
            btnNhapFileExcel.Click += btnNhapFileExcel_Click;
            // 
            // btnXuatFileExcel
            // 
            btnXuatFileExcel.Image = (Image)resources.GetObject("btnXuatFileExcel.Image");
            btnXuatFileExcel.ImageTransparentColor = Color.Magenta;
            btnXuatFileExcel.Name = "btnXuatFileExcel";
            btnXuatFileExcel.Size = new Size(86, 26);
            btnXuatFileExcel.Text = "Xuất...";
            btnXuatFileExcel.ToolTipText = "Xuất ra tập tin Excel";
            btnXuatFileExcel.Click += btnXuatFileExcel_Click;
            // 
            // frmChuyenXe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1609, 688);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChuyenXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chuyến xe";
            Load += frmChuyenXe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgChuyenXe).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox cboTuyenXe;
        private Label label5;
        private TextBox txtTenChuyenXe;
        private Label label2;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label6;
        private DateTimePicker dtpThoiGianDi;
        private Label label7;
        private ComboBox cboXe;
        private Label label4;
        private Label label1;
        private DateTimePicker dtpThoiGianDen;
        private ComboBox cboDiemXuatPhat;
        private GroupBox groupBox2;
        private DataGridView dvgChuyenXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
    }
}