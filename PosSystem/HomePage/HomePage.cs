using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            List<float> UnsortedMoneyPerDay = new List<float>();

            for (int i = -7; i < 0; i++)
                UnsortedMoneyPerDay.Add(SaleHistory.GetDay(DateTime.Now.AddDays(i).ToString("dd-MM-yyyy")));

            List<float> SortedMoneyPerDay = UnsortedMoneyPerDay.ToList();
            float temp = 0;
            for (int i = 0; i < SortedMoneyPerDay.Count; i++)
            {
                for (int j = 0; j < SortedMoneyPerDay.Count- 1; j++)
                {
                    if (SortedMoneyPerDay[j] > SortedMoneyPerDay[j + 1])
                    {
                        temp = SortedMoneyPerDay[j + 1];
                        SortedMoneyPerDay[j + 1] = SortedMoneyPerDay[j];
                        SortedMoneyPerDay[j] = temp;
                    }
                }
            }

            var chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            int day1 = int.Parse(DateTime.Now.AddDays(-7).ToString("dd"));
            int day7 = int.Parse(DateTime.Now.AddDays(0).ToString("dd"));

            chart.AxisX.Minimum = day1;
            chart.AxisX.Maximum = day7;
            
            chart.AxisY.Maximum = SortedMoneyPerDay[6];
            chart.AxisY.Minimum= SortedMoneyPerDay[0];
            
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Test");
            chart1.Series["Test"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series["Test"].Color = Color.Red;

            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.BackColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;


            for (int i = 0; i < 7; i++)
                chart1.Series["Test"].Points.AddXY(day1+i, UnsortedMoneyPerDay[i]);
        }
    }
}
