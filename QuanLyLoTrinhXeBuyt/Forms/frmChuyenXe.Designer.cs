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
            groupBox2 = new GroupBox();
            gridChuyenXe = new DataGridView();
            ChuyenXeID = new DataGridViewTextBoxColumn();
            TenChuyen = new DataGridViewTextBoxColumn();
            DiemXuatPhat = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            TenTuyen = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            label4 = new Label();
            cboXe = new ComboBox();
            label7 = new Label();
            dtpThoiGianDi = new DateTimePicker();
            txtDiemXuatPhat = new TextBox();
            label6 = new Label();
            btnNhap = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(255, 178);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 36);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(130, 178);
            btnHuyBo.Margin = new Padding(4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(116, 36);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(10, 179);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 36);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(254, 136);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 36);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(130, 136);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboTuyenXe
            // 
            cboTuyenXe.FormattingEnabled = true;
            cboTuyenXe.Items.AddRange(new object[] { "Đang hoạt động", "Đang bảo trì" });
            cboTuyenXe.Location = new Point(702, 83);
            cboTuyenXe.Margin = new Padding(4);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(203, 28);
            cboTuyenXe.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(616, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Tuyến xe";
            // 
            // txtTenChuyenXe
            // 
            txtTenChuyenXe.Location = new Point(140, 37);
            txtTenChuyenXe.Margin = new Padding(4);
            txtTenChuyenXe.Name = "txtTenChuyenXe";
            txtTenChuyenXe.Size = new Size(186, 27);
            txtTenChuyenXe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên chuyến xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(10, 135);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridChuyenXe);
            groupBox2.Location = new Point(3, 244);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 379);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các chuyến xe";
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
            gridChuyenXe.CellContentClick += gridChuyenXe_CellContentClick;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboXe);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpThoiGianDi);
            groupBox1.Controls.Add(txtDiemXuatPhat);
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
            groupBox1.Location = new Point(3, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1164, 221);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(378, 178);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 36);
            btnXuat.TabIndex = 25;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 91);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 23;
            label4.Text = "Xe";
            // 
            // cboXe
            // 
            cboXe.FormattingEnabled = true;
            cboXe.Location = new Point(280, 88);
            cboXe.Name = "cboXe";
            cboXe.Size = new Size(203, 28);
            cboXe.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 19;
            label7.Text = "Thời gian đi";
            // 
            // dtpThoiGianDi
            // 
            dtpThoiGianDi.Format = DateTimePickerFormat.Time;
            dtpThoiGianDi.Location = new Point(493, 37);
            dtpThoiGianDi.Name = "dtpThoiGianDi";
            dtpThoiGianDi.ShowUpDown = true;
            dtpThoiGianDi.Size = new Size(186, 27);
            dtpThoiGianDi.TabIndex = 18;
            // 
            // txtDiemXuatPhat
            // 
            txtDiemXuatPhat.Location = new Point(893, 28);
            txtDiemXuatPhat.Margin = new Padding(4);
            txtDiemXuatPhat.Name = "txtDiemXuatPhat";
            txtDiemXuatPhat.Size = new Size(186, 27);
            txtDiemXuatPhat.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(765, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 16;
            label6.Text = "Điểm xuất phát";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(379, 135);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(93, 37);
            btnNhap.TabIndex = 26;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmChuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1170, 625);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChuyenXe";
            Text = "Chuyến xe";
            Load += frmChuyenXe_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtDiemXuatPhat;
        private Label label6;
        private DateTimePicker dtpThoiGianDi;
        private Label label7;
        private ComboBox cboXe;
        private Label label4;
        private DataGridView gridChuyenXe;
        private DataGridViewTextBoxColumn ChuyenXeID;
        private DataGridViewTextBoxColumn TenChuyen;
        private DataGridViewTextBoxColumn DiemXuatPhat;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn BienSo;
        private Button btnXuat;
        private Button btnNhap;
    }
}