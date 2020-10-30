using System.Windows.Forms;

namespace PosSystem
{
    internal class InserOrderToList
    {
        private readonly Order order;
        private ListViewItem listViewItem;

        public InserOrderToList(Order order)
        {
            this.order = order;
            CheckItem();
        }

        private void CheckItem()
        {
            listViewItem = new ListViewItem(order.comboBox1.SelectedItem.ToString().Trim());

            if (ItemIsInTheList())
                AppendList();
            else
                AddNewItemToList();
        }

        private bool ItemIsInTheList()
        {
            for (int i = 0; i < order.listView1.Items.Count; i++)
                if (CodeBarIsinTheList(i))
                    return true;
            return false;
        }

        private bool CodeBarIsinTheList(int i)
        {
            return order.comboBox1.SelectedItem.ToString() == order.listView1.Items[i].SubItems[0].Text;
        }

        private void AppendList()
        {
            for (int i = 0; i < order.listView1.Items.Count; i++)
            {
                string itemID = order.listView1.Items[i].SubItems[0].Text;
                int quantity = int.Parse(order.listView1.Items[i].SubItems[1].Text);
                double price = int.Parse(order.lblFinalPrice.Text);

                if (TextBoxIsCodeBar(itemID))
                {
                    quantity++;
                    order.listView1.Items[i].SubItems[1].Text = quantity.ToString();
                    order.listView1.Items[i].SubItems[2].Text = (quantity * price).ToString();
                    DisplayFinalPrice();
                    return;
                }
            }
        }

        private bool TextBoxIsCodeBar(string itemID)
        {
            return order.comboBox1.SelectedItem.ToString() == itemID;
        }

        private void AddNewItemToList()
        {
            AddItems();
            DisplayFinalPrice();
        }

        private void AddItems()
        {
            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add(order.lblFinalPrice.Text);
            order.listView1.Items.Add(listViewItem);
        }

        private void DisplayFinalPrice()
        {
            double price = 0;

            for (int i = 0; i < order.listView1.Items.Count; i++)
            {
                price += double.Parse(order.listView1.Items[i].SubItems[2].Text);
                order.label1.Text = price.ToString() + " £";
            }
        }
    }
}