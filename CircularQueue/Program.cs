public partial class Program
{
    private static void Main()
    {
        CircularQueue cq = new(5);
        cq.Enqueue(5);
        cq.Enqueue(10);
        cq.Enqueue(11);
        cq.Enqueue(15);
        cq.Enqueue(20);

        while (!cq.IsEmpty())
        {
            int number = cq.Dequeue();
            Console.WriteLine(number);
        }
    }
}