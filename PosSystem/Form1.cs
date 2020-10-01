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
            CreateTopBar();
            CreateLoginPage();
            CheckDatabaseCreated();
        }

        private void CheckDatabaseCreated()
        {
            if (CreateDatabase.CheckifDatabaseExists())
                new CreateDatabase(); 
        }

        private void CreateTopBar()
        {
            Controls.Add(new TopBar());
        }

        private void CreateLoginPage()
        {
            panel1.Controls.Add(new LoginPage()); //TODO: Create panel dynamicly
        }
    }
}
