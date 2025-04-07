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
            gridChuyenXe = new DataGridView();
            ChuyenXeID = new DataGridViewTextBoxColumn();
            TenChuyen = new DataGridViewTextBoxColumn();
            DiemXuatPhat = new DataGridViewTextBoxColumn();
            ThoiGianDi = new DataGridViewTextBoxColumn();
            ThoiGianDen = new DataGridViewTextBoxColumn();
            TuyenXeID = new DataGridViewTextBoxColumn();
            XeID = new DataGridViewTextBoxColumn();
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
            txtMaChuyenXe = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cboXe = new ComboBox();
            label3 = new Label();
            dtpThoiGianDen = new DateTimePicker();
            label7 = new Label();
            dtpThoiGianDi = new DateTimePicker();
            txtDiemXuatPhat = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridChuyenXe
            // 
            gridChuyenXe.AllowUserToAddRows = false;
            gridChuyenXe.AllowUserToDeleteRows = false;
            gridChuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridChuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridChuyenXe.Columns.AddRange(new DataGridViewColumn[] { ChuyenXeID, TenChuyen, DiemXuatPhat, ThoiGianDi, ThoiGianDen, TuyenXeID, XeID });
            gridChuyenXe.Dock = DockStyle.Fill;
            gridChuyenXe.Location = new Point(4, 24);
            gridChuyenXe.MultiSelect = false;
            gridChuyenXe.Name = "gridChuyenXe";
            gridChuyenXe.RowHeadersWidth = 51;
            gridChuyenXe.Size = new Size(1156, 351);
            gridChuyenXe.TabIndex = 0;
            // 
            // ChuyenXeID
            // 
            ChuyenXeID.HeaderText = "Mã Chuyến Xe";
            ChuyenXeID.MinimumWidth = 6;
            ChuyenXeID.Name = "ChuyenXeID";
            // 
            // TenChuyen
            // 
            TenChuyen.HeaderText = "Tên Chuyến Xe";
            TenChuyen.MinimumWidth = 6;
            TenChuyen.Name = "TenChuyen";
            // 
            // DiemXuatPhat
            // 
            DiemXuatPhat.HeaderText = "Điểm xuất phát";
            DiemXuatPhat.MinimumWidth = 6;
            DiemXuatPhat.Name = "DiemXuatPhat";
            // 
            // ThoiGianDi
            // 
            ThoiGianDi.HeaderText = "Thời Gian Đi";
            ThoiGianDi.MinimumWidth = 6;
            ThoiGianDi.Name = "ThoiGianDi";
            // 
            // ThoiGianDen
            // 
            ThoiGianDen.HeaderText = "Thời Gian Đến";
            ThoiGianDen.MinimumWidth = 6;
            ThoiGianDen.Name = "ThoiGianDen";
            // 
            // TuyenXeID
            // 
            TuyenXeID.HeaderText = "Tuyến Xe";
            TuyenXeID.MinimumWidth = 6;
            TuyenXeID.Name = "TuyenXeID";
            // 
            // XeID
            // 
            XeID.HeaderText = "Xe";
            XeID.MinimumWidth = 6;
            XeID.Name = "XeID";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1017, 159);
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
            btnHuyBo.Location = new Point(893, 159);
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
            btnLuu.Location = new Point(769, 159);
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
            btnSua.Location = new Point(645, 159);
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
            btnXoa.Location = new Point(521, 159);
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
            cboTuyenXe.Location = new Point(834, 31);
            cboTuyenXe.Margin = new Padding(4);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(203, 28);
            cboTuyenXe.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(748, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Tuyến xe";
            // 
            // txtTenChuyenXe
            // 
            txtTenChuyenXe.Location = new Point(138, 72);
            txtTenChuyenXe.Margin = new Padding(4);
            txtTenChuyenXe.Name = "txtTenChuyenXe";
            txtTenChuyenXe.Size = new Size(186, 27);
            txtTenChuyenXe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên chuyến xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(397, 159);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaChuyenXe
            // 
            txtMaChuyenXe.Location = new Point(138, 31);
            txtMaChuyenXe.Margin = new Padding(4);
            txtMaChuyenXe.Name = "txtMaChuyenXe";
            txtMaChuyenXe.Size = new Size(186, 27);
            txtMaChuyenXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã chuyến xe";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboXe);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpThoiGianDen);
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
            groupBox1.Controls.Add(txtMaChuyenXe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1164, 221);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(748, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 23;
            label4.Text = "Xe";
            // 
            // cboXe
            // 
            cboXe.FormattingEnabled = true;
            cboXe.Location = new Point(834, 70);
            cboXe.Name = "cboXe";
            cboXe.Size = new Size(203, 28);
            cboXe.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 21;
            label3.Text = "Thời gian đến";
            // 
            // dtpThoiGianDen
            // 
            dtpThoiGianDen.Format = DateTimePickerFormat.Time;
            dtpThoiGianDen.Location = new Point(484, 70);
            dtpThoiGianDen.Name = "dtpThoiGianDen";
            dtpThoiGianDen.Size = new Size(186, 27);
            dtpThoiGianDen.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 19;
            label7.Text = "Thời gian đi";
            // 
            // dtpThoiGianDi
            // 
            dtpThoiGianDi.Format = DateTimePickerFormat.Time;
            dtpThoiGianDi.Location = new Point(484, 27);
            dtpThoiGianDi.Name = "dtpThoiGianDi";
            dtpThoiGianDi.Size = new Size(186, 27);
            dtpThoiGianDi.TabIndex = 18;
            // 
            // txtDiemXuatPhat
            // 
            txtDiemXuatPhat.Location = new Point(138, 107);
            txtDiemXuatPhat.Margin = new Padding(4);
            txtDiemXuatPhat.Name = "txtDiemXuatPhat";
            txtDiemXuatPhat.Size = new Size(186, 27);
            txtDiemXuatPhat.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 16;
            label6.Text = "Điểm xuất phát";
            // 
            // frmChuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 639);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmChuyenXe";
            Text = "frmChuyenXe";
            Load += frmChuyenXe_Load;
            ((System.ComponentModel.ISupportInitialize)gridChuyenXe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridChuyenXe;
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
        private TextBox txtMaChuyenXe;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtDiemXuatPhat;
        private Label label6;
        private DateTimePicker dtpThoiGianDi;
        private Label label7;
        private Label label3;
        private DateTimePicker dtpThoiGianDen;
        private ComboBox cboXe;
        private Label label4;
        private DataGridViewTextBoxColumn ChuyenXeID;
        private DataGridViewTextBoxColumn TenChuyen;
        private DataGridViewTextBoxColumn DiemXuatPhat;
        private DataGridViewTextBoxColumn ThoiGianDi;
        private DataGridViewTextBoxColumn ThoiGianDen;
        private DataGridViewTextBoxColumn TuyenXeID;
        private DataGridViewTextBoxColumn XeID;
    }
}