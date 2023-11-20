namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node next;
        public Node prev;

        public Node(int e, Node n, Node p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }


    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }


        public void AddLast(int e)
        {
            Node newest = new Node(e, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }

            size++;
        }


        public void AddFirst(int e)
        {
            Node newest = new Node(e, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }

            size++;
        }


        public void AddAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            Node newest = new Node(e, null, null);
            Node p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            newest.next = p.next;
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size++;
        }


        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Doubly List is Empty");
                return -1;
            }

            int e = head.element;
            head = head.next;
            size--;

            if (IsEmpty())
            {
                tail = null;
            }
            else
            {
                head.prev = null;
            }

            return e;
        }


        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Doubly List is Empty");
                return -1;
            }

            int e = tail.element;
            tail = tail.prev;
            tail.next = null;
            size--;

            return e;
        }


        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }

            Node p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next;
                i++;
            }

            int e = p.next.element;
            p.next = p.next.next;
            p.next.prev = p;
            size--;

            return e;
        }


        public void Display()
        {
            Node p = head;

            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }

            Console.WriteLine();
        }


        public bool IsEmpty()
             => size == 0;

        public int Length()
             => size;

        static void Main()
        {
            DoublyLinkedList l = new();
            l.AddLast(7);
            l.AddLast(4);
            l.AddLast(12);
            l.AddLast(8);
            l.AddLast(3);
            l.Display();
            Console.WriteLine("Size: " + l.Length());
            int element = l.RemoveAny(3);
            Console.WriteLine("Removed Element: " + element);
            l.Display();
            Console.WriteLine("Size: " + l.Length());
        }
    }
}
