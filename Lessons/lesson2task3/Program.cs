namespace CSharpApp
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть довжину рядка:");
                string? str = Console.ReadLine();
                uint num = Convert.ToUInt32(str);

                Console.WriteLine("Введіть символ заповнення рядка:");
                str = Console.ReadLine();
                char ch = Convert.ToChar(str[0]);

                for (int i = 0; i < num; ++i)
                {
                    Console.Write(ch);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

