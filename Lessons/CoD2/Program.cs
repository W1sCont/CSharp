using System;

namespace CoD2
{
    class MainClass
    {
        static void Main()
        {
            double SumArr(double[] arr)
            {         
                if (arr == null || arr.Length == 0) return 0;
                double sum = 0;

                foreach (var el in arr) sum += el;
                return sum;
            }

            double[] arr = { 1, 5.2, 4, 0, -1 };
            double[] arr1 = { -2.398 };
            double[] arr2 = null; 
            Console.WriteLine(SumArr(arr));
            Console.WriteLine(SumArr(arr1));
            Console.WriteLine(SumArr(arr2));

        }
    }
}
