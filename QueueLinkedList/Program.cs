using QueueLinkedList;

public class Program
{
    private static void Main(string[] args)
    {
        QueueLinked linkedQueue = new QueueLinked();
        linkedQueue.Enqueue(5);
        linkedQueue.Enqueue(10);
        linkedQueue.Enqueue(20);
        linkedQueue.Enqueue(30);
        linkedQueue.Dequeue();
        linkedQueue.Display();
    }
}