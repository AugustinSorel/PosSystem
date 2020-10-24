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
            AddComboBoxIndex();
        }

        private void AddComboBoxIndex()
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    new CreateWeekGraph(chart1);
                    label2.Text = CreateWeekGraph.GetFinalPrice();
                    break;
                case 1:
                    new CreateMonthGraph(chart1);
                    label2.Text = CreateMonthGraph.GetFinalPrice();
                    break;
            }
        }
    }
}
