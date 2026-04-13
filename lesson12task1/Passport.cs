namespace lesson12task1;

public struct Visa
{
    public string? Country { get; set; }
    public string? DayOfIssue { get; set; }
    public string? DayOfExpiry { get; set; }
}
public class Passport
{
    public int? DocumentNo { get; set; }
    public string? SurName { get; set; }
    public string? Name { get; set; }
    public string? Patronymic { get; set; }
    public string? DateOfBirth { get; set; }
    public string? Sex { get; set; }
    public string? DateOfIssue { get; set; }
    public string? DateOfExpiry { get; set; }

    public Passport(int DocumentNo_, string SurName_, string Name_, string Patronymic_, string DateOfBirth_, string Sex_, string DateOfIssue_, string DateOfExpiry_)
    {
        DocumentNo = DocumentNo_;
        SurName = SurName_;
        Name = Name_;
        Patronymic = Patronymic_;
        DateOfBirth = DateOfBirth_;
        Sex = Sex_;
        DateOfIssue = DateOfIssue_;
        DateOfExpiry = DateOfExpiry_;
    }

    public Passport()
        : this(0, null, null, null, null, null, null, null)
    {
    }

    public void Info()
    {
        Console.Write($"DocumentNo: {DocumentNo}\n");
        Console.Write($"SurName: {SurName}\t\t\t");
        Console.Write($"Name: {Name}\n");
        Console.Write($"Patronymic: {Patronymic}\n");
        Console.Write($"DateOfBirth: {DateOfBirth}\t\t");
        Console.Write($"Sex: {Sex}\n");
        Console.Write($"DateOfIssue: {DateOfIssue}\t\t");
        Console.Write($"DateOfExpiry: {DateOfExpiry}\n");
    }
}

public class ForeignPassport : Passport
{
    public string? Country { get; set; }
    public Visa[] MyVisa = new Visa[10];
    private int countVisa = 0;

    public ForeignPassport(string Country_, int DocumentNo_, string SurName_, string Name_, string Patronymic_,
        string DateOfBirth_, string Sex_, string DateOfIssue_, string DateOfExpiry_)
        : base(DocumentNo_, SurName_, Name_, Patronymic_, DateOfBirth_, Sex_, DateOfIssue_, DateOfExpiry_)
    {
        Country = Country_;
    }

    public void SetVisa(string? country_, string? dayOfIssue_, string? dayOfExpiry_)
    {
        MyVisa[countVisa].Country = country_;
        MyVisa[countVisa].DayOfIssue = dayOfIssue_;
        MyVisa[countVisa].DayOfExpiry = dayOfExpiry_;
        countVisa++;
    }

    public string GetVisaInf(int index_)
    {
        if (index_ < 0 && index_ > countVisa) throw new IndexOutOfRangeException();
        return Convert.ToString(MyVisa[index_]);
    }
    new public void Info()
    {
        Console.WriteLine($"\t\tForeign passport {Country}\t\t");
        base.Info();
    }

    public void InfoVisa()
    {
        Console.WriteLine($"\t\tForeign passport {Country}\t\t");
        for (int i = 0; i < countVisa; i++)
        {
            Console.Write($"Country: {MyVisa[i].Country}\n");
            Console.Write($"Day of issue: {MyVisa[i].DayOfIssue}\t\t");
            Console.Write($"Day of expiry: {MyVisa[i].DayOfExpiry}\n\n");
        }
    }
    public Visa this[int index_]
    {
        get { return MyVisa[index_]; }
    }
    public override string ToString()
    {
        string result = $"\tForeign passport {Country}\n";
        result += $"DocumentNo: {DocumentNo}\n";
        result += $"Full Name: {SurName} {Name} {Patronymic}\n";
        result += $"Sex: {Sex} | Birth: {DateOfBirth}\n";
        result += $"Validity: {DateOfIssue} - {DateOfExpiry}\n";
        
        if (countVisa > 0)
        {
            result += "\n\t\tVISAS\n";
            for (int i = 0; i < countVisa; i++)
            {
                result += $"[{i+1}] {MyVisa[i].Country}: from {MyVisa[i].DayOfIssue} to {MyVisa[i].DayOfExpiry}\n";
            }
        }
        else
        {
            result += "\nNo visas issued yet.\n";
        }

        return result;
    }
}