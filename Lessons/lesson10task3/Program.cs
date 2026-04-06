using lesson10task3;
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
                Console.WriteLine("Введіть шлях до файлу: ");
                string? filename = Console.ReadLine();
                Run start = new();
                start.RunStatistics(filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

