using DLinkedList;

namespace LearnDSAlgorithms
{
    class DoublyLinkedList
    {
        private Node? head;
        private Node? tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }


        public void AddLast(int e)
        {
            Node newest = new(e, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.Next = newest;
                newest.Previous = tail;
                tail = newest;
            }

            size++;
        }


        public void AddFirst(int e)
        {
            Node newest = new(e, null, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.Next = head;
                head.Previous = newest;
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

            Node newest = new(e, null, null);
            Node p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.Next;
                i++;
            }

            newest.Next = p.Next;
            p.Next.Previous = newest;
            p.Next = newest;
            newest.Previous = p;
            size++;
        }


        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Doubly List is Empty");
                return -1;
            }

            int e = head.Element;
            head = head.Next;
            size--;

            if (IsEmpty())
            {
                tail = null;
            }
            else
            {
                head.Previous = null;
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

            int e = tail.Element;
            tail = tail.Previous;
            tail.Next = null;
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
                p = p.Next;
                i++;
            }

            int e = p.Next.Element;
            p.Next = p.Next.Next;
            p.Next.Previous = p;
            size--;

            return e;
        }


        public void Display()
        {
            Node p = head;

            while (p != null)
            {
                Console.Write(p.Element + "-->");
                p = p.Next;
            }

            Console.WriteLine();
        }


        public bool IsEmpty()
             => size == 0;

        public int Length()
             => size;
    }
}
