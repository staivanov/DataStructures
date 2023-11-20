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
                tail.next = newest;
                newest.previous = tail;
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
                newest.next = head;
                head.previous = newest;
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
            Node p = GetNodeByPosition(position);

            newest.next = p.next;
            p.next.previous = newest;
            p.next = newest;
            newest.previous = p;
            size++;
        }


        public int RemoveFirst()
        {
            if (IsEmpty())
            {
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
                head.previous = null;
            }

            return e;
        }


        public int RemoveLast()
        {
            if (IsEmpty())
            {
                return -1;
            }

            int e = tail.element;
            tail = tail.previous;
            tail.next = null;
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
            int e = p.next.element;
            p.next = p.next.next;
            p.next.previous = p;
            size--;

            return e;
        }


        public void Display()
        {
            Node p = head;

            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }

            Console.WriteLine();
        }


        private Node GetNodeByPosition(int position)
        {
            Node p = head;
            int index = 1;

            while (index < position - 1)
            {
                p = p.next;
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
                numbers[index] = p.element;
                index++;
                p = p.next;
            }

            return numbers;
        }

        public int Length() => size;
        public bool IsEmpty() => size == 0;
    }
}
