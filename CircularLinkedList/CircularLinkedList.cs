using DLinkedList;

namespace CircularLinkedList
{
    public class CircularLinkedList
    {
        private Node? _head;
        private Node? _tail;
        private int _size;

        public CircularLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public void AddLast(int element)
        {
            Node newest = new(element, null);

            if (IsEmpty())
            {
                newest.Next = newest;
                _head = newest;
            }
            else
            {
                newest.Next = _tail.Next;
                _tail.Next = newest;
            }

            _tail = newest;
            _size++;
        }

        public void AddFirst(int element)
        {
            Node newest = new(element, null);

            if (IsEmpty())
            {
                newest.Next = newest;
                _head = newest;
                _tail = newest;
            }
            else
            {
                _tail.Next = newest;
                newest.Next = _head;
                _head = newest;
            }

            _size++;
        }

        public void AddElementAtPosition(int element, int position)
        {
            if (position <= 0 || position > Lenght())
            {
                Console.WriteLine("Invalid position");
                return;
            }

            Node newest = new(element, null);
            Node p = _head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.Next;
                i++;
            }

            newest.Next = p.Next;
            p.Next = newest;
            _size++;
        }

        public int RemoveFirstElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Linked List is empty.");
                return -1;
            }

            int element = _head.Element;
            _tail.Next = _head.Next;
            _head = _head.Next;
            _size--;

            if (IsEmpty())
            {
                _head = null;
                _tail = null;
            }

            return element;
        }

        public int RemoveLastElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Linked List is empty.");
                return -1;
            }

            int element,
                i = 0;
            Node p = _head;

            while (i < Lenght() - 1)
            {
                p = p.Next;
                i++;
            }

            _tail = p;
            p = p.Next;
            _tail.Next = _head;
            element = p.Element;
            _size--;

            return element;
        }

        public int RemoveElementAtPosition(int position)
        {
            if (position <= 0 || position >= Lenght())
            {
                Console.WriteLine("Invalid position");
                return -1;
            }

            Node p = _head;
            int i = 1,
                element = 0;

            while (i < position - 1)
            {
                p = p.Next;
                i++;
            }

            element = p.Next.Element;
            p.Next = p.Next.Next;

            _size--;

            return element;
        }

        public void Display()
        {
            Node previous = _head;
            int i = 0;

            while (i < Lenght())
            {
                if (i != (Lenght() - 1))
                {
                    Console.Write(previous.Element + " ---> ");
                    previous = previous.Next;
                    i++;
                }
                else
                {
                    Console.Write(previous.Element);
                    i++;
                }
            }

            Console.WriteLine();
        }

        public int Lenght() => _size;
        public bool IsEmpty() => _size == 0;
    }
}
