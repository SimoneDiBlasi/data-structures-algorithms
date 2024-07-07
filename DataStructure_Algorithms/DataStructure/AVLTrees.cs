namespace DataStructure
{

    public class AVLTree(AVLTree.Node? root)
    {
        public Node? Root { get; set; } = root;

        public class Node
        {
            public int Value { get; set; }
            public Node? LeftChild { get; set; }
            public Node? RightChild { get; set; }
            public int Height { get; set; }
        }

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }

        public Node Insert(Node root, int value)
        {
            if (root == null)
                return new Node() { Value = value };
            if (value < root.Value)
            {
                root.LeftChild = Insert(root.LeftChild, value);
            }
            else
            {
                root.RightChild = Insert(root.RightChild, value);
            }

            root.Height = Math.Max(Height(root.LeftChild), Height(root.RightChild)) + 1;
            return root;

        }

        private bool IsLeftHeavy(Node node)
        {
            return BalanceFactor(node) > 1;
        }

        private bool IsRightHeavy(Node node)
        {
            return BalanceFactor(node) < -1;
        }

        private int BalanceFactor(Node node)
        {
            return (node == null) ? -1 : Height(node.LeftChild) - Height(node.RightChild);
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
            return (root == null) ? -1 : root.Height;
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
