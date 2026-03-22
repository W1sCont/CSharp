namespace Task1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть вираз використовуючи тільки: '+' i '-' ");
                string? str = Console.ReadLine();
                str = str.Replace("+", " + ").Replace("-", " - ");
                string[] str1 = str.Split(' ');
                int result = 0;

                if (str1[1] == "-") result = -Convert.ToInt32(str1[2]);
                else if (str1[1] == "+") result = Convert.ToInt32(str1[2]);
                else  result = Convert.ToInt32(str1[0]);

                for (ushort i = 1; i < str1.Length; ++i)
                {
                    if (str1[i] == "+") result += Convert.ToInt32(str1[i + 1]);
                    else if (str1[i] == "-") result -= Convert.ToInt32(str1[i + 1]);
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
