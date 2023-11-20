namespace QueueLinkedList
{
    public class Node
    {
        internal Node? next;
        internal int element;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
}

