namespace dsa_repo.Trees
{
    public class BST<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Value;
            public Node? Left;
            public Node? Right;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? root;

        public void Insert(T value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node? node, T value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            int comparison = value.CompareTo(node.Value);

            if (comparison < 0)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else if (comparison > 0)
            {
                node.Right = InsertRec(node.Right, value);
            }

            return node;
        }

        public bool Contains(T value)
        {
            return ContainsRec(root, value);
        }

        private bool ContainsRec(Node? node, T value)
        {
            if (node == null)
            {
                return false;
            }

            int comparison = value.CompareTo(node.Value);

            if (comparison == 0)
            {
                return true;
            }

            if (comparison < 0)
            {
                return ContainsRec(node.Left, value);
            }

            return ContainsRec(node.Right, value);
        }

        public List<T> InOrder()
        {
            List<T> result = new List<T>();

            InOrderRec(root, result);

            return result;
        }

        private void InOrderRec(Node? node, List<T> result)
        {
            if (node == null)
            {
                return;
            }

            InOrderRec(node.Left, result);

            result.Add(node.Value);

            InOrderRec(node.Right, result);
        }

        public int Height()
        {
            return HeightRec(root);
        }

        private int HeightRec(Node? node)
        {
            if (node == null)
            {
                return -1;
            }

            return 1 + Math.Max(HeightRec(node.Left), HeightRec(node.Right));
        }
    }
}
