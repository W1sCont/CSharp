using System;
using System.IO;
namespace lesson13Shape;

public class Circle : Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }

    public Circle() :this(0, 0, 0) { }
    public Circle(int x, int y, int r) { X = x; Y = y; R = r; }

    public override void Show()
    {
        Console.WriteLine($"Circle, X = {X}, Y = {Y}, R = {R}");
    }

    public override double Area() => 3.14 * R * R;
    
    public override void Save()
    {
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter("Circle.txt", false);
            sw.Write($"Circle;{X};{Y};{R}");
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sw?.Close(); }
    }

    public override void Load(string? path)
    {
        StreamReader sr = null;
        try
        {
            sr = new StreamReader(path);
            string? line = File.ReadAllText(path);;
            string[] arr = line.Split(';');
            if (arr.Length == 4)
            {
                X = int.Parse(arr[1]);
                Y = int.Parse(arr[2]);
                R = int.Parse(arr[3]);
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sr?.Close(); }
    }
    public override string ToString()
    {
        return $"Circle;{X};{Y};{R}";
    }
}