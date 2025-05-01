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
            reportViewer1.Location = new Point(12, 86);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(781, 363);
            reportViewer1.TabIndex = 0;
            // 
            // cboTuyenXe
            // 
            cboTuyenXe.FormattingEnabled = true;
            cboTuyenXe.Location = new Point(91, 27);
            cboTuyenXe.Name = "cboTuyenXe";
            cboTuyenXe.Size = new Size(151, 28);
            cboTuyenXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(264, 26);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "button1";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(364, 27);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "button2";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmThongKeChuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLoc);
            Controls.Add(label1);
            Controls.Add(cboTuyenXe);
            Controls.Add(reportViewer1);
            Name = "frmThongKeChuyenXe";
            Text = "frmThongKeChuyenXe";
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