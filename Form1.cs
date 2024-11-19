namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        private BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                tree.Insert(value);
                MessageBox.Show($"Value {value} inserted successfully.");
                txtValue.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                if (tree.Delete(value))
                {
                    MessageBox.Show($"Value {value} deleted successfully.");
                }
                else
                {
                    MessageBox.Show($"Value {value} not found in the tree.");
                }
                txtValue.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                if (tree.Search(value))
                {
                    MessageBox.Show($"Value {value} found in the tree.");
                }
                else
                {
                    MessageBox.Show($"Value {value} not found in the tree.");
                }
                txtValue.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }
    }

    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        private Node root;

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private Node InsertRecursive(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRecursive(node.Right, value);
            }

            return node;
        }

        public bool Delete(int value)
        {
            bool found = false;
            root = DeleteRecursive(root, value, ref found);
            return found;
        }

        private Node DeleteRecursive(Node node, int value, ref bool found)
        {
            if (node == null)
            {
                return null;
            }

            if (value < node.Value)
            {
                node.Left = DeleteRecursive(node.Left, value, ref found);
            }
            else if (value > node.Value)
            {
                node.Right = DeleteRecursive(node.Right, value, ref found);
            }
            else
            {
                found = true;
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = FindMin(node.Right).Value;
                node.Right = DeleteRecursive(node.Right, node.Value, ref found);
            }

            return node;
        }

        private Node FindMin(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public bool Search(int value)
        {
            return SearchRecursive(root, value) != null;
        }

        private Node SearchRecursive(Node node, int value)
        {
            if (node == null || node.Value == value)
            {
                return node;
            }

            if (value < node.Value)
            {
                return SearchRecursive(node.Left, value);
            }

            return SearchRecursive(node.Right, value);
        }
    }
    
}

