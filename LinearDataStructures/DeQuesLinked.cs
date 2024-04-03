using QueueLinkedList;

namespace LearnDSAlgorithms
{
    class DeQueLinked
    {
        private Node front;
        private Node rear;
        private int size;

        public DeQueLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }


        public void AddLast(int e)
        {
            Node newest = new(e, null);

            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.Next = newest;
            }

            rear = newest;
            size++;
        }


        public void AddFirst(int e)
        {
            Node newest = new(e, null);

            if (IsEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.Next = front;
                front = newest;
            }

            size++;
        }


        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                return -1;
            }

            int e = front.Element;
            front = front.Next;
            size--;

            if (IsEmpty())
            {
                rear = null;
            }

            return e;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                return -1;
            }

            Node p = front;
            int i = 1;

            while (i < size - 1)
            {
                p = p.Next;
                i++;
            }

            rear = p;
            p = p.Next;
            int e = p.Element;
            rear.Next = null;
            size--;

            return e;
        }


        public int Search(int key)
        {
            Node p = front;
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
            Node p = front;

            while (p != null)
            {
                Console.Write(p.Element + " --> ");
                p = p.Next;
            }

            Console.WriteLine();
        }


        public int First()
        {
            if (IsEmpty()) return -1;

            return front.Element;
        }


        public int Last()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return rear.Element;
        }


        public int GetLength() => size;
        public bool IsEmpty() => size == 0;
    }
}
