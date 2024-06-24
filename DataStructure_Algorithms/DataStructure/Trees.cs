namespace DataStructure
{

    public class Tree(Tree.Node? root)
    {
        private Node? Root { get; set; } = root;

        public class Node
        {
            public int Value { get; set; }
            public Node? LeftChild { get; set; }
            public Node? RightChild { get; set; }
        }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node() { Value = value };
                return;
            }

            var currentNode = Root;
            while (true)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = new Node() { Value = value };
                        break;
                    }
                    currentNode = currentNode.LeftChild;
                }
                else
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = new Node() { Value = value };
                        break;
                    }
                    currentNode = currentNode.RightChild;
                }
            }
        }

        public bool Find(int value)
        {
            var currentNode = Root;
            while (currentNode != null)
            {
                if (currentNode.Value < value)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value > value)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
