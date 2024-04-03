public partial class Program
{
    public class CircularQueue
    {
        int[] numbers;
        int front;
        int rear;

        public CircularQueue(int initialSize)
        {
            front = -1;
            rear = -1;
            numbers = new int[initialSize];
        }


        public void Enqueue(int number)
        {
            if (IsEmpty())
            {
                front++;
                numbers[front] = number;
            }
            else if (IsFull())
            {
                Resize();
            }
            else
            {
                rear = (rear + 1) % numbers.Length;
                numbers[rear] = number;
            }
        }


        public int Dequeue()
        {
            int temp = numbers[front];

            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front = (front + 1) % numbers.Length;
            }

            return temp;
        }


        public void Resize()
        {
            int[] tempArr = new int[numbers.Length * 2];
            int i = 0;
            int j = front;

            do
            {
                tempArr[i++] = numbers[j];
                j = (j + 1) % numbers.Length;
            }
            while (j != front);

            front = 0;
            rear = numbers.Length - 1;
            numbers = tempArr;
        }

        public int Peek() => numbers[front];
        private bool IsFull() => ((rear + 1) % numbers.Length) == front;
        public bool IsEmpty() => (front == -1) && (rear == -1);
    }
}