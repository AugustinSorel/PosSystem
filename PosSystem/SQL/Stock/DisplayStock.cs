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
           stock.lblCodeBar.Text = stock.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
           stock.lblUnitPrice.Text = stock.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
           stock.pictureBoxitem.Image = ConvertByteToImage(GetByteImage());
        }

        private byte[] GetByteImage()
        {
            return (Byte[])stock.dataGridView1.SelectedRows[0].Cells[5].Value;
        }
    }
}