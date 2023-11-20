namespace StackWithLinkedList
{
    internal class Node
    {
        public Node next;
        public int element;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
}
