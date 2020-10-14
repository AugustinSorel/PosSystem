namespace PosSystem
{
    internal class DisplayStock
    {
        private readonly Stock stock;

        public DisplayStock(Stock stock)
        {
            this.stock = stock;
            ShowSelectedData();
        }

        private void ShowSelectedData()
        {
           stock.TxtBoxName.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
           stock.TxtBoxSurname.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
           stock.TxtBoxAge.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
           stock.TxtBoxGender.Text = seeTeam.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
           stock.WorkerPicture.Image = ConvertByteToImage(GetByteImage(seeTeam));
        }

        private byte[] GetByteImage(SeeTeam seeTeam)
        {
            return (Byte[])seeTeam.dataGridView1.SelectedRows[0].Cells[5].Value;
        }
    }
}