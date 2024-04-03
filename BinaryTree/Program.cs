using BinarySearchTree;

namespace BinaryTree
{
    public class Program
    {
        public static void Main()
        {
            BST bst = new();
            bst.Root = bst.InsertRecursive(bst.Root, 50);
            bst.Insert(bst.Root, 30);
            bst.Insert(bst.Root, 80);
            bst.Insert(bst.Root, 10);
            bst.Insert(bst.Root, 40);
            bst.Insert(bst.Root, 60);
            bst.Insert(bst.Root, 90);

            Console.WriteLine("Postorder Traversal");
            bst.PostOrderRecursive(bst.Root);          
        }
    }
}
