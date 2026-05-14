using System.Linq;
namespace Program_22_2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                bool start = true;
                Console.WriteLine("Виберіть один з варіантів валідації");
                while (start)
                {
                    Console.WriteLine("1-ПІП, 2-Електронна пошта, 3-Формат дати, 0-Вихід");
                    string? input = Console.ReadLine();
                    switch (input)
                    {   
                        case "1":
                            Console.WriteLine("Введіть прізвище та ініціали імя та побатькові");
                            string? input1 = Console.ReadLine();
                            if(Mask.Task1(input1)) Console.WriteLine("Валідацію пройдено");
                            else Console.WriteLine("Валідацію не пройдено");
                            break;
                        case "2":
                            Console.WriteLine("Введіть емейл адрес");
                            input1 = Console.ReadLine();
                            if(Mask.Task2(input1)) Console.WriteLine("Валідацію пройдено");
                            else Console.WriteLine("Валідацію не пройдено");
                            break;
                        case "3":
                            Console.WriteLine("Введіть дату");
                            input1 = Console.ReadLine();
                            if(Mask.Task3(input1)) Console.WriteLine("Валідацію пройдено");
                            else Console.WriteLine("Валідацію не пройдено");
                            break; 
                        case "0":
                            start = false;
                            break;
                        default:
                            Console.WriteLine("Не вірна команда");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}