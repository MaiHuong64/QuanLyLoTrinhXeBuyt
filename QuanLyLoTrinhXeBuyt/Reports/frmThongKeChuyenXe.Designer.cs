namespace QuanLyLoTrinhXeBuyt.Reports
{
    partial class frmThongKeChuyenXe
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            cboTuyenXe = new ComboBox();
            label1 = new Label();
            btnLoc = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Bottom;
            reportViewer1.Location = new Point(0, 108);
            reportViewer1.Margin = new Padding(4, 3, 4, 3);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1838, 825);
            reportViewer1.TabIndex = 0;
            // 
            // cboTuyenXe
            // 
            cboTuyenXe.FormattingEnabled = true;
            cboTuyenXe.Location = new Point(559, 39);
            cboTuyenXe.Margin = new Padding(4, 3, 4, 3);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(377, 30);
            cboTuyenXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 2;
            label1.Text = "Tuyến xe";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(967, 38);
            btnLoc.Margin = new Padding(4, 3, 4, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(129, 32);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1105, 39);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 32);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmThongKeChuyenXe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1838, 933);
            Controls.Add(btnHuy);
            Controls.Add(btnLoc);
            Controls.Add(label1);
            Controls.Add(cboTuyenXe);
            Controls.Add(reportViewer1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmThongKeChuyenXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê chuyến xe";
            Load += frmThongKeChuyenXe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cboTuyenXe;
        private Label label1;
        private Button btnLoc;
        private Button btnHuy;
    }
}