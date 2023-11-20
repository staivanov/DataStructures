namespace QueueLinkedList
{
    public class QueueLinked
    {
        private Node? front;
        private Node? rear;
        private int size;
        private int queueEmpty = 0;

        public QueueLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }


        public void Enqueue(int e)
        {
            Node newest = new(e, null);

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


        public int Dequeue()
        {
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                int firstElement = front.element;
                front = front.next;
                size--;

                if (IsEmpty())
                {
                    rear = null;
                }

                return firstElement;
            }
        }


        public void Display()
        {
            Node p = front;

            while (p != null)
            {
                Console.Write($"{p.element} --> ");
                p = p.next;
            }

            Console.WriteLine();
        }


        public bool IsEmpty() => size == queueEmpty;
        public int Length() => size;
    }
}
