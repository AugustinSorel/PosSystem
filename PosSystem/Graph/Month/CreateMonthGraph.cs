using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosSystem
{
    internal class CreateMonthGraph
    {
        private readonly Chart chart1;
        private readonly List<float> UnsortedMoneyPerDay = new List<float>();
        private readonly List<float> SortedMoneyPerDay;

        private readonly int day1 = 0;
        private readonly int day30 = int.Parse(DateTime.Now.ToString("dd"));
        private float max;
        private float min;

        public CreateMonthGraph(Chart chart1, Label label1)
        {
            this.chart1 = chart1;

            GetUnsortedList();
            SortedMoneyPerDay = GraphBubbleSort.GetListSorted(UnsortedMoneyPerDay);
            SetUpChart();
            if (max > 0)
            {
                PlotPoint();
                label1.Text = GetFinalPrice();
            }
            else
                label1.Text = "NO DATA";
        }

        private void SetUpChart()
        {
            chart1.Series.Clear();

            max = SortedMoneyPerDay[day30];
            min = SortedMoneyPerDay[0];

            ChartArea chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Maximum = day30;
            chart.AxisX.Minimum = day1;

            chart.AxisY.Maximum = max;
            chart.AxisY.Minimum = min;

            chart1.Series.Clear();
            
            chart.AxisY.Interval = max / 10;
            chart.AxisX.Interval = 1;

            chart1.Series.Add("Month");
            chart1.Series["Month"].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Color = Color.Green;

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

        internal string GetFinalPrice()
        {
            float finalPrice = 0;
            foreach (var item in UnsortedMoneyPerDay)
                finalPrice += item;

            return "Total for Sale: " + finalPrice.ToString() + " £";
        }

        private void PlotPoint()
        {
            for (int i = 0; i <= day30; i++)
                chart1.Series[0].Points.AddXY(day1 + i, UnsortedMoneyPerDay[i]);
        }

        private void GetUnsortedList()
        {
            for (int i = -day30; i <= 0; i++)
                UnsortedMoneyPerDay.Add(SaleHistory.GetDay(DateTime.Now.AddDays(i).ToString("dd-MM-yyyy")));
        }
    }
}