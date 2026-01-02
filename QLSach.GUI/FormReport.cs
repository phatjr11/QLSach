using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.BUS; // Needs BUS reference
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSach.GUI
{
    public partial class FormReport : Form
    {
        private SachService sachService = new SachService();

        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadChart();
        }

        private void LoadGrid()
        {
            var list = sachService.GetAll();
            // Requirement 2.8: Sort descending by Year (NamXB)
            var sortedList = list.OrderByDescending(s => s.NamXB).Select(s => new {
                MaSach = s.MaSach,
                TenSach = s.TenSach,
                NamXB = s.NamXB,
                LoaiSach = s.LoaiSach != null ? s.LoaiSach.TenLoai : "" // Bonus: Show Category Name
            }).ToList();

            dgvReport.DataSource = sortedList;
        }

        private void LoadChart()
        {
            var list = sachService.GetAll();
            // Group by LoaiSach and count
            var stats = list.GroupBy(s => s.LoaiSach != null ? s.LoaiSach.TenLoai : "Khác")
                            .Select(g => new { Loai = g.Key, Count = g.Count() })
                            .ToList();

            chart1.Series.Clear();
            Series series = new Series("Số lượng sách");
            series.ChartType = SeriesChartType.Pie; // Pie chart for variety
            
            foreach (var item in stats)
            {
                series.Points.AddXY(item.Loai, item.Count);
            }
            
            chart1.Series.Add(series);
            chart1.Titles.Clear();
            chart1.Titles.Add("Thống kê số lượng sách theo Thể loại");
        }
    }
}
