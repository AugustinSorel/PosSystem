namespace PosSystem
{
    internal class SearchItemByCodeBar
    {
        public class Node
        {
            public long data;
            public Node left, right;
        };

        static bool IterativeSearch(Node root, long key)
        {
            while (root != null)
            {
                if (key > root.data)
                    root = root.right;

                else if (key < root.data)
                    root = root.left;
                else
                    return true; 
            }
            return false;
        }

        static Node NewNode(long item)
        {
            Node temp = new Node();
            temp.data = item;
            temp.left = temp.right = null;
            return temp;
        }

        static Node Insert(Node Node, long data)
        {
            if (Node == null)
                return NewNode(data);

            if (data < Node.data)
                Node.left = Insert(Node.left, data);
            else if (data > Node.data)
                Node.right = Insert(Node.right, data);

            return Node;
        }

        public SearchItemByCodeBar(Stock stock)
        {
            Node root = null;
            root = Insert(root, 0);
            for (int i = 0; i <stock.dataGridView1.Rows.Count; i++)
                Insert(root, long.Parse(stock.dataGridView1.Rows[i].Cells[8].Value.ToString()));

            long BarcodeToSearch = long.Parse(stock.TxtBoxSearchName.Text);

            if (IterativeSearch(root, BarcodeToSearch))
                ShowTableFiltered(stock, BarcodeToSearch);
            else
                System.Windows.Forms.MessageBox.Show("Barecode not Founded", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        private static void ShowTableFiltered(Stock stock, long BarcodeToSearch)
        {
            for (int i = 0; i < stock.dataGridView1.Rows.Count; i++)
                if (long.Parse(stock.dataGridView1.Rows[i].Cells[8].Value.ToString()) != BarcodeToSearch)
                    stock.dataGridView1.Rows[i].Visible = false;
        }
    }
}