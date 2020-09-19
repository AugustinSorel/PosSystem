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
            TopBar.TopBar topBar = new TopBar.TopBar();
            Controls.Add(topBar);
            Controls.SetChildIndex(topBar, 0);
        }

        private void CreateLoginPage()
        {
            Controls.Add(new LoginPage());
        }
    }
}
