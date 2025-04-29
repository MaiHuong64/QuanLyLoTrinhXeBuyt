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
            btnXuat = new Button();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            dvgTuyenXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapFileExcel = new ToolStripButton();
            btnXuatFileExcel = new ToolStripButton();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTuyenXe).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Location = new Point(38, 441);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 41);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm tuyến";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 441);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(795, 441);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(144, 41);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Location = new Point(147, 441);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 41);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgTuyenXe);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(13, 13);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 379);
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
            dvgTuyenXe.Location = new Point(4, 24);
            dvgTuyenXe.MultiSelect = false;
            dvgTuyenXe.Name = "dvgTuyenXe";
            dvgTuyenXe.ReadOnly = true;
            dvgTuyenXe.RowHeadersWidth = 51;
            dvgTuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTuyenXe.Size = new Size(1156, 324);
            dvgTuyenXe.TabIndex = 4;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, toolStripButton1, toolStripSeparator1, btnNhapFileExcel, btnXuatFileExcel });
            toolStrip.Location = new Point(4, 348);
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
            // frmTuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 506);
            Controls.Add(groupBox2);
            Controls.Add(btnXoa);
            Controls.Add(btnXuat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
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
        private Button btnXuat;
        private Button btnSua;
        private GroupBox groupBox2;
        private DataGridView dvgTuyenXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapFileExcel;
        private ToolStripButton btnXuatFileExcel;
    }
}