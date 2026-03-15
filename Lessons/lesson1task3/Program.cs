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
                Console.WriteLine("Введіть число для перевірки полідрому");
                string? str = Console.ReadLine();
                uint number = Convert.ToUInt32(str);

                uint temp = number;
                uint rev = 0;

                while (temp > 0)
                {
                    uint lastNum = temp % 10;
                    rev = (rev * 10) + lastNum;
                    temp /= 10;
                }

                if (number == rev)
                {
                    Console.WriteLine($"Число {number} поліндром");
                }
                else
                {
                    Console.WriteLine($"Число {number} не поліндром");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

