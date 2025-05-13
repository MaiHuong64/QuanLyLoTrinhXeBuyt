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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label4 = new Label();
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNhanVien).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(172, 78);
            txtDiaChi.Margin = new Padding(4, 4, 4, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(253, 30);
            txtDiaChi.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 81);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 19;
            label6.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(172, 116);
            txtDienThoai.Margin = new Padding(4, 4, 4, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(253, 30);
            txtDienThoai.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 15;
            label4.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(172, 40);
            txtHoVaTen.Margin = new Padding(4, 4, 4, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(253, 30);
            txtHoVaTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboVaiTro);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1584, 199);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 84);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 22);
            label8.TabIndex = 29;
            label8.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(547, 81);
            cboVaiTro.Margin = new Padding(4, 4, 4, 4);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(253, 30);
            cboVaiTro.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(547, 36);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 30);
            txtEmail.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 21;
            label2.Text = "Email:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgNhanVien);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(18, 220);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(1594, 383);
            groupBox2.TabIndex = 19;
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
            dvgNhanVien.Location = new Point(6, 56);
            dvgNhanVien.Margin = new Padding(4, 4, 4, 4);
            dvgNhanVien.MultiSelect = false;
            dvgNhanVien.Name = "dvgNhanVien";
            dvgNhanVien.ReadOnly = true;
            dvgNhanVien.RowHeadersWidth = 51;
            dvgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgNhanVien.Size = new Size(1582, 323);
            dvgNhanVien.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(826, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 33;
            label3.Text = "Vai trò:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(903, 110);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 30);
            comboBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(903, 31);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 30);
            textBox1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(826, 39);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 30;
            label5.Text = "Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(903, 72);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 30);
            textBox2.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(826, 80);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 22);
            label7.TabIndex = 34;
            label7.Text = "Email:";
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(1027, 160);
            btnThoat.Margin = new Padding(6, 4, 6, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 40);
            btnThoat.TabIndex = 41;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Image = (Image)resources.GetObject("btnHuyBo.Image");
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(903, 159);
            btnHuyBo.Margin = new Padding(6, 4, 6, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(113, 40);
            btnHuyBo.TabIndex = 40;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(769, 159);
            btnLuu.Margin = new Padding(6, 4, 6, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(122, 40);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(627, 160);
            btnSua.Margin = new Padding(6, 4, 6, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 40);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(503, 160);
            btnXoa.Margin = new Padding(6, 4, 6, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 40);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(369, 160);
            btnThem.Margin = new Padding(6, 4, 6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 40);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnSua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 602);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private TextBox txtHoVaTen;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label2;
        private Label label8;
        private ComboBox cboVaiTro;
        private GroupBox groupBox2;
        private DataGridView dvgNhanVien;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
        private TextBox textBox2;
        private Label label7;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}