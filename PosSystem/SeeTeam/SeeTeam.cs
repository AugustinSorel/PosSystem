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
            SelectFirstRow();
        }

        private void SetLocation()
        {
            panel1.Location = SeeTeamSetLocationCenter.SetPanel1(panel1.Width);
            dataGridView1.Location = SeeTeamSetLocationCenter.SetDataGridView(dataGridView1.Width, dataGridView1.Height);
        }

        private void SelectFirstRow()
        {
            if (dataGridView1.Rows.Count > 1)
                DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
        }

        private void LoadData()
        {
            new LoadDataGridView(dataGridView1);
        }

        private DockStyle GetFillDock()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveTheWorkerLoggedIn();
            new ShowUserDetailsFromDataGrid(this);
        }

        private void RemoveTheWorkerLoggedIn()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
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
            MessageBox.Show("The worker has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // TODO: search a worker ? and filter the datagridview
    }
}
