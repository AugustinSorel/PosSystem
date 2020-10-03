using System;

namespace PosSystem
{
    class ShowUserDetailsFromDataGrid: SqlQueries
    {
        public ShowUserDetailsFromDataGrid(SeeTeam seeTeam)
        {
            ShowSelectedData(seeTeam);
        }

        private void ShowSelectedData(SeeTeam seeTeam)
        {
            seeTeam.textBox1.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            seeTeam.textBox2.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            seeTeam.textBox3.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            seeTeam.textBox4.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            seeTeam.pictureBox1.Image = ConvertByteToImage(GetByteImage(seeTeam));
        }

        private byte[] GetByteImage(SeeTeam seeTeam)
        {
            return  (Byte[])seeTeam.dataGridView1.SelectedRows[0].Cells[5].Value;
        }
    }
}
