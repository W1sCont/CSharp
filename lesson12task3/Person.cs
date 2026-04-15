namespace lesson12task3;

public class Person
{
    protected string? name;
    protected string? surName;
    protected int? age;
    protected string? phone;
    
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public int? Age { get; set; }
    public string? Phone { get; set; }

    public Person(string? name_, string surName_, int age_, string phone_)
    {
        Name = name_;
        SurName = surName_;
        Age = age_;
        Phone = phone_;
    }

    public Person()
        : this(null, null, 0, null)
    {
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name},\t Surname {SurName},\nAge: {Age},\t Phone: {Phone}");
    }

}