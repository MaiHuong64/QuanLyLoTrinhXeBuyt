namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmTuyenXe
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
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            dvgTuyenXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            btnHuy = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTuyenXe).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;

            btnThem.Location = new Point(52, 485);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 45);

            btnThem.Image = Properties.Resources.add1;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(38, 441);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 41);

            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm tuyến";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 

            btnXoa.Location = new Point(355, 485);
            btnXoa.Margin = new Padding(4, 3, 4, 3);

            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(273, 441);

            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 45);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;

            btnSua.Location = new Point(202, 485);
            btnSua.Margin = new Padding(4, 3, 4, 3);

            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(162, 441);

            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 45);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgTuyenXe);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(18, 14);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(1600, 417);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dvgTuyenXe
            // 
            dvgTuyenXe.AllowUserToAddRows = false;
            dvgTuyenXe.AllowUserToDeleteRows = false;
            dvgTuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTuyenXe.Dock = DockStyle.Bottom;
            dvgTuyenXe.Location = new Point(6, 30);
            dvgTuyenXe.Margin = new Padding(4, 3, 4, 3);
            dvgTuyenXe.MultiSelect = false;
            dvgTuyenXe.Name = "dvgTuyenXe";
            dvgTuyenXe.ReadOnly = true;
            dvgTuyenXe.RowHeadersWidth = 51;
            dvgTuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTuyenXe.Size = new Size(1588, 356);
            dvgTuyenXe.TabIndex = 4;
            dvgTuyenXe.CellContentClick += dvgTuyenXe_CellContentClick;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, btnTimKiem, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
            toolStrip.Location = new Point(6, 386);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1588, 27);
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
            txtTimKiem.Size = new Size(206, 27);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.pin_grey;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(58, 24);
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
            btnNhapFileExcel.Image = Properties.Resources.import1;
            btnNhapFileExcel.ImageTransparentColor = Color.Magenta;
            btnNhapFileExcel.Name = "btnNhapFileExcel";
            btnNhapFileExcel.Size = new Size(78, 24);
            btnNhapFileExcel.Text = "Nhập...";
            btnNhapFileExcel.ToolTipText = "Nhập dữ liệu từ Excel";
            // 
            // btnXuatFileExcel
            // 
            btnXuatFileExcel.Image = Properties.Resources.export1;
            btnXuatFileExcel.ImageTransparentColor = Color.Magenta;
            btnXuatFileExcel.Name = "btnXuatFileExcel";
            btnXuatFileExcel.Size = new Size(72, 24);
            btnXuatFileExcel.Text = "Xuất...";
            btnXuatFileExcel.ToolTipText = "Xuất ra tập tin Excel";
            btnXuatFileExcel.Click += btnXuatExcel_Click;
            // 
            // btnHuy
            // 

            btnHuy.Location = new Point(513, 485);
            btnHuy.Margin = new Padding(4, 3, 4, 3);

            btnHuy.Image = Properties.Resources.tải_xuống1;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(388, 441);

            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 45);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmTuyenXe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 557);
            Controls.Add(groupBox2);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTuyenXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TuyenXe";
            Load += frmTuyenXe_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTuyenXe).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private DataGridViewTextBoxColumn TenDiemDung;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox2;
        private DataGridView dvgTuyenXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
        private Button btnHuy;
    }
}