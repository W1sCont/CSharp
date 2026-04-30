namespace lesson18task1;

public static class task4
{
    public static int VowelsCount(this string s)
    {
        return s.Count(c => "aeiou".Contains(c));
    }
}