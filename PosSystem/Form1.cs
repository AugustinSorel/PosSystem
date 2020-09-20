using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateLoginPage();
            CreateTopBar();
        }

        private void CreateTopBar()
        {
            Controls.Add(new TopBar.TopBar());
            Controls.SetChildIndex(Controls.Find("TopBar", true).FirstOrDefault() as TopBar.TopBar, 0);
        }

        private void CreateLoginPage()
        {
            Controls.Add(new LoginPage());
        }
    }
}
