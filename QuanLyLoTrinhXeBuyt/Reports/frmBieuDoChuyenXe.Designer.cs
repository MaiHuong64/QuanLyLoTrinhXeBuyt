namespace QuanLyLoTrinhXeBuyt.Reports
{
    partial class frmBieuDoChuyenXe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartChuyenXe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartChuyenXe).BeginInit();
            SuspendLayout();
            // 
            // chartChuyenXe
            // 
            chartArea1.Name = "ChartArea1";
            chartChuyenXe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartChuyenXe.Legends.Add(legend1);
            chartChuyenXe.Location = new Point(12, 12);
            chartChuyenXe.Name = "chartChuyenXe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Chuyến xe";
            chartChuyenXe.Series.Add(series1);
            chartChuyenXe.Size = new Size(509, 398);
            chartChuyenXe.TabIndex = 0;
            chartChuyenXe.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Biểu đồ số chuyến xe theo tuyến";
            title1.Text = "Biểu đồ số chuyến xe theo tuyến";
            chartChuyenXe.Titles.Add(title1);
            // 
            // frmBieuDoChuyenXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 698);
            Controls.Add(chartChuyenXe);
            Name = "frmBieuDoChuyenXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += frmBieuDoChuyenXe_Load;
            ((System.ComponentModel.ISupportInitialize)chartChuyenXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartChuyenXe;
    }
}