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
            
            label2 = new Label();
            groupBox2 = new GroupBox();
            dvgTramXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            txtTenTram = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTramXe).BeginInit();
            toolStrip.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 48);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên trạm xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgTramXe);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(6, 132);
            groupBox2.Margin = new Padding(6, 4, 6, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 4, 6, 4);
            groupBox2.Size = new Size(1356, 457);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách trạm xe";
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
            dvgTramXe.Size = new Size(1344, 397);
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
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(644, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(136, 42);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm trạm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenTram);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1382, 125);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạm xe";
            // 
            // txtTenTram
            // 
            txtTenTram.Location = new Point(143, 45);
            txtTenTram.Name = "txtTenTram";
            txtTenTram.Size = new Size(471, 30);
            txtTenTram.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 21;
            label1.Text = "Tên trạm";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(786, 38);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 42);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa trạm";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(917, 38);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 42);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Image = (Image)resources.GetObject("btnHuy.Image");
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(1050, 38);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 42);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuybo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(1181, 38);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 42);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTramXe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 593);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTramXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trạm xe";
            Load += frmTramXe_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTramXe).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn TenTuyen;
        private DataGridViewTextBoxColumn DiemDung;
        private DataGridViewTextBoxColumn ChuyenXe;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dvgTramXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;

        private Button btnThem;
        private GroupBox groupBox3;
        private TextBox txtTenTram;
        private Label label1;
        private Button btnSua;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        
    }
}