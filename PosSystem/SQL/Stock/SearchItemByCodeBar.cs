using System.Data.OleDb;

namespace PosSystem
{
    internal class SearchItemByCodeBar: SqlQueries
    {
        public class Node
        {
            public long data;
            public Node left, right;
        };

        static bool IterativeSearch(Node root, long key)
        {
            // Traverse untill root reaches to dead end 
            while (root != null)
            {
                // pass right subtree as new tree 
                if (key > root.data)
                    root = root.right;

                // pass left subtree as new tree 
                else if (key < root.data)
                    root = root.left;
                else
                    return true; // if the key is found return 1 
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
            /* If the tree is empty, return a new Node */
            if (Node == null)
                return NewNode(data);

            /* Otherwise, recur down the tree */
            if (data < Node.data)
                Node.left = Insert(Node.left, data);
            else if (data > Node.data)
                Node.right = Insert(Node.right, data);

            /* return the (unchanged) Node pointer */
            return Node;
        }

        public SearchItemByCodeBar(Stock stock)
        {
            Node root = null;
            root = Insert(root, 0);
            for (int i = 0; i <stock.dataGridView1.Rows.Count; i++)
                Insert(root, long.Parse(stock.dataGridView1.Rows[i].Cells[8].Value.ToString()));

            if (IterativeSearch(root, 53454168532))
                System.Windows.Forms.MessageBox.Show("Found");
            else
                System.Windows.Forms.MessageBox.Show("Not Found");

        }

        //private Stock stock;
        //
        //public SearchItemByCodeBar(Stock stock)
        //{
        //    this.stock = stock;
        //    OleDbCommand oleDbCommand = CreateCommand();
        //    ExecuteCommand(oleDbCommand);
        //    stock.dataGridView1.DataSource = SetDataSource(oleDbCommand);
        //}
        //
        //private OleDbCommand CreateCommand()
        //{
        //    OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
        //    oleDbCommand.CommandText = GetCommandText();
        //    return oleDbCommand;
        //}
        //
        //private string GetCommandText()
        //{
        //    return "SELECT * FROM Items WHERE [BarCode] like('" + stock.TxtBoxSearchName.Text + "%')";
        //}
    }
}