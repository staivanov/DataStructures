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
            Node newest = new Node(e, null);

            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }

            rear = newest;
            size++;
        }


        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);

            if (IsEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
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

            int e = front.element;
            front = front.next;
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
                p = p.next;
                i++;
            }

            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null;
            size--;

            return e;
        }


        public int Search(int key)
        {
            Node p = front;
            int index = 0;

            while (p != null)
            {
                if (p.element == key)
                {
                    return index;
                }

                p = p.next;
                index++;
            }

            return -1;
        }


        public void Display()
        {
            Node p = front;

            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }

            Console.WriteLine();
        }


        public int First()
        {
            if (IsEmpty()) return -1;

            return front.element;
        }


        public int Last()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return rear.element;
        }


        public int GetLength() => size;
        public bool IsEmpty() => size == 0;
    }
}
