using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class TopBar : UserControl
    {
        int mov, movX, movY;

        public TopBar()
        {
            InitializeComponent();
        }

        private void TopBar_Load(object sender, EventArgs e)
        {
            Dock = SetTopBarDockStyle();
        }

        private DockStyle SetTopBarDockStyle()
        {
            return DockStyle.Top;
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_WOC2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.WindowState = GetMinimizeState();
        }

        private FormWindowState GetMinimizeState()
        {
            return FormWindowState.Minimized;
        }

        private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void FlowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void FlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                Form.ActiveForm.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
    }
}
