using System;
namespace lesson14task1;

public class ArrayInteger : ICalc
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

    public int CountDistinct()
    {
        int[] result = new int[capasity];
        int count = 0;

        for (int i = 0; i < capasity; i++)
        {
            if (arr[i] == null) continue;

            bool isDuplicate = false;
            for (int j = 0; j < count; j++)
            {
                if (arr[i].Equals(result[j]))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result[count] = arr[i];
                count++;
            }
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var v in  arr)
        {
            if (v == valueToCompare) count++;
        }
        return count;
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