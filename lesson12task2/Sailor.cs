namespace lesson12task2;

public class Sailor : Human
{
    public int? AverageSail { get; set; }
    public Sailor(string? name_, string? surname_, int age_, int avr_)
        : base(name_, surname_, age_)
    {
        AverageSail = avr_;
    }
    new public void Info()
    {
        base.Info();
        Console.WriteLine($"Average sail: {AverageSail}");
    }
}