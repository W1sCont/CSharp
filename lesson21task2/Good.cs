namespace Program_21_2;

public class Good
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public double Price { get; set; }
    public string? Category { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Price: {Price}, Category: {Category}";
    }
}