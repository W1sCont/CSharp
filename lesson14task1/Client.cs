namespace lesson14task1;

public class Client
{
    public Client(ICalc obj)
    {
        Console.WriteLine($"Method CountDistinct: {obj.CountDistinct()}");
        Console.WriteLine($"Method EqualToValue 3: {obj.EqualToValue(3)}");
        (obj as ArrayInteger).Print();
    }
}