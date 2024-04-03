internal class Program
{
    public class StackArray
    {
        int[] data;
        int top;

        public StackArray(int n)
        {
            data = new int[n];
            top = 0;
        }

        public void Push(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!");
                return;
            }
            else
            {
                data[top] = e;
                top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int e = data[top - 1];
                top--;
                return e;
            }
        }

        public int Peak()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return data[top - 1];
            }
        }

        public void Display()
        {
            foreach (var element in data)
            {
                Console.Write($"{element} <- ");
            }
            Console.WriteLine();
        }

        public bool IsFull() => top == data.Length;
        public bool IsEmpty() => top == 0;
        public int Length() => top;
    }

    private static void Main(string[] args)
    {
        StackArray s = new StackArray(10);
        s.Push(5);
        s.Push(3);
        int element = s.Peak();










    }
}