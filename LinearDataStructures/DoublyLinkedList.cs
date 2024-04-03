using QueueLinkedList;

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
            Node p = GetNodeByPosition(position);

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
                return -1;
            }

            Node p = GetNodeByPosition(position);
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
                Console.Write(p.Element + " --> ");
                p = p.Next;
            }

            Console.WriteLine();
        }


        private Node GetNodeByPosition(int position)
        {
            Node p = head;
            int index = 1;

            while (index < position - 1)
            {
                p = p.Next;
                index++;
            }

            return p;
        }


        public int[] GetAllElementsToArray()
        {
            int length = Length(),
                 index = 0;
            int[] numbers = new int[length];
            Node p = head;

            while (index < length)
            {
                numbers[index] = p.Element;
                index++;
                p = p.Next;
            }

            return numbers;
        }

        public int Length() => size;
        public bool IsEmpty() => size == 0;
    }
}
