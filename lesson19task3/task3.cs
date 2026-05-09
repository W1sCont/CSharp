namespace lesson19task3;

public delegate int TextDataProcessing(string? text);

public class Task3
{
    public int VowelCount(string? text)
    {
        if (text == null) return 0;
        int count = text.Count(cv => "aeiou".Contains(char.ToLower(cv)));
        return count;
    }

    public int ConsonantCount(string? text)
    {
        if (text == null) return 0;
        int count = text.Count(cc => "BCDFGHJKLMNPQRSTVWXYZ".Contains(char.ToUpper(cc)));
        return count;
    }

    public int LenghtCount(string? text)
    {
        if (text == null) return 0;
        return text.Length;
    }

    public void Client(TextDataProcessing d, string? str)
    {
        var lst = d.GetInvocationList();
        foreach (var v in lst)
        {
            var result = ((TextDataProcessing)v)(str);
            Console.WriteLine($"Method name:{v.Method.Name} : {result}");
        }
    }
}