namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmXeBuyt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXeBuyt));
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnDoiAnh = new Button();
            btnLuu = new Button();
            picHinhAnh = new PictureBox();
            btnSua = new Button();
            cboTrangThai = new ComboBox();
            btnXoa = new Button();
            label5 = new Label();
            btnThem = new Button();
            txtBienSo = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dvgXeBuyt = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            label1 = new Label();
            txtMaXe = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgXeBuyt).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtBienSo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaXe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1067, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe buýt";
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(931, 183);
            btnThoat.Margin = new Padding(6, 4, 6, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 40);
            btnThoat.TabIndex = 41;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Image = (Image)resources.GetObject("btnHuyBo.Image");
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(801, 183);
            btnHuyBo.Margin = new Padding(6, 4, 6, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(118, 40);
            btnHuyBo.TabIndex = 40;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Image = (Image)resources.GetObject("btnDoiAnh.Image");
            btnDoiAnh.ImageAlign = ContentAlignment.BottomLeft;
            btnDoiAnh.Location = new Point(904, 34);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(136, 38);
            btnDoiAnh.TabIndex = 17;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.TextAlign = ContentAlignment.MiddleRight;
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(680, 183);
            btnLuu.Margin = new Padding(6, 4, 6, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(109, 40);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(697, 15);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(187, 163);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 16;
            picHinhAnh.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(555, 182);
            btnSua.Margin = new Padding(6, 4, 6, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đang bảo trì" });
            cboTrangThai.Location = new Point(470, 27);
            cboTrangThai.Margin = new Padding(4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(171, 33);
            cboTrangThai.TabIndex = 10;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(425, 182);
            btnXoa.Margin = new Padding(6, 4, 6, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 40);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 33);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(304, 182);
            btnThem.Margin = new Padding(6, 4, 6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtBienSo
            // 
            txtBienSo.Location = new Point(126, 70);
            txtBienSo.Margin = new Padding(4);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(171, 33);
            txtBienSo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 4;
            label2.Text = "Biển số xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgXeBuyt);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(24, 252);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1062, 306);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách xe buýt";
            // 
            // dvgXeBuyt
            // 
            dvgXeBuyt.AllowUserToAddRows = false;
            dvgXeBuyt.AllowUserToDeleteRows = false;
            dvgXeBuyt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgXeBuyt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgXeBuyt.Dock = DockStyle.Fill;
            dvgXeBuyt.Location = new Point(4, 59);
            dvgXeBuyt.MultiSelect = false;
            dvgXeBuyt.Name = "dvgXeBuyt";
            dvgXeBuyt.ReadOnly = true;
            dvgXeBuyt.RowHeadersWidth = 51;
            dvgXeBuyt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgXeBuyt.Size = new Size(1054, 243);
            dvgXeBuyt.TabIndex = 4;
            dvgXeBuyt.CellFormatting += dvgXeBuyt_CellFormatting;
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, btnTimKiem, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
            toolStrip.Location = new Point(4, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1054, 29);
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
            txtTimKiem.Size = new Size(138, 29);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 0;
            label1.Text = "Mã xe";
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(126, 27);
            txtMaXe.Margin = new Padding(4);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(171, 33);
            txtMaXe.TabIndex = 1;
            // 
            // frmXeBuyt
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 559);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmXeBuyt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xe buýt";
            Load += frmXe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgXeBuyt).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBienSo;
        private Label label2;
        private Label label5;
        private ComboBox cboTrangThai;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private GroupBox groupBox2;
        private DataGridView dvgXeBuyt;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtMaXe;
        private Label label1;
    }
}