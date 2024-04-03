using QueueArrayImplementation;

internal class Program
{
    private static void Main()
    {
        QueueArray queuearray = new QueueArray(5);
        queuearray.Enqueue(5);
        queuearray.Enqueue(8);
        queuearray.Enqueue(9);
        queuearray.Enqueue(12);
        queuearray.Enqueue(22);
        queuearray.Display();
        int firstElement = queuearray.Dequeue();
    }
}