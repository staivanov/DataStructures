namespace CircularLinkedList
{
    internal class Program
    {
        static void Main()
        {
            CircularLinkedList circularLinkedList = new();
            circularLinkedList.AddLast(7);
            circularLinkedList.AddLast(3);
            circularLinkedList.AddLast(12);
            circularLinkedList.AddFirst(30);
            circularLinkedList.Display();
            circularLinkedList.RemoveLastElement();
            circularLinkedList.Display();
            int removedElement = circularLinkedList.RemoveElementAtPosition(2);
            Console.WriteLine($"Removed element {removedElement}.");
            circularLinkedList.Display();
        }
    }
}
