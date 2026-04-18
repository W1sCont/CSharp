using System;
using System.IO;
namespace lesson13Shape;

public class Triangle : Shape
{
    public int A { get; set; }
    public int B { get; set; }

    public Triangle() :this(0, 0) { }
    public Triangle(int a, int b) { A = a; B = b; }

    public override void Show()
    {
        Console.WriteLine($"Triangle, A = {A}, B = {B}");
    }

    public override double Area() => 0.5 * A * B;
    
    public override void Save()
    {
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter("Triangle.txt", false);
            sw.Write($"Triangle;{A};{B}");
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
            if (arr.Length == 3)
            {
                A = int.Parse(arr[1]);
                B = int.Parse(arr[2]);
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sr?.Close(); }
    }

    public override string ToString()
    {
        return $"Triangle;{A};{B}";
    }
}