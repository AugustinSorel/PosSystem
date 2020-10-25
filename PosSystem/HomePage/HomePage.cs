using System;
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
            SetLocation();
            SelectWeekGraph();
        }

        private void SetLocation()
        {
            groupBox1.Location = HomePageLocation.SetGraphLocation(groupBox1.Width);
        }

        private void SelectWeekGraph()
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Weekly view";
                    new CreateWeekGraph(chart1, label2);
                    break;
                case 1:
                    label1.Text = "Monthly view";
                    new CreateMonthGraph(chart1, label2);
                    break;
            }
        }
    }
}
