namespace QueueArrayImplementation
{
    internal class QueueArray
    {
        private int[] data;
        private int size;
        private int rear;
        private int front;
        private int emptyQueue = 0;

        public QueueArray(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }


        public void Enqueue(int e)
        {
            if (IsQueueFull())
            {
                return;
            }
            else
            {
                data[rear] = e;
                rear++;
                size++;
            }
        }


        public int Dequeue()
        {
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                int firstElement = data[front];
                front--;
                size--;

                return firstElement;
            }
        }


        public void Display()
        {
            foreach (var item in data)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public bool IsQueueFull() => size == data.Length;
        public bool IsEmpty() => size == emptyQueue;
        public int Length() => size;
    }
}
