using StackWithLinkedList;

internal class Program
{
    private static void Main()
    {
        StackLinked linkedStack = new StackLinked();
        linkedStack.Push(10);
        linkedStack.Push(11);
        linkedStack.Push(0);
        int lastElement = linkedStack.Peek();
        linkedStack.Display();
    }
}