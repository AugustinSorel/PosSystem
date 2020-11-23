using System;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SaleCheckInput
    {
        internal static bool CheckCashInput(Sale sale)
        {
            try
            {
                double price = 0;

                double cash = double.Parse(sale.textBox2.Text);

                for (int i = 0; i < sale.listView1.Items.Count; i++)
                    price += double.Parse(sale.listView1.Items[i].SubItems[3].Text);

                if (cash >= price)
                    return true;
                else
                {
                    MessageBox.Show("The cash input is too small", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valide input for cash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal static bool ChcekTextChangeCash(Sale sale)
        {
            try
            {
                double cash = double.Parse(sale.textBox2.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valide input for cash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}