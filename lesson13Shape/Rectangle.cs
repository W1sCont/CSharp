using System;
using System.IO;
namespace lesson13Shape;

public class Rectangle : Shape
{
    public int X1 { get; set; }
    public int X2 { get; set; }
    public int Y1 { get; set; }
    public int Y2 { get; set; }

    public Rectangle() :this(0, 0, 0, 0) { }

    public Rectangle(int x1, int x2, int y1, int y2)
    {
        X1 = x1;
        X2 = x2;
        Y1 = y1;
        Y2 = y2;
    }

    public override void Show()
    {
        Console.WriteLine($"Rectangle, X1 = {X1}, X2 = {X2}, Y1 = {Y1}, Y2 = {Y2}");
    }

    public override double Area()
    {
        int a = X2 - X1;
        int b = Y2 - Y1;
        return a * b;
    }
    
    public override void Save()
    {
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter("Rectangle.txt", false);
            sw.Write($"Rectangle;{X1};{X2};{Y1};{Y2}");
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
            if (arr.Length == 5)
            {
                X1 = int.Parse(arr[1]);
                X2 = int.Parse(arr[2]);
                Y1 = int.Parse(arr[3]);
                Y2 = int.Parse(arr[4]);
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sr?.Close(); }
    }
    public override string ToString()
    {
        return $"Rectangle;{X1};{X2};{Y1};{Y2}";
    }
}