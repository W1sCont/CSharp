namespace lesson12task3;

public class Student : Person
{
    protected int grade_point_average;
    protected int group_number;

    public int GPA
    {
        get { return grade_point_average; }
        set { grade_point_average = value; }
    }
    public int GroupNumber { get; set; }

    public Student(string? name_, string surName_, int age_, string phone_, int gpa_, int groupNumber_)
        : base(name_, surName_, age_, phone_)
    {
        GPA = gpa_;
        GroupNumber = groupNumber_;
    }

    public Student()
        :this(null,null,0,null,0,0)
    {
    }

    new public void Print()
    {
        base.Print();
        Console.WriteLine($"Group point average: {GPA}\nGroup number: {GroupNumber}");
    }
    public override string ToString() 
    {
        return $"{SurName} {Name}, Age: {Age}, Group: {GroupNumber}, GPA: {GPA}";
    }
}