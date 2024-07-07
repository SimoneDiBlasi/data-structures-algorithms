namespace DataStructure
{

    public class BinaryTree(BinaryTree.Node? root)
    {
        public Node? Root { get; set; } = root;

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

        public int Height(Node root)
        {
            if (root == null)
                return -1;
            if (root.LeftChild == null && root.RightChild == null)
                return 0;
            return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
        }

        public List<Node> GetNodesFromDistance(Node root, int distance)
        {
            if (root == null) return [];
            var list = new List<Node>() { root };
            if (distance == 0) return list;

            if (root.LeftChild != null)
            {
                var leftNodes = GetNodesFromDistance(root.LeftChild, distance - 1);
                if (leftNodes != null)
                    list.AddRange(leftNodes);
            }
            if (root.RightChild != null)
            {
                var rightNodes = GetNodesFromDistance(root.RightChild, distance - 1);
                if (rightNodes != null)
                    list.AddRange(rightNodes);
            }
            return list;
        }

        public int Size(Node root)
        {
            if (root == null) return 0;
            int count = 1;
            if (root.LeftChild != null)
            {
                count += Size(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                count += Size(root.RightChild);
            }

            return count;
        }

        public int CountLeaves(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.LeftChild == null && node.RightChild == null)
            {
                return 1;
            }

            return CountLeaves(node.LeftChild) + CountLeaves(node.RightChild);
        }
    }
}
