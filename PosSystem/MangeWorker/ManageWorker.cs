using System;
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
            txtBoxName.Focus();
            WorkerPicture.Image = Properties.Resources.DefaultAvatar;
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
            if (UserNameIsNotTaken() && DataFilled() && HandleCheckboxChecked() && CheckAge())
            {
                new AddWorkerDetails(this);
                new AddWorkerSecurity(this);
                BtnCancel.PerformClick();
            }
        }

        private bool CheckAge()
        {
            return CheckWorkerAge.CheckIfInteger(txtBoxAge.Text);
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
            return !CheckIfUserNameIsTaken.CheckUserName(txtBoxUsername.Text);
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    WorkerPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (txtDelete.Text != string.Empty && WorkerIdExists() && WarningMessage())
            {
                new DeleteWorkerDetails(this);
                new DeleteWorkerSecurity(this);
                BtnDeleteCancel.PerformClick();
            }
        }

        private bool WarningMessage()
        {
            return CheckDeletingWorker.Check(); 
        }

        private bool WorkerIdExists()
        {
            return CheckIfWorkerIdExists.IdExists(txtDelete.Text);
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtBoxName.Focus();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            groupBox3.Enabled = true;
            txtDelete.Focus();
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
                txtBoxSurname.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxAge.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxGender.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxUsername.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDeleteDelete.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
