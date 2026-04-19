namespace lesson14task2;

public class Client
{
    public Client(IMath obj)
    {
        Console.WriteLine($"Method Max: {obj.Max()}");
        Console.WriteLine($"Method Min: {obj.Min()}");
        Console.WriteLine($"Method Avg: {obj.Avg()}");
        Console.WriteLine($"Method valueToSearch 4: {obj.Search(4)}");
        Console.WriteLine($"Method valueToSearch 11: {obj.Search(11)}");
        (obj as ArrayInteger).Print();
    }
}