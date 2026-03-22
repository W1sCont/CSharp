namespace Task2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть текст: ");
                string? str = Console.ReadLine();
                // today is a good day for walking. i will try to walk near the see.

                StringBuilder str1 = new StringBuilder(str);
                str1[0] = char.ToUpper(str1[0]);

                for(ushort i = 0; i < str1.Length; ++i)
                {
                    if (str1[i] == '.' && i != str1.Length - 1)
                        if (str1[i + 1] == ' ') str1[i + 2] = char.ToUpper(str1[i + 2]);
                        else str1[i + 1] = char.ToUpper(str1[i + 1]);
                }

                Console.WriteLine("Результат: ");
                Console.WriteLine(str1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
