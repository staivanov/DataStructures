namespace BinarySearchTree
{
    public class Node
    {
        public int Element { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }


        public Node(int element, Node left, Node right)
        {
            Element = element;
            Left = left;
            Right = right;
        }
    }
}
