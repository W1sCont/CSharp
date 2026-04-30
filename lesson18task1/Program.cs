using lesson18task1;

namespace Program_18
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                // task 1
                int a = 10, b = 23, c = 2;
                task1 nr1 = new task1();
                int res = nr1.Max(a, b, c);
                Console.WriteLine($"Max of {a}, {b}, {c} is {res}");
                
                double d = 10.5, e = 23.2, f = 2.3;
                task1 nr2 = new task1();
                double res2 = nr2.Max(d, e, f);
                Console.WriteLine($"Max of {d}, {e}, {f} is {res2}");
                
                // task 2
                int[] arr1 = { 23, 10, 34, 2 };
                task2 nr3 = new task2();
                int res1 = nr3.Sum(arr1);
                Console.WriteLine($"Sum of {arr1[0]}, {arr1[1]}, {arr1[2]}, {arr1[3]} is {res1}");
                
                double[] arr2 = { 10.5, 23.2, 2.3 };
                task2 nr4 = new task2();
                double res21 = nr4.Sum(arr2);
                Console.WriteLine($"Sum of {arr2[0]}, {arr2[1]}, {arr2[2]} is {res21}");
                
                // task 3
                int vow = 23, vow1 = 12;
                Console.WriteLine($"Number {vow} is vowels: {vow.IntExtension()}");
                Console.WriteLine($"Number {vow1} is vowels: {vow1.IntExtension()}");
                
                // task 4
                string str = "Hello, world!";
                Console.WriteLine($"Number of vowels in {str} is {str.VowelsCount()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}