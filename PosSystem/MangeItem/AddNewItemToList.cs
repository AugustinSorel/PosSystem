using System;
using System.Windows.Forms;

namespace PosSystem
{
    internal class AddNewItemToList
    {
        private readonly ManageItem manageItem;
        private readonly ListViewItem listViewItem;

        public AddNewItemToList(ManageItem manageItem)
        {
            this.manageItem = manageItem;

            listViewItem = new ListViewItem(GetItemId());
            listViewItem.SubItems.Add(GetQuantity());
            manageItem.listView1.Items.Add(listViewItem);
        }

        private string GetQuantity()
        {
            return manageItem.txtboxQuantity.Text;
        }

        private string GetItemId()
        {
            return manageItem.TxtBoxBarCode.Text;
        }
    }
}