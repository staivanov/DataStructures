using DLinkedList;

namespace StackWithLinkedList
{
    public class StackLinked
    {
        private Node? top = null;
        private int size = 0;
        private readonly int emptyStack = 0;


        public StackLinked()
        {
            top = null;
            size = 0;
        }


        public void Push(int e)
        {
            Node newest = new(e, null);

            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.Next = top;
                top = newest;
            }

            size++;
        }


        public int Pop()
        {
            if (IsEmpty()) return emptyStack;

            int lastElement = top.Element;
            top = top.Next;
            size--;
            return lastElement;
        }


        public void Display()
        {
            Node p = top;

            while (p != null)
            {
                Console.Write($"{p.Element} <-- ");
                p = p.Next;
            }
        }


        public int Peek()
            => size == emptyStack ? emptyStack : top.Element;

        public bool IsEmpty()
            => size == emptyStack;

        public int Length()
            => size;
    }
}
