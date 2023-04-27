using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Windows.Controls;

namespace AssetManagementVishwa.View.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard_p : Page
    {
        public Dashboard_p()
        {
            InitializeComponent();
            PointLabel = chartPoint =>
              string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        private void Chart_OnDataClick(object sender, LiveCharts.ChartPoint chartPoint)
        {

            var chart = (PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
    }
}
