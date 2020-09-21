using System;
using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Left;
        }
    }
}
