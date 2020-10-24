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
            CreateWeekGraph();
            DisplayMontGrap();
        }

        private void DisplayMontGrap()
        {
            new CreateMonthGraph(chart2);
            //label4.Text = CreateMonthGraph.GetFinalPrice();
        }

        private void CreateWeekGraph()
        {
            //new CreateWeekGraph(chart1);
        }
    }
}
