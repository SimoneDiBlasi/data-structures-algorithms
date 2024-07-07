using DataStructure;
using static DataStructure.BinaryTree;


/* creating a binary tree and entering the nodes */
BinaryTree tree = new BinaryTree(new Node() { LeftChild = null, RightChild = null, Value = 5, });
tree.Insert(3);
tree.Insert(6);
tree.Insert(2);
tree.Insert(4);
tree.Insert(1);
tree.Insert(7);
tree.Insert(9);
Console.WriteLine("The  binary tree is : " + tree);
Console.WriteLine("The size of binary tree is : " + tree.CountLeaves(tree.Root));

