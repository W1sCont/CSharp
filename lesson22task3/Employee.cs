namespace Program_22_3;

public class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int DepId { get; set; }

    public override string ToString()
    {
        return $"{LastName} {FirstName}, {Age}, {DepId}";
    }
}

class Department()
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
}