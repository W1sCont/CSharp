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
                Console.WriteLine("Введіть шлях до файлу: ");
                string? path = Console.ReadLine();
                Console.WriteLine("Введіть числа для запису або двічу ентер для заверешшея: ");
                fn10 result = new fn10();
                string? str;
                double temp = 0;
                
                while (true)
                {
                    str = Console.ReadLine();
                    if (str == "") break;
                    temp = Convert.ToDouble(str);
                    result.AddToArr(temp);
                }
                Console.WriteLine("Запис у файл!");
                result.SaveToFile(path);

                Console.WriteLine("Зчитування з файлу!");
                fn10 resultNew = fn10.LoadFromFile(path);

                Console.WriteLine(resultNew);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}

