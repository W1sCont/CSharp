using lesson10task1;
namespace CSharpApplication.Lesson10
{ 
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть дані для запису: ");
                fn10 result = new fn10();
                string? str;
                double temp = 0;
                
                while (true)
                {
                    str = Console.ReadLine();
                    if (str == null) break;
                    temp = Convert.ToDouble(str);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

