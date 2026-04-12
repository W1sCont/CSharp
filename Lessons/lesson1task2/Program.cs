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
                Console.WriteLine("Введіть число: ");
                string? str = Console.ReadLine();
                uint num = Convert.ToUInt32(str);
                uint temp = 0;
                for (uint i = 1; i <= (num / 2); ++i)
                {
                    if (num % i == 0)
                    {
                        temp += i;
                    }
                }

                if (num == temp)
                {
                    Console.WriteLine($"Число {num} досконале");
                }
                else
                {
                    Console.WriteLine($"Число {num} не досконале");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

