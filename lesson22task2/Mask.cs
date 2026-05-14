using System.Text;
using System.Text.RegularExpressions;
namespace Program_22_2;

public class Mask
{
    public static bool Task1(string text)
    {
        string pattern1 = @"^[A-ZА-Я]\w+\s[A-ZА-Я]\.\s?[A-ZА-Я]\.$";
        string pattern2 = @"^[A-ZА-Я]\w+\s[A-ZА-Я][A-ZА-Я]\.$";

        Regex regex1 = new Regex(pattern1);
        Regex regex2 = new Regex(pattern2);
        return regex1.IsMatch(text.Trim()) || regex2.IsMatch(text.Trim()) ;
    }
    
    public static bool Task2(string text)
    {
        string pattern = @"^\w{3,16}\.(\w+\.)?(\w+\.)?\w{2,3}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(text.Trim());
    }
    
    public static bool Task3(string text)
    {
        string pattern = @"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])[-.]?(0[1-9]|1[0-2])[-.]?(\d{4})$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(text.Trim());
    }
}