using System;

namespace PosSystem
{
    internal class DisplayStock: SqlQueries
    {
        private readonly Stock stock;

        public DisplayStock(Stock stock)
        {
            this.stock = stock;
            ShowSelectedData();
        }

        private void ShowSelectedData()
        {
            stock.TxtBoxDescrption.Text = stock.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            stock.TxtBoxSupplierID.Text = stock.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            stock.TxtBoxPrice.Text = stock.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            stock.textBoxStockMin.Text = stock.dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Trim();
            stock.textBoxStockMax.Text = stock.dataGridView1.SelectedRows[0].Cells[7].Value.ToString().Trim();
           stock.pictureBoxItem.Image = ConvertByteToImage(GetByteImage());
        }

        private byte[] GetByteImage()
        {
            return (Byte[])stock.dataGridView1.SelectedRows[0].Cells[5].Value;
        }
    }
}