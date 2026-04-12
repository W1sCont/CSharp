using lesson11task4;

namespace Program_11_4
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                // /*
                Console.WriteLine("Enter path to file: ");
                string? filename = Console.ReadLine();
                
                Statistic start = new();
                start.Start(filename);
                // */
                /*
                Statistic start = new();
                Statistic.Generate("test.txt", 100000);
                start.Start("test.txt");
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}