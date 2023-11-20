namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node? next = null;
        public Node? previous = null;

        public Node(int e, Node? n)
        {
            element = e;
            next = n;
        }

        public Node(int e, Node? n, Node? p)
        {
            element = e;
            next = n;
            previous = p;
        }
    }
}
