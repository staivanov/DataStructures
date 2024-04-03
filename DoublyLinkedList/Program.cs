using LearnDSAlgorithms;

public class Program
{
    public static void Main()
    {
        DoublyLinkedList l = new();
        l.AddLast(7);
        l.AddLast(4);
        l.AddLast(12);
        l.AddLast(8);
        l.AddLast(3);
        l.Display();
        Console.WriteLine("Size: " + l.Length());
        int element = l.RemoveAny(3);
        Console.WriteLine("Removed Element: " + element);
        l.Display();
        Console.WriteLine("Size: " + l.Length());

    }
}