namespace QuanLyLoTrinhXeBuyt.Reports
{
    partial class frmThongKeXeBuyt
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
            btnHuy = new Button();
            btnLoc = new Button();
            label1 = new Label();
            cboTrangThai = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Bottom;
            reportViewer1.Location = new Point(0, 115);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1337, 597);
            reportViewer1.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1055, 28);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(941, 27);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 7;
            btnLoc.Text = "Lọc kết quả";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(224, 29);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(511, 28);
            cboTrangThai.TabIndex = 5;
            // 
            // frmThongKeXeBuyt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 712);
            Controls.Add(btnHuy);
            Controls.Add(btnLoc);
            Controls.Add(label1);
            Controls.Add(cboTrangThai);
            Controls.Add(reportViewer1);
            Name = "frmThongKeXeBuyt";
            Text = "frmThongKeXeBuyt";
            Load += frmThongKeXeBuyt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button btnHuy;
        private Button btnLoc;
        private Label label1;
        private ComboBox cboTrangThai;
    }
}