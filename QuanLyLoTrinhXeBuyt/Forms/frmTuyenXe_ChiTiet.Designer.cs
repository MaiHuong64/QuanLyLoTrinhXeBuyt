namespace QuanLyLoTrinhXeBuyt.Forms
{
    partial class frmTuyenXe_ChiTiet
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
            gridChiTiet = new DataGridView();
            groupBox2 = new GroupBox();
            btnLuu = new Button();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            txtGhiChu = new TextBox();
            txtTenTuyen = new TextBox();
            label2 = new Label();
            btnThemTuyen = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnXoaTram = new Button();
            btnThemTram = new Button();
            label1 = new Label();
            cboTramXe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridChiTiet).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridChiTiet
            // 
            gridChiTiet.AllowUserToAddRows = false;
            gridChiTiet.AllowUserToDeleteRows = false;
            gridChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridChiTiet.Dock = DockStyle.Fill;
            gridChiTiet.Location = new Point(3, 23);
            gridChiTiet.Name = "gridChiTiet";
            gridChiTiet.RowHeadersWidth = 51;
            gridChiTiet.Size = new Size(1005, 233);
            gridChiTiet.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridChiTiet);
            groupBox2.Location = new Point(18, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1011, 259);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(264, 465);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu tuyến xe";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(514, 465);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(txtTenTuyen);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnThemTuyen);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1017, 81);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết tuyến xe";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(457, 36);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(125, 27);
            txtGhiChu.TabIndex = 12;
            // 
            // txtTenTuyen
            // 
            txtTenTuyen.Location = new Point(102, 36);
            txtTenTuyen.Name = "txtTenTuyen";
            txtTenTuyen.Size = new Size(125, 27);
            txtTenTuyen.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 11;
            label2.Text = "Ghi chú";
            // 
            // btnThemTuyen
            // 
            btnThemTuyen.Location = new Point(698, 32);
            btnThemTuyen.Name = "btnThemTuyen";
            btnThemTuyen.Size = new Size(94, 29);
            btnThemTuyen.TabIndex = 8;
            btnThemTuyen.Text = "Thêm tuyen";
            btnThemTuyen.UseVisualStyleBackColor = true;
            btnThemTuyen.Click += btnThemTuyen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 38);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Tên tuyến";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaTram);
            groupBox1.Controls.Add(btnThemTram);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTramXe);
            groupBox1.Location = new Point(18, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1011, 88);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạm xe";
            // 
            // btnXoaTram
            // 
            btnXoaTram.Location = new Point(603, 35);
            btnXoaTram.Name = "btnXoaTram";
            btnXoaTram.Size = new Size(94, 29);
            btnXoaTram.TabIndex = 14;
            btnXoaTram.Text = "Xóa trạm";
            btnXoaTram.UseVisualStyleBackColor = true;
            btnXoaTram.Click += btnXoaTram_Click;
            // 
            // btnThemTram
            // 
            btnThemTram.Location = new Point(408, 36);
            btnThemTram.Name = "btnThemTram";
            btnThemTram.Size = new Size(94, 29);
            btnThemTram.TabIndex = 13;
            btnThemTram.Text = "Thêm trạm";
            btnThemTram.UseVisualStyleBackColor = true;
            btnThemTram.Click += btnThemTram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Tên Trạm";
            // 
            // cboTramXe
            // 
            cboTramXe.FormattingEnabled = true;
            cboTramXe.Location = new Point(138, 36);
            cboTramXe.Name = "cboTramXe";
            cboTramXe.Size = new Size(220, 28);
            cboTramXe.TabIndex = 0;
            // 
            // frmTuyenXe_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 501);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(groupBox2);
            Name = "frmTuyenXe_ChiTiet";
            Text = " ";
            Load += frmTuyenXe_TramXe_Load;
            ((System.ComponentModel.ISupportInitialize)gridChiTiet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridChiTiet;
        private GroupBox groupBox2;
        private Button btnLuu;
        private Button btnThoat;
        private GroupBox groupBox3;
        private TextBox txtGhiChu;
        private TextBox txtTenTuyen;
        private Label label2;
        private Button btnThemTuyen;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnXoaTram;
        private Button btnThemTram;
        private Label label1;
        private ComboBox cboTramXe;
    }
}