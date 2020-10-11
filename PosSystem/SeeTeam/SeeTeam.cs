using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class SeeTeam : UserControl
    {
        public SeeTeam()
        {
            InitializeComponent();
        }

        private void SeeTeam_Load(object sender, System.EventArgs e)
        {
            Dock = GetFillDock();
            SetLocation();
            BringToFront();
            LoadData();
        }

        private void SetLocation()
        {
            panel1.Location = SeeTeamSetLocationCenter.SetPanel1(panel1.Width);
            dataGridView1.Location = SeeTeamSetLocationCenter.SetDataGridView(dataGridView1.Width, dataGridView1.Height);
            panel2.Location = SeeTeamSetLocationCenter.SetPanel2(panel2.Width, panel2.Height);
        }

        private void SelectFirstRow()
        {
            if (dataGridView1.Rows.Count > 1)
                DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
        }

        private void LoadData()
        {
            new LoadDataGridView(dataGridView1);
            SelectFirstRow();
            RemoveTheWorkerLoggedIn();
        }

        private DockStyle GetFillDock()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new ShowUserDetailsFromDataGrid(this);
            new ShowUserSecurityFromDataGrid(this);
        }

        private void RemoveTheWorkerLoggedIn()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == UserDetailsVAR.Id)
                    dataGridView1.Rows.Remove(row);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
            groupBox1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new UpdateWorkerDetails(this);
            groupBox1.Enabled = false;
            LoadData();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    WorkerPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
            groupBox2.Enabled = false;
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            new SearchWorkerByName(this);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            TxtBoxSearchName.Focus();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TxtBoxSearchName.Text = string.Empty;
            groupBox3.Enabled = false;
            LoadData();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (UserNameIsNotTaken() && DataFilled() && HandleCheckboxChecked())
            {
                new UpdateUserSecurity(this);
                groupBox2.Enabled = false;
            }
        }

        private void EnableGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void ResetGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            LoadData();
        }

        private void GroupByName_Click(object sender, EventArgs e)
        {
            new OrderByWorkerName(dataGridView1); // TODO: Having a label with sql aggreagtion queries
        }

        private void BtnGroupBySurnameName_Click(object sender, EventArgs e)
        {
            new OrderByWorkerSurname(dataGridView1);
        }

        private void BtnGroupByAge_Click(object sender, EventArgs e)
        {
            new OrderByWorkerAge(dataGridView1);
        }

        private void BtnGroupByAdmin_Click(object sender, EventArgs e)
        {
            new OrderByWorkerAdmin(dataGridView1);
        }

        private bool HandleCheckboxChecked()
        {
            return CheckAdminRight.Check(checkBox1);
        }

        private bool DataFilled()
        {
            return SeeTeamCheckDataFilled.TextboxFilled(this);
        }

        private bool UserNameIsNotTaken()
        {
            return !SeeTeamCheckIfUserNameIsTaken.CheckUserName(this);
        }
    }
}
