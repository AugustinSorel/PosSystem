using System.Windows.Forms;

namespace PosSystem
{
    internal class AddItemToList
    {
        private readonly Sale sale;
        private ListViewItem listViewItem;

        public AddItemToList(Sale sale)
        {
            this.sale = sale;
            CheckItem();
        }

        private void CheckItem()
        {
            listViewItem = new ListViewItem(sale.textBox1.Text);

            if (ItemIsInTheList())
                AppendList();
            else
                AddNewItemToList();
        }

        private bool ItemIsInTheList()
        {
            for (int i = 0; i < sale.listView1.Items.Count; i++)
                if (CodeBarIsinTheList(i))
                    return true;
            return false;
        }

        private bool CodeBarIsinTheList(int i)
        {
            return sale.textBox1.Text == sale.listView1.Items[i].SubItems[0].Text;
        }

        private void AppendList()
        {
            for (int i = 0; i < sale.listView1.Items.Count; i++)
            {
                string codeBar = sale.listView1.Items[i].SubItems[0].Text;
                int quantity = int.Parse(sale.listView1.Items[i].SubItems[1].Text);
                double price = int.Parse(sale.lblFinalPrice.Text);

                if (TextBoxIsCodeBar(codeBar))
                {
                    quantity++;
                    sale.listView1.Items[i].SubItems[1].Text = quantity.ToString();
                    sale.listView1.Items[i].SubItems[3].Text = (quantity * price).ToString();
                    DisplayFinalPrice();
                    ClearControls();
                    return;
                }
            }
        }

        private bool TextBoxIsCodeBar(string codeBar)
        {
            return sale.textBox1.Text == codeBar;
        }

        private void AddNewItemToList()
        {
            AddItems();
            DisplayFinalPrice();
            ClearControls();
        }

        private void AddItems()
        {
            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add(sale.lblItemIDDisplay.Text);
            listViewItem.SubItems.Add(sale.lblFinalPrice.Text);
            sale.listView1.Items.Add(listViewItem);
        }

        private void ClearControls()
        {
            sale.textBox1.Clear();
            sale.textBox1.Focus();
        }

        private void DisplayFinalPrice()
        {
            double price = 0;

            for (int i = 0; i < sale.listView1.Items.Count; i++)
            {
                price += double.Parse(sale.listView1.Items[i].SubItems[3].Text);
                sale.lblDisplayFinalPrice.Text = price.ToString() + " £";
            }
        }
    }
}