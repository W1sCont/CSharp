namespace lesson13task2;

public class Course
{
    public string? Name { get; set; }
    public int? Duration { get; set; }

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }
    
    public Course() : this(null, 0){}

    public override string ToString()
    {
        return $"Name: {Name}, Duration: {Duration}";
    }
}

public class OnlineCourse : Course
{
    public string? Type { get; set; }

    public OnlineCourse(string name, int duration, string type)
        : base(name, duration) { Type = type; }

    public OnlineCourse() : base(null, 0) { Type = null; }

    public override string ToString()
    {
        return $"Name: {Name}, Duration: {Duration}, Type: {Type}";
    }
}