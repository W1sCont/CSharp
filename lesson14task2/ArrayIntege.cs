namespace lesson14task2;

public class ArrayInteger : IMath
{
    public int[] arr;
    public int capasity = 10;

    public ArrayInteger(int capasity_)
    {
        if (capasity_ > capasity) capasity = capasity_;
        arr = new int[capasity];
        Random r = new Random();
        for (int i = 0; i < capasity; i++)
        {
            arr[i] = r.Next(1, 11);
        }
    }

    public int Max()
    {
        int result = int.MinValue;
        foreach (var v in arr)
        {
            if (v > result) result = v;
        }

        return result;
    }

    public int Min()
    {
        int result = int.MaxValue;
        foreach (var v in arr)
        {
            if (v < result) result = v;
        }

        return result;
    }

    public double Avg()
    {
        double result = 0;
        foreach (var v in arr)
        {
            result += v;
        }

        result /= capasity;
        return Math.Round(result, 2);
    }

    public bool Search(int valueToSearch)
    {
        foreach (var v in arr)
        {
            if (v == valueToSearch) return true;
        }
        return false;
    }
    
    public void Print()
    {
        foreach (var v in arr)
        {
            Console.Write(v + " ");
        }
        Console.WriteLine();
    }
}