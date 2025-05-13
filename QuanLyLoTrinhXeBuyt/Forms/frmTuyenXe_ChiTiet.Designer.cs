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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuyenXe_ChiTiet));
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
            gridChiTiet.Location = new Point(4, 26);
            gridChiTiet.Margin = new Padding(4, 3, 4, 3);
            gridChiTiet.Name = "gridChiTiet";
            gridChiTiet.RowHeadersWidth = 51;
            gridChiTiet.Size = new Size(1382, 256);
            gridChiTiet.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridChiTiet);
            groupBox2.Location = new Point(25, 212);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1390, 285);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tuyến xe";
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(363, 512);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 55);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu tuyến xe";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(707, 512);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 55);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
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
            groupBox3.Location = new Point(16, 13);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1398, 89);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết tuyến xe";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(628, 40);
            txtGhiChu.Margin = new Padding(4, 3, 4, 3);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(170, 30);
            txtGhiChu.TabIndex = 12;
            // 
            // txtTenTuyen
            // 
            txtTenTuyen.Location = new Point(140, 40);
            txtTenTuyen.Margin = new Padding(4, 3, 4, 3);
            txtTenTuyen.Name = "txtTenTuyen";
            txtTenTuyen.Size = new Size(170, 30);
            txtTenTuyen.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 11;
            label2.Text = "Ghi chú";
            // 
            // btnThemTuyen
            // 
            btnThemTuyen.Image = (Image)resources.GetObject("btnThemTuyen.Image");
            btnThemTuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemTuyen.Location = new Point(997, 34);
            btnThemTuyen.Margin = new Padding(4, 3, 4, 3);
            btnThemTuyen.Name = "btnThemTuyen";
            btnThemTuyen.Size = new Size(149, 49);
            btnThemTuyen.TabIndex = 8;
            btnThemTuyen.Text = "Thêm tuyến";
            btnThemTuyen.TextAlign = ContentAlignment.MiddleRight;
            btnThemTuyen.UseVisualStyleBackColor = true;
            btnThemTuyen.Click += btnThemTuyen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 7;
            label5.Text = "Tên tuyến";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaTram);
            groupBox1.Controls.Add(btnThemTram);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTramXe);
            groupBox1.Location = new Point(25, 109);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1390, 97);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạm xe";
            // 
            // btnXoaTram
            // 
            btnXoaTram.Image = (Image)resources.GetObject("btnXoaTram.Image");
            btnXoaTram.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaTram.Location = new Point(828, 29);
            btnXoaTram.Margin = new Padding(4, 3, 4, 3);
            btnXoaTram.Name = "btnXoaTram";
            btnXoaTram.Size = new Size(129, 53);
            btnXoaTram.TabIndex = 14;
            btnXoaTram.Text = "Xóa trạm";
            btnXoaTram.TextAlign = ContentAlignment.MiddleRight;
            btnXoaTram.UseVisualStyleBackColor = true;
            btnXoaTram.Click += btnXoaTram_Click;
            // 
            // btnThemTram
            // 
            btnThemTram.Image = (Image)resources.GetObject("btnThemTram.Image");
            btnThemTram.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemTram.Location = new Point(563, 29);
            btnThemTram.Margin = new Padding(4, 3, 4, 3);
            btnThemTram.Name = "btnThemTram";
            btnThemTram.Size = new Size(139, 53);
            btnThemTram.TabIndex = 13;
            btnThemTram.Text = "Thêm trạm";
            btnThemTram.TextAlign = ContentAlignment.MiddleRight;
            btnThemTram.UseVisualStyleBackColor = true;
            btnThemTram.Click += btnThemTram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 22);
            label1.TabIndex = 13;
            label1.Text = "Tên Trạm";
            // 
            // cboTramXe
            // 
            cboTramXe.FormattingEnabled = true;
            cboTramXe.Location = new Point(190, 40);
            cboTramXe.Margin = new Padding(4, 3, 4, 3);
            cboTramXe.Name = "cboTramXe";
            cboTramXe.Size = new Size(301, 30);
            cboTramXe.TabIndex = 0;
            // 
            // frmTuyenXe_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 579);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTuyenXe_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết tuyến xe";
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