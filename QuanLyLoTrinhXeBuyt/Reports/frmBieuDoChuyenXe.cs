using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyLoTrinhXeBuyt.Reports
{
    public partial class frmBieuDoChuyenXe : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        public frmBieuDoChuyenXe()
        {
            InitializeComponent();
        }
        public void BieuDoTronChuyenTheoTuyen()
        {
            try
            {
                chartChuyenXe.Series["Chuyến xe"].Points.Clear();
                chartChuyenXe.Series["Chuyến xe"].ChartType = SeriesChartType.Pie;
                chartChuyenXe.Series["Chuyến xe"].IsValueShownAsLabel = true;
                chartChuyenXe.Series["Chuyến xe"].LabelFormat = "{0} chuyến";

                var charChuyenXe = context.ChuyenXe
                    .GroupBy(c => c.TuyenXe.TenTuyen)
                    .Select(c => new
                    {
                        TenTuyen = c.Key,
                        SoChuyen = c.Count()
                    })
                    .ToList();

                if (charChuyenXe.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu chuyến xe.");
                    return;
                }

                foreach (var item in charChuyenXe)
                {
                    chartChuyenXe.Series["Chuyến xe"].Points.AddXY(item.TenTuyen, item.SoChuyen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        
        private void frmBieuDoChuyenXe_Load(object sender, EventArgs e)
        {
            BieuDoTronChuyenTheoTuyen();
        }
    }
}
