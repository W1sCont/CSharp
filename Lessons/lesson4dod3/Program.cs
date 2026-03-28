using System.Text;

namespace Taks3
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
                string?[] str1 = str.Split(" ");
                
                Console.WriteLine("Введіть слово яке потрібно замінити на ***: ");
                string? word = Console.ReadLine();
                StringBuilder temp = new("");
                for (int i = 0; i < str1.Length; ++i)
                {
                    if (str1[i] == word)
                    {
                        temp.Append("***");
                        temp.Append(" ");
                    }
                    else 
                    {   
                        temp.Append(str1[i]);
                        temp.Append(" ");
                    }
                }

                temp.ToString();
                Console.WriteLine(temp);

                Console.WriteLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

