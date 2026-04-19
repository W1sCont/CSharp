namespace lesson13task3;

public class President : Worker
{
    public string? TypeOfProfit { get; set; }

    public President(string name, string surname, int age, string type)
        : base(name, surname, age) { TypeOfProfit = type; }

    public President() : base(null, null, 0) { TypeOfProfit = null; }
    
    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Type of profit: {TypeOfProfit}");
    }
}

public class Security : Worker
{
    public string? WeaponType { get; set; }

    public Security(string name, string surname, int age, string type)
        : base(name, surname, age) { WeaponType = type; }

    public Security() : base(null, null, 0) { WeaponType = null; }
    
    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Weapon type: {WeaponType}");
    }
}

public class Manager : Worker
{
    public string? DepartmentName { get; set; }

    public Manager(string name, string surname, int age, string department)
        : base(name, surname, age) { DepartmentName = department; }

    public Manager() : base(null, null, 0) { DepartmentName = null; }
    
    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Department name: {DepartmentName}");
    }
}

public class Engineer : Worker
{
    public string? ProgrammingLanguage { get; set; }

    public Engineer(string name, string surname, int age, string ProgrLanguage)
        : base(name, surname, age) { ProgrammingLanguage = ProgrLanguage; }

    public Engineer() : base(null, null, 0) { ProgrammingLanguage = null; }
    
    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Programming Language: {ProgrammingLanguage}");
    }
}