namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmXe
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
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cboTrangThai = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            numSoGhe = new NumericUpDown();
            label3 = new Label();
            txtBienSo = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            cboLoaiXe = new ComboBox();
            txtMaXe = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            gridXe = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoGhe).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridXe).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numSoGhe);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBienSo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboLoaiXe);
            groupBox1.Controls.Add(txtMaXe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1164, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe buýt";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(990, 99);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(148, 43);
            btnDoiAnh.TabIndex = 17;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(760, 17);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(204, 185);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 16;
            picHinhAnh.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1018, 209);
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
            btnHuyBo.Location = new Point(894, 209);
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
            btnLuu.Location = new Point(770, 209);
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
            btnSua.Location = new Point(637, 209);
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
            btnXoa.Location = new Point(513, 209);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đang bảo trì" });
            cboTrangThai.Location = new Point(138, 148);
            cboTrangThai.Margin = new Padding(4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(186, 33);
            cboTrangThai.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 97);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 26);
            label4.TabIndex = 8;
            label4.Text = "Số ghế";
            // 
            // numSoGhe
            // 
            numSoGhe.Location = new Point(477, 89);
            numSoGhe.Margin = new Padding(4);
            numSoGhe.Name = "numSoGhe";
            numSoGhe.Size = new Size(224, 33);
            numSoGhe.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 39);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 6;
            label3.Text = "Loại xe";
            // 
            // txtBienSo
            // 
            txtBienSo.Location = new Point(138, 89);
            txtBienSo.Margin = new Padding(4);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(186, 33);
            txtBienSo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 4;
            label2.Text = "Biển số xe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(389, 209);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Items.AddRange(new object[] { "Xe 7 chỗ", "Xe 16 chỗ " });
            cboLoaiXe.Location = new Point(477, 29);
            cboLoaiXe.Margin = new Padding(4);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(224, 33);
            cboLoaiXe.TabIndex = 2;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(138, 31);
            txtMaXe.Margin = new Padding(4);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(186, 33);
            txtMaXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 0;
            label1.Text = "Mã xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridXe);
            groupBox2.Location = new Point(18, 286);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1164, 337);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách xe buýt";
            // 
            // gridXe
            // 
            gridXe.AllowUserToAddRows = false;
            gridXe.AllowUserToDeleteRows = false;
            gridXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridXe.Dock = DockStyle.Fill;
            gridXe.Location = new Point(4, 30);
            gridXe.MultiSelect = false;
            gridXe.Name = "gridXe";
            gridXe.RowHeadersWidth = 51;
            gridXe.Size = new Size(1156, 303);
            gridXe.TabIndex = 0;
            gridXe.CellFormatting += gridXe_CellFormatting;
            // 
            // frmXe
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 622);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmXe";
            Load += frmXe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoGhe).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private NumericUpDown numSoGhe;
        private Label label3;
        private TextBox txtBienSo;
        private Label label2;
        private Button btnThem;
        private ComboBox cboLoaiXe;
        private TextBox txtMaXe;
        private Label label1;
        private Label label5;
        private ComboBox cboTrangThai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private DataGridView gridXe;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
    }
}