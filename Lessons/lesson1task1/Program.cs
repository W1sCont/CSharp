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
                Console.WriteLine("Введіть 6-ти значне число:");
                string? str = Console.ReadLine();
                uint number = Convert.ToUInt32(str);
                if (number < 99999 || number > 1000000)
                {
                    Console.WriteLine("Error");
                    return;

                }

                Console.WriteLine("Введіть номери рядків для обміну значеннями");
                Console.WriteLine("Перший номер:");
                str = Console.ReadLine();
                byte num1 = Convert.ToByte(str);

                Console.WriteLine("Другий номер:");
                str = Console.ReadLine();
                byte num2 = Convert.ToByte(str);

                uint weight1 = 1;
                uint weight2 = 1;
                for (byte i = 1; i < num1; i++)
                {
                    weight1 *= 10;
                }

                for (byte i = 1; i < num2; i++)
                {
                    weight2 *= 10;
                }

                uint digit1 = (number / weight1) % 10;
                uint digit2 = (number / weight2) % 10;

                uint result = number - (digit1 * weight1) - (digit2 * weight2)
                    + (digit2 * weight1) + (digit1 * weight2);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

