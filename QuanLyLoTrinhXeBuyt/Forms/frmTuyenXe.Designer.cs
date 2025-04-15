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
            groupBox1 = new GroupBox();
            gridTuyenXe = new DataGridView();
            label1 = new Label();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            btnLap = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            txtGhiChu = new TextBox();
            label3 = new Label();
            txtTenTuyenXe = new TextBox();
            btnLuu = new Button();
            label2 = new Label();
            txtMaTuyenXe = new TextBox();
            TuyenXeID = new DataGridViewTextBoxColumn();
            TenTuyen = new DataGridViewTextBoxColumn();
            Ghichu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridTuyenXe);
            groupBox1.Location = new Point(9, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách chuyến xe";
            // 
            // gridTuyenXe
            // 
            gridTuyenXe.AllowUserToAddRows = false;
            gridTuyenXe.AllowUserToDeleteRows = false;
            gridTuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTuyenXe.Columns.AddRange(new DataGridViewColumn[] { TuyenXeID, TenTuyen, Ghichu });
            gridTuyenXe.Dock = DockStyle.Fill;
            gridTuyenXe.Location = new Point(3, 23);
            gridTuyenXe.Name = "gridTuyenXe";
            gridTuyenXe.RowHeadersWidth = 51;
            gridTuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTuyenXe.Size = new Size(941, 315);
            gridTuyenXe.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã tuyến xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(76, 108);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLap);
            groupBox2.Controls.Add(btnHuyBo);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTenTuyenXe);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaTuyenXe);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(944, 171);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin  tuyến xe";
            // 
            // btnLap
            // 
            btnLap.Location = new Point(761, 108);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(146, 29);
            btnLap.TabIndex = 11;
            btnLap.Text = "Lập chi tiết";
            btnLap.UseVisualStyleBackColor = true;
            btnLap.Click += btnLap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(598, 108);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(146, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(430, 108);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(710, 46);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(125, 27);
            txtGhiChu.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 49);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Ghi chú";
            // 
            // txtTenTuyenXe
            // 
            txtTenTuyenXe.Location = new Point(404, 42);
            txtTenTuyenXe.Name = "txtTenTuyenXe";
            txtTenTuyenXe.Size = new Size(125, 27);
            txtTenTuyenXe.TabIndex = 6;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(250, 108);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(146, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 45);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên tuyến xe";
            // 
            // txtMaTuyenXe
            // 
            txtMaTuyenXe.Location = new Point(133, 42);
            txtMaTuyenXe.Name = "txtMaTuyenXe";
            txtMaTuyenXe.Size = new Size(125, 27);
            txtMaTuyenXe.TabIndex = 4;
            // 
            // TuyenXeID
            // 
            TuyenXeID.DataPropertyName = "TuyenXeID";
            TuyenXeID.HeaderText = "Mã Tuyến";
            TuyenXeID.MinimumWidth = 6;
            TuyenXeID.Name = "TuyenXeID";
            // 
            // TenTuyen
            // 
            TenTuyen.DataPropertyName = "TenTuyen";
            TenTuyen.HeaderText = "Tên chuyến";
            TenTuyen.MinimumWidth = 6;
            TenTuyen.Name = "TenTuyen";
            // 
            // Ghichu
            // 
            Ghichu.DataPropertyName = "Ghichu";
            Ghichu.HeaderText = "Ghi chú";
            Ghichu.MinimumWidth = 6;
            Ghichu.Name = "Ghichu";
            // 
            // frmTuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 529);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTuyenXe";
            Text = "TuyenXe";
            Load += frmTuyenXe_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView gridTuyenXe;
        private DataGridViewTextBoxColumn TenDiemDung;
        private Label label1;
        private Button btnThem;
        private GroupBox groupBox2;
        private TextBox txtMaTuyenXe;
        private TextBox txtTenTuyenXe;
        private Label label2;
        private Button btnLuu;
        private TextBox txtGhiChu;
        private Label label3;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnLap;
        private DataGridViewTextBoxColumn TuyenXeID;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn Ghichu;
    }
}