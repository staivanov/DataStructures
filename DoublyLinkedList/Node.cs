namespace DLinkedList
{
    public class Node
    {
        public int Element { get; set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }


        public Node(int element, Node next)
        {
            Element = element;
            Next = next;
        }

        public Node(int element, Node node, Node previous)
        {
            Element = element;
            Next = node;
            Previous = previous;
        }
    }
}
