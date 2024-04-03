using QueueLinkedList;

namespace LearnDSAlgorithms
{
    class LinkedList
    {
        private Node? head;
        private Node? tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }


        public void AddLast(int e)
        {
            Node? newest = new(e, null);

            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                tail.Next = newest;
            }

            tail = newest;
            size++;
        }


        public void AddFirst(int e)
        {
            Node newest = new(e, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.Next = head;
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

            Node? newest = new(e, null);
            Node? p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p?.Next;
                i++;
            }

            newest.Next = p.Next;
            p.Next = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int e = head.Element;
                head = head.Next;
                size--;

                if (IsEmpty())
                {
                    tail = null;
                }

                return e;
            }
        }


        public int RemoveLast()
        {
            if (IsEmpty())
            {
                return -1;
            }

            Node? p = head;
            int i = 1;

            while (i < size - 1)
            {
                p = p.Next;
                i++;
            }

            tail = p;
            p = p.Next;
            int e = p.Element;
            tail.Next = null;
            size--;

            return e;
        }

        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size - 1) return -1;

            Node p = GetNodeByPosition(position);
            int e = p.Next.Element;
            p.Next = p.Next.Next;
            size--;

            return e;
        }

        public int SearchElement(int key)
        {
            Node p = head;
            int index = 0;

            while (p != null)
            {
                if (p.Element == key)
                {
                    return index;
                }

                p = p.Next;
                index++;
            }

            return -1;
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


        public void SortLinkedList()
        {
            int passes = GetLength();

            while (passes >= 0)
            {
                int index = 0;
                Node p = head;

                while (index < passes - 1)
                {
                    if (p.Element > p.Next.Element)
                    {
                        int temp = p.Element;
                        p.Element = p.Next.Element;
                        p.Next.Element = temp;
                    }

                    p = p.Next;
                    index++;
                }

                passes--;
            }
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

        public int GetLength()
            => size;
        public bool IsEmpty()
            => size == 0;
    }
}
