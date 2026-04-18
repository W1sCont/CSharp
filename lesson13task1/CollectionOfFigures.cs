using System;
using System.IO;
using lesson13Shape;
namespace lesson13task1;

public class CollectionOfFigures
{
    private int capasity = 0;
    private int count = 0;
    private Shape[] arr; 
    
    public CollectionOfFigures(int num)
    {
        capasity = num;
        arr = new Shape[capasity];
    }

    public CollectionOfFigures()
        :this(10)
    {
    }

    public void Add(Shape obj)
    {
        if (count == capasity)
        {
            capasity += 10;
            Array.Resize(ref arr, capasity);
        }
        
        arr[count] = obj;
        count++;
    }

    public void Delete(int idx_)
    {
        if (idx_ >= 0 && idx_ < count)
        {
            if (idx_ < count - 1)
            {
                Array.Copy(arr, idx_ + 1, arr, idx_, count - idx_ - 1);
            } 
            count--;
            arr[count] = null;
        }
        else throw new IndexOutOfRangeException();
    }

    public void Delete(Shape obj)
    {
        int indexToRemove = -1;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] == obj)
            {
                indexToRemove = i;
                break;
            }
        }
        Delete(indexToRemove);
    }

    public void Print() { for (int i = 0; i < count; i++) { arr[i].Show(); } }

    public void Print(Shape obj)
    {
        Triangle? t = obj as Triangle;
        Rectangle? r = obj as Rectangle;
        Circle? c = obj as Circle;
        
        for (int i = 0; i < count; i++)
        {
            if (t != null) { if (arr[i] is Triangle) arr[i].Show(); }
            else if (r != null) { if (arr[i] is Rectangle) arr[i].Show(); }
            else if (c != null) { if (arr[i] is Circle) arr[i].Show(); }
        }
    }

    public double AllArea()
    {
        double result = 0;
        for (int i = 0; i < count; i++) { result += arr[i].Area(); }
        return Math.Round(result, 2);
    }

    public double AllArea(Shape obj)
    {
        Triangle? t = obj as Triangle;
        Rectangle? r = obj as Rectangle;
        Circle? c = obj as Circle;
        
        double result = 0;
        for (int i = 0; i < count; i++)
        {
            if (t != null) { if (arr[i] is Triangle) result += arr[i].Area(); }
            else if (r != null) { if (arr[i] is Rectangle) result += arr[i].Area(); }
            else if (c != null) { if (arr[i] is Circle) result += arr[i].Area(); }
        }
        return Math.Round(result, 2);
    }

    public void Load(string? path)
    {
        StreamReader sr = null;
        Shape? result = null;
        try
        {
            sr = new StreamReader(path);
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(";");
                if (str[0] == "Triangle")
                {
                    int a = int.Parse(str[1]);
                    int b = int.Parse(str[2]);
                    result = new Triangle(a, b);
                }
                else if (str[0] == "Circle")
                {
                    int x = int.Parse(str[1]);
                    int y = int.Parse(str[2]);
                    int r = int.Parse(str[3]);
                    result = new Circle(x, y, r);
                }
                else if (str[0] == "Rectangle")
                {
                    int x1 = int.Parse(str[1]);
                    int x2 = int.Parse(str[2]);
                    int y1 = int.Parse(str[3]);
                    int y2 = int.Parse(str[4]);
                    result = new Rectangle(x1, x2, y1, y2);
                }

                if (result != null) { Add(result); }
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sr?.Close(); }
    }

    public void Save(string? path)
    {
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter(path, false);
            for (int i = 0; i < count; i++)
            {
                if (arr[i] != null)
                {
                    sw.WriteLine(arr[i].ToString());
                }
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        finally { sw?.Close(); }
    }
}