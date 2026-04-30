using System.Numerics;
namespace lesson18task1;

public class task2
{
    public T Sum<T>(T[] arr) where T : INumber<T>
    {
        T result = T.Zero;
        foreach (var v in arr) result += v;
        return result;
    }
}