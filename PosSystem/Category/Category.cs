using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, System.EventArgs e)
        {
            base.Dock = GetFill();
            BringToFront();
            LoadData();
            SetLocation();
        }

        private void SetLocation()
        {
            panel1.Location = SeeTeamSetLocationCenter.SetPanel1(panel1.Width);
            dataGridView1.Location = SeeTeamSetLocationCenter.SetDataGridView(dataGridView1.Width, dataGridView1.Height);
            panel2.Location = SeeTeamSetLocationCenter.SetPanel2(panel2.Width, panel2.Height);
        }

        private void LoadData()
        {
            new CategoryLoadData(dataGridView1);
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new DisplayCategory(this);
        }

        private void BtnWorkerDetailsUpdate_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            new UpdateCategory(this);
            LoadData();
        }

        private void BtnWorkerDetailsEnable_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtboxName.Focus();

        }

        private void BtnWorkerDetailsCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void BtnSearchNameSearch_Click(object sender, EventArgs e)
        {
            if (NameExists())
            {
                new FilterDataGrid(dataGridView1, TxtBoxSearchName.Text);
                groupBox3.Enabled = false;
            }
        }

        private bool NameExists()
        {
            return CategorySearchByName.CheckIfNameExists(this);
        }

        private void BtnSearchNameEnable_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            TxtBoxSearchName.Focus();
        }

        private void BtnSearchNameReset_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            TxtBoxSearchName.Clear();
            LoadData();
        }

        private void ResetGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            LoadData();
        }

        private void EnableGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void BtnGroupByName_Click(object sender, EventArgs e)
        {
            new CategoryGroupByName(dataGridView1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            textBoxInputName.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            textBoxInputDesc.Clear();
            textBoxInputName.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            new InsertNewCategory(this);
            button3.PerformClick();
            LoadData();
        }
    }
}
