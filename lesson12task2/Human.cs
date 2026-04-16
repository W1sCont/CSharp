namespace lesson12task2;

public class Human
{
    protected string? Name { get; set; }
    protected string? Surname { get; set; }
    protected int Age { get; set; }

    public Human(string? name_, string? surname_, int age_)
    {
        Name = name_;
        Surname = surname_;
        Age = age_;
    }

    public Human()
        : this(null, null, 0)
    {
    }

    public void Info()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
    }
}