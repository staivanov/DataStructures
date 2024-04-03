using LearnDSAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        DeQueLinked d = new DeQueLinked();
        d.AddFirst(5);
        d.AddFirst(3);
        d.AddLast(7);
        d.AddLast(12);
        d.Display();
        Console.WriteLine("Size: " + d.GetLength());
        Console.WriteLine("Front Element Removed: " + d.RemoveFirst());
        Console.WriteLine("Rear Element Removed: " + d.RemoveLast());
        d.Display();
        Console.WriteLine("First Element: " + d.First());
        Console.WriteLine("Last Element: " + d.Last());
        Console.ReadKey();
    }
}