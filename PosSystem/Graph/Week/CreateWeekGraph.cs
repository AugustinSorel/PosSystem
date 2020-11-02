using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosSystem
{
    internal class CreateWeekGraph
    {
        private readonly Chart chart1;
        private readonly List<float> UnsortedMoneyPerDay = new List<float>();
        private readonly List<float> SortedMoneyPerDay;

        private readonly int day1 = int.Parse(DateTime.Now.AddDays(-7).ToString("dd"));
        private readonly int day7 = int.Parse(DateTime.Now.ToString("dd"));
        private float max;
        private float min;

        public CreateWeekGraph(Chart chart1, Label label)
        {
            this.chart1 = chart1;
            day1 = GetDay1();

            GetUnsortedList();
            SortedMoneyPerDay = GraphBubbleSort.GetListSorted(UnsortedMoneyPerDay);
            SetUpChart();
            if (max > 0)
            {
                PlotPoint();
                label.Text = GetFinalPrice();
            }
            else
                label.Text = "NO DATA";
        }

        internal string GetFinalPrice()
        {
            float finalPrice = 0;
            foreach (var item in UnsortedMoneyPerDay)
                finalPrice += item;

            return "Final Price: " + finalPrice.ToString() + " £";
        }

        private void SetUpChart()
        {
            chart1.Series.Clear();

            max = SortedMoneyPerDay[day7];
            min = SortedMoneyPerDay[day1];

            var chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = day1;
            chart.AxisX.Maximum = day7;

            chart.AxisY.Maximum = max;
            chart.AxisY.Minimum = min;

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = max / 10;

            chart1.Series.Add("Week");
            chart1.Series["Week"].ChartType = SeriesChartType.Spline;
            chart1.Series["Week"].Color = Color.Red;

            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.BackColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private int GetDay1()
        {
            return day7 <= 7 ? 0 : day1;
        }

        private void PlotPoint()
        {
            for (int i = day1; i <= day7; i++)
                chart1.Series["Week"].Points.AddXY(day1 + i, UnsortedMoneyPerDay[i]);
        }

        private void GetUnsortedList()
        {
            for (int i = -day7; i <= day1; i++)
                UnsortedMoneyPerDay.Add(SaleHistory.GetDay(DateTime.Now.AddDays(i).ToString("dd-MM-yyyy")));
        }
    }
}