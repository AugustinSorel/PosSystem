using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageWorker : UserControl
    {
        public ManageWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, System.EventArgs e)
        {
            textBox1.Focus();
            pictureBox1.Image = Properties.Resources.DefaultAvatar;
            Dock = GetDock();
            BringToFront();
            SetPanelLocation();
        }

        private void SetPanelLocation()
        {
            panel1.Location = ManageWorkerSetLocationCenter.CenterPanel1(Width, Height);
            panel2.Location = ManageWorkerSetLocationCenter.CenterPanel2(Width, Height);
        }

        private DockStyle GetDock()
        {
            return DockStyle.Fill;
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            if (UserNameIsNotTaken() && DataFilled() && HandleCheckboxChecked())
            {
                new AddWorkerDetails(this);
                new AddWorkerSecurity(this);
                button5.PerformClick();
            }
        }

        private bool HandleCheckboxChecked()
        {
            return CheckAdminRight.Check(checkBox1);
        }

        private bool DataFilled()
        {
            return CheckDataFilled.TextboxFilled(this);
        }

        private bool UserNameIsNotTaken()
        {
            return !CheckIfUserNameIsTaken.CheckUserName(textBox5.Text);
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (WorkerIdExists() && WarningMessage() && textBox7.Text != string.Empty)
            {
                new DeleteWorkerDetails(this);
                new DeleteWorkerSecurity(this);
                button6.PerformClick();
            }
        }

        private bool WarningMessage()
        {
            return CheckDeletingWorker.Check(); 
        }

        private bool WorkerIdExists()
        {
            return CheckIfWorkerIdExists.IdExists(textBox7.Text);
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            groupBox3.Enabled = true;
            textBox7.Focus();
        }

        private void Button5_Click(object sender, System.EventArgs e)
        {
            ManageWorkerClearControls.ClearTextBoxesInPanel1(groupBox1, groupBox2, checkBox1);
            ManageWorkerClearControls.EnabledToFalseControlsInGroupBox1(this);
        }

        private void Button6_Click(object sender, System.EventArgs e)
        {
            ManageWorkerClearControls.ClearTextBoxesInPanel2(groupBox3);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
