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
            btnThem = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridTuyenXe);
            groupBox1.Location = new Point(12, 12);
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
            gridTuyenXe.Dock = DockStyle.Fill;
            gridTuyenXe.Location = new Point(3, 23);
            gridTuyenXe.MultiSelect = false;
            gridTuyenXe.Name = "gridTuyenXe";
            gridTuyenXe.RowHeadersWidth = 51;
            gridTuyenXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTuyenXe.Size = new Size(941, 315);
            gridTuyenXe.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Location = new Point(38, 378);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 41);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm tuyến";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(627, 378);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(146, 41);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 378);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(795, 378);
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
            btnSua.Location = new Point(147, 378);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 41);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(472, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // frmTuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 435);
            Controls.Add(textBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnXuat);
            Controls.Add(groupBox1);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Name = "frmTuyenXe";
            Text = "TuyenXe";
            Load += frmTuyenXe_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTuyenXe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView gridTuyenXe;
        //private DataGridViewTextBoxColumn TenDiemDung;
        private Button btnThem;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnXuat;
        private Button btnSua;
        private TextBox textBox1;
    }
}