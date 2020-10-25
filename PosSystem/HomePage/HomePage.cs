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
            ShowNotification();
        }

        private void ShowNotification()
        {
            if (InputIsDigit() && InputNotEmpty())
            {
                new ShowNotification(listView1, label3, textBox1.Text);
            }
        }

        private bool InputIsDigit()
        {
            return RangeStockInput.checkRange(textBox1.Text);
        }

        private bool InputNotEmpty()
        {
            return textBox1.Text != string.Empty;
        }

        private void SetLocation()
        {
            groupBox1.Location = HomePageLocation.SetGraphLocation(groupBox1.Width);
            groupBox2.Location = HomePageLocation.SetNotificationLocation(groupBox1.Width);
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

        private void ListView1_Click(object sender, EventArgs e)
        {
            new DisplayItemSelected(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ShowNotification();
        }
    }
}
