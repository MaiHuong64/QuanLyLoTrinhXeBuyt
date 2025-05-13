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
            groupBox2 = new GroupBox();
            dvgTramXe = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            button3 = new Button();
            btnSua = new Button();
            button2 = new Button();
            button1 = new Button();
            btnThem = new Button();
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
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenTramXe);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(1356, 185);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chuyến xe";
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
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(687, 113);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 40);
            button3.TabIndex = 35;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(276, 112);
            btnSua.Margin = new Padding(6, 4, 6, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 40);
            btnSua.TabIndex = 32;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(562, 113);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 34;
            button2.Text = "Hủy bỏ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnHuybo_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(428, 113);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 40);
            button1.TabIndex = 33;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(141, 112);
            btnThem.Margin = new Padding(6, 4, 6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 40);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
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
        private GroupBox groupBox2;
        private DataGridView dvgTramXe;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private Button button3;
        private Button btnSua;
        private Button button2;
        private Button button1;
        private Button btnThem;
    }
}