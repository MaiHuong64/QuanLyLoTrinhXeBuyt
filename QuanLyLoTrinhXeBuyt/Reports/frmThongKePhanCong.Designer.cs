namespace QuanLyLoTrinhXeBuyt.Reports
{
    partial class frmThongKePhanCong
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
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            btnLoc = new Button();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(285, 14);
            dtpTuNgay.Margin = new Padding(4, 3, 4, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(167, 30);
            dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày: ";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(826, 16);
            btnLoc.Margin = new Padding(4, 3, 4, 3);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(104, 30);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(627, 14);
            dtpDenNgay.Margin = new Padding(4, 3, 4, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(167, 30);
            dtpDenNgay.TabIndex = 4;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(12, 68);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1432, 595);
            reportViewer1.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(938, 16);
            btnHuy.Margin = new Padding(4, 3, 4, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(104, 30);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmThongKePhanCong
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 675);
            Controls.Add(reportViewer1);
            Controls.Add(label2);
            Controls.Add(dtpDenNgay);
            Controls.Add(btnHuy);
            Controls.Add(btnLoc);
            Controls.Add(label1);
            Controls.Add(dtpTuNgay);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKePhanCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKePhanCong";
            Load += frmThongKePhanCong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Button btnLoc;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button btnHuy;
    }
}