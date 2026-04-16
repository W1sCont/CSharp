namespace lesson12task2;

public class Builder : Human
{
    public string? TypeOfBuilder { get; set; }

    public Builder(string? name_, string? surname_, int age_, string? type_)
        : base(name_, surname_, age_)
    {
        TypeOfBuilder = type_;
    }

    new public void Info()
    {
        base.Info();
        Console.WriteLine($"Type of builder: {TypeOfBuilder}");
    }
}