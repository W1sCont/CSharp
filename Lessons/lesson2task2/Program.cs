using System.Numerics;
using System.Runtime.InteropServices;
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
                Console.WriteLine("Введіть 6 значене число:");
                string? str = Console.ReadLine();
                uint num = Convert.ToUInt32(str);

                if (num < 100000 || num > 999999)
                {
                    Console.WriteLine("Помилка: число має бути шестизначним!");
                    return;
                }

                uint reversed = 0;
                uint temp = num;

                while (temp > 0)
                {
                    uint digit = temp % 10;     
                    reversed = reversed * 10 + digit; 
                    temp /= 10;                  
                }

                Console.WriteLine($"Результат перевороту: {reversed}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

