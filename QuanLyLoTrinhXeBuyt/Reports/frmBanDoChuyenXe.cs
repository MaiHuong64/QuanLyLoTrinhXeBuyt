using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyLoTrinhXeBuyt.Reports
{
    public partial class frmBanDoChuyenXe : Form
    {
        QLLTXBContext context = new QLLTXBContext();
        public frmBanDoChuyenXe()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            BieuDoTron();   
           
        }
        private void BieuDoTron()
        {
            try
            {
                chart1.Series["Chuyến xe"].Points.Clear();
                chart1.Series["Chuyến xe"].ChartType = SeriesChartType.Pie;
                chart1.Series["Chuyến xe"].IsValueShownAsLabel = true;
                chart1.Series["Chuyến xe"].LabelFormat = "{0}";

                var charChuyenXe = context.ChuyenXe.GroupBy(c => new { c.TuyenXeID, c.TuyenXe.TenTuyen })
                .Select(g => new
                {
                    TuyenID = g.Key.TuyenXeID,
                    TenTuyen = g.Key.TenTuyen,
                    SoChuyen = g.Count()
                })
                .ToList();

                if (charChuyenXe.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu chuyến xe.");
                    return;
                }

                foreach (var item in charChuyenXe)
                {
                    chart1.Series["Chuyến xe"].Points.AddXY(item.TenTuyen, item.SoChuyen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }
    }
}