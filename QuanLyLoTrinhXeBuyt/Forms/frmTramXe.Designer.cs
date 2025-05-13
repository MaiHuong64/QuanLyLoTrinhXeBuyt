namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmTramXe
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTramXe));
            txtTenTramXe = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();

            groupBox2 = new GroupBox();
            dvgTramXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTramXe).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenTramXe
            // 

            txtTenTramXe.Location = new Point(231, 45);
            txtTenTramXe.Margin = new Padding(6, 4, 6, 4);
            txtTenTramXe.Name = "txtTenTramXe";
            txtTenTramXe.Size = new Size(947, 30);

            txtTenTramXe.TabIndex = 5;
            txtTenTramXe.KeyDown += txtTenTramXe_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;

            label2.Location = new Point(48, 48);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);

            label2.TabIndex = 4;
            label2.Text = "Tên trạm xe";
            // 
            // groupBox1
            // 

            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtTenTramXe);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(1356, 185);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(913, 112);
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
            btnHuyBo.Location = new Point(783, 112);
            btnHuyBo.Margin = new Padding(6, 4, 6, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(118, 40);
            btnHuyBo.TabIndex = 40;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.BottomLeft;
            btnLuu.Location = new Point(662, 112);
            btnLuu.Margin = new Padding(6, 4, 6, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(109, 40);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(537, 111);
            btnSua.Margin = new Padding(6, 4, 6, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(286, 111);
            btnThem.Margin = new Padding(6, 4, 6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(407, 111);
            btnXoa.Margin = new Padding(6, 4, 6, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 40);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgTramXe);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(18, 208);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(1356, 383);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dvgTramXe
            // 
            dvgTramXe.AllowUserToAddRows = false;
            dvgTramXe.AllowUserToDeleteRows = false;
            dvgTramXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTramXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTramXe.Dock = DockStyle.Fill;
            dvgTramXe.Location = new Point(6, 56);
            dvgTramXe.Margin = new Padding(4, 3, 4, 3);
            dvgTramXe.MultiSelect = false;
            dvgTramXe.Name = "dvgTramXe";
            dvgTramXe.ReadOnly = true;
            dvgTramXe.RowHeadersWidth = 51;
            dvgTramXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTramXe.Size = new Size(1344, 323);
            dvgTramXe.TabIndex = 4;
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTimKiem, toolStripButton1, toolStripSeparator1 });
            toolStrip.Location = new Point(6, 27);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1344, 29);
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
            // toolStripButton1
            // 

            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(66, 26);

            toolStripButton1.Text = "Tìm";
            toolStripButton1.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";

            toolStripSeparator1.Size = new Size(6, 29);

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

            // 
            // frmTramXe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTramXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trạm xe";
            Load += frmTramXe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTramXe).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn TuyenXeID;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn DiemDung;
        private DataGridViewTextBoxColumn ChuyenXe;
        private TextBox txtTenTramXe;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dvgTramXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;

        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;

    }
}