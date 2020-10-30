using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, System.EventArgs e)
        {
            base.Dock = GetFill();
            BringToFront();
            SetLocation();
            DisplayLabels();
        }

        private void DisplayLabels()
        {
            lblDate.Text = GetDate();
            LblWorkerID.Text = GetWorkerID();
        }

        private static string GetWorkerID()
        {
            return "Worker ID: " + UserDetailsVAR.Id.ToString();
        }

        private static string GetDate()
        {
            return "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void SetLocation()
        {
            panel1.Location = OrderLocation.SetPanel1(panel1.Width);
            panel2.Location = OrderLocation.SetPanel2(panel2.Width);
            label1.Location = OrderLocation.FinaPrice();
            panel3.Location = OrderLocation.Panel3(panel3.Width);
            groupBox2.Location = OrderLocation.GroupBox2(groupBox2.Width);
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            comboBox1.Focus();
        }
    }
}
