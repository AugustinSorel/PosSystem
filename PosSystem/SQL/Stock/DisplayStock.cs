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

            stock.txtCategory.Text = stock.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            stock.TxtBoxPurchacePrice.Text = stock.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            stock.txtCoef.Text = stock.dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim();
            stock.lblFinalPrice.Text = stock.dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Trim();


            stock.textBoxStockMin.Text = stock.dataGridView1.SelectedRows[0].Cells[10].Value.ToString().Trim();
            stock.textBoxStockMax.Text = stock.dataGridView1.SelectedRows[0].Cells[11].Value.ToString().Trim();
           stock.pictureBoxItem.Image = ConvertByteToImage(GetByteImage());
        }

        private byte[] GetByteImage()
        {
            return (Byte[])stock.dataGridView1.SelectedRows[0].Cells[9].Value;
        }
    }
}