using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, System.EventArgs e)
        {
            Dock = DockStyle.Fill;
            this.BringToFront();
            CreateGraph();
        }

        private void CreateGraph()
        {
            float day1 = SaleHistory.GetDay1();
            float day2 = float.Parse("10");
            float day3 = float.Parse("3");
            float day4 = float.Parse("4");
            float day5 = float.Parse("22");
            float day6 = float.Parse("10");
            float day7 = float.Parse("4");

            var chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 7;
            chart.AxisY.Maximum = 22;
            chart.AxisY.Minimum= 0;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Test");
            chart1.Series["Test"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["Test"].Color = Color.Red;

            chart1.Series["Test"].Points.AddXY(1, day1);
            chart1.Series["Test"].Points.AddXY(2, day2);
            chart1.Series["Test"].Points.AddXY(3, day3);
            chart1.Series["Test"].Points.AddXY(4, day4);
            chart1.Series["Test"].Points.AddXY(5, day5);
            chart1.Series["Test"].Points.AddXY(6, day6);
            chart1.Series["Test"].Points.AddXY(7, day7);
        }
    }
}
