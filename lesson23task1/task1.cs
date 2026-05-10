namespace Program_23_1;

public record Car(string Name, string Model, int Year)
{
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Model: {Model}, Year: {Year}");
    }
}


public record ElectroCar(string Name, string Model, int Year, int BatteryCapacity) : Car(Name, Model, Year)
{
    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Model: {Model}, Year: {Year}, Battery capacity: {BatteryCapacity}");
    }
}