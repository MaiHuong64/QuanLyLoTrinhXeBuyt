namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmDiemDung
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
            gridTuyenXe = new DataGridView();
            TuyenXeID = new DataGridViewTextBoxColumn();
            TenTuyen = new DataGridViewTextBoxColumn();
            DiemDung = new DataGridViewTextBoxColumn();
            ChuyenXe = new DataGridViewTextBoxColumn();
            cboChuyenXe = new ComboBox();
            cboDiemDung = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            btnThoat = new Button();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTenTuyenXe = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            txtNMaTuyenXe = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridTuyenXe);
            groupBox2.Location = new Point(13, 189);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 432);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các tuyến xe";
            // 
            // gridTuyenXe
            // 
            gridTuyenXe.AllowUserToAddRows = false;
            gridTuyenXe.AllowUserToDeleteRows = false;
            gridTuyenXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTuyenXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTuyenXe.Columns.AddRange(new DataGridViewColumn[] { TuyenXeID, TenTuyen, DiemDung, ChuyenXe });
            gridTuyenXe.Dock = DockStyle.Fill;
            gridTuyenXe.Location = new Point(4, 24);
            gridTuyenXe.MultiSelect = false;
            gridTuyenXe.Name = "gridTuyenXe";
            gridTuyenXe.ReadOnly = true;
            gridTuyenXe.RowHeadersVisible = false;
            gridTuyenXe.RowHeadersWidth = 51;
            gridTuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTuyenXe.Size = new Size(1156, 404);
            gridTuyenXe.TabIndex = 0;
            // 
            // TuyenXeID
            // 
            TuyenXeID.DataPropertyName = "TuyenXeID";
            TuyenXeID.HeaderText = "Mã tuyến xe";
            TuyenXeID.MinimumWidth = 6;
            TuyenXeID.Name = "TuyenXeID";
            TuyenXeID.ReadOnly = true;
            // 
            // TenTuyen
            // 
            TenTuyen.HeaderText = "Tên tuyến xe";
            TenTuyen.MinimumWidth = 6;
            TenTuyen.Name = "TenTuyen";
            TenTuyen.ReadOnly = true;
            // 
            // DiemDung
            // 
            DiemDung.HeaderText = "Điểm dừng";
            DiemDung.MinimumWidth = 6;
            DiemDung.Name = "DiemDung";
            DiemDung.ReadOnly = true;
            // 
            // ChuyenXe
            // 
            ChuyenXe.HeaderText = "Chuyến xe";
            ChuyenXe.MinimumWidth = 6;
            ChuyenXe.Name = "ChuyenXe";
            ChuyenXe.ReadOnly = true;
            // 
            // cboChuyenXe
            // 
            cboChuyenXe.FormattingEnabled = true;
            cboChuyenXe.Location = new Point(138, 73);
            cboChuyenXe.Name = "cboChuyenXe";
            cboChuyenXe.Size = new Size(186, 28);
            cboChuyenXe.TabIndex = 23;
            // 
            // cboDiemDung
            // 
            cboDiemDung.FormattingEnabled = true;
            cboDiemDung.Location = new Point(559, 71);
            cboDiemDung.Name = "cboDiemDung";
            cboDiemDung.Size = new Size(186, 28);
            cboDiemDung.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 20;
            label5.Text = "Chuyến xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 18;
            label4.Text = "Điểm dừng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1015, 107);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(116, 36);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuybo
            // 
            btnHuybo.Location = new Point(1015, 63);
            btnHuybo.Margin = new Padding(4);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(116, 36);
            btnHuybo.TabIndex = 14;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1015, 19);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 36);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(873, 104);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 36);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(873, 60);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTenTuyenXe
            // 
            txtTenTuyenXe.Location = new Point(559, 28);
            txtTenTuyenXe.Margin = new Padding(4);
            txtTenTuyenXe.Name = "txtTenTuyenXe";
            txtTenTuyenXe.Size = new Size(186, 27);
            txtTenTuyenXe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên Tuyến Xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(873, 16);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtNMaTuyenXe
            // 
            txtNMaTuyenXe.Location = new Point(138, 31);
            txtNMaTuyenXe.Margin = new Padding(4);
            txtNMaTuyenXe.Name = "txtNMaTuyenXe";
            txtNMaTuyenXe.Size = new Size(186, 27);
            txtNMaTuyenXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã tuyến xe";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboChuyenXe);
            groupBox1.Controls.Add(cboDiemDung);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuybo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtTenTuyenXe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtNMaTuyenXe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1164, 168);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
            // 
            // frmDiemDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 669);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDiemDung";
            Text = "Trạm xe";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView gridTuyenXe;
        private DataGridViewTextBoxColumn TuyenXeID;
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn DiemDung;
        private DataGridViewTextBoxColumn ChuyenXe;
        private ComboBox cboChuyenXe;
        private ComboBox cboDiemDung;
        private Label label5;
        private Label label4;
        private Button btnThoat;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTenTuyenXe;
        private Label label2;
        private Button btnThem;
        private TextBox txtNMaTuyenXe;
        private Label label1;
        private GroupBox groupBox1;
    }
}