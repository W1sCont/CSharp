using System.Numerics;
namespace lesson18task1;

public class task1
{
    public T Max<T>(T a, T b, T c) where T : INumber<T>
    {
        if (a > b && a > c) return a;
        else if (b > a && b > c) return b;
        else return c;
    }
}