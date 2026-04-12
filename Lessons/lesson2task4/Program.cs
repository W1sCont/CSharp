using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpApplication.DataTypes
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть число для перевірки!");
                string? str = Console.ReadLine();
                int len = str.Length;
                int num = Convert.ToInt32(str);
                int temp = num;
                double sum = 0;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += Math.Pow(digit, len);
                    temp /= 10;
                }

                if ((int)sum == num)
                    Console.WriteLine($"Число {num} це число Армстронга!");
                else
                    Console.WriteLine($"Число {num} не число Армстронга!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

