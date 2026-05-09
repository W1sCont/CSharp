namespace lesson19task2;

public delegate Action ActionDelegate();

public class Methods
{
    public void CurrentTime()
    {
        Console.WriteLine($"Current time: {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
    }

    public void CurrentDate()
    {
        Console.WriteLine($"Current date: {DateTime.Now.Date}");
    }

    public static void DayOfWeek()
    {
        Console.WriteLine($"Current day of week: {DateTime.Now.DayOfWeek}");
    }

    public static void Client(Action del)
    {
        del();
    }
}