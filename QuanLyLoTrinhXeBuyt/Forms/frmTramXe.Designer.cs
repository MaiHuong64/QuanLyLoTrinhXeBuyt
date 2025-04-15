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
            groupBox2 = new GroupBox();
            gridTramXe = new DataGridView();
            btnThoat = new Button();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTenTramXe = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTramXe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridTramXe);
            groupBox2.Location = new Point(13, 189);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(990, 270);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các tuyến xe";
            // 
            // gridTramXe
            // 
            gridTramXe.AllowUserToAddRows = false;
            gridTramXe.AllowUserToDeleteRows = false;
            gridTramXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTramXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTramXe.Dock = DockStyle.Fill;
            gridTramXe.Location = new Point(4, 24);
            gridTramXe.MultiSelect = false;
            gridTramXe.Name = "gridTramXe";
            gridTramXe.ReadOnly = true;
            gridTramXe.RowHeadersVisible = false;
            gridTramXe.RowHeadersWidth = 51;
            gridTramXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTramXe.Size = new Size(982, 242);
            gridTramXe.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(664, 83);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 36);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuybo
            // 
            btnHuybo.Location = new Point(540, 83);
            btnHuybo.Margin = new Padding(4);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(89, 36);
            btnHuybo.TabIndex = 14;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(416, 83);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 36);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(292, 83);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 36);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(168, 83);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenTramXe
            // 
            txtTenTramXe.Location = new Point(168, 41);
            txtTenTramXe.Margin = new Padding(4);
            txtTenTramXe.Name = "txtTenTramXe";
            txtTenTramXe.Size = new Size(690, 27);
            txtTenTramXe.TabIndex = 5;
            txtTenTramXe.KeyDown += txtTenTramXe_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên trạm xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 83);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuybo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtTenTramXe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(986, 168);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(769, 83);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(89, 36);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // frmTramXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 476);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTramXe";
            Text = "Trạm xe";
            Load += frmTramXe_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTramXe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView gridTramXe;
        private DataGridViewTextBoxColumn TuyenXeID;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn DiemDung;
        private DataGridViewTextBoxColumn ChuyenXe;
        private Button btnThoat;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTenTramXe;
        private Label label2;
        private Button btnThem;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnTimKiem;
    }
}