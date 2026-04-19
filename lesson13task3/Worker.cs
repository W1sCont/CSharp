namespace lesson13task3;

public abstract class Worker
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }

    public Worker(string? name, string? surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    public Worker() : this(null,null,0){}
    
    public abstract void Print();
}