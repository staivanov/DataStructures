namespace DLinkedList
{
    public class Node
    {
        internal int element;
        internal Node next;
        internal Node previous;

        public Node(int e, Node n, Node p)
        {
            element = e;
            next = n;
            previous = p;
        }
    }
}
