namespace lesson12task2;

public class Pilot : Human
{
    public string? TypeOfPilot { get; set; }
    public Pilot(string? name_, string? surname_, int age_, string? Type_)
        : base(name_, surname_, age_)
    {
        TypeOfPilot = Type_;
    }
    new public void Info()
    {
        base.Info();
        Console.WriteLine($"Type of aviation: {TypeOfPilot}");
    }
}